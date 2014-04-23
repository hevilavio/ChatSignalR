using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web; 

namespace ChatSignalR.DAO
{
    public class DdosDAO
    {
    //    string _urlConexao;
    //    public DdosDAO()
    //    {
    //        _urlConexao = ConfigurationManager.ConnectionStrings["ChatConnection"].ToString();
    //    }

        public long InserirDados(string dados)
        {
    //        long id = 0;
    //        using (MySqlConnection conn = new MySqlConnection(_urlConexao))
    //        {
    //            MySqlCommand cmd = conn.CreateCommand();
    //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //            cmd.CommandText = "spInserirDadoDDOS";

    //            MySqlParameter p1 = new MySqlParameter("_dados", MySqlDbType.VarChar);
    //            p1.Value = dados;


    //            cmd.Parameters.Add(p1);
                
    //            cmd.Connection.Open();
    //            cmd.ExecuteNonQuery();

    //            id = cmd.LastInsertedId;

    //        }
            
    //      return id;
            return 15;
        }
    }
}