using ConsoleApp28;
using ConsoleApp4.Classes;
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

                case 16:
                    Console.WriteLine("Введите целове число p");
                    int p16 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите целое число q");
                    int q16 = Convert.ToInt32(Console.ReadLine());

                    Class16 class16 = new Class16(q16, p16);

                    List<int> generalDivider = class16.GetGeneralDivider(q16, p16);

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

                        Class17 class17 = new Class17();
                        List<int> pf = class17.PrimeFactors(n17);

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
            }
        }
    }
}