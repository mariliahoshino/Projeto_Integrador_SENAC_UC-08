using System.Collections.Generic;
namespace UC8At3_Marília.Models
{
    public class InfoCarrinho
    {
         private static List<Carrinho> lista = new List<Carrinho>();
    

        public static void Incluir(Carrinho novaLista)
        {
             lista.Add(novaLista);
        }

        public static List<Carrinho> Listar()
        {
             return lista;
        }


        public static double TotalizaPedido()
        {
            double total = 0;
            foreach (var lista in lista)
            {
                total = total + lista.valoruni * lista.quantidade;
            }
            return (total);
        }
    }
}