using System;
using System.Runtime.InteropServices;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("Symulator procesora INTEL8086");
            string ax = "-", bx = "-", cx = "-", dx = "-";
            Console.WriteLine("AX:{0} BX:{1} CX:{2} DX:{3}" ,ax, bx, cx, dx);

            
            do
            {Console.WriteLine("Jeśli chcesz wprowadić wartość wybierz 1, jeśli chcesz wykonać rozkaz MOV wybierz 2 kończ: wybierz 3");
                 a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("Jeśli chcesz wprowadić wartość AX wybierz 1, BX wybierz 2, CX wybierz 3, DX wybierz 4");
                    int b = int.Parse(Console.ReadLine());
                    if (b == 1) { ax = Console.ReadLine(); }
                    else if (b == 2) { bx = Console.ReadLine(); }
                    else if (b == 3) { cx = Console.ReadLine(); }
                    else if (b == 4) { dx = Console.ReadLine(); }
                    else { Console.WriteLine("Podano złą watość"); }
                }
                else if (a == 2)
                {
                    Console.WriteLine("Wybierz pierwszy parametr, AX wybierz 1, BX wybierz 2, CX wybierz 3, DX wybierz 4");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wybierz drugi parametr, AX wybierz 1, BX wybierz 2, CX wybierz 3, DX wybierz 4");
                    int d = int.Parse(Console.ReadLine());
                    if (c == 1 || d == 2) { bx = ax; }
                    else if (c == 1 || d == 3) { cx = ax; }
                    else if (c == 1 || d == 4) { dx = ax; }
                    else if (c == 2 || d == 1) { ax = bx; }
                    else if (c == 2 || d == 3) { cx = bx; }
                    else if (c == 2 || d == 4) { dx = bx; }
                    else if (c == 3 || d == 1) { ax = cx; }
                    else if (c == 3 || d == 2) { bx = cx; }
                    else if (c == 3 || d == 4) { dx = cx; }
                    else if (c == 4 || d == 1) { ax = dx; }
                    else if (c == 4 || d == 2) { bx = dx; }
                    else if (c == 4 || d == 3) { cx = dx; }
                    else { Console.WriteLine("Podano złą watość"); }
                }
                else { Console.WriteLine("Podano złą watość"); }

                Console.WriteLine("AX:{0} BX:{1} CX:{2} DX:{3}", ax, bx, cx, dx);
            } while (a != 0);
        }
    }
}
