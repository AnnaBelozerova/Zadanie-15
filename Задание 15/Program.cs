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
            try
            {
                Console.Write("Введите количество элементов ряда: ");
                int chet = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите начальное значени ряда: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите разность арифметического ряда: ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите знаменатель геометрического ряда: ");
                int q = Convert.ToInt32(Console.ReadLine());

                ArithProgression arithProgression = new ArithProgression(x, d);

                Console.Write(arithProgression.getStart());
                for (int i = 0; i < chet; i++)
                {
                    Console.Write("{0,8}", arithProgression.getNext());
                }
                Console.WriteLine();

                GeomProgression geomProgression = new GeomProgression(x, q);

                Console.Write(geomProgression.getStart());
                for (int i = 0; i < chet; i++)
                {
                    Console.Write("{0,8}", geomProgression.getNext());
                }
                Console.WriteLine();

                Console.Write("Введите новое начальное значени ряда: ");
                x = Convert.ToInt32(Console.ReadLine());
                arithProgression.Resert();
                arithProgression.setStart(x);
                Console.Write(arithProgression.getStart());
                for (int i = 0; i < chet; i++)
                {
                    Console.Write("{0,8}", arithProgression.getNext());
                }
                Console.WriteLine();

                geomProgression.Resert();
                geomProgression.setStart(x);
                Console.Write(geomProgression.getStart());
                for (int i = 0; i < chet; i++)
                {
                    Console.Write("{0,8}", geomProgression.getNext());
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();

        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void Resert();

    }
    public class ArithProgression : ISeries
    {
        int start;
        int value;
        int d;
        public ArithProgression(int start=0, int d=1)
        {
            this.start = start;
            value = start;
            this.d = d;
        }
        public int getNext()
        {
            value += d;
            return value;
        }

        public void Resert()
        {
            value = start;
        }

        public void setStart(int x)
        {
            this.start = x;
            value = this.start;
        }
        public int getStart()
        {
            return this.start;
        }
    }
    class GeomProgression : ISeries
    {
        int start;
        int value;
        int q;
        public GeomProgression(int start=1, int q=2)
        {
            if (start != 0 && q != 0)
            {
                this.start = start;
                value = start;
                this.q = q;
            }
            else
            {
                if (start == 0)
                {
                    this.start = 1;
                    value = 1;
                    this.q = q;
                    Console.WriteLine("Начальное значение геометрического ряда не может быть равно 0. Установлено значение по умолчанию.");
                }
                else
                {
                    this.start = start;
                    value = start;
                    this.q = 2;
                    Console.WriteLine("Значение знаменателя геометрического ряда не может быть равно 0 или 1. Установлено значение по умолчанию.");
                }
            }
            
        }
        public int getNext()
        {
            value *= q;
            return value;
        }

        public void Resert()
        {
            value = start;
        }

        public void setStart(int x)
        {
            this.start = x;
            value = this.start;
        }
        public int getStart()
        {
            return this.start;
        }
    }
}
