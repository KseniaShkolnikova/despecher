using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispetcher
{
    internal class Class3
    {
        private static Process dd;
        public static void ocnov()
        {
            Console.Clear();
            List<Process> processa = new List<Process>();
            foreach (Process process in Process.GetProcesses())
            {
                processa.Add(process);
            }
            int i = 1;
            foreach (Process processdla in Process.GetProcesses())
            {
                Console.SetCursorPosition(2, i);
                Console.WriteLine(processdla.ProcessName);
                Console.SetCursorPosition(40, i);
                Console.WriteLine(processdla.WorkingSet64);
                Console.SetCursorPosition(65, i);
                Console.WriteLine(processdla.BasePriority);
                Console.SetCursorPosition(80, i);
                Console.WriteLine(processdla.PagedSystemMemorySize64);
                i++;
            }
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("Имя");
            Console.SetCursorPosition(35, 0);
            Console.WriteLine("Физическая память");
            Console.SetCursorPosition(60, 0);
            Console.WriteLine("Приоритет");
            Console.SetCursorPosition(75, 0);
            Console.WriteLine("Страничная системная память");
            int position = Class1.strelka(1, 1, processa.Count);
            dd = processa[position - 1];
            inform();
        }
        private static void inform()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(dd);
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Физическая память                       {dd.WorkingSet64}");
                Console.WriteLine($"Приоритет                               {dd.BasePriority}");
                Console.WriteLine($"Страничная системная память             {dd.PagedSystemMemorySize64}");
                Console.WriteLine($"Класс приоритета                        {dd.PriorityClass}");
                Console.WriteLine($"Время использования процесса            {dd.UserProcessorTime}");
                Console.WriteLine($"Все время использования                 {dd.TotalProcessorTime}");
            }
            catch
            {
                try
                {
                    Console.WriteLine($"Класс приоритета                        {dd.PriorityClass}");
                    Console.WriteLine($"Время использования процесса            {dd.UserProcessorTime}");
                    Console.WriteLine($"Все время использования                 {dd.TotalProcessorTime}");
                }
                catch
                {
                    try
                    {
                        Console.WriteLine($"Время использования процесса            {dd.UserProcessorTime}");
                        Console.WriteLine($"Все время использования                 {dd.TotalProcessorTime}");
                    }
                    catch
                    {
                        try
                        {
                            Console.WriteLine($"Все время использования                 {dd.TotalProcessorTime}");
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Недостаточно разрешений\nЧто бы вернутся нажмите кнопу Beckspace\nдля выхода - Escape");
                            Class1.strelka(3, 3, 3);

                        }
                    }
                }
            }
            finally
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("D - Завершить процесс\nDel - Завершить все процессы с этим именем");
                Class1.strelka(10,10,10);
            }
            
        }
        public static void ydal()
        {
            dd.Kill();
            ocnov();
        }
        public static void ydalvse()
        {
            foreach (Process processdla in Process.GetProcesses())
            {
                if (dd.ProcessName == processdla.ProcessName)
                {
                    processdla.Kill();
                }
            }
            dd.Kill();
            ocnov();
        }
    }
}
