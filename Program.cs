using System;
using System.IO;
using System.Collections.Generic;

namespace _282
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();???
            //P17();
            //P18();
            //P19();
            //P20();???
            //P21();???
        }

        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma
        /// "numarul este mai mare sau egal decat x?". 
        /// </summary>
        private static void P21()
        {

        }

        /// <summary>
        /// Afisati fractia m/n in format zecimal, 
        /// cu perioada intre paranteze (daca e cazul). 
        /// Exemplu: 13/30 = 0.4(3).
        /// </summary>
        private static void P20()
        {
            
        }

        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. 
        /// De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        /// </summary>
        private static void P19()
        {
            int n,c1=-1,c2=-1;
            bool ok = true;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            if (n < 10)
                Console.WriteLine("nu");
            else
            {
                c1 = n % 10;
                n = n / 10;
                while (n != 0)
                {
                    if (n % 10 != c1 && c2 == -1)
                        c2 = n % 10;
                    else if (n%10!=c1 && n%10!=c2)
                    {
                        ok = false;
                        break;
                    }
                    n = n / 10;
                }
             }
            if (ok==true)
                Console.WriteLine("da");
            else
                Console.WriteLine("nu");
            
        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n. 
        /// De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2.
        /// </summary>
        private static void P18()
        {
            int n, d, p;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            d = 2;
            while (n>1)
            {
                p = 0;
                while(n%d==0)
                {
                    p++;
                    n = n / d;
                }
                if(p!=0)
                {
                    Console.WriteLine(d + "^" + p );
                }
                d++;
            }
        }


        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.
        /// </summary>
        private static void P17()
        {
            int a, b, r, x, y;
            Console.WriteLine("Introduceti a si b: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            
            while (b != 0)
            {
                r=a % b;
                a=b;
                b = r;
            }
            Console.WriteLine($"Cmmdc: {a} si cmmmc: {x * y / a}");
        }

        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        private static void P16()
        {
            


        }

        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>
        private static void P15()
        {
            int a, b, c;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti c: ");
            c = int.Parse(Console.ReadLine());
            if (a <= b)
            {
                if (b <= c)
                    Console.WriteLine(a + " " + b + " " + c);
               else if (c <= b)
                    Console.WriteLine(a + " " + c + " " + b);
                
            }
            else if (b <= a)
            {
                if (a <= c)
                    Console.WriteLine(b + " " + a + " " + c);
               else if (c <= a)
                    Console.WriteLine(b + " " + c + " " + a);
            }
            else if (c <= a)
            {
                if (a <= b)
                    Console.WriteLine(c + " " + a + " " + b);
               else if (b <= a)
                    Console.WriteLine(c + " " + b + " " + a);
            }
        }

        /// <summary>
        /// Determianti daca un numar n este palindrom. 
        /// (un numar este palindrom daca citit invers obtinem 
        /// un numar egal cu el, de ex. 121 sau 12321. 
        /// </summary>
        private static void P14()
        {
            int n, oglindit = 0, aux;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            aux = n;
            do
            {
                oglindit = oglindit * 10 + aux % 10;
                aux = aux / 10;
            } while (aux != 0);
            if (n == oglindit)
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom");
        }

        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void P13()
        {
            int y1, y2, ani = 0, i;
            Console.WriteLine("Introduceti y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y2: ");
            y2 = int.Parse(Console.ReadLine());
            for (i = y1 + 1; i < y2; i++)
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                    ani++;
            Console.WriteLine($"Exista {ani} ani bisecti intre anii {y1} si {y2}");

        }

        /// <summary>
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].
        /// </summary>
        private static void P12()
        {
            int a, b, n, numere = 0, i;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            for (i = a; i <= b; i++)
            {
                if (i % n == 0)
                    numere++;
            }
            Console.WriteLine($"Exista {numere} numere integi divizibile cu {n} care se afla in intervalul [{a}, {b}]");

        }

        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        private static void P11()
        {
            int n;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write(n % 10 + " ");
                n = n / 10;
            } while (n != 0);
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void P10()
        {
            int n;
            bool ok = true;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            if (n < 2)
                ok = false;
            if (n == 2)
                ok = true;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                {
                    ok = false;
                    break;
                }
            if (ok == false)
                Console.WriteLine($"{n} nu este numar prim");
            else
                Console.WriteLine($"{n} este numar prim");
        }

        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>
        private static void P9()
        {
            int n;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Divizorii lui {n} sunt: 1, ");
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    Console.Write(i + ", ");
            Console.Write(n);

        }

        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b
        /// ale carori valori sunt date de intrare.
        /// Se cere sa se inverseze valorile lor fara 
        /// a folosi alte variabile suplimentare.  
        /// </summary>
        private static void P8()
        {
            int a, b;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti b: ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a} si b={b}");
        }

        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b 
        /// ale carori valori sunt date de intrare.
        /// Se cere sa se inverseze valorile lor. 
        /// </summary>
        private static void P7()
        {
            int a, b, aux;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti b: ");
            b = int.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"a={a} si b={b}");
        }

        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        private static void P6()
        {
            int a, b, c;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti c: ");
            c = int.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
                Console.WriteLine($"Cele trei numere, {a}, {b}, {c}, pot fi laturile unui triunghi");
            else
                Console.WriteLine($"Cele trei numere, {a}, {b}, {c}, nu pot fi laturile unui triunghi");
        }

        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. 
        /// Cifrele se numara de la dreapta la stanga. 
        /// </summary>
        private static void P5()
        {
            int n, k, p = 1, cif;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti k: ");
            k = int.Parse(Console.ReadLine());
            for (int i = 1; i < k; i++)
                p = p * 10;
            cif = n / p % 10;
            Console.WriteLine($"a {k}-a cifra de la sfarsitul lui {n} este {cif}");

        }

        /// <summary>
        /// Detreminati daca un an y este an bisect. 
        /// </summary>
        private static void P4()
        {
            int y;
            Console.WriteLine("Introduceti anul: ");
            y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                Console.WriteLine($"Anul {y} este an bisect");
            else
                Console.WriteLine($"Anul {y} nu este an bisect");

        }

        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        private static void P3()
        {
            int n, k;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti k: ");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} nu se divide cu {k}");

        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, 
        /// unde a, b si c sunt date de intrare.
        /// Tratati toate cazurile posibile.
        /// </summary>
        private static void P2()
        {
            double a, b, c, x1, x2, delta;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti c: ");
            c = int.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine($"Pentru {a}*x^2+{b}*x+{c}=0, x1=x2={x1}");
            }
            else if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Pentru {a}*x^2+{b}*x+{c}=0, x1={x1} si x2={x2}");
            }
            else
            {
                Console.WriteLine($"Pentru {a}*x^2+{b}*x+{c}=0, ecuatia nu are solutii reale");
            }
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        /// </summary>
        private static void P1()
        {
            float a, b, x;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti b: ");
            b = int.Parse(Console.ReadLine());
            if (-b % a == 0)
            {
                x = -b / a;
                Console.WriteLine($"Pentru {a}x+{b}=0, x este {x}");
            }
            else
            {
                x = -b / a;
                Console.WriteLine($"Pentru {a}x+{b}=0, x este -{b}/{a}, adica {x} ");
            }




        }
    }
}
