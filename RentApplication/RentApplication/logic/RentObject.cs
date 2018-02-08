
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RentApplication.logic
{
    class RentObject
    {
        public string DisplayName { get; set; }
        public DateTime RentalDate { get; set; }
        public string type { get; set; }
        public string DisplayDetail {
            get
            {
                string dateStr = RentalDate.ToString("dd.MM.yyyy");
                return type + " Ausgeborgt am: " + dateStr;
            }
        }
    }
}
