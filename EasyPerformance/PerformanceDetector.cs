using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using CloudBox.EasyHook;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace CloudBox.Performance
{
    public class PerformanceDetector
    {
        int m_cpuUsage;
        MemoryInfo m_mainMemory;
        Dictionary<string, MemoryInfo> m_moduleMemorys;
        bool m_isMonitoring;
        PerformanceCounter theCPUCounter;
        static PerformanceDetector m_instance = new PerformanceDetector();

        Form m_mainForm;

        const int INTERVAL_TIME = 300;

        public Dictionary<string, MemoryInfo> ModuleMemorys
        {
            get { return m_moduleMemorys; }
            set { m_moduleMemorys = value; }
        }
        public MemoryInfo MainMemory
        {
            get { return m_mainMemory; }
            set { m_mainMemory = value; }
        }

        public int CpuUsage
        {
            get { return m_cpuUsage; }
            set { m_cpuUsage = value; }
        }

        private PerformanceDetector()
        {
        }

        public static PerformanceDetector Instance
        {
            get { return m_instance; }
            set {}
        }

        void update()
        {
            try
            {
                updateCPU();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            updateMemory();
        }

        void updateCPU()
        {
            m_cpuUsage = (int)(theCPUCounter.NextValue()/ Environment.ProcessorCount);
        }

        void updateMemory()
        {
            Process currentProcess = Process.GetCurrentProcess();
            m_mainMemory.update(currentProcess.WorkingSet64);

            ProcessModuleCollection myProcessModuleCollection = currentProcess.Modules;
            // Display the 'ModuleMemorySize' of each of the modules.
            ProcessModule myProcessModule;
            for (int i = 0; i < myProcessModuleCollection.Count; i++)
            {
                myProcessModule = myProcessModuleCollection[i];
                if (m_moduleMemorys.Keys.Contains(myProcessModule.ModuleName))
                    m_moduleMemorys[myProcessModule.ModuleName].update(myProcessModule.ModuleMemorySize);
                else
                {
                    MemoryInfo mem = new MemoryInfo();
                    mem.Name = myProcessModule.ModuleName;
                    mem.update(myProcessModule.ModuleMemorySize);
                    m_moduleMemorys[myProcessModule.ModuleName] = mem;
                }
            }
        }

        string GetInstanceName(Process process)
	    {
	        return GetProcessInstanceName(process.Id);
	    }

        string GetProcessInstanceName(int pid)
	    {
	        var category = new PerformanceCounterCategory("Process");
	 
	        var instances = category.GetInstanceNames();
	        foreach (var instance in instances)
	        {
	 
	            using (var counter = new PerformanceCounter(category.CategoryName,
	                 "ID Process", instance, true))
	            {
	                int val = (int)counter.RawValue;
	                if (val == pid)
	                {
	                    return instance;
	                }
	            }
	        }
	        throw new ArgumentException("Invalid pid!");
	    }

        public void initialize()
        {
            m_mainMemory = new MemoryInfo();
            m_mainMemory.Name = "Current Process";

            m_moduleMemorys = new Dictionary<string, MemoryInfo>();

            theCPUCounter = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);

            m_isMonitoring = true;
            Thread t = new Thread(new ThreadStart(this.updateThread));
            t.Start();

            HookManager.Instance.RegisterHook(HookType.WH_KEYBOARD, new CustomHookProc.HookProcHandler(KeyboardHookProc));
        }

        public void destory()
        {
            if (m_mainForm != null)
            {
                m_mainForm.Close();
                m_mainForm.Dispose();
                m_mainForm = null;
            }
            m_isMonitoring = false;
        }

        void showMonitorForm()
        {
            if (m_mainForm == null)
            {
                m_mainForm = new frmPerformance();
                m_mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            }
            m_mainForm.Show();
        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_mainForm.Dispose();
            m_mainForm = null;
        }

        void updateThread()
        {
            while (m_isMonitoring)
            {
                try
                {
                    update();
                }catch{}
                Thread.Sleep(INTERVAL_TIME);
            }
        }

        void KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            KeyStateInfo ctrlKey = KeyboardInfo.GetKeyState(Keys.ControlKey);
            KeyStateInfo altKey = KeyboardInfo.GetKeyState(Keys.Alt);
            KeyStateInfo mKey = KeyboardInfo.GetKeyState(Keys.M);

            if (ctrlKey.IsPressed && altKey.IsPressed && mKey.IsPressed)
            {
                showMonitorForm();
            }
        }
    }
}
