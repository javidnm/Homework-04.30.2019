using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vizew.WebUI.Models.Entity
{
    public class Contact : BaseEntity
    {
        [Required]
        [DisplayName("Ad")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Mesaj")]

        public string Message { get; set; }
        [DisplayName("Oxunanlar")]

        public bool IsReady { get; set; }
        public bool IsAnswered { get; set; }
        public DateTime AnsweredDate { get; set; }
        public string Answer { get; set; }

    }
}