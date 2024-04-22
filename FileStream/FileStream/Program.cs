using FileStreamTask.Models;
using System.Text.Json;
using System.Xml.Serialization;

namespace FileStreamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region JSON_Serialize

            //Product product = new Product
            //{
            //    Name = "Mavi qatarin sirri",
            //    Description = "Dedektiv janrinda kitab",
            //    Price = 6.99,
            //    DiscountPercet = 1
            //};

            //string json = JsonSerializer.Serialize(product);

            //Console.WriteLine(json);

            #endregion


            #region JSON_DeSerialize

            //string json = "{\"Id\":1,\"Name\":\"Mavi qatarin sirri\",\"Description\":\"Dedektiv janrinda kitab\",\"Price\":6.99,\"DiscountPercet\":1}";

            //Product product = JsonSerializer.Deserialize<Product>(json);

            //Console.WriteLine("Id: " + product.Id);
            //Console.WriteLine("Name: " + product.Name);
            //Console.WriteLine("Description: " + product.Description);
            //Console.WriteLine("Price: " + product.Price);
            //Console.WriteLine("DiscountPercet: " + product.DiscountPercet);

            #endregion


            #region XML_Serialize

            //Product product = new Product
            //{
            //    Name = "Mavi qatarin sirri",
            //    Description = "Dedektiv janrinda kitab",
            //    Price = 6.99,
            //    DiscountPercet = 1
            //};

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));

            //using (TextWriter writer = new StreamWriter("product.xml"))
            //{
            //    xmlSerializer.Serialize(writer, product);
            //}

            #endregion


            #region XML_DeSerialize

            //string xmlFilePath = "product.xml";

            //Product product;

            //XmlSerializer serializer = new XmlSerializer(typeof(Product));
            //using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            //{
            //    product = (Product)serializer.Deserialize(fileStream);
            //}

            //Console.WriteLine("Id: " + product.Id);
            //Console.WriteLine("Name: " + product.Name);
            //Console.WriteLine("Description: " + product.Description);
            //Console.WriteLine("Price: " + product.Price);
            //Console.WriteLine("DiscountPercet: " + product.DiscountPercet);

            #endregion
        }
    }
}
