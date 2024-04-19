using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipsOnPoints.Models
{
    public class Card (){
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Ca_Id")]
        public int Id { get; set;}
        [Column("Ca_Answer")]
        public string ?Answer {get; set;}
        [Column("Ca_ThemeId")]
        public int ?ThemeId {get; set;}
    }
}