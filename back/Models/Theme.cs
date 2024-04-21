using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipsOnPoints.Models
{
    public class Theme (){
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Th_Id")]
        public int Id {get; set;}  

        [Column("Th_PluralTheme")]
        public string ?PluralTheme {get; set;}   
           
        [Column("Th_SingleTheme")]  
        public string ?SingleTheme {get; set;} 
        [Column("Th_QtyTips")]
        public int QtyTips {get; set;}
        public ICollection<ThemeComplements> ?ThemeComplements { get; set;}

    }
}