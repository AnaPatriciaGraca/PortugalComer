using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortugalCome.Models
{
    public class Fotografias
    {
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Nome do ficheiro que contém a fotografia - campo obrigatório
        /// </summary>
        public string Designacao { get; set; }


        /// <summary>
        /// Data e hora a que o upload da fotografia foi efetuado
        /// </summary>
        public DateTime Upload { get; set; }


        /// <summary>
        /// Chave estrangeira que faz a ligação com a tabela dos Restaurantes
        /// </summary>
        [ForeignKey(nameof(Restaurante))]
        public int RestauranteFK { get; set; }
        public Restaurantes Restaurante { get; set; }
    }
}
