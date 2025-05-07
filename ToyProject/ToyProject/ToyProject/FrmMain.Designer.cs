namespace ToyProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            label1 = new Label();
            TxtDiary = new TextBox();
            monthCalendar1 = new MonthCalendar();
            TxtSave = new Button();
            label2 = new Label();
            TxtContent = new TextBox();
            LblContent = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "작성";
            // 
            // TxtDiary
            // 
            TxtDiary.Location = new Point(12, 27);
            TxtDiary.Multiline = true;
            TxtDiary.Name = "TxtDiary";
            TxtDiary.Size = new Size(524, 100);
            TxtDiary.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 139);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // TxtSave
            // 
            TxtSave.Location = new Point(542, 27);
            TxtSave.Name = "TxtSave";
            TxtSave.Size = new Size(30, 100);
            TxtSave.TabIndex = 3;
            TxtSave.Text = "저장";
            TxtSave.UseVisualStyleBackColor = true;
            TxtSave.Click += TxtSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 139);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "내용";
            // 
            // TxtContent
            // 
            TxtContent.Location = new Point(250, 157);
            TxtContent.Multiline = true;
            TxtContent.Name = "TxtContent";
            TxtContent.ReadOnly = true;
            TxtContent.ScrollBars = ScrollBars.Vertical;
            TxtContent.Size = new Size(322, 112);
            TxtContent.TabIndex = 5;
            // 
            // LblContent
            // 
            LblContent.AutoSize = true;
            LblContent.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LblContent.Location = new Point(250, 278);
            LblContent.Name = "LblContent";
            LblContent.Size = new Size(0, 20);
            LblContent.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(LblContent);
            Controls.Add(TxtContent);
            Controls.Add(label2);
            Controls.Add(TxtSave);
            Controls.Add(monthCalendar1);
            Controls.Add(TxtDiary);
            Controls.Add(label1);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "일기장";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtDiary;
        private MonthCalendar monthCalendar1;
        private Button TxtSave;
        private Label label2;
        private TextBox TxtContent;
        private Label LblContent;
    }
}
