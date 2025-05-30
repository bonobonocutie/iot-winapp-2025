namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void TxtLog_TextChanged(object sender, EventArgs e)
        {

        }

        // async : 비동기로 동작하는 메서드 선언
        // async, await는 항상 같이 사용
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurState.Text = "현재상태 : 진행";
            BtnStart.Text = "진행중";
            BtnStart.Enabled = false;

            // 시간이 걸리는 연산을 수행
            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            // await로 비동기 대기
            await Task.Run(() => {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    TxtLog.Text += i.ToString() + "\r\n";
                    TxtLog.SelectionStart = TxtLog.Text.Length;
                    TxtLog.ScrollToCaret(); // 스크롤을 제일 밑으로
                    PrgProcess.Value = progress;
                    Thread.Sleep(50);
                    //Application.DoEvents(); // 권장 X
                }
            });
            
            


            LblCurState.Text = "현재상태 : 중지";
            BtnStart.Text = "시작";
            BtnStart.Enabled = true;

        }
    }
}
