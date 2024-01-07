using System.ComponentModel.DataAnnotations;

namespace MedRem.Entities
{
    public class MedReminder
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public TimeSpan TimeRemaining => ReminderDate - DateTime.Now;

        [Required]
        public DateTime ReminderDate { get; set; }
        public string? ReminderLongDate { get; set; }
        public ReminderState ReminderState { get; set; }
        public MedReminder()
        {
            Title = "Medicine Reminder";
            CreateDate = DateTime.Now;
            ReminderState = ReminderState.NotTimeYet;
            Id = Guid.NewGuid();
        }
    }

    public enum ReminderState
    {
        TimeOut = 1,
        NotTimeYet = 2,
        NowIsTime = 3
    }
}
