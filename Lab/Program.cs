using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        static void DoExercise1()
        {
            Console.WriteLine("Упражнение 1\nВведите текст\n");
            string text = Console.ReadLine();
            ACipher acipher_text = new ACipher(text);
            string text2 = Console.ReadLine();
            BCipher bcipher_text = new BCipher(text2);
            Console.WriteLine($"Зашифрованный текст: { acipher_text.Encode()}\n" +
                $"Расшифруем: {acipher_text.Decode()}\n" +
                $"Теперь второй способ\n" +
                $"Зашифрованный текст: {bcipher_text.Encode()}\n" +
                $"Расшифруем: {bcipher_text.Decode()}\n");  
        }

        static void DoHomeWork1()
        {
            Console.WriteLine("Домашняя работа 1\n");
            Coordinates coord = new Coordinates();
            coord.X = 0;
            coord.Y = 0;
            Point point = new Point(Color.Красный, State.Видимое, coord);
            point.Print();
            point.MoveVert(3);
            point.MoveHoriz(4);
            point.Print();
            int radius = 3;
            Circle circle = new Circle(Color.Синий, State.Видимое, coord, radius);
            circle.Print();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 10\n");
            DoExercise1();
            DoHomeWork1();
            Console.ReadKey();
        }
    }
}
