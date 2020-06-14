using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencao.Utilidade
{
    class DefProd
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public String definirProd(String produto, String quantidade)
        {
            
            cmd.CommandText = "insert into tbl_Producao_Mensal values (@produto, @quantidade);";
            cmd.Parameters.AddWithValue("@produto", produto);           
            cmd.Parameters.AddWithValue("@quantidade", quantidade);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados";
            }
            return mensagem;
        }
    }
}
