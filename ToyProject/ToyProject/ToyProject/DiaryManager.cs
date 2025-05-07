using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ToyProject
{
    internal class DiaryManager
    {
        private string filePath = Path.Combine("diary.json");

        public List<DiaryEntry> LoadDiaryEntries()
        {
            if (!File.Exists(filePath))
            {
                return new List<DiaryEntry>(); // 파일이 없으면 빈 리스트 반환
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<DiaryEntry>>(json);
        }

        public void SaveDiaryEntries(List<DiaryEntry> entries)
        {

            var options = new JsonSerializerOptions { 
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string json = JsonSerializer.Serialize(entries, options);

            File.WriteAllText(filePath, json);
        }

        public string GetEmotionFromPython(string content)
        {
            try
            {
                // Python 스크립트를 실행하기 위한 설정
                var startInfo = new ProcessStartInfo
                {
                    FileName = "python", // Python 인터프리터 경로
                    Arguments = $"diary.py \"{content}\"", // 텍스트를 인자로 전달
                    RedirectStandardOutput = true, // Python 출력값을 C#에서 받을 수 있도록 설정
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Python 프로세스 시작
                using (var process = Process.Start(startInfo))
                {
                    // Python 출력 결과를 읽음
                    using (var reader = process.StandardOutput)
                    {
                        string emotion = reader.ReadLine();
                        Console.WriteLine(emotion);

                        //string error = process.StandardError.ReadToEnd();
                        //if (!string.IsNullOrEmpty(error))
                        //    Console.WriteLine("Python error: " + error);

                        return emotion; // 감정 값을 반환
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
