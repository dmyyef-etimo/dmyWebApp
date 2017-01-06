using System.ComponentModel.DataAnnotations;

namespace dmyWebApp.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }
    }
}