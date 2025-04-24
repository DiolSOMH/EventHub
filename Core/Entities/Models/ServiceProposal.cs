using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models
{
    public class ServiceProposal
    {
        [Key]
        public int Id { get; set; }
        public AppUser Author { get; set; }
        public string Gender { get; set; }
        public string AuthorId {get; set;}
        public string Service { get; set; }
        public string Location { get; set; }
        public string WorkingDays { get; set; }
        public string EventTypes { get; set; }
        public DateTime DateProposed { get; set; }
        public int Age { get; set;}
        public string? MoreDetails { get; set; }
    }
}