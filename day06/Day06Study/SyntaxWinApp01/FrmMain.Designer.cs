﻿namespace SyntaxWinApp01
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            PrgProcess = new ProgressBar();
            BtnStart = new Button();
            TxtLog = new TextBox();
            label1 = new Label();
            BgwProcess = new System.ComponentModel.BackgroundWorker();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 289);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(90, 17);
            LblState.Text = "현재상태 : 중지";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(12, 256);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(454, 30);
            PrgProcess.TabIndex = 1;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(472, 256);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(100, 30);
            BtnStart.TabIndex = 2;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(12, 27);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.ScrollBars = ScrollBars.Vertical;
            TxtLog.Size = new Size(560, 223);
            TxtLog.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "로그";
            // 
            // BgwProcess
            // 
            BgwProcess.DoWork += BgwProcess_DoWork;
            BgwProcess.ProgressChanged += BgwProcess_ProgressChanged;
            BgwProcess.RunWorkerCompleted += BgwProcess_RunWorkerCompleted;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(label1);
            Controls.Add(TxtLog);
            Controls.Add(BtnStart);
            Controls.Add(PrgProcess);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "백그라운드워커 윈앱";
            Load += FrmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ProgressBar PrgProcess;
        private Button BtnStart;
        private TextBox TxtLog;
        private Label label1;
        private ToolStripStatusLabel LblState;
        private System.ComponentModel.BackgroundWorker BgwProcess;
    }
}
