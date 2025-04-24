namespace SyntaxWinApp03
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
            BtnSave = new Button();
            BtnLoad = new Button();
            RtbNote = new RichTextBox();
            BtnBold = new Button();
            BtnRed = new Button();
            DlgOpen = new OpenFileDialog();
            DlgSave = new SaveFileDialog();
            DlgColor = new ColorDialog();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(366, 269);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 30);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(472, 269);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(100, 30);
            BtnLoad.TabIndex = 0;
            BtnLoad.Text = "읽기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // RtbNote
            // 
            RtbNote.Location = new Point(12, 12);
            RtbNote.Name = "RtbNote";
            RtbNote.Size = new Size(560, 251);
            RtbNote.TabIndex = 1;
            RtbNote.Text = "";
            // 
            // BtnBold
            // 
            BtnBold.BackColor = SystemColors.ControlLight;
            BtnBold.Location = new Point(330, 269);
            BtnBold.Name = "BtnBold";
            BtnBold.Size = new Size(30, 30);
            BtnBold.TabIndex = 2;
            BtnBold.Text = "B";
            BtnBold.UseVisualStyleBackColor = false;
            BtnBold.UseWaitCursor = true;
            BtnBold.Click += BtnBold_Click;
            // 
            // BtnRed
            // 
            BtnRed.BackColor = SystemColors.ControlLight;
            BtnRed.ForeColor = Color.Red;
            BtnRed.Location = new Point(294, 269);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(30, 30);
            BtnRed.TabIndex = 3;
            BtnRed.Text = "R";
            BtnRed.UseVisualStyleBackColor = false;
            BtnRed.UseWaitCursor = true;
            BtnRed.Click += BtnRed_Click;
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnRed);
            Controls.Add(BtnBold);
            Controls.Add(RtbNote);
            Controls.Add(BtnLoad);
            Controls.Add(BtnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "파일IO 윈앱";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSave;
        private Button BtnLoad;
        private RichTextBox RtbNote;
        private Button BtnBold;
        private Button BtnRed;
        private OpenFileDialog DlgOpen;
        private SaveFileDialog DlgSave;
        private ColorDialog DlgColor;
    }
}
