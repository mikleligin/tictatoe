using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace крестикинолики
{ 
    class Program
    {
        static void sterka()
        {
            Console.Clear();
        }
        static void Main(string[] args)
        {

            char[,] pole = new char[5, 5];
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = ' ';
                }
            }
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[j, 1] = '|';
                }
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[j, 3] = '|';
                }
            }
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[1, i] = '-';
                }
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[3, i] = '-';
                }
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t \t \t Крестики-нолики v2.0 ");
            Console.Write("\t \t \t   by");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" angelscream");
            Console.ResetColor();
            Console.WriteLine();
           // System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Вводите цифры на клавиатуре num(это которая справа). ");
           


            
            
            pole[1, 1] = '+';
            pole[1, 3] = '+';
            pole[3, 1] = '+';
            pole[3, 3] = '+';
            Console.WriteLine("Игра начнется через 5 секунд");
            //System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Выберите режим игры:");
            Console.WriteLine("1.Режим с ботом");
            Console.WriteLine("2.Режим с другом");
            int cho = int.Parse(Console.ReadLine());
            switch (cho)
            {
                case 1:
           { 


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Первые ходят ИКСЫ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Нажмите цифру от 1 до 9");
            Console.ResetColor();
            int swch = 0;
            while (true)
            {
                if (swch == 0)
                {


                    int a = int.Parse(Console.ReadLine());

                    sterka();
                    switch (a)
                    {

                        case 7:
                            {
                                if (pole[0, 0] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[0, 0] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }

                        case 8:
                            {
                                if (pole[0, 2] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[0, 2] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }
                        case 9:
                            {
                                if (pole[0, 4] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[0, 4] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }
                        case 4:
                            {
                                if (pole[2, 0] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[2, 0] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }
                        case 5:
                            {
                                if (pole[2, 2] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[2, 2] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }
                        case 6:
                            {
                                if (pole[2, 4] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[2, 4] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }
                        case 1:
                            {
                                if (pole[4, 0] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[4, 0] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }
                        case 2:
                            {
                                if (pole[4, 2] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[4, 2] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }
                        case 3:
                            {
                                if (pole[4, 4] == 'o')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Эта клетка уже занята");
                                    Console.ResetColor();
                                    break;
                                }
                                pole[4, 4] = 'x';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                swch++;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Введите числа от одного до 9");
                                break;
                            }
                    }

                }

                if (swch == 1)
                {
                    Random rdm = new Random();
                    int random = rdm.Next(1, 9);
                    int b = random;
                    int[] radm = new int[8];
                    for (int i = 0; i < radm.Length; i++)
                    {
                        radm[i] = random;
                        if (i > 1)
                        {


                            if (radm[i] == radm[i - 1])
                            {
                                random++;
                                if (random > 9)
                                {
                                    random--;
                                }
                                if (random < 1)
                                {
                                    random++;
                                }


                            }
                        }
                    }
                    int a1 = 0;
                    int x = radm[a1];

                    sterka();
                    switch (x)
                    {

                        case 7:
                            {
                                if (pole[0, 0] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    Console.ResetColor();
                                    break;

                                }
                                pole[0, 0] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;
                                break;
                            }

                        case 8:
                            {
                                if (pole[0, 2] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    Console.ResetColor();
                                    break;

                                }
                                pole[0, 2] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;
                                break;
                            }
                        case 9:
                            {
                                if (pole[0, 4] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    Console.ResetColor();
                                    break;
                                }
                                pole[0, 4] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;
                                break;
                            }
                        case 4:
                            {
                                if (pole[2, 0] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    Console.ResetColor();
                                    break;
                                }
                                pole[2, 0] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;
                                break;
                            }
                        case 5:
                            {
                                if (pole[2, 2] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    Console.ResetColor();
                                    break;
                                }
                                pole[2, 2] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;
                                break;
                            }
                        case 6:
                            {
                                if (pole[2, 4] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    Console.ResetColor();
                                    break;
                                }
                                pole[2, 4] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;

                                break;
                            }
                        case 1:
                            {
                                if (pole[4, 0] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    Console.ResetColor();
                                    break;
                                }
                                pole[4, 0] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;

                                break;
                            }
                        case 2:
                            {
                                if (pole[4, 2] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    Console.ResetColor();
                                    break;
                                }
                                pole[4, 2] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;

                                break;
                            }
                        case 3:
                            {
                                if (pole[4, 4] == 'x')
                                {


                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            Console.Write(pole[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    a1++;
                                    break;
                                }
                                pole[4, 4] = 'o';
                                for (int i = 0; i < pole.GetLength(0); i++)
                                {
                                    for (int j = 0; j < pole.GetLength(1); j++)
                                    {
                                        Console.Write(pole[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                a1++;
                                swch--;

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Введите числа от одного до 9");
                                break;
                            }
                    }

                }
                            if (pole[0, 0] == 'x' && pole[0, 2] == 'x' && pole[0, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'o' && pole[0, 2] == 'o' && pole[0, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[2, 0] == 'x' && pole[2, 2] == 'x' && pole[2, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[2, 0] == 'o' && pole[2, 2] == 'o' && pole[2, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[4, 0] == 'x' && pole[4, 2] == 'x' && pole[4, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[4, 0] == 'o' && pole[4, 2] == 'o' && pole[4, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'x' && pole[2, 2] == 'x' && pole[4, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'o' && pole[2, 2] == 'o' && pole[4, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 4] == 'x' && pole[2, 2] == 'x' && pole[4, 0] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 4] == 'o' && pole[2, 2] == 'o' && pole[4, 0] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'x' && pole[2, 0] == 'x' && pole[4, 0] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'o' && pole[2, 0] == 'o' && pole[4, 0] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 2] == 'x' && pole[2, 2] == 'x' && pole[4, 2] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 2] == 'o' && pole[2, 2] == 'o' && pole[4, 2] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 4] == 'x' && pole[2, 4] == 'x' && pole[4, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 4] == 'o' && pole[2, 4] == 'o' && pole[4, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                        }
                        
            Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Выбираем,кто будет ходить первым");
                        for (int i = 0; i < 4; i++)
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        Console.WriteLine();
                        int swch = 0;
                        Random y = new Random();
                        int x = y.Next(0, 2);
                        if (x==1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Первые ходят НУЛИ");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;
                            swch = 1;
                            Console.WriteLine("Нажмите цифру от 1 до 9");
                            Console.ResetColor();
                        }
                        if (x == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Первые ходят ИКСЫ");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("Нажмите цифру от 1 до 9");
                            Console.ResetColor();
                        }

                        while (true)
                        {
                            if (swch == 0)
                            {


                                int a = int.Parse(Console.ReadLine());

                                sterka();
                                switch (a)
                                {

                                    case 7:
                                        {
                                            if (pole[0, 0] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[0, 0] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }

                                    case 8:
                                        {
                                            if (pole[0, 2] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[0, 2] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }
                                    case 9:
                                        {
                                            if (pole[0, 4] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[0, 4] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }
                                    case 4:
                                        {
                                            if (pole[2, 0] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[2, 0] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }
                                    case 5:
                                        {
                                            if (pole[2, 2] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[2, 2] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }
                                    case 6:
                                        {
                                            if (pole[2, 4] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[2, 4] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }
                                    case 1:
                                        {
                                            if (pole[4, 0] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[4, 0] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }
                                    case 2:
                                        {
                                            if (pole[4, 2] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[4, 2] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (pole[4, 4] == 'o')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[4, 4] = 'x';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch++;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Введите числа от одного до 9");
                                            break;
                                        }
                                }

                            }

                            if (swch == 1)
                            {
                                int b = int.Parse(Console.ReadLine());

                                sterka();
                                switch (b)
                                {

                                    case 7:
                                        {
                                            if (pole[0, 0] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[0, 0] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;
                                            break;
                                        }

                                    case 8:
                                        {
                                            if (pole[0, 2] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;

                                            }
                                            pole[0, 2] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;
                                            break;
                                        }
                                    case 9:
                                        {
                                            if (pole[0, 4] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[0, 4] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;
                                            break;
                                        }
                                    case 4:
                                        {
                                            if (pole[2, 0] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[2, 0] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;
                                            break;
                                        }
                                    case 5:
                                        {
                                            if (pole[2, 2] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[2, 2] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;
                                            break;
                                        }
                                    case 6:
                                        {
                                            if (pole[2, 4] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[2, 4] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;

                                            break;
                                        }
                                    case 1:
                                        {
                                            if (pole[4, 0] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[4, 0] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;

                                            break;
                                        }
                                    case 2:
                                        {
                                            if (pole[4, 2] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[4, 2] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;

                                            break;
                                        }
                                    case 3:
                                        {
                                            if (pole[4, 4] == 'x')
                                            {


                                                for (int i = 0; i < pole.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < pole.GetLength(1); j++)
                                                    {
                                                        Console.Write(pole[i, j]);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Эта клетка уже занята");
                                                Console.ResetColor();
                                                break;
                                            }
                                            pole[4, 4] = 'o';
                                            for (int i = 0; i < pole.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < pole.GetLength(1); j++)
                                                {
                                                    Console.Write(pole[i, j]);
                                                }
                                                Console.WriteLine();
                                            }
                                            swch--;

                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Введите числа от одного до 9");
                                            break;
                                        }
                                }

                            }
                            if (pole[0, 0] == 'x' && pole[0, 2] == 'x' && pole[0, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'o' && pole[0, 2] == 'o' && pole[0, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[2, 0] == 'x' && pole[2, 2] == 'x' && pole[2, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[2, 0] == 'o' && pole[2, 2] == 'o' && pole[2, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[4, 0] == 'x' && pole[4, 2] == 'x' && pole[4, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[4, 0] == 'o' && pole[4, 2] == 'o' && pole[4, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'x' && pole[2, 2] == 'x' && pole[4, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'o' && pole[2, 2] == 'o' && pole[4, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 4] == 'x' && pole[2, 2] == 'x' && pole[4, 0] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 4] == 'o' && pole[2, 2] == 'o' && pole[4, 0] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'x' && pole[2, 0] == 'x' && pole[4, 0] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 0] == 'o' && pole[2, 0] == 'o' && pole[4, 0] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 2] == 'x' && pole[2, 2] == 'x' && pole[4, 2] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 2] == 'o' && pole[2, 2] == 'o' && pole[4, 2] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 4] == 'x' && pole[2, 4] == 'x' && pole[4, 4] == 'x')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Иксы победили . Партия! ");
                                Console.ResetColor();
                                break;
                            }
                            if (pole[0, 4] == 'o' && pole[2, 4] == 'o' && pole[4, 4] == 'o')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Нули победили . Партия!");
                                Console.ResetColor();
                                break;
                            }
                        }
                        Console.ReadLine();
                        break;
                    
                    }
        }
        }

    }
}


