using System;
using Taller31AccesoDatos.Modelos;

namespace Taller31AccesoDatos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prueba_Insert();
        }

        /// <summary>
        /// Prueba insercion de un registro
        /// </summary>
        private static void Prueba_Insert() {
            Customers cust = null;
            cust = new Customers {
                CustomerId = "XYZ",
                CompanyName = "",
                ContactName = ""
            };
            using(NorthwindContext dbctxt = new NorthwindContext()) {
                dbctxt.Add<Customers>(cust);
                dbctxt.SaveChanges();
            }
        }
    }
}
