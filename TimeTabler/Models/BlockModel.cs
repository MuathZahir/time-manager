using System.ComponentModel.DataAnnotations;

namespace TimeTabler.Models
{
    public class BlockModel : ScheduleItem
    {
        [Required]
        public DateTime? Date { get; set; } = DateTime.Today;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsRecurring { get; set; }
        public RecurringDays RecurringDays { get; set; } = new();
        [Required] public GroupModel? Group { get; set; }
    }
}
