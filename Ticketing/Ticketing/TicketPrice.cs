using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 27m;       // 35.5 --> 25.5  --> 30 --> 30*0.9 = 27
        const decimal mdecGeneral = 21.38m;        // 28.75 --> 18.75 --> 23.75 --> 23.75*0.9 = 21.38
        const decimal mdecBox = 51.3m;               // 62 --> 52 --> 57 --> 57*0.9 = 51.3
        const decimal mdecDiscount = 5.0m; 

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }

         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice
    public TicketPrice(int section, int quantity, bool discount)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
         }
         if (discount)
         { mPrice -= mdecDiscount; }

         AmountDue = mPrice * quantity;

     }
    }
}
