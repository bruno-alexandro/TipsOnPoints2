using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipsOnPoints.Models
{
    public class CardTips (){
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Ct_Id")]
        public int Id { get; set;}
        [Column("Ct_CardId")]
        [ForeignKey("Card")]
        public int CardId { get; set;}
        [Column("Ct_Tip")]
        public string ?Tip {get; set;}
        public Card ?Card { get; set; }
    }
}