namespace Практическая3
{
    class Program
    {
        static void Main(string[] args)
        {
            Piano();

        }
        static int[] firstoctav = new int[] { 880, 987, 1047, 1175, 1319, 1397, 1568, 932, 1109, 1245, 1480, 1661 };
        static int[] secondoctav = new int[] { 440, 493, 523, 587, 659, 698, 784, 466, 554, 622, 748, 830 };
        static int[] thirdoctav = new int[] { 110, 123, 130, 146, 164, 174, 196, 116, 138, 155, 185, 287 };
        static void Piano()
        {
            Console.WriteLine("Белые клавиши: D-до; F-ре; G-ми; H-фа; J-соль; K-ля; L-си;");
            Console.WriteLine("Черные: R - До # и ре b; T - ми # и фа b; Y- фа # и соль b; U- ля# и си b; I- си # и до b.");
            Console.WriteLine("Переключение октавы: 1- F1; 2- F2; 3-F3.");
            Console.WriteLine("Чтобы вернуться в меню выбора октавы выберите 'Backspace'");
            Console.WriteLine("Для выхода нажмите любую клавишу, не являющуюся выбором октавы");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F1)
            {
                oktava1(firstoctav);
            }
            if (key.Key == ConsoleKey.F2)
            {
                oktava2(secondoctav);
            }
            if (key.Key == ConsoleKey.F3)
            {
                oktava3(thirdoctav);
            }
            if (key.Key == ConsoleKey.Backspace)
            {
                exit();
            }


        }


        static void oktava1(int[] sound)
        {
            Console.Clear();
            Console.WriteLine("Первая октава");
            for (ConsoleKeyInfo key = Console.ReadKey(); key.Key != ConsoleKey.Backspace;)
            {
                ConsoleKeyInfo l = Console.ReadKey();
                key = l;
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(sound[0], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(sound[1], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(sound[2], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(sound[3], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(sound[4], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.K)
                {
                    Console.Beep(sound[5], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.L)
                {
                    Console.Beep(sound[6], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.R)
                {
                    Console.Beep(sound[7], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(sound[8], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(sound[9], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.U)
                {
                    Console.Beep(sound[10], 150);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.I)
                {
                    Console.Beep(sound[11], 150);
                    Console.Clear();
                }

            }
            Piano();
        }


        static void oktava2(int[] sound)
        {
            Console.Clear();
            Console.WriteLine("Вторая октава");
            for (ConsoleKeyInfo key = Console.ReadKey(); key.Key != ConsoleKey.Backspace;)
            {

                ConsoleKeyInfo l = Console.ReadKey();
                key = l;



                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(sound[11], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(sound[10], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(sound[9], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(sound[8], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(sound[7], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.K)
                {
                    Console.Beep(sound[6], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.L)
                {
                    Console.Beep(sound[5], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.R)
                {
                    Console.Beep(sound[4], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(sound[3], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(sound[2], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.U)
                {
                    Console.Beep(sound[1], 175);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.I)
                {
                    Console.Beep(sound[0], 175);
                    Console.Clear();
                }
            }
            Piano();
        }

        static void oktava3(int[] sound)
        {
            Console.Clear();
            Console.WriteLine("Третья октава");
            for (ConsoleKeyInfo key = Console.ReadKey(); key.Key != ConsoleKey.Backspace;)
            {
                ConsoleKeyInfo l = Console.ReadKey();
                key = l;
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(sound[0], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(sound[1], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(sound[2], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(sound[3], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(sound[4], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.K)
                {
                    Console.Beep(sound[5], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.L)
                {
                    Console.Beep(sound[6], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.R)
                {
                    Console.Beep(sound[7], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(sound[8], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(sound[9], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.U)
                {
                    Console.Beep(sound[10], 200);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.I)
                {
                    Console.Beep(sound[11], 200);
                    Console.Clear();
                }
            }
            Piano();
        }
        static void exit()
        {
            Console.Clear();
        }
    }
}