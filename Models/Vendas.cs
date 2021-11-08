namespace UC8At3_Marília.Models
{
    public class Vendas
    {
        public int Id {get; set;}
        public string Produto {get; set;}
        public int Quantidade {get; set;}
        public double ValorUnitario {get; set;}
        public double Total {get; set;}

        public int Usuario {get; set;}
    }
}