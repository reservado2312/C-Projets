using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcinario
{
    class ListarFuncionarios
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set;}
        public string? Cpf { get; set; }
        public string? Nndereco { get; set; }

        public static DataTable GetFuncionarios()
        { 
            var dt = new DataTable();

            var sql = "select id, nome, email, cpf, endereco from tbFuncionarios";
            try
            {
                using (var cn = new MySqlConnection(ConexaoBanco.meuServidor))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql,cn))
                    {
                        da.Fill(dt);
                    }
                }

            }
            catch (Exception ex)
            {
                //Devolve menssagem de erro caso ocorra algum erro do método a cima
                MessageBox.Show("Erro no metodo listar funcionarios: " + ex.Message);
            }
            return dt;
            
        
        }


    }
}
