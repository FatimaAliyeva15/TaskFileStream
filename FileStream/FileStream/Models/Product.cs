using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamTask.Models
{
    public class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double DiscountPercet { get; set; }

        public Product()
        {
            _id++;
            Id = _id;
            
        }

    }
}
