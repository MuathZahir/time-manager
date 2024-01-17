using System.ComponentModel.DataAnnotations;

namespace TimeTabler.Models
{
    public class BlockModel : ScheduleItem
    {
        [Required]
        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsRecurring { get; set; }
        public RecurringDays RecurringDays { get; set; }
        [Required]
        public GroupModel Group { get; set; }
    }
}
