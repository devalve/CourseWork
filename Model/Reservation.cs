using System;
using System.Collections.Generic;

namespace CourseWork.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public string[]? Members { get; set; }
    }
}
