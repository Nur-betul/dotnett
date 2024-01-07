namespace MedRem.DataAccess.Abstract
{
    public interface IReminderRepository
    {
        List<Entities.MedReminder> GetNotTimeYets();
        List<Entities.MedReminder> GetTimeOuts();
        List<Entities.MedReminder> GetNowIsTime();
        Entities.MedReminder GetById(Guid id);

        void Add(Entities.MedReminder reminder);
        void Remove(Guid id);
        void Retitle(string title, Entities.MedReminder reminder);
        void TimeOut(Guid id);
        void NowIsTime(Guid id);

    }
}
