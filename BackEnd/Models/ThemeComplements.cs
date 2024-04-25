using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipsOnPoints2.Models
{
    public class ThemeComplements (){
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Tc_Id")]
        public int Id { get; set;}
        [Column("Tc_ThemeId")]
        [ForeignKey("Theme")]  
        public int ThemeId { get; set;}
        [Column("Tc_Complements")]
        public string ?Complements {get; set;}
        public Theme ?Theme { get; set; }
    }
}