using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Table
{
    public class OOP
    {
        private static void Main()
        {

            ArrayList list = new ArrayList();
            ArrayList log = new ArrayList();
            List<int> ToSearch2 = new List<int>();
            ArrayList ToSearch = new ArrayList();
            List<int> log2 = new List<int>();
            List<int> log3 = new List<int>();
            bool flag = true;
            bool flag1 = true;
            string[] ListFilter = {"1-Слово начинается с заглваной", "2-Слово заканчивается заглавной", "3-Слово начинается с маленькой буквой", "4-Слово заканчивается маленькой буквой", "5-Слово начинается с цифры","6-Слово заканчивается цифрой",
                    "7-Начинается цифрой,заканчивается заглвной", "8-Заканчивается цифрой,начинается с заглвной","9-Начинается цифрой,заканчивается маленькой", "10-Заканчивается цифрой,начинается с маленькой",
            "11-Начинается с заглавной, заканчивается с маленькой", "12-Начинается с маленькой, заканчивается заглавной", "13-Имеются знаки", "14-Начинаются и заканчиваются с загланой",
            "15-Начинаются и заканчиваются с маленькой", "16-Начинаются и заканчиваются с цифры","17-Выход"};
            while (flag1)
            {
                Console.WriteLine("1 – Просмотр таблицы");
                Console.WriteLine("2 – Добавить запись");
                Console.WriteLine("3 – Удалить запись");
                Console.WriteLine("4 – Обновить запись");
                Console.WriteLine("5 – Поиск записей");
                Console.WriteLine("6 – Просмотреть лог");
                Console.WriteLine("7 - Выход");
                int Num1 = int.Parse(Console.ReadLine());
                switch (Num1)
                {
                    case 1:
                        {
                            Console.WriteLine(new string('-', 76));
                            Console.WriteLine($"{"|Сельско хозяйственные культуры",-75}|");
                            Console.WriteLine(new string('-', 76));
                            Console.WriteLine($"{"|Наименование",-25}|{"Тип ",-12}|{"Площадь",-20}|{"Урожайность",-15}|");
                            Console.WriteLine(new string('-', 76));
                            foreach (object item in list)
                            {

                                Console.WriteLine(item);
                                Console.WriteLine(new string('-', 76));
                            }
                            Console.WriteLine($"{"|Перечисляемый тип: Z - зерновые, B - бобовые",-75}|");
                            Console.WriteLine(new string('-', 76));
                            break;
                        }
                    case 2:
                        {
                            while (flag)
                            {
                                Console.WriteLine("Введите данные:");

                                Console.WriteLine("Наименование:");
                                string name = Console.ReadLine();
                                if (log.Count >= 50)
                                {
                                    log.RemoveAt(0);
                                }
                                log.Add(DateTime.Now.ToString("HH:mm:ss") + " - Добавлена запись  " + $"“{name}”");
                                string GG = DateTime.Now.ToString("HH:mm:ss");
                                string[] GG1 = GG.Split(':');
                                int GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                                log2.Add(GG2);
                                Console.WriteLine("Тип растения (З-Зерновой, Б-Бобовые");
                                string ItemType = Console.ReadLine();
                                if (log.Count >= 50)
                                {
                                    log.RemoveAt(0);
                                }
                                log.Add(DateTime.Now.ToString("HH:mm:ss") + " - Добавлена запись  " + $"“{ItemType}”");
                                GG = DateTime.Now.ToString("HH:mm:ss");
                                GG1 = GG.Split(':');
                                GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                                log2.Add(GG2);
                                Console.WriteLine("Площадь посева (га)");
                                int ploh = Int32.Parse(Console.ReadLine());
                                if (log.Count >= 50)
                                {
                                    log.RemoveAt(0);
                                }
                                log.Add(DateTime.Now.ToString("HH:mm:ss") + " - Добавлена запись  " + $"“{ploh}”");
                                GG = DateTime.Now.ToString("HH:mm:ss");
                                GG1 = GG.Split(':');
                                GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                                log2.Add(GG2);
                                Console.WriteLine("Урожайность (ц/га)");
                                int uroz = Int32.Parse(Console.ReadLine());
                                if (log.Count >= 50)
                                {
                                    log.RemoveAt(0);
                                }
                                log.Add(DateTime.Now.ToString("HH:mm:ss") + " - Добавлена запись  " + $"“{uroz}”");
                                GG = DateTime.Now.ToString("HH:mm:ss");
                                GG1 = GG.Split(':');
                                GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                                log2.Add(GG2);
                                ToSearch.Add(name);
                                ToSearch.Add(ItemType);
                                ToSearch.Add(ploh.ToString());
                                ToSearch.Add(uroz.ToString());
                                ToSearch2.Add(ploh);
                                ToSearch2.Add(uroz);
                                list.Add($"{$"|{name}",-25}" + $"{$"|{ItemType}",-13}" + $"{$"|{ploh}",-21}" + $"{$"|{uroz}",-16}|");
                                while (true)
                                {
                                    Console.WriteLine("Добавить строку?\nда - продолжить\nнет - вывод таблицы");
                                    string input = Console.ReadLine();
                                    if (input == "да" || input == "нет")
                                    {
                                        if (input == "нет")
                                        {
                                            flag = false;
                                            break;
                                        }
                                        break;
                                    }
                                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Номер строки которую нужно удалить:");
                            int NumLine = int.Parse(Console.ReadLine());
                            if (log.Count >= 50)
                            {
                                log.RemoveAt(0);
                            }
                            log.Add(DateTime.Now.ToString("HH:mm:ss") + " - Удалена запись  " + $"“{list[NumLine - 1]}”");
                            string GG = DateTime.Now.ToString("HH:mm:ss");
                            string[] GG1 = GG.Split(':');
                            int GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                            log2.Add(GG2);
                            list.RemoveAt(NumLine - 1);

                          //  ToSearch.RemoveAt((0+(NumLine-1)*4)-(3+(NumLine-1)*4));
                          //  ToSearch2.RemoveAt((0 + (NumLine - 1) * 2) - (3 + (NumLine - 1) * 2));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Номер строки которую нужно обновить:");
                            int NumLine = int.Parse(Console.ReadLine());
                            list.RemoveAt(NumLine - 1);
                            Console.WriteLine("Введите данные:");

                            Console.WriteLine("Наименование:");
                            string name = Console.ReadLine();
                            if (log.Count >= 50)
                            {
                                log.RemoveAt(0);
                            }
                            log.Add(DateTime.Now.ToString("HH:mm:ss") + $" - В строке под номером {NumLine} проихошли обновления " + $"“{name}”");
                            string GG = DateTime.Now.ToString("HH:mm:ss");
                            string[] GG1 = GG.Split(':');
                            int GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                            log2.Add(GG2);
                            Console.WriteLine("Тип растения (З-Зерновой, Б-Бобовые");
                            string ItemType = Console.ReadLine();
                            if (log.Count >= 50)
                            {
                                log.RemoveAt(0);
                            }
                            log.Add(DateTime.Now.ToString("HH:mm:ss") + $" - В строке под номером {NumLine} проихошли обновления " + $"“{ItemType}”");
                            GG = DateTime.Now.ToString("HH:mm:ss");
                            GG1 = GG.Split(':');
                            GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                            log2.Add(GG2);
                            Console.WriteLine("Площадь посева (га)");
                            int ploh = Int32.Parse(Console.ReadLine());
                            if (log.Count >= 50)
                            {
                                log.RemoveAt(0);
                            }
                            log.Add(DateTime.Now.ToString("HH:mm:ss") + $" - В строке под номером {NumLine} проихошли обновления " + $"“{ploh}”");
                            GG = DateTime.Now.ToString("HH:mm:ss");
                            GG1 = GG.Split(':');
                            GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                            log2.Add(GG2);
                            Console.WriteLine("Урожайность (ц/га)");
                            int uroz = Int32.Parse(Console.ReadLine());
                            if (log.Count >= 50)
                            {
                                log.RemoveAt(0);
                            }
                            log.Add(DateTime.Now.ToString("HH:mm:ss") + $" - В строке под номером {NumLine} проихошли обновления " + $"“{uroz}”");
                            GG = DateTime.Now.ToString("HH:mm:ss");
                            GG1 = GG.Split(':');
                            GG2 = ((int.Parse(GG1[0])) * 3600) + ((int.Parse(GG1[1])) * 60) + ((int.Parse(GG1[2])));
                            log2.Add(GG2);
                            ToSearch.Add(name);
                            ToSearch.Add(ItemType);
                            ToSearch.Add(ploh.ToString());
                            ToSearch.Add(uroz.ToString());
                            ToSearch2.Add(ploh);
                            ToSearch2.Add(uroz);
                            list.Insert(NumLine - 1, $"{$"|{name}",-25}" + $"{$"|{ItemType}",-13}" + $"{$"|{ploh}",-21}" + $"{$"|{uroz}",-16}|");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Хотите вывести список филтров?(да или нет)");
                            String Answer = Console.ReadLine();
                            
                            if (Answer == "да")
                            {
                                foreach (string Line in ListFilter)
                                {
                                    Console.WriteLine(Line);
                                }
                            }
                            Console.WriteLine("Введите номер фильтра:");
                            int Object = int.Parse(Console.ReadLine());
                            switch (Object)
                            {
                                case 1:
                                    {

                                        Regex regex = new Regex(@"^[А-ЯA-Z]");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 2:
                                    {

                                        Regex regex = new Regex(@"[А-ЯA-Z]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 3:
                                    {

                                        Regex regex = new Regex(@"^[а-яa-z]");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 4:
                                    {

                                        Regex regex = new Regex(@"[а-яa-z]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 5:
                                    {

                                        Regex regex = new Regex(@"^[0-9]");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 6:
                                    {

                                        Regex regex = new Regex(@"[0-9]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 7:
                                    {

                                        Regex regex = new Regex(@"^[0-9][А-ЯA-Z]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 8:
                                    {

                                        Regex regex = new Regex(@"^[А-ЯA-Z][0-9]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 9:
                                    {

                                        Regex regex = new Regex(@"^[а-яa-z][0-9]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 10:
                                    {

                                        Regex regex = new Regex(@"^[0-9][а-яa-z]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 11:
                                    {

                                        Regex regex = new Regex(@"^[А-ЯA-Z][а-яa-z]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 12:
                                    {

                                        Regex regex = new Regex(@"^[а-яa-z][А-ЯA-Z]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 13:
                                    {

                                        Regex regex = new Regex(@"\W");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 14:
                                    {
                                        Regex regex = new Regex(@"^[A-ZА-Я]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 15:
                                    {
                                        Regex regex = new Regex(@"^[а-яa-z]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 16:
                                    {
                                        Regex regex = new Regex(@"^[0-9]$");
                                        foreach (string g in ToSearch)
                                        {
                                            if (regex.IsMatch(g))
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;
                                    }
                                case 17:
                                    {

                                        int NumSe = int.Parse(Console.ReadLine());
                                        foreach (int g in ToSearch2)
                                        {
                                            if (g > NumSe)
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;

                                    }
                                case 18:
                                    {

                                        int NumSe = int.Parse(Console.ReadLine());
                                        foreach (int g in ToSearch2)
                                        {
                                            if (g < NumSe)
                                            {
                                                Console.WriteLine(g);
                                            }

                                        }
                                        break;

                                    }
                                case 19:

                                    {



                                        int NumSe = int.Parse(Console.ReadLine());

                                        foreach (int g in ToSearch2)

                                        {

                                            if (g > NumSe)

                                            {

                                                Console.WriteLine(g);

                                            }



                                        }

                                        break;



                                    }                               
                            }
                            break;
                                   
                        }
                    case 6:
                        {
                            int Hova = 0;
                            int MAX = 0;
                            foreach (string Line in log)
                            {
                                Console.WriteLine(Line);
                            }
                            foreach (int G in log2)
                            {
                                if (Hova > 0)
                                {
                                    log3.Add(log2[Hova] - log2[Hova-1]);
                                }
                                Hova++;
                            }
                            MAX = log3.Max();
                            Console.WriteLine($"{MAX/3600}:{MAX/60}:{MAX} – Самый долгий период бездействия пользователя");
                            break;
                        }
                    case 7:
                        {
                            Process.GetCurrentProcess().Kill();
                            break;
                        }

                }
            }

        }
    } 
}
