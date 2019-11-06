using System;

namespace WordCount
{
    public static class WordCounts
    {
        public static void WordCount()
        {
            var Text = "Msssssssssssss Plateau State, Jos.\nI am studying Computer Science in the University of Jos.\nMy name is Seth, i am a Nigerian. I live in Plateau State, Jos.\nI am studying Computer Science in the University of Jos.\nMy name is Seth, i am a Nigerian. I live in Plateau State, Jos.\nI am studying Computer Science in the University of Jos.\nMy name is Seth, i am a Nigerian. I live in Plateau State, Jos.\nI am studying Computer Science in the University of Jos.\nMy name is Seth, i am a Nigerian. I live in Plateau State, Jos.\nI am studying Computer Science in the University of Jos.\nMy name is Seth, i am a Nigerian. I live in Plateau State, Jos.\nI am studying Computer Science in the University of Jos.\nMy name is Seth, i am a Nigerian. I live in Plateau State, Jos.\nI am studying Computer Science in the University of Jos.\nMy name is Seth, i am a Nigerian. I live in Plateau State, Jos.\nI am studying Computer Science in the University of Jos.";
            double TextLength = (double)Text.Length / 200;//Ans = 6.65
            int Minute = (int)TextLength;
            double Seconds = Convert.ToDouble(TextLength);
            double multiplication = (Seconds - Minute) * 0.60;
            double _ans = Convert.ToDouble(String.Format("{0:00.00}", multiplication));
            double _finalsec = Convert.ToDouble(_ans.ToString().Split('.')[1]);
            if (_finalsec < 30)
            {
                Console.WriteLine("{0} Words = a {1} Minute(s).", Text.Length, Minute);
            }
            else
                Minute += 1;
            Console.WriteLine("{0} Words = a {1} Minute(s).", Text.Length, Minute);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WordCounts.WordCount();
        }
    }
}
