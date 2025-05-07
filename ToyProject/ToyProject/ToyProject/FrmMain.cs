using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToyProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void TxtSave_Click(object sender, EventArgs e)
        {
            DiaryManager diaryManager = new DiaryManager();
            string content = TxtDiary.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string emotion = "";

            List<DiaryEntry> entries = diaryManager.LoadDiaryEntries();

            var todayEntry = entries.FirstOrDefault(e => e.Date.ToString("yyyy-MM-dd") == date);

            if (todayEntry != null)
            {
                todayEntry.Content += "\r\n" + content;
                emotion = diaryManager.GetEmotionFromPython(todayEntry.Content);

                int emotionNum = int.Parse(emotion);
                emotion = ConvertEmotionCodeToEmoji(emotionNum);

                todayEntry.Emotion = emotion;

            }
            else
            {
                emotion = diaryManager.GetEmotionFromPython(content);

                int emotionNum = int.Parse(emotion);
                emotion = ConvertEmotionCodeToEmoji(emotionNum);

                DiaryEntry de = new DiaryEntry
                {
                    Date = DateTime.Parse(date),
                    Content = content,
                    Emotion = emotion
                };

                entries.Add(de);

            }

            diaryManager.SaveDiaryEntries(entries);

        }

        private string ConvertEmotionCodeToEmoji(int emotionNum)
        {
            return emotionNum switch
            {
                1 => "😢 너무 슬프고 속상한 하루였군요.",
                2 => "😞 마음이 조금 무거운 하루였군요.",
                3 => "😐 그저 그런 하루였군요.",
                4 => "🙂 작은 기쁨들이 쌓인 하루였군요.",
                5 => "😄 기분 좋은 일이 가득한 하루였군요!",
                _ => "❓"
            };
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;

            DiaryManager diaryManager = new DiaryManager();

            List<DiaryEntry> entries = diaryManager.LoadDiaryEntries();


            // 선택된 날짜와 일치하는 일기 찾기
            var de = entries.FirstOrDefault(entry => entry.Date.Date == selectedDate.Date);
            if (de != null)
            {
                TxtContent.Text = de.Content;
                LblContent.Text = de.Emotion;
            }
            else
            {
                TxtContent.Text = "이 날짜에는 일기가 없습니다.";
                LblContent.Text = "";
            }
        }
    }
}
