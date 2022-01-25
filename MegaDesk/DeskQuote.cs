using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {
        public string clientName { get; set; }
        public Desk desk { get; set; }
        public DeskQuoteCalculator calculator { get; set; }
        public RushOption rush { get; set; }
        public int totalPrice { get; set; }
        public DateTime quoteDate { get; set; }

        public DeskQuote(string clientName, Desk desk, RushOption rush)
        {
            this.clientName = clientName;
            this.desk = desk;
            this.rush = rush;
            this.calculator = new DeskQuoteCalculator();
            this.totalPrice = calculator.CalculateQuotePrice(desk, rush);
            this.quoteDate = DateTime.Today;
        }
    }
}
