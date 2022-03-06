using System;

namespace CinemaTicketSalesAutomation.Models
{
    public class Sales : BaseClass
    {

        public Sales()
        {
            creationDate = DateTime.Now.ToString();
        }
        public string creationDate { get; set; }
        public decimal totalPrice { get; set; }
        public int count { get; set; }
        public string sessionTime { get; set; }

        public override string ToString()
        {
            return $"{movieName} adli filmin {sessionTime} seansina {count} adet bilet kesilmistir. Toplam tutar = {totalPrice} ₺ | Satin alma tarihi = {creationDate}";
        }
    }
}
