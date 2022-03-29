using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CG.Classes
{
    class mssqlconect
    {
        private SqlConnection conectar;

        public void conectdb()
        {
            //conectar = new SqlConnection(@"Data Source=SERVIDOR-GESTSE\SQLEXPRESS;Initial Catalog=vetorh_teste;Persist Security Info=True;User ID=vetorh;Password=vetorh");
            conectar = new SqlConnection(@"Password=vetorh;Persist Security Info=True;User ID=vetorh;Initial Catalog=vetorh;Data Source=SERVIDOR-GESTSE\SQLEXPRESS");
            if (conectar.State == ConnectionState.Closed)
                conectar.Open();
        }

        public DataTable ConsultaTabela(string dadosmssql)
        {
            conectdb();
            SqlDataAdapter consulta = new SqlDataAdapter(dadosmssql, conectar);
            DataTable tabela = new DataTable();
            consulta.Fill(tabela);
            conectar.Close();
            return tabela;

        }
    }
}
