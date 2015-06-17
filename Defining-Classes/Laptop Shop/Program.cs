﻿using System;
    class Program
    {
        public static void Main()
        {
            Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", 128, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", new Battery("Li-Ion, 4-cells, 2550 mAh",4.5),2259.00 );
            Console.WriteLine(lenovo);

            Laptop acer = new Laptop("Acer Aspire", 4000);
            Console.WriteLine(acer);
        }
    }
