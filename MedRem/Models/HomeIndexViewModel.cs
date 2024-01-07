using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedRem.Models
{
    public class HomeIndexViewModel
    {
        public List<Entities.MedReminder> TimeOuts { get; set; } = new List<Entities.MedReminder>();
        public List<Entities.MedReminder> NotTimeYets { get; set; } = new List<Entities.MedReminder>();
        public List<Entities.MedReminder> NowIsTime { get; set; } = new List<Entities.MedReminder>();
        public ReminderCreateViewModel CreateViewModel { get; set; } = new ReminderCreateViewModel();

    }
}
