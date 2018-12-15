using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Controller
    {
        /// <summary>
        /// Сложение 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Addition(int a, int b)
        {
            if (a <= 0 && b <= 0)
            { 
                throw new Exception("куку Ёпта");
            }
            return (a + b).ToString();
        }
        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Substraction(int a, int b)
        {
            if (a <= 0 && b <= 0)
            {
                throw new Exception("куку Ёпта");
            }
            return (a - b).ToString();
        }
        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Multiplication(int a, int b)
        {
            if (a <= 0 && b <= 0)
            {
                throw new Exception("куку Ёпта");
            }
            return (a * b).ToString();
        }
        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Division(int a, int b)
        {
            /*if (b == 0)
            {
                throw new Exception("на ноль делить нельзя");
            }*/
            if (a <= 0 && b <= 0 || b == 0)
            {
                throw new Exception("куку Ёпта");
            }
            return (a / b).ToString();
        }       

    }

}         
            
       
         
     
	

	

   
    






    

