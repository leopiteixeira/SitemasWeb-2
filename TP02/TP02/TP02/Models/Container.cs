using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP02.Models
{
    public class Container
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContainerId { get; set; }

        [Required]
        public string ?Numero {  get; set; }

        [Required]
        public TipoContainer Tipo {  get; set; }

        [Required]
        [Range(20,40)]
        public int Tamanho { get; set; }

        public int BlId { get; set; }

        [ForeignKey("BlId")]
        public BL ?BL { get; set; }
    }
}
