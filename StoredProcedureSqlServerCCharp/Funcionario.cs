using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureSqlServerCCharp
{
    public class Funcionario
    {
        public int ID;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Conjuge { get; set; }
        public string Filhos { get; set; }
        public string DataAdmissao { get; set; }



        public DataTable Buscar(string nome)
        {
            var dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.strConn))
                {
                    cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(null, cn))
                    {
                        da.SelectCommand.Connection = cn;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.CommandText = "pr_BuscarFuncionario"; // Nome da stored procedure corrigido
                        da.SelectCommand.Parameters.AddWithValue("@Nome", nome);

                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar os dados!\n\n" + ex.Message);
            }

            return dt;
        }
    }
}

    


