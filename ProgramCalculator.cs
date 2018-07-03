using System;

namespace Calculator
{
    class ProgramCalculator
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Введіть 1 число.");
            double y=Convert.ToDouble(Console.ReadLine());           
           Console.WriteLine("Введіть 2 число.");
           double z=Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Введіть арефметичний знак:(*),(/),(+),(-) або (%)");

           double result=0;
           string c=Console.ReadLine();
          
          
           if (c=="+") {
               result=y+z;
           }
           else if (c=="-") {
               result=y-z;
           }
            
            else if (c=="*") {
               result=y*z;
           } 
            else if (c=="%") {
               result=y%z;
           }
            else if (c=="/") {
                if (z==0) {
                    Console.WriteLine("На нуль ділити не можна."); 
                while(z==0){
                    Console.WriteLine("Помилка");
                     Console.WriteLine("Введіть 2 число.");
                    z=Convert.ToDouble(Console.ReadLine());
                    result=y/z;
                    }
                
                }
                else { 
                    result=y/z;
                }
           }  
            
            
            
            Console.WriteLine(result);
        }

        
    }
}
