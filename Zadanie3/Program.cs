﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {



            //DataClasses1DataContext db = new DataClasses1DataContext();
            //  ExtensionMethods.getStringFromVendorAndProduct(db.Products.ToList());
            string a = ExtensionMethods.GetPageNumberWithNProducts(1, 3).getStringFromVendorAndProduct();
            Console.WriteLine(a.Length);
            Console.ReadKey();



        }
        }
    }

