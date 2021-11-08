using System;
using System.Collections.Generic;
using MySqlConnector;
//using MySqlConnector.Data.MySqlClient;

namespace UC8At3_Marília.Models
{
    public class ContatoRepository{

        private const string DadosConexao = "Database=deltamoto;Data source=localhost;User Id=root;";

        public void TestarConexao(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando! contato"); 
            Conexao.Close();             
        }
        //operacoes de manipulacao no banco de dados da classe 'Usuario'
        //CRUD -> inserir(C) Usuario no Banco, listar(R), alterar(U), excluir(D)


        /*
        public Usuario validarLogin(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao

            //definir query = "select * from Usuario" where Id=100"
            String Query = "select * from Usuario where Login=@Login and Senha=@Senha";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Login",user.Login); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Senha",user.Senha); //controle para sql-injection
            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario userEncontrado = null;
            

            if (Reader.Read())
            {
                userEncontrado = new Usuario();
                userEncontrado.Id = Reader.GetInt32("Id");


                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome"); 
                 
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login"); 
                 
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");

                userEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            return userEncontrado;


        }
        */

        /*
        public Usuario buscarPorId (int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao

             //definir query = "select * from Usuario" where Id=100"
            String Query = "select * from Usuario where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",Id); //controle para sql-injection

            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario userEncontrado = new Usuario();

            if (Reader.Read())
            {
                userEncontrado.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome"); 
                 
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login"); 
                 
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");

                userEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }
            

            Conexao.Close();  //fechar conexao

            return userEncontrado;   //retornar Lista de usuarios



        }
        */

        /*        

        public List<Usuario> listar(){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao

             //definir query = "select * from Usuario" 
            String Query = "select * from Usuario";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Usuario> Lista = new List<Usuario>();
            while(Reader.Read())
            {

                 Usuario userEncontrado = new Usuario();       
                 userEncontrado.Id = Reader.GetInt32("Id");
                 
                 if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome"); 
                 
                  if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login"); 
                 
                  if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha"); 
                 
                 userEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento"); 
                 
                 Lista.Add(userEncontrado);   
            }

            Conexao.Close();  //fechar conexao

            return Lista;   //retornar Lista de usuarios
           
        }
        */


        public void inserir(Contato interesse) {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao
            
            //definir query "insert into tabela (campo1,campo2) Values (info1,info2)";
            String Query= "insert into Contato (Nome,Email,Telefone,Mensagem,Queremkt) values (@Nome,@Email,@Telefone,@Mensagem,@Queremkt)";

            //comando e os controles para sql-injection
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Nome",interesse.Nome); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Email", interesse.Email); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Telefone", interesse.Telefone); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Mensagem", interesse.Mensagem); //controle para 
            Comando.Parameters.AddWithValue("@Queremkt", interesse.Queremkt); //controle para 

            Comando.ExecuteNonQuery(); //executar no banco de dados
            
            Conexao.Close();  //fechar conexao

        }


        /*
        public void atualizar(Usuario user){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao
            
            //definir query "update TABELA SET campo1=info1, campo2=info where Id=10";
            String Query= "Update Usuario SET Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento  Where Id=@Id";

            //comando e os controles para sql-injection
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",user.Id); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Nome",user.Nome); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Login",user.Login); //controle para sql-injection
            Comando.Parameters.AddWithValue("@Senha",user.Senha); //controle para sql-injection
            Comando.Parameters.AddWithValue("@DataNascimento",user.DataNascimento); //controle para 

            Comando.ExecuteNonQuery(); //executar no banco de dados
            
            Conexao.Close();  //fechar conexao

        }
        */

        /*
        public void remover(Usuario user){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abrir conexao

            //definir a query(sq)
            String Query = "delete from Usuario where Id=@Id";

            //definir comando
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Id",user.Id); //controle para sql-injection

            Comando.ExecuteNonQuery(); //executar no banco de dados
            
            Conexao.Close(); //fechar a conexao

        }
        */














    }
}