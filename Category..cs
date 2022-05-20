using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHandsOn
{
    internal class CategoryModule
    {
        int categoryId; string categoryType;
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\LUCKY\source\repos\FileHandlingHandsOn\FileHandlingHandsOn.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            int counter = 1, totalCategoryRecords;
            Console.WriteLine("Enter total number Of Category Module records you want to store");
            totalCategoryRecords = Convert.ToInt32(Console.ReadLine());

            streamWriterObj.WriteLine("CategoryId\tCategoryType");

            while (counter <= totalCategoryRecords)
            {
                Console.WriteLine("Enter product category Id");
                categoryId = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(categoryId + "\t\t");

                Console.WriteLine("Enter category type of product");
                categoryType = Console.ReadLine();
                streamWriterObj.WriteLine(categoryType);
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
