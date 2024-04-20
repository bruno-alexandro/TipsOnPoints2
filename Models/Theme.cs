using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipsOnPoints.Models
{
    public class Theme (){
        public int Id {get; set;}
        public string PluralTheme {get; set;} = "";
        public string SingleTheme {get; set;} = "";
        public int QtyTips {get; set;}
        public string ThemeComplements {get; set;} = "";
    }
}