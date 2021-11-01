using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GeomProgression gp = new GeomProgression();
            Console.Write("Введите начальное значени ряда: ");
            
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите разность арифметического ряда: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель геометрического ряда: ");
            int q = Convert.ToInt32(Console.ReadLine());

            ArithProgression ap = new ArithProgression(x,d);
            for (int i = x; i < 10; i+=d)
            {
                ap.getNext(i);
                
            }
            
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext(int x);
        void Resert();

    }
    public class ArithProgression : ISeries
    {
        int x;
        int d;
        public ArithProgression(int x, int d)
        { 
        }
        public int getNext(int x)
        {
            return x + d;
        }

        public void Resert()
        {
            throw new NotImplementedException();
        }

        public void setStart(int x)
        {
            Console.WriteLine(x);
        }
    }
    class GeomProgression : ISeries
    {
        int x;
        public int getNext(int d)
        {
            return x * d;
        }

        public void Resert()
        {
            throw new NotImplementedException();
        }

        public void setStart(int x)
        {
            throw new NotImplementedException();
        }
    }
}
