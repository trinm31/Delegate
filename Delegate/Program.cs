using System;

namespace Delegate
{
    class Program
    {
        
        // Khoi tao Delegate
        //public delegate void ShowLog(String message);

        public static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Infor {s}");
            Console.ResetColor();
        }
        
        public static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Warning {s}");
            Console.ResetColor();
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        } 
        
        // callback example
        public static void TinhTong(int a, int b, Action<string> callback)
        {
            int c = a + b;
            //gọi callback
            callback(c.ToString());
        }

        static void Main(string[] args)
        {
            
            // 1. Gioi thieu delegate
                //ShowLog showLog;

                // showLog = Info;
                // showLog("Thong Bao");
                //
                // showLog = Warning;
                // showLog("Thong Bao");
                //
                // showLog = null;
                // showLog += Warning;
                // showLog += Info;
                // showLog += Warning;
                //
                // showLog("Testlag");
            
            // 2. Func va Action
                // Func<kiểu_tham_số_1, kiểu_tham_số_2, ..., kiểu_trả_về> var_delegate;
                // Func<int, int, int> TinhTong;
                // TinhTong = Sum;
                // var ketqua = TinhTong(1, 2);
                // Console.WriteLine(ketqua);
                
                //Action<kiểu_tham_số_1, kiểu_tham_số_2, ... > var_delegate;
                // Action<string> showlog = null;
                //
                // showlog += Warning;
                // showlog += Info;
                // showlog += Warning;
                //
                // showlog("Test Log");
                
            // 3. Callback giúp cho một function gọi một function khác
            
                // TinhTong(5,6, (x) => Console.WriteLine($"Tổng hai số là: {x}"));
                // TinhTong(5,6, Info);
                // TinhTong(5,6, Warning);
           
        }
    }
}