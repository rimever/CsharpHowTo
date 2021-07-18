using System;
using System.Linq;

namespace ArrayDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {1, 2, 3};
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            Console.WriteLine($"array2={array2[0]},{array2[1]},{array2[2]}");

            int[] array3 = new int[array1.Length];
            Array.Copy(array1,array3,array1.Length);
            Console.WriteLine($"array3={array3[0]},{array3[1]},{array3[2]}");

            int[] array4 = (int[]) array1.Clone();
            Console.WriteLine($"array4={array4[0]},{array4[1]},{array4[2]}");

            int[] array5 = array1.ToArray();
            Console.WriteLine($"array5={array5[0]},{array5[1]},{array5[2]}");
        }
    }
}