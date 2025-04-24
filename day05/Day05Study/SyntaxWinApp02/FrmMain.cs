namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int add(int x, int y)
        {
            return x + y;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            // 대리자  = 람다식
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";

            // sayHello 함수 생성 대신
            Action<string> sayHello = name => MessageBox.Show($"안녕, {name}", "인사",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            sayHello("유고");

            // LINQ 사용 이전
            List<int> resList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];

            // 짝수만 추출해서 오름차순 정렬하는 로직
            foreach (int n in numbers)
            {
                if (n % 2 == 0) // 짝수
                {
                    resList.Add(n);
                }
            }

            TxtLog.Text += "짝수리스트 > " + string.Join(" ", resList) + "\r\n";
            resList.Sort();
            TxtLog.Text += "정렬리스트 > " + string.Join(" ", resList) + "\r\n";

            // 기본 LINQ 방식 -> 3줄로 위의 전통방식을 처리
            numbers = [14, 20, 11, 15, 18, 19, 16, 13, 12, 17];
            var resList2 = from n in numbers
                           where n % 2 == 0
                           orderby n
                           select n;
            TxtLog.Text += "링큐1 정렬리스트 > " + string.Join(" ", resList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [24, 30, 21, 25, 28, 29, 26, 23, 22, 27];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "링큐2 정렬리스트 > " + string.Join(" ", resList3) + "\r\n";

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TxtTest.PlaceholderText = "테스트입니다";
            TxtTest.Size = new Size(348, 23);
            TxtTest.KeyPress += TxtTest_KeyPress;
            TxtTest.Font = new Font("휴먼매직체", 12, FontStyle.Italic);
        }

        private void TxtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // == 13
            {
                MessageBox.Show("엔터를 클릭했습니다.", "키프레스",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            Print<int>(100);
            Print<float>(3.141592f);
            Print<string>("안녕, 유고!");
            Print<bool>(true);

            // 생략가능
            Print(100);
            Print(3.141592f);
            Print("안녕, 유고!");
            Print(true);

            // 제네릭 클래스 사용
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

            Box<string> strBox = new Box<string>();
            strBox.Value = "애슐리";
            strBox.Show();

        }

        public void Print<T>(T data) { Console.WriteLine(data); }
    }

    // 제네릭 클래스
    public class Box<T> // where T : struct
    {
        public T Value { get; set; } // 속성

        public void Show()
        {
            MessageBox.Show($"Box의 값 : {Value}", "Box값",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
