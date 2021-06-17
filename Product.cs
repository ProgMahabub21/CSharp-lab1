using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInfo
{
    struct ManuDate
    {
        private byte day;
        private byte month;
        private short year;

        public ManuDate(byte day, byte month, short year)
        {

            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void PrintDate()
        {
            Console.WriteLine("Manufracture Date {0}/{1}/{2}", day, month, year);
        }
    }
    class Product
    {
        private string id;
        private float price;
        private ManuDate date;
        public Product() 
        {
        //default constructor
        }
        public void SetID(string id)
        {
            this.id = id;
        }
        public string GetID()
        {
            return this.id;
        }
        public void SetPrice(float price)
        {
            this.price = price;
        }
        public float GetPrice()
        {
            return this.price;
        }
        public void SetDate(ManuDate date)
        {
            this.date = date;
        }
        public ManuDate GetDate()
        {
            return this.date;
        }

        
        public Product(string id,float price,ManuDate date)
        {
            this.SetID(id);
            this.SetDate(date);
            this.SetPrice(price);
        }
        public void PrintProduct()
        {
            Console.WriteLine("Product Information:-");
            Console.WriteLine("ID {0}", this.GetID());
            this.date.PrintDate();
            Console.WriteLine("Price  {0}", this.GetPrice());
        }

    }
}
