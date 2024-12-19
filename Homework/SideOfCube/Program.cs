using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Генерирует модель куба и выводит его лицевую сторону.
// Следует исправить: генерирует стороны не игрального кубика, а рандомно от 0 до 9,
// выводит только лицевую сторону, а не рандомную.
namespace Homework
{
    internal class SideOfCube
    {
        public static void Main(string[] args)
        {
            int[,,] cube = new int[3, 3, 3];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        cube[l, j, i] = rand.Next(0, 2);
                    }
                }
            }

            Console.WriteLine("Сторона куба");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(cube[i, j, 0].ToString());
                }
                Console.WriteLine();
            }
        }

    }
}
