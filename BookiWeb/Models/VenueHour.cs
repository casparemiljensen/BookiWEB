using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookiWeb.Models {
    public class VenueHour {

        public int Id { get; set; }
        public string WeekDay { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public int VenueId { get; set; }

    }
}