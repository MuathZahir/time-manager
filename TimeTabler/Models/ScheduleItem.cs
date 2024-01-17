using System.ComponentModel.DataAnnotations;

namespace TimeTabler.Models
{
    public abstract class ScheduleItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }

    public enum ScheduleItemType
    {
        Task,
        Block,
        Group
    }

    [Flags]
    public enum DayOfWeek
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32
    }

    [Flags]
    public enum MonthOfYear
    {
        January = 0,
        February = 1,
        March = 2,
        April = 4,
        May = 8,
        June = 16,
        July = 32,
        August = 64,
        September = 128,
        October = 256,
        November = 512,
        December = 1024
    }
}
