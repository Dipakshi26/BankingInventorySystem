using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHandsOn
{
    internal class PurchaseSalesModule
    {
        int salesId, productId, price;
        string salesDate;
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\LUCKY\source\repos\FileHandlingHandsOn\FileHandlingHandsOn.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            int counter = 1, totalPurchaseSalesRecords;
            Console.WriteLine("Enter total number Of Purchase And Sales Module records you want to store");
            totalPurchaseSalesRecords = Convert.ToInt32(Console.ReadLine());

            streamWriterObj.WriteLine("SalesId \t Productid\tprice\tsalesdate");

            while (counter <= totalPurchaseSalesRecords)
            {
                Console.WriteLine("Enter sales Id");
                salesId = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(salesId + "\t\t");

                Console.WriteLine("Enter product id");
                productId = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(productId + "\t\t");

                Console.WriteLine("Enter price");
                price = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(price + "\t");

                Console.WriteLine("Enter slaes date");
                salesDate = (Console.ReadLine());
                streamWriterObj.WriteLine(salesDate);

                counter++;
                Console.WriteLine();

            }
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");
            Console.WriteLine();
        }
    }

}

