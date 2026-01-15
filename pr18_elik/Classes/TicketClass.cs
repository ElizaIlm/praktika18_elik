using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr18_elik.Classes
{
    public class TicketsClass
    {
        // Стоимость
        public string price { get; set; }
        // Откуда
        public string from { get; set; }
        // Куда
        public string to { get; set; }
        // Время и дата вылета
        public string time_start { get; set; }
        // Время в пути
        public string time_way { get; set; }

        public TicketsClass(string from, string to, string price, string time_start, string time_way)
        {
            this.from = from;
            this.to = to;
            this.price = price;
            this.time_start = time_start;
            this.time_way = time_way;
        }
    }
}
