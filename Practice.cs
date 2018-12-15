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
            int answer;

            int x, y;
            Console.WriteLine("Введите число 1");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            y = int.Parse(Console.ReadLine());

            sum = x + y;



            Console.WriteLine("Введите ответ");
            answer = int.Parse(Console.ReadLine());

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
            //var s;

            Console.WriteLine("Выберите направление игрока: W, A, S, D");
           
            LableStart :

            var s = Console.ReadKey();

            switch (s.KeyChar)
            {
                case 'W':
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

            goto LableStart;



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
           int[,] Matrix = new int[10,10];

           Random Rnd = new Random();

            for(int i = 0; i < 10; i++)
                for(int j = 0; j < 10; j++)
                {
                    Matrix[i, j] = Rnd.Next(0, 10);
                    Console.Write(Matrix[i, j] + "  ");
                    if (j == 9) Console.Write("\n");
                }

        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for (int i = 0; i < 6; i++)
                Console.WriteLine("Hello world!!!");
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {

            string afrochildren = "Десять негритят отправились обедать, \nОдин поперхнулся, их осталось девять.\nДевять негритят, поев, клевали носом, \nОдин не смог проснуться, их осталось восемь. "; 
           
            Console.WriteLine(afrochildren);

//Восемь негритят в Девон ушли потом,
//Один не возвратился, остались всемером. 

//Семь негритят дрова рубили вместе,
//Зарубил один себя - и осталось шесть их. 

//Шесть негритят пошли на пасеку гулять,
//Одного ужалил шмель, их осталось пять. 

//Пять негритят судейство учинили,
//Засудили одного, осталось их четыре. 

//Четыре негритенка пошли купаться в море,
//Один попался на приманку, их осталось трое. 

//Трое негритят в зверинце оказались,
//Одного схватил медведь, и вдвоем остались. 

//Двое негритят легли на солнцепеке,
//Один сгорел - и вот один, несчастный, одинокий. 

//Последний негритенок поглядел устало,
//Он пошел повесился, и никого не стало.
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            for (int i = 0; i >= -10; i--)
            {
                switch (i % 2)
                {
                    case 0:
                        Console.Write(i + "  Number is an even number\n");
                        break;
                    case -1:
                        Console.Write(i + "  Number is an odd number\n");
                        break;
                }
            }
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
           Console.WriteLine("Введите слово");
           string word = Console.ReadLine();
           int NumA = 0;
           for (int i = 0; i < word.Length; i++)
           {

               if (word[i] == 'a' || word[i] == 'A' || word[i] == 'а' || word[i] == 'А') NumA++; // с учетом регистра и раскладки клавиатуры
           }
           Console.WriteLine(NumA);

        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            int AlphInt;
            char Alph = '\u007A';
            bool Flag = true;
            for( int i = 0; Flag; i++)
            {
                Console.Write(Alph + " ");

                AlphInt = Convert.ToInt32(Alph);
                switch (i % 2)     // для вывода алфавита с учетом регистра
                {
                    case 0:
                        AlphInt -= 32;
                        break;
                    case 1:
                        AlphInt += 31;
                        break;
                }
                if(Alph == 'A') 
                {
                    Flag = false;
                    Console.WriteLine("\nКолличество символов  " + (i / 2 + 1)); // для проверки все ли выведенно
                }
               else
                    Alph = Convert.ToChar(AlphInt);
            }
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            int i = 1;
            int n;

            Console.WriteLine("Введите диапазон");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                switch (i % 2)
                {
                    case 0:
                        Console.Write(i + "\n");
                        break;

                     
                    //case -1:
                    //    Console.Write(i + "  Number is an odd number\n");
                    //    break;
                }
                i++;
            }
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
            int i = 1;
            int n;

            Console.WriteLine("Введите диапазон");
            n = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (i % 2)
                {
                    //case 0:
                    //    Console.Write(i + "\n");
                    //    break;


                    case 1:
                        Console.Write(i + "\n");
                        break;
                }
                i++;
            }
            while (i <= n);
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            int i = 0;
            while(i < 6)
            {
                Console.WriteLine("Hello world!!!");
                i++;
            }
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            int i, j, degree;
            j = 0;
            float sum = 1;

            Console.WriteLine("Введите число");
            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите степень");
            degree = Convert.ToInt32(Console.ReadLine());

            if (degree == 0) Console.WriteLine("1");
            else
            {
                if (degree > 0)
                {
                    while (j < degree)
                    {
                        sum *= i;
                        //sum = Convert.ToInt32(Math.Pow(i, degree));
                        j++;
                    }
                }
                else
                    while (j > degree)
                    {
                       sum /= i;
                        //sum = (float)(Math.Pow(i, degree));
                        j--;

                    }
                Console.WriteLine(sum);
            }
            
            }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            int answer;

            while (true)
            {
                Console.WriteLine("Введите ответ 2 + 2 = ");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 4) 
                {
                    Console.WriteLine("Правильно");
                    break; 
                }
                else Console.WriteLine("Неправильно");

            }

        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {

            int step;
            int sum = 0;
            
            while(sum < 25)
            { 
                Console.WriteLine("Введите число от 1 до 6");
                step = Convert.ToInt32(Console.ReadLine());
                if (step < 1 || step > 6)
                {
                    Console.WriteLine("Ошибка");
                }
                else sum += step;
                Console.WriteLine("Текущее положение " + sum);
                
            }
            Console.WriteLine("Вы дошли до конца");
            

        }



        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            int step;
            int sumfirstPlayer = 0;
            int sumsecondlayer = 0;
            bool flagFirstPl = true;

            while (sumfirstPlayer < 25 && sumsecondlayer < 25)
            {
                if (flagFirstPl == true)
                {
                    Console.WriteLine("Первый игрок введите число от 1 до 6");
                }
                else Console.WriteLine("Второй игрок введите число от 1 до 6");
                step = Convert.ToInt32(Console.ReadLine());
                if (step < 1 || step > 6)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                    if (flagFirstPl == true)
                    {
                        sumfirstPlayer += step;
                        flagFirstPl = false;
                    }
                    else
                    { 
                        sumsecondlayer += step;
                        flagFirstPl = true;
                    }
                 
                Console.WriteLine("Текущее положение игрока 1 " + sumfirstPlayer);
                
                Console.WriteLine("Текущее положение игрока 2 " + sumsecondlayer);

            }
            if(sumfirstPlayer >= 25)
            Console.WriteLine("Первый игрок победил");
            else Console.WriteLine("Второй игрок победил");
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            int x, y, result;
            char operand;
            result = 0;

             Console.WriteLine("Введите первое число");
             x = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Введите операнд +, -, *, /");
             operand = Convert.ToChar(Console.ReadLine());

             Console.WriteLine("Введите второе число");
             y = Convert.ToInt32(Console.ReadLine());

             if (operand == '+') result = x + y;
             else if (operand == '-') result = x - y;
             else if (operand == '*') result = x * y;
             else if (operand == '/') result = x / y;
             else Console.WriteLine("Ошибка");

             Console.WriteLine("Ответ " + result);

        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {

            int x, y, result;
            char operand;
            result = 0;

            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите операнд +, -, *, /");
            operand = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());

            switch(operand)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
                default: 
                    Console.WriteLine("Ошибка"); 
                    break;
            }

            Console.WriteLine("Ответ " + result);
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            string word;

            Console.WriteLine("Введите слово");
            word = Console.ReadLine();

            //foreach(char ch in word)
            //{
            //    Console.Write(ch);
            //}

            for(int i = word.Length-1; i >= 0; i--)
                Console.Write(word[i]);

        }
    }
}
