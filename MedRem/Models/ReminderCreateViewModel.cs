using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MedRem.CustomValidations;

namespace MedRem.Models
{
    public class ReminderCreateViewModel
    {
        public string Title { get; set; } = "Reminder Create Model";
        [Required]
        [ReminderDate]
        public DateTime ReminderDate { get; set; }
    }
}
