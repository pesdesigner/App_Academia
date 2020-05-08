using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace App_Projeto
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\C#\\Application\\App_Academia\\App_Projeto\\banco\\banco_academia.db");
            conexao.Open();
            return conexao;
        }
    }
}
