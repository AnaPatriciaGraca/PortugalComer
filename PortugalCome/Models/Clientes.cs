using System.ComponentModel.DataAnnotations;

namespace PortugalCome.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do Cliente
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Contacto tleefónico do utilizador/Cliente
        /// </summary
        public string Telefone { get; set; }

        /// <summary>
        /// Morada do utilizador para entrega das encomendas dos restaurantes
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do Restaurante
        /// </summary>
        public string CodigoPostal { get; set; }

        /// <summary>
        /// Fotografia do cliente a mostrar na aplicação
        /// </summary>
        public string Fotografia { get; set; }

        /// Chave de ligação
        public string UserNameId { get; set; }
    }
}
