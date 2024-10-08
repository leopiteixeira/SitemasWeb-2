using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP02.Models
{
    public class BL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlId { get; set; }

        [Required(ErrorMessage = "O numero da BL é obrigatório")]
        public string ?Numero { get; set; }

        [Required(ErrorMessage = "O consignee da BL é obrigatório")]
        public string ?Consignee { get; set; }

        [Required(ErrorMessage = "O navio da BL é obrigatório")]
        public string ?Navio { get; set; }

        public ICollection<Container> ?Containers { get; set; }
    }
}
