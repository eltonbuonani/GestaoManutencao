using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencao.Utilidade
{
    class AbrirOrdem
    {           
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        //SqlDataReader dr;

        public String abrirOrdem(String descricao, String tipo, String setor, String pessoa, String criticidade, String data, String descrServico, String pecasNecessarias, String equipamento)
        {
            string  SQL = "insert into tbl_Ordem ( ID_Usuario, ord_Data, ID_Criticidade, ord_Tipo, ord_Pecas, ord_Descricao, ord_Setor, ";
                    SQL += "  ord_Descricao_Servico, ord_Equipamento) values ( @pessoa, @data, @criticidade, @tipo, @pecas, @descricao, @setor, ";
                    SQL += " @descrServico, @equipamento);";
   
            tem = false;
            cmd.CommandText = SQL.ToString();
            cmd.Parameters.AddWithValue("@pessoa", pessoa);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@criticidade", criticidade);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@pecas", pecasNecessarias);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@setor", setor);
            cmd.Parameters.AddWithValue("@descrServico", descrServico);
            cmd.Parameters.AddWithValue("@equipamento", equipamento);

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
