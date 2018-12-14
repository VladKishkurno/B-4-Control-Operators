using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        public static int SUM2Number()
        {
            int x, y;
            Console.WriteLine("Введите число 1");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            y = int.Parse(Console.ReadLine());
            return x + y;
        }
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            int sum;
            int answer;

            int x, y;
            Console.WriteLine("Введите число 1");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            y = int.Parse(Console.ReadLine());

            sum = x + y;

            Console.WriteLine("Введите ответ");
            answer = int.Parse(Console.ReadLine());

            if (sum == answer) Console.WriteLine("Правильно\n");
            else Console.WriteLine("Неправильно\n");
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            int sum;
            //int answer;

            int x, y;
            Console.WriteLine("Введите число 1");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            y = int.Parse(Console.ReadLine());

            sum = x + y;


            //Console.WriteLine("Введите ответ");
            //answer = int.Parse(Console.ReadLine());

            //if (sum == answer) Console.WriteLine("Правильно\n");
            //else Console.WriteLine("Неправильно\n");

            if (x == y) Console.WriteLine("Равно\n");
            else if (x > y) Console.WriteLine("X > Y\n");
            else Console.WriteLine("X < Y\n");
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            int sum;
            //int answer;

            int x, y;
            Console.WriteLine("Введите число 1");
            x = int.Parse(Console.ReadLine());

            if (x >= 0)
            {
                
                Console.WriteLine("Введите число 2");
                y = int.Parse(Console.ReadLine());

                if (y >= 0)
                {

                    sum = x + y;


                    //Console.WriteLine("Введите ответ");
                    //answer = int.Parse(Console.ReadLine());

                    //if (sum == answer) Console.WriteLine("Правильно\n");
                    //else Console.WriteLine("Неправильно\n");

                    if (x == y) Console.WriteLine("Равно\n");
                    else if (x > y) Console.WriteLine("X > Y\n");
                    else Console.WriteLine("X < Y\n");
                }
            }
            else Console.WriteLine("Введите положителное число");
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var ToDay = DateTime.Today;
            int DayOfWeak = Convert.ToInt32(ToDay.DayOfWeek);


            switch (DayOfWeak)
            {
                case 1 :
                    Console.WriteLine("Доброго понедельника, Ольга!");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4 :
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                default :
                    Console.WriteLine("Воскресенье");
                    break;

            }
            
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            char s;

            Console.WriteLine("Выберите направление игрока: W, A, S, D");
            s = Convert.ToChar(Console.Read());

            switch (s)
            {
                case 'W' :
                case 'w':
                    Console.WriteLine("W");
                    break;
                case 'S':
                case 's':
                    Console.WriteLine("S");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("D");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("a");
                    break;

            }



        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
                   //  var i = int.Parse(Console.ReadLine());
            //int i = 1;

            for (int i = 1; i <= 10; i++ )
            {
                switch (i % 2)
                {
                    case 0:
                        Console.Write(i + "  Number is an even number\n");
                        break;

                    case 1:
                        Console.Write(i + "  Number is an odd number\n");
                        break;
                }
            }
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for(int i = 30; i >= 0; i--)
                if (i % 3 == 0) Console.Write(i + "\n");
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
           
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
        }
    }
}
