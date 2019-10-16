using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Event
    {

        public static void Main()
        {
            Number myNumber = new Number(100000);
            myNumber.PrintMoney();
            myNumber.PrintNumber();
            Console.ReadKey();
        }
    }

    class Number
    {
        private PrintHelper _printHelper;

        public Number(int val)
        {
            _value = val;

            _printHelper = new PrintHelper();
            
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
        }
        
        void printHelper_beforePrintEvent()
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }

        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }

    public class PrintHelper
    {
       
        public delegate void BeforePrint();

      
        public event BeforePrint beforePrintEvent;

        public PrintHelper()
        {

        }

        public void PrintNumber(int num)
        {
            
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Hexadecimal: {0:X}", dec);
            
        }
    }
}