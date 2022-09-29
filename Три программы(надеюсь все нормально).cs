namespace freeprogramm
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            menu();
            static void menu()
            {
                Console.WriteLine("Выберите программу, которую вы хотите запустить \r\n1. Угадай число\r\n2. Таблица умножения\r\n3. Вывод делителей числа\r\n4. Выйти из программы");
                Console.WriteLine("Введите операцию: ");
                int programa = Convert.ToInt32(Console.ReadLine());
                while (programa != 4)
                {
                    static void program1(int programa)
                    {
                        if (programa == 1)
                        {
                            Random rand = new Random();
                            int chislotwo = rand.Next(100);
                            int chislo;
                            int vveli;
                            vveli = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Вы выбрали игру угадай число");
                            vveli = Convert.ToInt32(Console.ReadLine());
                            do
                            {

                                chislo = Convert.ToInt32(Console.ReadLine());

                                if (chislo < vveli)
                                {
                                    Console.WriteLine("загаданное число меньше вашего");
                                }
                                if (chislo > vveli)
                                {
                                    Console.WriteLine("загаданное число больше вашего");
                                }
                            } while (vveli != chislo);
                            Console.WriteLine("Победа");
                        }
                    }
                    static void program2 (int programa)
                    {
                        if (programa == 2)
                        {
                            int maximal = 9;
                            for (int i = 1; i <= maximal; i++)
                            {
                                Console.WriteLine();
                                for (int j = 1; j <= maximal; j++)
                                {
                                    Console.Write("{0} ", i * j);
                                }
                            }
                            Console.ReadKey();

                        }
                    }
                    static void program3 (int programa)
                    {
                     if (programa == 3)
                        {
                            Console.WriteLine("Введите число");
                            int ChisloP3 = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i * i <= ChisloP3; i++)
                            {
                                if (ChisloP3 % i == 0)
                                    Console.WriteLine(i);
                            }
                            Console.WriteLine(ChisloP3);
                        }
                    }
                    Console.WriteLine("Вы в главном меню,выберите ваше следующее действие");
                    programa = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}