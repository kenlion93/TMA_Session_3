using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Khai bao mang int co 100 phan tu. Nhap n phan tu. Kiem tra n nam tu 1->100, neu ko thoa thi nhap lai
             * 1. Liet ke cac phan tu Duong
             * 2. Tinh tong cac phan tu
             * 3. Dem co bao nhiu phan tu Am
             * 4. Kiem tra trong mang co gia tri chan~ hay ko?
             * 5. Tim gia tri Max, Min trogn mang.
             * Cho phep user nhan y(Y) de tip tuc thuc hien
             */
            Demo_7();
            Console.Read();
        }

        //Lambda (array, connection)
        static void Demo_7()
        {
            int[] a = { 5, -10, -3, 2, 4 };
            var result = a.Where(i => i > 0).Sum();
            Console.WriteLine("Sum: " + result);
        }


        static void Demo_6()
        {
            var age = 18;
            Console.WriteLine("Age: " + age);
            var fullName = "ABC";
            Console.WriteLine("full name: " + fullName);
            var status = true;
            Console.WriteLine("Status " + status);
            Console.WriteLine("\n-----------------");
            int[] a = { 5, 1, 3, -1, 44 };

            for (var i = 0; i < a.Length; i++)
            {
                Console.Write("  " + a[i]);
            }
            Console.WriteLine("\n-----------------");
            foreach (var i in a)
            {
                Console.Write("  " + i);
            }
        }

        static void Demo_5()
        {
            double[] a = new double[100];
            int n;
            string key = "";
            do
            {
                Console.Write("Nhap so luong n phan tu: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0 || n > 100)
                {
                    Console.WriteLine("Khong hop le. Moi ban nhap lai");
                }
            } while (n < 0 || n > 100);

            do
            {
                //Nhap mang
                for (int i = 0; i < n; i++)
                {
                    Console.Write("So thu " + i + ": ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Show mang gia tri va Menu
                Console.Clear();
                Console.WriteLine("Mang gia tri: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("  " + a[i]);
                }
                Console.WriteLine("\n---------------");
                Console.WriteLine("1. Liet ke cac so Duong");
                Console.WriteLine("2. Tinh Tong cac phan tu");
                Console.WriteLine("3. Dem so phan tu Am");
                Console.WriteLine("4. Kiem tra trong mang co gia tri chan khong");
                Console.WriteLine("5. Tim Min va Max");
                Console.Write("Moi ban chon: ");
                int menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (menu)
                {
                    case 1:
                        //Console.WriteLine("Case 1");
                        Console.Write("Cac so Duong: ");
                        Case1(a, n);
                        break;
                    case 2:
                        //Console.WriteLine("Case 2");
                        Case2(a, n);
                        break;
                    case 3:
                        //Console.WriteLine("Case 3");
                        Case3(a, n);
                        break;
                    case 4:
                        //Console.WriteLine("Case 4");
                        Case4(a, n);
                        break;
                    case 5:
                        //Console.WriteLine("Case 5");
                        Case5(a, n);
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le");
                        break;
                }
                Console.WriteLine("\n\nNhan Y(y) de tiep tuc");
                key = Console.ReadLine();
            } while (key == "Y" || key == "y");

        }
        static void Case1(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    Console.Write("  " + a[i]);
                }
            }
            Console.WriteLine();
        }

        static void Case2(double[] a, int n)
        {
            double s = 0;
            foreach (int i in a)
            {
                s += i;
            }
            Console.WriteLine("Tong mang la: " + s);
        }

        static void Case3(double[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Co " + count + " phan tu am");
        }

        static void Case4(double[] a, int n)
        {
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    flag = true;
                    break;
                }
            }
            Console.WriteLine(flag ? "Co so chan" : "Khong co so chan");
        }
        static void Case5(double[] a, int n)
        {
            double max = a[0];
            double min = a[0];
            for (int i = 1; i < n; i++)
            {
                //tim max
                if (a[i] > max)
                {
                    max = a[i];
                }
                //tim min
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }
        static void Demo_4()
        {
            double[] a = { 5, 10, 2, 7, 9 };
            Console.WriteLine("A array: ");
            Display(a, a.Length);

            double[] b = { 11, 45, 77, 89, 66, 55 };
            Console.WriteLine("\nB array: ");
            Display(b, b.Length);
        }

        static void Display(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("  " + a[i]);
            }
        }

        static void Demo_3()
        {
            int[] a = new int[100];
            Console.Write("Nhap so n phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element " + i + ": ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Output: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("  " + a[i]);
            }
        }

        static void Demo_2()
        {
            string[] names = { "Name 1", "Name 2", "Name 3", "Name 4" };
            Console.WriteLine("Length string: " + names.Length);

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("  " + names[i]);
            }
            Console.WriteLine();
            foreach (string i in names)
            {
                Console.WriteLine(i + "  ");
            }
        }

        static void Demo_1()
        {
            int[] a = new int[5];
            a[0] = 5;
            a[1] = 10;
            a[2] = -7;
            a[3] = 23;
            a[4] = -15;
            Console.WriteLine("Length: " + a.Length);
            //Console.WriteLine(a[2]);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("  " + a[i]);
            }
            Console.WriteLine();
            foreach (int i in a)//i la gia tri trong mang~ i.e: 5 10 -7
            {
                Console.Write(i);
            }
        }


    }
}
