using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static partial class Controller
    {
        /// <summary>
        /// Сложение 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Addition(double a, double b)
        {
            if (a <= 0 && b <= 0)
            { 
                throw new Exception("куку Ёпта");
            }
            return (a + b);
        }
        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Substraction(double a, double b)
        {
            if (a <= 0 && b <= 0)
            {
                throw new Exception("куку Ёпта");
            }
            return (a - b);
        }
        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Multiplication(double a, double b)
        {
            if (a <= 0 && b <= 0)
            {
                throw new Exception("куку Ёпта");
            }
            return (a * b);
        }
        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double  Division(double a, double b)
        {
            /*if (b == 0)
            {
                throw new Exception("на ноль делить нельзя");
            }*/
            if (a <= 0 && b <= 0 || b == 0)
            {
                throw new Exception("куку Ёпта");
            }
            return (a / b);
        }
        public static string Calc(List<double> n, List<eOperation> o)  
        {
            

            return string.Empty;
        }

    }
     

}         
            
       
         
     
	

	

   
    






    

