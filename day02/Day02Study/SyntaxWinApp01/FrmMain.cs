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

            // 문자형 타입
            char ch01 = 'A';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0World!"; // \0 : end of line 

            // 불린 타입
            bool bool01 = true;

            // Nullable
            //int int02 = null;  // 기본타입(정수형, 실수형, 불린 / 문자열제외)은 NULL 할당불가
            int? int03 = null; // 기본타입 뒤에 ? 붙여줄 것

            // 상수타입
            const int int04 = 15; // const를 만나면 상수. 한번 할당후 변경 불가
            //int04 = 26;

            // 동적타입 // 컴파일되면서 해당 타입으로 형결정
            var int05 = false;
            //int05 = "string";

            //MessageBox.Show(intVal2.ToString() + ch01 + ch02, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(int03.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
