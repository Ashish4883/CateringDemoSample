using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CateringDemoSample.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Categ")]
        public int CategId { get; set; }
        public Category Categ { get; set; }
        public string Desc { get; set; }
        public string PhotoPath { get; set; }
        public bool Check { get; set; }

    }
}
