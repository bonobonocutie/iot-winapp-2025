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
            MessageBox.Show("�޽���", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // ���� �ڷ���
            sbyte sbtVal = 127; // signed byte : -128 ~127 �� ����
            byte btVal = 255; // byte : 0 ~ 255 �� ����(1byte ũ��)
            short stVal = 32767; // short : -32768 ~ 32767 �� ����
            ushort ustVal = 65535; // unsigned short : 0 ~ 65535 ����(2bytes ũ��)
            int intVal = 2147483647; // int : -21�� ~ 21��(4bytes ũ��)
            uint uintVal = 4294967295;
            long lngVal; // long : -92�� ~ 92��
            ulong ulngVal; // unsigned long : 1800��(8bytes)

            // �Ǽ� �ڷ���
            float fVal = 3.141592f; // float : 4bytes �Ҽ���
            double dVal = 3.141592; // double : 8bytes �Ҽ���
            decimal dcVal = 3.141592m; // decimal : 16bytes �Ҽ���

            // ������ Ÿ��
            char ch01 = 'A';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);
        }
    }
}
