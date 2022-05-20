using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHandsOn
{
    internal class Program
    {

        static void Main(string[] args)
        {

            User userObj = new User();
            userObj.WriteFile();
            Console.WriteLine();

            CategoryModule categoryModuleObj = new CategoryModule();
            categoryModuleObj.WriteFile();
            Console.WriteLine();

            ProductModule productModuleObj = new ProductModule();
            productModuleObj.WriteFile();
            Console.WriteLine();

            PurchaseSalesModule purchaseSalesMouduleObj = new PurchaseSalesModule();
            purchaseSalesMouduleObj.WriteFile();
            Console.WriteLine();

        }
    }
}

