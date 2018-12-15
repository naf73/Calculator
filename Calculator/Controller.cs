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
            double result = 0;

            double[] numbers = n.ToArray();
            eOperation[] oper = o.ToArray();


            for (int i = 0; i < n.Count; i++)
            {
                if(i==0)
                {
                    result += numbers[i];
                }
                else
                {
                    switch (oper[i])
                    {
                        case eOperation.empty:
                            break;
                        case eOperation.addition:
                            result += numbers[i];
                            break;
                        case eOperation.subtraction:
                            result -= numbers[i];
                            break;
                        case eOperation.multiplication:
                            result *= numbers[i];
                            break;
                        case eOperation.division:
                            result /= numbers[i];
                            break;
                        default:
                            break;
                    }
                }
            }

            return result.ToString();
        }

    }
     

}         
            
       
         
     
	

	

   
    






    

