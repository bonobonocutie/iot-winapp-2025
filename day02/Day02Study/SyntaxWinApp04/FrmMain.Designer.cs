﻿namespace SyntaxWinApp04
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
            TxtName = new TextBox();
            LblAge = new Label();
            label1 = new Label();
            RdoMale = new RadioButton();
            RdoFemale = new RadioButton();
            LblResult = new Label();
            TxtResult = new TextBox();
            BtnMsg = new Button();
            TxtAge = new MaskedTextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(18, 24);
            LblName.Name = "LblName";
            LblName.Size = new Size(62, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름 입력:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(86, 21);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(187, 23);
            TxtName.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(18, 53);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(62, 15);
            LblAge.TabIndex = 0;
            LblAge.Text = "나이 입력:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 81);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "나이 입력:";
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.Location = new Point(88, 77);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(49, 19);
            RdoMale.TabIndex = 3;
            RdoMale.TabStop = true;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Location = new Point(143, 77);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(49, 19);
            RdoFemale.TabIndex = 4;
            RdoFemale.TabStop = true;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(18, 132);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(58, 15);
            LblResult.TabIndex = 0;
            LblResult.Text = "결      과:";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(86, 129);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(463, 23);
            TxtResult.TabIndex = 5;
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(472, 259);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(86, 53);
            TxtAge.Mask = "0000-00-00";
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(186, 23);
            TxtAge.TabIndex = 7;
            TxtAge.ValidatingType = typeof(DateTime);
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(TxtAge);
            Controls.Add(BtnMsg);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMale);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(label1);
            Controls.Add(LblAge);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법연습 윈앱04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private Label label1;
        private RadioButton RdoMale;
        private RadioButton RdoFemale;
        private Label LblResult;
        private TextBox TxtResult;
        private Button BtnMsg;
        private MaskedTextBox TxtAge;
    }
}
