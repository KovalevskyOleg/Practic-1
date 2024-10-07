using System.Security.Cryptography;

namespace Практика_1
{
    internal class Program
    {
        static void Main(string[] args)
        { bool Check = true;
            while (true)
            {
                Console.Write("Выберете номер задания: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10. Введите 0 если хотите вернуться к выбору задачи  \n");
                int Choose = Convert.ToInt32(Console.ReadLine());
                //111111111
                if (Choose == 1)
                {
                    Console.Write("Задача 1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними  \n");
                    Console.Write("Введите первое число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите третье число: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите четвёртое число: ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    double summ = Convert.ToDouble(a + b + c + d) / 4;
                    Console.WriteLine(summ);
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                }

                //2222222
                if (Choose == 2)
                {
                    Console.Write("Задача 2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел  \n");
                    Console.Write("Введите первое число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Выберете действие 1. Сложение 2. Вычитание 3. Умножение 4. Деление. 5 Нахождение остатка \n");
                    int Choose2 = Convert.ToInt32(Console.ReadLine());
                    if (Choose == 1)
                    {
                        double summ = Convert.ToDouble(a + b);
                        Console.WriteLine(summ);
                    }
                    if (Choose == 2)
                    {
                        double summ = Convert.ToDouble(a - b);
                        Console.WriteLine(summ);
                    }
                    if (Choose == 3)
                    {
                        double summ = Convert.ToDouble(a * b);
                        Console.WriteLine(summ);
                    }
                    if (Choose == 4)
                    {
                        double summ = Convert.ToDouble(a / b);
                        Console.WriteLine(summ);
                    }
                    if (Choose == 5)
                    {
                        double summ = Convert.ToDouble(a % b);
                        Console.WriteLine(summ);
                    }
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                }
                //3333
                if (Choose == 3)
                {
                    Console.Write("Задача 3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
                    Console.Write("Выберите шкалу вводимой температуры:\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт  \n");
                    int Degrees = Convert.ToInt32(Console.ReadLine());
                    if (Degrees == 1)
                    {
                        Console.Write("Введите показатель температура (градусы)\n");
                        double IndicatorС = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Выберите тип шкалы для конвертации:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт\n");
                        int Variant = Convert.ToInt32(Console.ReadLine());
                        if (Variant == 1)
                        {
                            Console.Write("Вы не можете конвертировать один и тот же тип градусов\n");
                            Console.WriteLine(IndicatorС);
                        }
                        if (Variant == 2)
                        {
                            double Answer = Convert.ToDouble(IndicatorС + 273.15);
                            Console.WriteLine(Answer);
                        }
                        if (Variant == 3)
                        {
                            double Answer = Convert.ToDouble((IndicatorС * 9 / 5) + 32);
                            Console.WriteLine(Answer);
                        }
                    }
                    if (Degrees == 2)
                    {
                        Console.Write("Введите показатель температура (градусы)\n");
                        double IndicatorС = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Выберите тип шкалы для конвертации:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт\n");
                        int Variant = Convert.ToInt32(Console.ReadLine());
                        if (Variant == 1)
                        {
                            double Answer = Convert.ToDouble(IndicatorС - 273.15);
                            Console.WriteLine(Answer);
                        }
                        if (Variant == 2)
                        {
                            Console.Write("Вы не можете конвертировать один и тот же тип градусов\n");
                            Console.WriteLine(IndicatorС);
                        }
                        if (Variant == 3)
                        {
                            double Answer = Convert.ToDouble((IndicatorС - 273.15) * 9 / 5 + 32);
                            Console.WriteLine(Answer);
                        }
                    }
                    if (Degrees == 3)
                    {
                        Console.Write("Введите показатель температура (градусы)\n");
                        double IndicatorС = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Выберите тип шкалы для конвертации:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт\n");
                        int Variant = Convert.ToInt32(Console.ReadLine());
                        if (Variant == 1)
                        {
                            double Answer = Convert.ToDouble((IndicatorС - 32) * 5 / 9);
                            Console.WriteLine(Answer);
                        }
                        if (Variant == 2)
                        {
                            double Answer = Convert.ToDouble((IndicatorС - 32) * 5 / 9 + 273.15);
                            Console.WriteLine(Answer);
                        }
                        if (Variant == 3)
                        {
                            Console.Write("Вы не можете конвертировать один и тот же тип градусов\n");
                            Console.WriteLine(IndicatorС);
                        }
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();

                    }

                }
                //4444444444
                if (Choose == 4)
                {
                    Console.Write("Задача 4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути\n");
                    Console.WriteLine("Введите путь");
                    string str = Console.ReadLine();
                    string[] parts = str.Split('/');
                    Console.WriteLine(parts[parts.Length - 1]);
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                }
                //55555555555
                if (Choose == 5)
                {
                    Console.Write("Задача 5. Разработайте программу для нахождения самого длинного слова в предложении\n");
                    Console.WriteLine("Введите ваше предложение");
                    string str = Console.ReadLine();
                    string[] parts = str.Split(' ');
                    string maxlen = "";
                    for (int i = 0; i < parts.Length; i++)
                    {
                        string currentlen = parts[i];
                        if (maxlen.Length < currentlen.Length)
                        {
                            maxlen = parts[i];
                        }
                    }
                    Console.WriteLine("Самое длинное слово это " + maxlen);
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                }
                //6666666666666
                if (Choose == 6)
                {
                    Console.WriteLine("Введите значения для первого массива через пробел:");
                    string strr = Console.ReadLine();
                    string[] firstArrey = strr.Split(' ');
                    Console.WriteLine("Введите значения для второго массива через пробел:");
                    strr = Console.ReadLine();
                    string[] secondArrey = strr.Split(' ');
                    string[] thirdArray;
                    for (int i = 0; i < firstArrey.Length; i++)
                    {
                        Console.Write($"{Convert.ToInt32(firstArrey[i]) * Convert.ToInt32(secondArrey[i])} ");
                    }
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                }
                //777777777777777
                if (Choose == 7)
                {
                    Console.Write("Задача 7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных\n");
                    Console.WriteLine("Введите пять чисел:");
                    string str = Console.ReadLine();
                    string[] partse = str.Split(" ");
                    int suMax = -999999999;
                    int suMin = 999999999;
                    foreach (string i in partse)
                    {
                        if (suMax < Convert.ToInt32(i))
                        {
                            suMax = Convert.ToInt32(i);
                        }
                        if (suMin > Convert.ToInt32(i))
                        {
                            suMin = Convert.ToInt32(i);
                        }
                    }
                    Console.WriteLine("Максимальное число: " + suMax); Console.WriteLine("Минимальное число: " + suMin);
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                }
                //8888888888888
                if (Choose == 8)
                {
                Console.Write("Задача 8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем\n");
                    Console.Write(" Введите уровень пирамиды : ");
                    int levels = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= levels; i++)
                    {
                        for (int j = 0; j < levels - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write(k + " ");
                        }


                        Console.WriteLine();
                    }
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                }
                //999999999999
                if (Choose == 9)
                {
                    Console.Write("Задача 9. Напечатать полную таблицу умножения в виде\n");
                     for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{1} x {j} = {i * j}\t");
            }
            
                 Console.WriteLine();
        
        }
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                }
                //10
                if (Choose == 10)
                {
                    Console.Write("Задача 10. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных\n");
                    Console.WriteLine("Введите пять чисел:");
                    string str = Console.ReadLine();
                    string[] partse = str.Split(" ");
                    int suMax = -999999999;
                    int suMin = 999999999;
                    foreach (string i in partse)
                    {
                        if (suMax < Convert.ToInt32(i))
                        {
                            suMax = Convert.ToInt32(i);
                        }
                        if (suMin > Convert.ToInt32(i))
                        {
                            suMin = Convert.ToInt32(i);
                        }
                    }
                    Console.WriteLine("Максимальное число: " + suMax); Console.WriteLine("Минимальное число: " + suMin);
                }
                if (Choose == 0)
                {
                    Check = false;
                    Console.Write("Завершение работы");
                    Console.Clear();
                }
            }




        }
    }
}