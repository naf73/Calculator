using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static partial class ControllerParse
    {
        /// <summary>
        /// Парсер строки
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static bool Parse(string s,out List<double> n,out List<eOperation> o)
        {
            bool res = false;
            n = new List<double>();
            o = new List<eOperation>();

            List<string> words = new List<string>(s.Split(' '));

            foreach (string word in words)
            {
                
                if ( double.TryParse(word,out double number))
                {
                    n.Add(number);
                }
                else
                {
                    switch (word)
                    {
                        case "+":
                            o.Add(eOperation.addition);
                            break;
                        case "-":
                            o.Add(eOperation.subtraction);
                            break;
                        case "*":
                            o.Add(eOperation.multiplication);
                            break;
                        case "/":
                            o.Add(eOperation.division);
                            break;
                        default:
                            break;
                    }                    
                }
            }

            res = true;

            return res;
        }
    }
}
