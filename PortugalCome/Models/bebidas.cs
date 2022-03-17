using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortugalCome.Models
{
    public class bebidas
    {
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Nome das bebidas disponíveis no Restaurante - campo obrigatório
        /// </summary>
        public string Designacao { get; set; }


        /// <summary>
        /// Breve descrição da bebida (facultativo)
        /// </summary>
        public string Descricao { get; set; }


        /// <summary>
        /// Fotografia da bebida (facultativo)
        /// >>>>>>>>>>>>>>>>>>   Duvida: colocar regex para a string do ficheiro da foto? <<<<<<<<<<<<<<<
        /// </summary>
        public string Foto { get; set; }


        /// <summary>
        /// Chave estrangeira que associa as Bebidas aos respectivos Restaurantes
        /// </summary>
        [ForeignKey(nameof(Restaurante))]
        public int RestauranteFK { get; set; }
        public Restaurantes Restaurante { get; set; }
    }
}
