using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Models
{
    public class Sales : BaseClass
    {
        public Sales()
        {
            creationDate = DateTime.Now.ToString();
        }
        public string creationDate { get; set; }
        public int count { get; set; }
        public decimal totalPrice { get; set; }
        public string sessionTime { get; set; }

        public override string ToString()
        {
            return $"{creationDate} tarihinde {movieName} adlı filmin {sessionTime} seansına {count} adet bilet satın alma işleminiz gerçekleşmiştir. Toplam tutar {totalPrice} TL'dir. İyi seyirler dileriz.";
        }
    }
}
