using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagementMVC.Models
{
    public class Event
    {
        public int Id { get; set; } // unique ID

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [Required]
        public required string Location { get; set; }
    }
}