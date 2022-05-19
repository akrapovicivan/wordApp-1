using System.ComponentModel.DataAnnotations.Schema;

namespace WordAPI
{
    public class User
    {
        public int Id { get; set; }
        public string DateOfBirth { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string BussinessEmail { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [ForeignKey("Has")]
        public int  HasId { get; set; }
        
    }
}
