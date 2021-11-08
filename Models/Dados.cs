namespace UC8At3_Marília.Models
{
    public static class Dados
    {
        public static InfoCarrinho CarrinhoAtual {get; set;}

        static Dados()
        {
            CarrinhoAtual = new InfoCarrinho();
        }
    }
}