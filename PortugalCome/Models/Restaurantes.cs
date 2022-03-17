using System.ComponentModel.DataAnnotations;

namespace PortugalCome.Models
{
    public class Restaurantes
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do Restaurante
        /// </summary>
        public string Nome { get; set; }


        /// <summary>
        /// Horário de Funcionamento do Restaurante
        /// </summary>
        public string Horario { get; set; }


        /// <summary>
        /// Contacto telefónico do restaurante, poderá ser um número de telemóvel ou telefone fixo Português
        /// </summary>
        public string Telefone { get; set; }


        /// <summary>
        /// Coordenadas da localização do restaurante, o preenchimento terá de ser obrigatório para esta aplicação
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Coordenada da localização do restaurante, o preenchimento terá de ser obrigatório para esta aplicação
        /// </summary>
        public string Longitude { get; set; }


        /// <summary>
        /// Código Postal do Restaurante
        /// </summary>
        public string CodigoPostal { get; set; }


        /// <summary>
        /// Morada do restaurante - pode incluir Rua, nº da porta e andar
        /// </summary>
        public string Morada { get; set; }

    }
}
