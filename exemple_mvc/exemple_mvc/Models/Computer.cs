using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_mvc.Models
{
    public class Computer
    {
        public Computer(int id, string name, decimal price, string cPU, string harDisk, string rAM)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            CPU = cPU;
            HarDisk = harDisk;
            RAM = rAM;
        }

        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string CPU { get; set; }
        public string HarDisk { get; set; }
        public string RAM { get; set; } 


    }
}