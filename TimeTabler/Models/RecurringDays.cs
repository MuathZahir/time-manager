namespace TimeTabler.Models
{
    public class RecurringDays
    {
        public bool Monday { get; set; } = false;
        public bool Tuesday { get; set; } = false;
        public bool Wednesday { get; set; } = false;
        public bool Thursday { get; set; } = false;
        public bool Friday { get; set; } = false;
        public bool Saturday { get; set; } = false;
        public bool Sunday { get; set; } = false;

        //public Dictionary<DayOfWeek, bool> Days { get; set; } = new Dictionary<DayOfWeek, bool>()
        //{
        //                    { DayOfWeek.Sunday, false },
        //        { DayOfWeek.Monday, false },
        //        { DayOfWeek.Tuesday, false },
        //        { DayOfWeek.Wednesday, false },
        //        { DayOfWeek.Thursday, false },
        //        { DayOfWeek.Friday, false },
        //        { DayOfWeek.Saturday, false }
        //    };
    }
}
