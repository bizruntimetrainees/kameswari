using System;  
namespace CSharpProgram  
{  
    class GenericClass<Double>  
    {  
        public GenericClass(Double msg)  
        {  
            Console.WriteLine(msg);  
        }  
    }  

    class Program  
    {  
        static void Main(string[] args)  
        {  
            GenericClass<string> gen   = new GenericClass<string> ("This is generic class");  
            GenericClass<int>    genI  = new GenericClass<int>(101);  
            GenericClass<char>   getCh = new GenericClass<char>('I');

            Console.ReadKey();
        }  
    }  
}  