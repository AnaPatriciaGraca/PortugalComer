using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortugalCome.Models
{
    public class Pedidos
    {
        //definir PK se não vai dar erro a fazer a migração da BD
        [Key]
        public int Id { get; set; }

        //um pedido tem de ter uma data
        //devo saber se o pedido já foi efetuado ou não e se foi dentro do prazo

        //NÃO PERMITIR PERSONALIZAÇÃO DO PEDIDO

        /// <summary>
        /// Data/Hora a que foi efetuado o pedido ao restaurante
        /// </summary>
        public DateTime DataEncomenda { get; set; }

        /// <summary>
        /// Data/Hora em que foi entregue a encomenda do restaurante
        /// </summary>
        public DateTime DataEntrega { get; set; }

        /// <summary>
        /// Detalhe do Pedido efetuado pelo Cliente ao Restaurante
        /// </summary>
        /// 
        public string Detalhes { get; set; }

        //FK da tabela Restaurante
        [ForeignKey(nameof(Restaurante))]
        public int RestauranteFK { get; set; }
        public Restaurantes Restaurante { get; set; }

        //FK da tabela Cliente
        [ForeignKey(nameof(Cliente))]
        public int ClienteFK { get; set; }
        public Clientes Cliente { get; set; }
    }
}
