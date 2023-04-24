using Microsoft.Extensions.Configuration;
using SK2EVERYONE.Model.HIHs;
using System.Data.SqlClient;

namespace SK2EVERYONE.DAL.HIHs
{
    interface IHIHSrcDb
    {
        IEnumerable<HIH> GetAllHIH();
    }

    public class HIHSrcDb : IHIHSrcDb
    {
        public string connectionStringSourceSql;
        public HIHSrcDb(IConfiguration config) 
        {
            connectionStringSourceSql = config["ConnectionStrings:SourceSqlDb"];
        }

        //TODO: Radek, implement correct IEnumerable
        public IEnumerable<HIH> GetAllHIH()
        {
            List<HIH> hihList = new List<HIH>();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionStringSourceSql))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT T.KOC0441, T.NAC044101, T.NAC044102, T3.KOC0440 FROM A00C0441 T LEFT JOIN A00C0440 T3 ON(T3.ICI0000 = T.ODI0440)";
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        hihList.Add(new HIH
                        {
                            Id = rdr[0].ToString(),
                            Name = rdr[1].ToString(),
                            Region = rdr[2].ToString(),
                            IdWithoutRegion = rdr[3].ToString()
                        });
                    }
                }

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }
            return hihList;
        }
    }
}
