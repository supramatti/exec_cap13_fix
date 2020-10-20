using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace exec_cap13_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\myfolder\file.csv";
            string[] lines = File.ReadAllLines(filePath);
 
            int count = 0;
            List<Product> list = new List<Product>();

            for (int i = 0; i < lines.Length; i++)
            {
                count = 0;
                string[] x = lines[i].Split(',');
                while (count < x.Length)
                {
                    string name = x[count];
                    count++;
                    double price = double.Parse(x[count], CultureInfo.InvariantCulture);
                    count++;
                    int quantity = int.Parse(x[count]);
                    list.Add(new Product(name, price, quantity));
                    count++;
                }
            }
            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }
    }
}
