using System.Collections.Generic;

namespace CinemaTicketSalesAutomation.Models
{
    public class Session
    {
        public Session()
        {
            setDefaultChairs();
        }
        public string date { get; set; }
        public string time { get; set; }
        public List<Chair> chairs { get; set; }

        private void setDefaultChairs()
        {
            chairs = new List<Chair>();
            string[] rows = { "a", "b", "c", "d" };
            string[] numbers = { "1", "2", "3", "4", "5", "6", };
            foreach (string row in rows)
            {
                foreach (string number in numbers)
                {
                    Chair chair = new Chair(row, number);
                    chairs.Add(chair);
                }
            }
        }
    }
}
