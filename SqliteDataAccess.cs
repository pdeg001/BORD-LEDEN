using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace scorebord_leden
{
    public class SqliteDataAccess
    {
        public static List<ClubModel> LoadClubs()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
               // var output = cnn.Query<ClubModel>("SELECT * FROM vereniging", new DynamicParameters());
                var output = cnn.Query<ClubModel>("select vereniging.*, count(leden.Name) as ledenCount from vereniging vereniging left join leden leden on leden.Ver_Id = vereniging.id group by 1", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveClub(ClubModel clubs)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO vereniging (Naam) VALUES (@Naam)", clubs);
            }
        }

        public static void UpdateClub(ClubModel clubs)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE vereniging SET Naam = @Naam WHERE Id = @Id", clubs);
            }
        }

        public static void DeleteClub(ClubModel clubs)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM vereniging WHERE Id = @Id", clubs);
            }
        }


        public static List<LedenModel> GetLeden(LedenModel lm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<LedenModel>("SELECT * FROM leden WHERE Ver_Id = @IdClub", lm); // new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveLeden(LedenModel lm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO leden (Name, Ver_id) VALUES (@Name, @IdClub)", lm);
            }
        }

        public static void UpdateLeden(LedenModel lm)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE leden SET Name = @Name WHERE Id = @Id", lm);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
