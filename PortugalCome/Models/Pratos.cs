using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortugalCome.Models
{
    public class Pratos
    {
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Nome do Prato - campo obrigatório
        /// </summary>
        public string Designacao { get; set; }


        /// <summary>
        /// Breve descrição do prato - campo obrigatório
        /// </summary>
        public string Descricao { get; set; }


        /// <summary>
        /// Nome do ficheiro que contém a fotografia do Prato (facultativo)
        /// </summary>
        public string Foto { get; set; }


        /// <summary>
        /// Chave estrangeira que associa os pratos aos respectivos restaurantes
        /// </summary>
        [ForeignKey(nameof(Restaurante))]
        public int RestauranteFK { get; set; }
        public Restaurantes Restaurante { get; set; }
    }
}
