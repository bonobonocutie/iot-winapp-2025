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
            // 백그라운드 워커 초기화
            BgwProcess.WorkerReportsProgress = true; // 진행사항 리포트할 것인지

            BgwProcess.DoWork += BgwProcess_DoWork; // 백그라운드 진행 이벤트

            // 버튼 클릭 이벤트
            BtnStart.Click += BtnStart_Click;

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            LblState.Text = "현재상태 : 진행";
            BtnStart.Text = "진행 중";
            BtnStart.Enabled = false;

            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;
            PrgProcess.Value = 0;

            TxtLog.Clear();

            BgwProcess.RunWorkerAsync(); // 백그라운드 작업 시작
        }

        // 백그라운드 실제 작업
        private void BgwProcess_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            long MaxVal = 200;
            long total = 0;

            for(int i = 0; i < MaxVal; i++)
            {
                total += i % 3; // 내부적으로 임의적 처리

                int progress = (int)((i * 100) / MaxVal) + 1;
                // 진행사항을 ProgressChanged 이벤트쪽으로 전달(넘김)
                BgwProcess.ReportProgress(progress, i);

                Thread.Sleep(50); // 50ms 시간 소요
            }
        }

        // 진행상내 UI 업데이트
        private void BgwProcess_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage; // DoWork.ReportProgress(1,2) 중 1번으로 넘어온 값
            int currVal = (int)e.UserState; // ReportProgress 2번으로 넘어온 값

            PrgProcess.Value = progress;

            TxtLog.AppendText(currVal.ToString() + "\r\n");
            TxtLog.SelectionStart = TxtLog.Text.Length;
            TxtLog.ScrollToCaret(); // 마지막 줄로 이동

            LblState.Text = $"현재상태 : {progress}%";
        }

        // 백그라운드 작업 완료된 후 처리 이벤트
        private void BgwProcess_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            LblState.Text = "현재상태 : 중지";
            BtnStart.Enabled = true;
            BtnStart.Text = "시작";
        }

    }
}
