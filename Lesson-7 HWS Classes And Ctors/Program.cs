using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_HWS_Classes_And_Ctors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Computer Qst (With ToString)
            Computer computer = new Computer
            {
                price = 2900,
                screenSize = 20.2f,
                numberOfProcessors = 2
            };

            int[] myArr = new int[10];

            Computer[] myCmpArr = new Computer[10];
            int size = 1;
            for (int i = 0; i < myCmpArr.Length; i++)
            {
                myCmpArr[i] = new Computer();
                myCmpArr[i].screenSize = size++;
                myCmpArr[i].price = size * 112;
            }

            computer.AddProcessor();
            Console.WriteLine(computer.numberOfProcessors);
            computer.TurnOn();
            Console.WriteLine(computer.isTurnOn);
            computer.TurnOff();
            Console.WriteLine(computer.isTurnOn);

            Console.WriteLine(computer);

            #endregion

            #region Qst Table

            //inst 1:
            Table t = new Table();
            t.legs = 3;
            t.color = "black";

            //inst 2:
            Table t2 = new Table(4, "red");

            //inst 3:
            Table t3 = new Table
            {
                legs = 6,
                color = "green"
            };

            //inst 4:
            Table t4 = t2;

            t2.legs = 10;

            #endregion
        }
    }

    class Computer
    {
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;


        public int TellMeThePrice()
        {
            Console.WriteLine(price);
            return price;
        }

        public void TellMeTheScreenSize()
        {
            Console.WriteLine(screenSize);
        }

        public void TurnOn()
        {
            isTurnOn = true;
        }

        public void TurnOff()
        {
            isTurnOn = false;
        }

        public void AddProcessor()
        {
            numberOfProcessors++;
        }

        public override string ToString()
        {
            return $"Price: {price}. Screen Size: {screenSize}. is Turn On: {isTurnOn}. Processors: {numberOfProcessors}.";
        }
    }
    
    class Table
    {
        public int legs;
        public string color;

        public Table()
        {

        }

        public Table(int legs, string color)
        {
            this.legs = legs;
            this.color = color;
        }
    }
}
