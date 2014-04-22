using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ChatSignalR.DAO.Hubs
{
    public class ChatDAO
    {
        private string _urlConexao;

        public ChatDAO()
        {
            _urlConexao = ConfigurationManager.ConnectionStrings["ChatConnection"].ToString();
        }

        public long AdicionarMensagem(string remetente, string mensagem, DateTime dataHora)
        {
            long id = 0;
            using (MySqlConnection conn = new MySqlConnection(_urlConexao))
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spInserirMensagem";

                MySqlParameter p1 = new MySqlParameter("_remetente", MySqlDbType.VarChar);
                p1.Value = remetente;

                MySqlParameter p2 = new MySqlParameter("_mensagem", MySqlDbType.VarChar);
                p2.Value = mensagem;

                MySqlParameter p3 = new MySqlParameter("_dtHora", MySqlDbType.DateTime);
                p3.Value = dataHora;


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                id = cmd.LastInsertedId;

            }

            return id;
        }
    }
}