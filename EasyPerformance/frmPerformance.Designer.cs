namespace CloudBox.Performance
{
    partial class frmPerformance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpbCPU = new System.Windows.Forms.GroupBox();
            this.pgbCPU = new System.Windows.Forms.ProgressBar();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.gpbMemory = new System.Windows.Forms.GroupBox();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpbCPU.SuspendLayout();
            this.gpbMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCPU
            // 
            this.gpbCPU.Controls.Add(this.pgbCPU);
            this.gpbCPU.Controls.Add(this.txtCPU);
            this.gpbCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbCPU.Location = new System.Drawing.Point(0, 0);
            this.gpbCPU.Name = "gpbCPU";
            this.gpbCPU.Size = new System.Drawing.Size(123, 52);
            this.gpbCPU.TabIndex = 0;
            this.gpbCPU.TabStop = false;
            this.gpbCPU.Text = "CPU";
            // 
            // pgbCPU
            // 
            this.pgbCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.pgbCPU.ForeColor = System.Drawing.Color.LightGreen;
            this.pgbCPU.Location = new System.Drawing.Point(34, 18);
            this.pgbCPU.Name = "pgbCPU";
            this.pgbCPU.Size = new System.Drawing.Size(86, 23);
            this.pgbCPU.Step = 1;
            this.pgbCPU.TabIndex = 1;
            // 
            // txtCPU
            // 
            this.txtCPU.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCPU.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCPU.Location = new System.Drawing.Point(3, 18);
            this.txtCPU.MaxLength = 3;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.ReadOnly = true;
            this.txtCPU.Size = new System.Drawing.Size(31, 23);
            this.txtCPU.TabIndex = 0;
            this.txtCPU.Text = "10";
            // 
            // gpbMemory
            // 
            this.gpbMemory.Controls.Add(this.txtMemory);
            this.gpbMemory.Controls.Add(this.label1);
            this.gpbMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbMemory.Location = new System.Drawing.Point(0, 52);
            this.gpbMemory.Name = "gpbMemory";
            this.gpbMemory.Size = new System.Drawing.Size(123, 46);
            this.gpbMemory.TabIndex = 1;
            this.gpbMemory.TabStop = false;
            this.gpbMemory.Text = "Memory";
            // 
            // txtMemory
            // 
            this.txtMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMemory.Location = new System.Drawing.Point(3, 18);
            this.txtMemory.MaxLength = 20;
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.Size = new System.Drawing.Size(88, 22);
            this.txtMemory.TabIndex = 3;
            this.txtMemory.Text = "1024";
            this.txtMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(91, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "KB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDetail
            // 
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetail.Location = new System.Drawing.Point(0, 98);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(123, 26);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPerformance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(123, 98);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.gpbMemory);
            this.Controls.Add(this.gpbCPU);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerformance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPerformance_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPerformance_FormClosed);
            this.gpbCPU.ResumeLayout(false);
            this.gpbCPU.PerformLayout();
            this.gpbMemory.ResumeLayout(false);
            this.gpbMemory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCPU;
        private System.Windows.Forms.GroupBox gpbMemory;
        private System.Windows.Forms.ProgressBar pgbCPU;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Timer timer1;
    }
}