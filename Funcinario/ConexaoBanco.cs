using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcinario
{
    static class ConexaoBanco
    {
        //4 Variaveis declaradas passando as informações do banco de dados
        private const string servidor = "localhost";
        private const string bancoDados = "dbFuncionarios";
        private const string usuario = "root";
        private const string senha = "";

        //Variavel com toda a String de conexão do banco de dados
        static public string meuServidor = $"server={servidor}; user id={usuario}; database={bancoDados};password={senha} ";           


    }
}
