using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_25_structvsclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoStruct aStruct = new AutoStruct(1600);
            AutoClass aClass = new AutoClass(1500);
            Console.WriteLine($"struct: {aStruct.hut}");
            Console.WriteLine($"class: {aClass.hut}");

            ValtoztatStruct(aStruct);
            ValtoztatClass(aClass);

            Console.WriteLine($"struct: {aStruct.hut}");
            Console.WriteLine($"class: {aClass.hut}");
            Console.ReadLine();
        }

        private static void ValtoztatClass(AutoClass a)
        {
            a.hut = 0;
        }

        private static void ValtoztatStruct(AutoStruct a)
        {
            a.hut = 0;
        }
    }

    struct AutoStruct
    {
        public int hut;
        public AutoStruct(int hut)
        {
            this.hut = hut;
        }
    }

    class AutoClass
    {
        public int hut;
        public AutoClass(int hut)
        {
            this.hut = hut;
        }
    }
}
