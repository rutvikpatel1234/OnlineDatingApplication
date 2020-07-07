using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;


namespace Utilities
{
    public class PaymentClass
    {

        public string apikey { get; set; }
        public string Cardname { get; set; }
        public string Cardnumber { get; set; }
        public string Cardtype { get; set; }
        public string Ccv { get; set; }
        public string Monthlysubscription { get; set; }
        public string Username { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }



        public PaymentClass(string cardholder, string cardnumber, string cardtype, string ccv, string monthlysubscription, string username, string month, string year)
        {

            this.Cardname = cardholder;
            this.Cardnumber = cardnumber;
            this.Cardtype = cardtype;
            this.Ccv = ccv;
            this.Monthlysubscription = monthlysubscription;
            this.Username = username;
            this.Month = month;
            this.Year = year;

        }

        public PaymentClass()
        {
        }
        public PaymentClass(string userName)
        {
            this.Username = userName;
        }
    }
}
