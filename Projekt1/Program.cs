using System;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool main = true;
            while (main)
            {
                main = huvudMeny();
            }
        }
        public static bool huvudMeny()
        {
            int menySan;
            Console.WriteLine("Skriv in siffran för den funktionen som du vill använda");
            Console.WriteLine("1. Medelhastighet");
            Console.WriteLine("2. distans");
            Console.WriteLine("3. tid");
            Console.WriteLine("4. avsluta programet");

            menySan = int.Parse(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out menySan))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            switch (menySan)
            {
                case 1:
                    {
                        MedelHastighet();
                        return true;
                    }
                case 2:
                    {
                        distans();
                        return true;
                    }
                case 3:
                    {
                        tid();
                        return true;
                    }
                case 4:
                    {
                        return false;
                    }
                default:
                    {
                        return true;
                    }
            }
        }
        static void MedelHastighet()
        {
            float m, s, v;
            Console.WriteLine("skriv in distans i meter");
            while (!float.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }

            Console.WriteLine("Skriv in tid i sekund");
            while (!float.TryParse(Console.ReadLine(), out s))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            v = s / m;
            Console.WriteLine("medelhastigheten är {0} m/s", v);
        }
        static void distans()
        {
            float m, s, v;
            Console.WriteLine("skriv in distans i meter");
            while (!float.TryParse(Console.ReadLine(), out v))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }

            Console.WriteLine("Skriv in tid i sekund");
            while (!float.TryParse(Console.ReadLine(), out s))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            m = s * v;
            Console.WriteLine("distansen är {0} meter", m);
        }
        static void tid()
        {
            float m, s, v;
            Console.WriteLine("skriv in distans i meter");
            while (!float.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }

            Console.WriteLine("Skriv in tid i sekund");
            while (!float.TryParse(Console.ReadLine(), out v))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            s = v * m;
            Console.WriteLine("det tar {0} sekunder att färdas {1} med {2} i hastighet", s, m, s);
        }
    }
}