using System;

namespace Triangle
{
    class ProgramTriangle
    {
        static void Main(string[] args)
        {
            
           Console.WriteLine("Введіть 1 число.");
            double y=Convert.ToDouble(Console.ReadLine());           
           Console.WriteLine("Введіть 2 число.");
           double z=Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Введіть 3 число.");
           double c=Convert.ToDouble(Console.ReadLine()); 
           if (y>z && y>c){
               if (y>z+c) {
                   Console.WriteLine("Output:True");
                }
                else{
                     Console.WriteLine("Output:False"); 
                }
            }
           else{
               if(y==z){
                   if(y==c){
                   Console.WriteLine("Output:True");
                   }
                else{
                    if(c<y+z){Console.WriteLine("Output:True");
                    }
                 else{
                     Console.WriteLine("Output:False");
                 }
                }
               }
            else{
                if(z<y+c){Console.WriteLine("Output:True");
                    }
                 else{
                     if (z>y && z>c){
               if (z>y+c) {
                   Console.WriteLine("Output:True");
               }
           else{
              Console.WriteLine("Output:False"); 
           }
           
               
           
           }
           else{
               if(z==y){
                   if(z==c){
                   Console.WriteLine("Output:True");
                   }
                else{
                    if(c<y+z){Console.WriteLine("Output:True");
                    }
                 else{
                     Console.WriteLine("Output:False");
                 }
                }
               }
            else{
                if(y<z+c){Console.WriteLine("Output:True");
                    }
                 else{
                     if (c>z && c>y){
               if (c>z+y) {
                   Console.WriteLine("Output:True");
               }
           else{
              Console.WriteLine("Output:False"); 
           }
           
               
           
           }
           else{
               if(c==z){
                   if(y==c){
                   Console.WriteLine("Output:True");
                   }
                else{
                    if(y<c+z){Console.WriteLine("Output:True");
                    }
                 else{
                     Console.WriteLine("Output:False");
                 }
                }
               }
            else{
                if(z<y+c){Console.WriteLine("Output:True");
                    }
                 else{
                     Console.WriteLine("Output:False");
            }
           }
            }
           } 
                            }
                        }
                    }
                }
            }
        }
    }
}
