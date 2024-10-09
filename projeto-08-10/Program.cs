using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace projeto_08_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao;
            MySqlCommand cmd;
            conexao = new MySqlConnection("server=localhost; Database=adega; Uid = root; pwd = ''");

            try
            {
                conexao.Open();
                Console.WriteLine("conectado");
                
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }

            string sql;
            sql = "select * from bebidas";
            cmd = new MySqlCommand(sql,conexao);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();

            while (rdr.Read()) { 
            Console.WriteLine("id da bebida:" + rdr["cod_bebida"] + "\n");
            Console.WriteLine("nome da bebida:" + rdr["nome_bebida"] + "\n tipo da bebida:" + rdr["tipo_bebida"] +"\n");
            
            }
            Console.ReadKey();

        }
    }
}
