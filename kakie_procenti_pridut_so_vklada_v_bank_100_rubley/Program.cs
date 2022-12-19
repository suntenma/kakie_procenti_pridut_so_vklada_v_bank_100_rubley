using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakie_procenti_pridut_so_vklada_v_bank_100_rubley
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("сумма влклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            if (sum <= 100)
                Console.WriteLine($"общая сумма: {sum + sum / 20}");
            else if (sum > 100 && sum < 200)
                Console.WriteLine($"общая сумма: {sum + sum / 100 * 7}");
            else
                Console.WriteLine($"общая сумма: {sum + sum / 10}");
        }
    }
}
