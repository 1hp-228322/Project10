using Project10;
using Project10.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №8");
            Console.WriteLine("Введите номер задания от 1 до 30:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 1:

                    Console.WriteLine("Введите целое число А");
                    double A1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите целое число N");
                    int N1 = int.Parse(Console.ReadLine());

                    Class1 class1 = new Class1(A1, N1);

                    Console.WriteLine($"Числа от А то В: ");

                    Console.WriteLine(class1.G1());

                    Console.ReadLine();

                    break;

                case 2:

                    Console.WriteLine("Введите целое число N");
                    int N2 = int.Parse(Console.ReadLine());

                    Class2 class2 = new Class2(N2);
                    Console.WriteLine(class2.G1());
                    Console.ReadLine();
                    break;

                case 3:

                    Console.WriteLine("Введите целое число N");
                    int N3 = int.Parse(Console.ReadLine());

                    Class3 class3 = new Class3(N3);
                    Console.WriteLine(class3.G1());
                    Console.ReadLine();
                    break;

                case 4:

                    Console.WriteLine("Введите целое число N");
                    int N4 = int.Parse(Console.ReadLine());

                    Class4 class4 = new Class4(N4);
                    Console.WriteLine(class4.G1());
                    Console.ReadLine();
                    break;

                case 5:

                    Console.WriteLine("Введите целое число N");
                    int N5 = int.Parse(Console.ReadLine());

                    Class5 class5 = new Class5(N5);
                    Console.WriteLine(class5.G1());
                    Console.ReadLine();
                    break;

                case 6:

                    Console.WriteLine("Введите целое число N");
                    int N6 = int.Parse(Console.ReadLine());

                    Class6 class6 = new Class6(N6);
                    Console.WriteLine(class6.G1());
                    Console.ReadLine();
                    break;

                case 7:

                    Console.WriteLine("Введите целое число");
                    int N7 = int.Parse(Console.ReadLine());

                    Class7 class7 = new Class7(N7);
                    Console.WriteLine(class7.G1());
                    Console.ReadLine();
                    break;

                case 8:

                    Console.WriteLine("Введите целое число");
                    int N8 = int.Parse(Console.ReadLine());

                    Class8 class8 = new Class8(N8);
                    Console.WriteLine(class8.G1());
                    Console.ReadLine();
                    break;

                case 9:

                    Console.WriteLine("Введите целое число X");
                    int X9 = int.Parse(Console.ReadLine());

                    Class9 class9 = new Class9(X9);
                    Console.WriteLine(class9.G1());
                    Console.ReadLine();
                    break;

                case 10:

                    Console.WriteLine("Введите целое число N");
                    double N10 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите целое число M");
                    double M10 = int.Parse(Console.ReadLine());

                    Class10 class10 = new Class10(N10,M10);
                    Console.WriteLine(class10.G1());

                    Console.ReadLine();
                    break;

                case 11:

                    Console.WriteLine("Введите целое число N");
                    double N11 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите целое число M");
                    double M11 = int.Parse(Console.ReadLine());

                    Class11 class11 = new Class11(N11, M11);
                    Console.WriteLine(class11.G1());

                    Console.ReadLine();
                    break;

                case 12:
                    Class12 class12 = new Class12();
                    Console.WriteLine(class12.G1());

                    Console.ReadLine();
                    break;

                case 13:

                    Console.WriteLine("Введите целое число N");
                    double N12 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите целое число M");
                    double M12 = int.Parse(Console.ReadLine());

                    Class13 class13 = new Class13(N12, M12);
                    Console.WriteLine(class13.G1());

                    Console.ReadLine();
                    break;

                case 14:

                    Console.WriteLine("Введите целое число M");
                    double N14 = int.Parse(Console.ReadLine());

                    Class14 class14 = new Class14(N14);
                    Console.WriteLine(class14.G1());

                    Console.ReadLine();
                    break;

                case 15:

                    Console.WriteLine("Введите целое число M");
                    double N15 = int.Parse(Console.ReadLine());

                    Class15 class15 = new Class15(N15);
                    Console.WriteLine(class15.G1());

                    Console.ReadLine();
                    break;

                case 16:
                    Console.WriteLine("Введите целове число p");
                    int p16 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите целое число q");
                    int q16 = Convert.ToInt32(Console.ReadLine());

                    Class16 class16 = new Class16(q16, p16);

                    List<int> generalDivider = class16.GetGeneralDivider();

                    Console.WriteLine($"Делители числа {q16}, взаимно просты с {p16}:");

                    foreach (int devider in generalDivider)
                    {
                        Console.Write(devider + " ");
                    }
                    Console.ReadLine();
                    break;

                case 17:
                    try
                    {
                        Console.WriteLine("Введите целве число n");
                        int n17 = Convert.ToInt32(Console.ReadLine());

                        Class17 class17 = new Class17(n17);
                        List<int> pf = class17.PrimeFactors();

                        Console.WriteLine($"Простые делители чиса {n17}: ");

                        foreach (int devider in pf)
                        {
                            Console.Write(devider + " ");
                        }

                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                    break;

                case 18:
                    try
                    {
                        Class18 class18 = new Class18();

                        List<int> primes = class18.GetFirst100Primes();

                        Console.WriteLine("Первые 100 простых чисел:");
                        for (int i = 0; i < primes.Count; i++)
                        {
                            Console.Write(primes[i] + " ");
                            if ((i + 1) % 10 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                    break;

                case 19:
                    try
                    {
                        Console.Write("Введите значение m: ");
                        int m19 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите значение n: ");
                        int n19 = Convert.ToInt32(Console.ReadLine());

                        if (m19 > n19)
                        {
                            Console.WriteLine("Ошибка: m должно быть меньше или равно n.");
                            return;
                        }

                        Class19 class19 = new Class19(m19, n19);

                        long result = class19.CalculateProductOfSquares();

                        Console.WriteLine($"Произведение квадратов четных чисел в интервале [{m19}, {n19}]: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                        
                    break;

                case 20:
                    try
                    {
                        Console.Write("Введите натуральное число n: ");
                        int n20 = Convert.ToInt32(Console.ReadLine());

                        Class20 class20 = new Class20(n20);

                        long result = class20.CalculateExpression();

                        Console.WriteLine($"Результат выражения для n = {n20}: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                    break;

                case 21:
                    try
                    {
                        Console.Write("Введите количество нечетных чисел N: ");
                        int n21 = Convert.ToInt32(Console.ReadLine());

                        Class21 class21 = new Class21(n21);

                        long result = class21.CalculateDifferenceOfCubes();

                        Console.WriteLine($"Разность кубов {n21} нечетных чисел: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                    break;

                case 22:
                    try
                    {
                        Console.Write("Введите значение m: ");
                        int m22 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите значение n: ");
                        int n22 = Convert.ToInt32(Console.ReadLine());

                        Class22 class22 = new Class22(m22, n22);

                        long result = class22.CalculateSquareOfDifference();

                        Console.WriteLine($"Квадрат разности чисел от {m22} до {n22}: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                    break;

                case 23:
                    try
                    {
                        Class23 class23 = new Class23();

                        int result = class23.CalculateSum();

                        Console.WriteLine($"Сумма отрицательных чисел, кратных 5 от -20 до 20: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                    break;

                case 24:
                    try
                    {
                        Class24 class24 = new Class24();

                        int result = class24.CalculateSum();

                        Console.WriteLine($"Сумма положительных чисел, кратных 4 и меньших 100: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    break;

                case 25:
                    try
                    {
                        Console.Write("Введите натуральное число N: ");
                        int n25 = Convert.ToInt32(Console.ReadLine());

                        Class25 class25 = new Class25(n25);

                        long result = class25.CalculateDifferenceOfSquares();

                        Console.WriteLine($"Разность квадратов всех чисел от 1 до {n25}: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    break;

                case 26:
                    try
                    {
                        Class26 class26 = new Class26();


                        Console.WriteLine("Нечетные числа от 100 до 200:");
                        Console.WriteLine(class26.GetOddNumbers());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                    break;

                case 27:
                    try
                    {
                        Console.Write("Введите значение m: ");
                        int m27 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите значение n: ");
                        int n27 = Convert.ToInt32(Console.ReadLine());

                        if (m27 > n27)
                        {
                            Console.WriteLine("Ошибка: m должно быть меньше или равно n.");
                            return;
                        }

                        Class27 class27 = new Class27(m27, n27);

                        long result = class27.CalculateProductOfCubes();

                        Console.WriteLine($"Произведение кубов чисел от {m27} до {n27}: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    break;

                case 28:
                    try
                    {
                        Console.Write("Введите натуральное число n: ");
                        int n28 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите натуральное число m: ");
                        int m28 = Convert.ToInt32(Console.ReadLine());

                        Class28 class28 = new Class28(n28, m28);
                      
                        Console.WriteLine($"{class28.FindNumbers()}");
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                break;

                case 29:
                    try
                    {
                        Console.Write("Введите значение m: ");
                        int m29 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите значение n: ");
                        int n29 = Convert.ToInt32(Console.ReadLine());

                        if (m29 > n29)
                        {
                            Console.WriteLine("Ошибка: m должно быть меньше или равно n.");
                            return;
                        }

                        Class19 class19 = new Class19(m29, n29);

                        long result = class19.CalculateProductOfSquares();

                        Console.WriteLine($"Произведение квадратов нечетных чисел в интервале [{m29}, {n29}]: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                break;

                case 30:
                    try
                    {
                        Console.Write("Введите значение m: ");
                        int m30 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите значение n: ");
                        int n30 = Convert.ToInt32(Console.ReadLine());

                        if (m30 > n30)
                        {
                            Console.WriteLine("Ошибка: m должно быть меньше или равно n.");
                            return;
                        }

                        Class19 class19 = new Class19(m30, n30);

                        long result = class19.CalculateProductOfSquares();

                        Console.WriteLine($"Произведение квадратов нечетных чисел в интервале [{m30}, {n30}]: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }

                break;
            }
        }
    }
}