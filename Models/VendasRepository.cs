using System;
using System.Collections.Generic;
using MySqlConnector;

namespace UC8At3_Marília.Models
{
    public class VendasRepository   //sempre rodar dotnet add package MySqlConnector e talvez dotnet add package MySql.Data
                                    //MySql fica com erro se esquecer
    {
        

        private const string DadosConexao = "Database=deltamoto;Data source=localhost;User Id=root;";

        public void TestarConexao(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando! vendas"); 
            Conexao.Close();             
        }
        //operacoes de manipulacao no banco de dados da classe 'Usuario'
        //CRUD -> inserir(C) Usuario no Banco, listar(R), alterar(U), excluir(D)


        public Vendas buscarPorId (int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao

             //definir query = "select * from Usuario" where Id=100"
            String Query = "select * from Vendas where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",Id); //controle para sql-injection

            MySqlDataReader Reader = Comando.ExecuteReader();

            Vendas userEncontrado = new Vendas();

            if (Reader.Read())
            {
                userEncontrado.Id = Reader.GetInt32("Id");
                 
                 if (!Reader.IsDBNull(Reader.GetOrdinal("Produto")))
                    userEncontrado.Produto = Reader.GetString("Produto"); 
                 
                if (!Reader.IsDBNull(Reader.GetOrdinal("Quantidade")))
                    userEncontrado.Quantidade = Reader.GetInt32("Quantidade"); 
                 
                if (!Reader.IsDBNull(Reader.GetOrdinal("ValorUnitario")))
                    userEncontrado.ValorUnitario = Reader.GetDouble("ValorUnitario"); 


                /*
                if (!Reader.IsDBNull(Reader.GetOrdinal("Atrativos")))
                    userEncontrado.Atrativos = Reader.GetString("Atrativos"); 
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                    userEncontrado.Destino = Reader.GetString("Destino"); 

                //userEncontrado.Usuario = Reader.GetInt32("Usuario");
                 
                userEncontrado.Saida = Reader.GetDateTime("Saida"); 

                userEncontrado.Retorno = Reader.GetDateTime("Retorno");
                */  

            }
            

            Conexao.Close();  //fechar conexao

            return userEncontrado;   //retornar Lista de usuarios



        }








        

        public List<Vendas> listar(){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao

             //definir query = "select * from Vendas" 
            String Query = "select * from Vendas";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Vendas> Lista = new List<Vendas>();
            while(Reader.Read())
            {

                 Vendas userEncontrado = new Vendas();       
                 userEncontrado.Id = Reader.GetInt32("Id");
                 
                 if (!Reader.IsDBNull(Reader.GetOrdinal("Produto")))
                    userEncontrado.Produto = Reader.GetString("Produto"); 
                 
                if (!Reader.IsDBNull(Reader.GetOrdinal("Quantidade")))
                    userEncontrado.Quantidade = Reader.GetInt32("Quantidade"); 
                 
                if (!Reader.IsDBNull(Reader.GetOrdinal("ValorUnitario")))
                    userEncontrado.ValorUnitario = Reader.GetDouble("ValorUnitario"); 


                /*
                if (!Reader.IsDBNull(Reader.GetOrdinal("Atrativos")))
                    userEncontrado.Atrativos = Reader.GetString("Atrativos"); 
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                    userEncontrado.Destino = Reader.GetString("Destino"); 

                //userEncontrado.Usuario = Reader.GetInt32("Usuario");
                 
                userEncontrado.Saida = Reader.GetDateTime("Saida"); 

                userEncontrado.Retorno = Reader.GetDateTime("Retorno");
                */ 

                 
                 Lista.Add(userEncontrado);   
            }

            Conexao.Close();  //fechar conexao

            return Lista;   //retornar Lista de usuarios
           
        }


        public void inserir(Vendas user) {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao
            
            //definir query "insert into tabela (campo1,campo2) Values (info1,info2)";
            String Query= "insert into Vendas ( IdUsuario,Produto,Quantidade,ValorUnitario) values (@IdUsuario,@Produto,@Quantidade,@ValorUnitario)";

            //comando e os controles para sql-injection
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
                Comando.Parameters.AddWithValue("@IdUsuario",user.Usuario); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Produto",user.Produto); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Quantidade",user.Quantidade); //controle para sql-injection
            Comando.Parameters.AddWithValue("@ValorUnitario",user.ValorUnitario); //controle para sql-injection
            //Comando.Parameters.AddWithValue("@Atrativos",user.Atrativos); //controle para 
            //Comando.Parameters.AddWithValue("@Saida",user.Saida); //controle para sql-injection
            //Comando.Parameters.AddWithValue("@Retorno",user.Retorno); //controle para sql-injection
            //Comando.Parameters.AddWithValue("@Usuario",user.Usuario); //controle para sql-injection

            Comando.ExecuteNonQuery(); //executar no banco de dados
            
            Conexao.Close();  //fechar conexao

        }


        public void atualizar(Vendas user){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao
            
            //definir query "update TABELA SET campo1=info1, campo2=info where Id=10";
            String Query= "Update Vendas SET Produto=@Produto, Quantidade=@Quantidade, ValorUnitario=@ValorUnitario  Where Id=@Id";

            //comando e os controles para sql-injection
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",user.Id); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Produto",user.Produto); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Quantidade",user.Quantidade); //controle para sql-injection
            Comando.Parameters.AddWithValue("@ValorUnitario",user.ValorUnitario); //controle para sql-injection
            //Comando.Parameters.AddWithValue("@Atrativos",user.Atrativos); //controle para 
            //Comando.Parameters.AddWithValue("@Saida",user.Saida); //controle para sql-injection
            //Comando.Parameters.AddWithValue("@Retorno",user.Retorno); //controle para sql-injection
            //Comando.Parameters.AddWithValue("@Usuario",user.Usuario); //controle para sql-injection 

            Comando.ExecuteNonQuery(); //executar no banco de dados
            
            Conexao.Close();  //fechar conexao

        }


        public void remover(Vendas user){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao

            //definir a query(sq)
            String Query = "delete from Vendas where Id=@Id";

            //definir comando
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",user.Id); //controle para sql-injection

            Comando.ExecuteNonQuery(); //executar no banco de dados
            
            Conexao.Close(); //fechar a conexao

        }

    }
}












