using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Models
{
    public class Session
    {
        public Session()
        {
            SetDefaultChairs();
        }
        public string date { get; set; }
        public string time { get; set; }
        public List<Chair> Chairs { get; set; }

        private void SetDefaultChairs()
        {
            Chairs = new List<Chair>();
            string[] rows = { "a", "b", "c", "d" };
            string[] numbers = { "1", "2", "3", "4", "5", "6" };
            foreach (string row in rows)
            {
                foreach (string number in numbers)
                {
                    Chair chair = new Chair(row, number);
                    Chairs.Add(chair);
                }
            }
        }
    }
}
