using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanalDeal.Entities
{
    public class Aution
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string PictureURL { get; set; }
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
