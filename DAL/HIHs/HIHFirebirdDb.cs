using FirebirdSql.Data.FirebirdClient;
using SK2EVERYONE.BLL.HIHs;
using SK2EVERYONE.Model.HIHs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK2EVERYONE.DAL.HIHs
{
    public class HIHFirebirdDb
    {
        public string connectionStringFirebird;
        public HIHFirebirdDb()
        {
            connectionStringFirebird = AppConfig.GetConnectionStringFirebird();
        }

        public void InsertHIH()
        {
            try
            {
                using (FbConnection con = new FbConnection(@connectionStringFirebird)) 
                {
                    FbCommand cmd = new FbCommand();
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "insert into hih(id, name, region, idwithoutregion) values (@id, @name, @region, @idwithoutregion)";
                    cmd.Parameters.Add("@id", FbDbType.VarChar);
                    cmd.Parameters.Add("@name", FbDbType.VarChar);
                    cmd.Parameters.Add("@region", FbDbType.VarChar);
                    cmd.Parameters.Add("@idwithoutregion", FbDbType.VarChar);
                    con.Open();
                    List<HIH> hihList = new HIHBLL().GetAllHIH();
                    hihList.ForEach(hih =>
                    {
                        cmd.Parameters["@id"].Value = hih.Id;
                        cmd.Parameters["@name"].Value = hih.Name;
                        cmd.Parameters["@region"].Value = hih.Region;
                        cmd.Parameters["@idwithoutregion"].Value = hih.IdWithoutRegion;
                        cmd.ExecuteNonQuery();
                    });

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
