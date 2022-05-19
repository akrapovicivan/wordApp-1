using System.ComponentModel.DataAnnotations.Schema;

namespace WordAPI
{
    public class Has
    {
        
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Words")]
        public int IdWord { get; set; }

    }
}
 