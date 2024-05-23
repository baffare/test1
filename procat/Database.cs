using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procat
{
    internal class Database
    {
        string conn = @"Data Source=DESKTOP-949SEK0; Initial Catalog=prokat; Integrated Security=True";


        public ArrayList GetConnection()
        {
            ArrayList all = new ArrayList();
            using(SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Zakaz", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord reault in dr)
                            all.Add(reault);
                }
                catch
                {
                }
            }
            return all;
        }

        public bool Getzakaz(int ID, string kodZakaz,string datecreate, string timeZakaz, int idClient, int Uslugs, string Status, string dateClose, string timeProkat, int Price, string adressInfoZakaz)
        {
            bool flag = true;
            string dobavlenie = string.Format("INSERT INTO Zakaz (ID, kodZakaz, datecreate, timeZakaz, idClient, Uslugs, Status, dateClose, timeProkat, Price, adressInfoZakaz ) " +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                ID, kodZakaz, datecreate, timeZakaz, idClient, Uslugs, Status, dateClose, timeProkat, Price, adressInfoZakaz);
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand com = new SqlCommand(dobavlenie, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) 
                        flag = true;
                }
                catch { }

            }
            return flag;
        }

        public Boolean Delzakaz(string kodZakaz)
        {
            Boolean flag = false;
            string acc = string.Format("DELETE FROM Zakaz Where kodZakaz = '" + kodZakaz + "'");
            using (SqlConnection con =new SqlConnection(conn))
            {
                SqlCommand com = new SqlCommand(acc, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flag = true;
                }
                catch { }
            }
            return flag;
        }
        
    }
    }

