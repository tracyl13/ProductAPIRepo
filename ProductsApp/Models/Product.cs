/* Tracy Lan
 * 3374 Quality Assurance & Testing
 * Lab 8 
 * October 20, 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }
}