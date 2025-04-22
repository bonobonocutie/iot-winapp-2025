namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // 정수 자료형
            sbyte sbtVal = 127; // signed byte : -128 ~127 수 저장
            byte btVal = 255; // byte : 0 ~ 255 수 저장(1byte 크기)
            short stVal = 32767; // short : -32768 ~ 32767 수 저장
            ushort ustVal = 65535; // unsigned short : 0 ~ 65535 저장(2bytes 크기)
            int intVal = 2147483647; // int : -21억 ~ 21억(4bytes 크기)
            uint uintVal = 4294967295;
            long lngVal; // long : -92경 ~ 92경
            ulong ulngVal; // unsigned long : 1800경(8bytes)

            // 실수 자료형
            float fVal = 3.141592f; // float : 4bytes 소수점
            double dVal = 3.141592; // double : 8bytes 소수점
            decimal dcVal = 3.141592m; // decimal : 16bytes 소수점

            // 무자형 타입
            char ch01 = 'A';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);
        }
    }
}
