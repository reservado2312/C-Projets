using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcinario
{
    internal class cadastroFuncionarios
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id 
        { 
            get { return id; } 
            set { id = value; }
        }

        public string Nome 
        { 
            get { return nome; } 
            set {  nome = value; } 
        }

        public string Email 
        {  
            get { return email; } 
            set {  email = value; }
        }

        public string Cpf 
        { 
            get {  return cpf; } 
            set {  cpf = value; }
        }

        public string Endereco 
        { 
            get {  return endereco; } 
            set {  endereco = value; } 
        }




        //Metodo para cadastrar funcionario 

        public bool cadastrarFuncionarios() 
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.meuServidor);
                MySqlConexaoBanco.Open();

                string insert = $"insert into tbFuncionarios(nome, email, cpf, endereco) values ('{Nome}','{Email}','{Cpf}','{Endereco}')";
                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;
                comandoSql.ExecuteNonQuery();
                //MySqlConexaoBanco.Close();
                return true;
            }
            catch (Exception ex)
            {
                //Retorna menssagem de erro caso não consiga cadastrar o funcionario no banco de dados
                //Possivelmmente problema no banco de dados
                MessageBox.Show("Erro no banco de dados - Metoto cadstrarFumcionario" + ex.Message);                
                return false;
            }
        }

        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.meuServidor);
                MySqlConexaoBanco.Open();

                string select = $"select id, nome, email, cpf, endereco from tbFuncionarios where cpf = '{Cpf}'";

                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;
                
                MySqlDataReader reader = comandoSql.ExecuteReader();
                //MySqlConexaoBanco.Close();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Metoto cadstrarFumcionario" + ex.Message);                
                return null;
            }
        }

        public bool atualizarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.meuServidor);
                MySqlConexaoBanco.Open();

                string update = $"update tbfuncionarios set email = '{Email}', endereco = '{Endereco}' where id = '{Id}'";

                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;
                comandoSql.ExecuteNonQuery();
                //MySqlConexaoBanco.Close();
                return true;
            }
            catch (Exception ex)
            {
                //Retorna Menssagem especificando qual erro
                MessageBox.Show("Erro no Banco de Dados - Método atualizar funcionario: " + ex.Message);                
                return false;
            }
        }

        public bool apagaFuncionario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.meuServidor);
                MySqlConexaoBanco.Open();

                string delete = $"delete from tbfuncionarios where id = '{Id}'";

                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;
                comandoSql.ExecuteNonQuery();
                //MySqlConexaoBanco.Close();
                return true;
            }
            catch (Exception ex)
            {
                //Retorna Menssagem especificando qual erro
                MessageBox.Show("Erro no Banco de Dados - Método Deletar funcionario: " + ex.Message);
                return false;
            }
        }

    }
}
