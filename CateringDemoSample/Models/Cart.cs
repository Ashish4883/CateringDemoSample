using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CateringDemoSample.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [ForeignKey("Food")]
        public int FoodId { get; set; }
        public Food food { get; set; }
        public DateTime Date { get; set; }

    }
}
