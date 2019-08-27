using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            showResult(calculateAddMul(readNumber("Please Enter Tow Numbers : ")));
     
        }

        private static void showResult((long number1, long number2, long result1, long result2) p) => Console.WriteLine($"{p.number1} + {p.number2} = {p.result1} \n{p.number1} * {p.number2} =  {p.result2}");



        private static (long  , long ,long , long) calculateAddMul((long number1, long number2) p)
        {
            long res1, res2;
            res1 = p.number1 + p.number2;
            res2 = p.number1 * p.number2;
            return ( p.number1,p.number2,res1, res2);
        }

        private static (long , long ) readNumber(string v)
        {
            long numb1, numb2;
            Console.WriteLine(v);

           numb1 = long.Parse( Console.ReadLine());
           numb2 = long.Parse( Console.ReadLine());

            return (numb1,numb2);
        }
    }
}
