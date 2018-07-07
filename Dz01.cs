using System;

namespace Faktorial
{
    class Dz01
    {
        static void Main(string[] args)
        {
         
         Console.WriteLine("Введіть 1 число.");
         int y=Convert.ToInt32(Console.ReadLine());          
          

          int x=1;
        // Факторіал  
           for (int i = 1; i<=y; i++)
           {
             x=i*x;  
           } 
           Console.WriteLine("Факториал: " + x);
          
          
          
           //Cума чисел від 1 до введенного користувачем (у)       
           x=0;
           for (int i = 1; i<=y; i++)
           {
             x=i+x;  
           } 
        Console.WriteLine("Сумма чисел від 1 до " + y + ": " + x );
        
        
    
        // Вивести всі квадрати натуральних чисел, що не перевищюють числа у
         Console.WriteLine("Квадрати чисел, що не перевищюють числа " + y + ":");
         x=1;
         int z=1;
        do
        {
           Console.WriteLine(z);
           x=x+1;
           z=x*x;
        } while (y>=z);
         
        //Чи є число простим?   
       z=1;
        for (int i = 2; i < y; i++)
        {
          x=y%i;
         if (x==0)
         {
           z=0; 
             Console.WriteLine("Число складне."); 
             break;
         }
         
        }   
         if (z==1)
         {
             Console.WriteLine("Число просте."); 
         }
         
  
         //Знайти суму та добуток цифр числа
         int ostacha=0;
         int suma=0;
         int g=y;
         int dobutok=1;
         while (g>=1)
         {
         ostacha=g%10;
         suma=suma+ostacha;
         dobutok=dobutok*ostacha;
         g=(g-ostacha)/10;
         }
         Console.WriteLine("Сума цифр: " + suma);
         Console.WriteLine("Добуток цифр: " + dobutok);

        
        

        
         //Знайти максимальну цифру та кількість її входжень
        //  Console.WriteLine("Введіть число.");
        // int k=Convert.ToInt32(Console.ReadLine());   
          ostacha=0;
         int max=0;
          g=y;
         int kilkist=1;
         while (g>=1)
         {
         ostacha=g%10;
         g=(g-ostacha)/10;
        if (ostacha==max)
        {
          kilkist=kilkist+1;  
        }
        if (ostacha>max)
        {
         max=ostacha;   
        kilkist=1;
        }
         }
         Console.WriteLine("Максимальна цифра: " + max);
        Console.WriteLine("Кількість входжень: " + kilkist);
        }
    }
}
