using MedRem.DataAccess.Abstract;
using MedRem.Entities;

namespace MedRem.DataAccess.Concrete
{
    public class ReminderRepository : IReminderRepository
    {
        private static List<MedRem.Entities.MedReminder>? _reminders;

        public static List<MedReminder> Reminders { get => _reminders; set => _reminders = value; }

        public ReminderRepository()
        {
            Reminders = new List<MedRem.Entities.MedReminder>();
        }
        public List<MedRem.Entities.MedReminder> GetNotTimeYets()
        {
            return Reminders.Where(reminder => reminder.ReminderState == ReminderState.NotTimeYet).ToList();
        }

        public List<MedRem.Entities.MedReminder>? GetTimeOuts()
        {
            return Reminders.Where(reminder => reminder.ReminderState == ReminderState.TimeOut).ToList();
        }

        public List<MedRem.Entities.MedReminder> GetNowIsTime()
        {
            return Reminders.Where(reminder => reminder.ReminderState == ReminderState.NowIsTime).OrderBy(reminder => reminder.CreateDate).ToList();
        }

        public MedRem.Entities.MedReminder? GetById(Guid id)
        {
            var reminder = Reminders.FirstOrDefault(reminder => reminder.Id == id);
            return reminder;
        }

        public void Add(MedRem.Entities.MedReminder reminder)
        {
            reminder.ReminderLongDate = reminder.ReminderDate.ToString("F");
            Reminders.Add(reminder);
        }

        public void Remove(Guid id)
        {
            Reminders.RemoveAll(reminder => reminder.Id == id);
        }

        public void Retitle(string title, MedRem.Entities.MedReminder reminder)
        {
            var result = Reminders.Find(r => r.Id == reminder.Id);
            if (result != null)
            {
                result.Title = title;
            }
        }

        public void TimeOut(Guid id)
        {
            var result = Reminders.Find(r => r.Id == id);
            if (result != null)
            {
                result.ReminderState = ReminderState.TimeOut;
            }
        }
        public void NowIsTime(Guid id)
        {
            var result = Reminders.Find(r => r.Id == id);
            if (result != null)
            {
                result.ReminderState = ReminderState.NowIsTime;
            }

        }

        List<MedReminder> IReminderRepository.GetNotTimeYets()
        {
            throw new NotImplementedException();
        }

        List<MedReminder> IReminderRepository.GetTimeOuts()
        {
            throw new NotImplementedException();
        }

        List<MedReminder> IReminderRepository.GetNowIsTime()
        {
            throw new NotImplementedException();
        }

        MedReminder IReminderRepository.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IReminderRepository.Add(MedReminder reminder)
        {
            throw new NotImplementedException();
        }

        void IReminderRepository.Retitle(string title, MedReminder reminder)
        {
            throw new NotImplementedException();
        }
    }
}
