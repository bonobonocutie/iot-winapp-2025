namespace SyntaxWinApp02
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
            BtnMsg = new Button();
            LblPain = new Label();
            TxtPain = new TextBox();
            LblPainPoint = new Label();
            CboPainPoint = new ComboBox();
            BtnDisplay = new Button();
            TxtResult = new TextBox();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // BtnMsg
            // 
            BtnMsg.ForeColor = SystemColors.ActiveCaptionText;
            BtnMsg.Location = new Point(472, 259);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 0;
            BtnMsg.Text = "메시지";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblPain
            // 
            LblPain.AutoSize = true;
            LblPain.Location = new Point(22, 31);
            LblPain.Name = "LblPain";
            LblPain.Size = new Size(59, 15);
            LblPain.TabIndex = 1;
            LblPain.Text = "통증 여부";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(99, 28);
            TxtPain.MaxLength = 3;
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니오";
            TxtPain.Size = new Size(118, 23);
            TxtPain.TabIndex = 2;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // LblPainPoint
            // 
            LblPainPoint.AutoSize = true;
            LblPainPoint.Location = new Point(22, 72);
            LblPainPoint.Name = "LblPainPoint";
            LblPainPoint.Size = new Size(59, 15);
            LblPainPoint.TabIndex = 3;
            LblPainPoint.Text = "통증 부위";
            // 
            // CboPainPoint
            // 
            CboPainPoint.FormattingEnabled = true;
            CboPainPoint.Items.AddRange(new object[] { "머리", "눈", "코", "목", "가슴", "배" });
            CboPainPoint.Location = new Point(99, 69);
            CboPainPoint.Name = "CboPainPoint";
            CboPainPoint.Size = new Size(118, 23);
            CboPainPoint.TabIndex = 4;
            CboPainPoint.SelectedIndexChanged += CboPainPoint_SelectedIndexChanged;
            // 
            // BtnDisplay
            // 
            BtnDisplay.ForeColor = SystemColors.ActiveCaptionText;
            BtnDisplay.Location = new Point(366, 259);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(100, 40);
            BtnDisplay.TabIndex = 5;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = true;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(24, 102);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(548, 139);
            TxtResult.TabIndex = 6;
            // 
            // BtnWhile
            // 
            BtnWhile.ForeColor = SystemColors.ActiveCaptionText;
            BtnWhile.Location = new Point(260, 259);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(100, 40);
            BtnWhile.TabIndex = 7;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnWhile);
            Controls.Add(TxtResult);
            Controls.Add(BtnDisplay);
            Controls.Add(CboPainPoint);
            Controls.Add(LblPainPoint);
            Controls.Add(TxtPain);
            Controls.Add(LblPain);
            Controls.Add(BtnMsg);
            Name = "FrmMain";
            Text = "문법학습 윈앱03";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMsg;
        private Label LblPain;
        private TextBox TxtPain;
        private Label LblPainPoint;
        private ComboBox CboPainPoint;
        private Button BtnDisplay;
        private TextBox TxtResult;
        private Button BtnWhile;
    }
}
