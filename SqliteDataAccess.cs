using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace scorebord_leden
{
    public class SqliteDataAccess
    {
        public static List<Clubs> LoadClubs()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Clubs>("SELECT * FROM vereniging", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveClub(Clubs clubs)
        {
            string Name = "Verenigings Naam";
            string col = "Naam";
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO vereniging (Naam) VALUES ({Name})", clubs);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
