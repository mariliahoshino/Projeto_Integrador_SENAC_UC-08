using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UC8At3_Marília.Models
{
    public class Contato
    {
        public int Id { get; set; }

        //[StringLength(100)]
        public string Nome { get; set; }

        //[StringLength(100)]
        public string Email { get; set; }

        //[StringLength(20)]
        public string Telefone { get; set; }

        //[StringLength(500)]
        public string Mensagem { get; set; }
        //public bool Queremkt { get; set; }
        public string Queremkt { get; set; }
    }
}