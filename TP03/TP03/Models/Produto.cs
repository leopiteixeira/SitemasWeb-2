using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP03.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ?Nome { get; set; }

        [Required]
        [StringLength(200)]
        public string ?Descricao { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Preco {  get; set; }

        [Required]
        [Range (0, int.MaxValue)]
        public int Qtd { get; set; }

    }
}
