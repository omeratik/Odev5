using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Entities
{
	public class Discount
	{
        public int Id { get; set; }
        public string DiscountName { get; set; }
        public int DiscountRatio { get; set; }
    }
}
