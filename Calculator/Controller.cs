using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Controller
    {
        public static string Addition(int a, int b)
        {

            return (a + b).ToString();
        }

        public static string Substraction(int a, int b)
        {
            return (a - b).ToString();
        }

        public static string Multiplication(int a, int b)
        {
            return (a * b).ToString();
        }

        public static string Division(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("на ноль делить нельзя");
            }
            return (a / b).ToString();
        }       

    }

}         
            
       
         
     
	

	

   
    






    

