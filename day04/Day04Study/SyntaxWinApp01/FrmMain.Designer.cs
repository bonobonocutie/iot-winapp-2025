namespace SyntaxWinApp01
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
            LblName = new Label();
            groupBox1 = new GroupBox();
            TxtPhone = new MaskedTextBox();
            NudAge = new NumericUpDown();
            TxtGender = new TextBox();
            TxtResult = new TextBox();
            TxtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnCheck = new Button();
            PicResult = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).BeginInit();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(16, 28);
            LblName.Name = "LblName";
            LblName.Size = new Size(38, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름 :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(NudAge);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LblName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 287);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "정보입력/결과";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(68, 122);
            TxtPhone.Mask = "000-9000-0000";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(151, 23);
            TxtPhone.TabIndex = 4;
            // 
            // NudAge
            // 
            NudAge.Location = new Point(69, 59);
            NudAge.Name = "NudAge";
            NudAge.Size = new Size(150, 23);
            NudAge.TabIndex = 2;
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(69, 90);
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(150, 23);
            TxtGender.TabIndex = 3;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(16, 189);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(255, 83);
            TxtResult.TabIndex = 5;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(69, 30);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 23);
            TxtName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 171);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "결과 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 125);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "폰번호 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 93);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "성별 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 61);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "나이 :";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(472, 269);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 30);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "체크";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // PicResult
            // 
            PicResult.BackColor = Color.White;
            PicResult.Image = Properties.Resources.girl;
            PicResult.Location = new Point(305, 12);
            PicResult.Name = "PicResult";
            PicResult.Size = new Size(267, 251);
            PicResult.SizeMode = PictureBoxSizeMode.StretchImage;
            PicResult.TabIndex = 3;
            PicResult.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(PicResult);
            Controls.Add(BtnCheck);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            Text = "문법학습 윈앱01";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LblName;
        private GroupBox groupBox1;
        private TextBox TxtName;
        private Label label1;
        private NumericUpDown NudAge;
        private TextBox TxtGender;
        private Label label3;
        private Label label2;
        private MaskedTextBox TxtPhone;
        private TextBox TxtResult;
        private Label label4;
        private Button BtnCheck;
        private PictureBox PicResult;
    }
}
