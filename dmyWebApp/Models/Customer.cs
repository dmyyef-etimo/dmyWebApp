using System;
using System.ComponentModel.DataAnnotations;

namespace dmyWebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        public DateTime Birthday { get; set; }
    }
}