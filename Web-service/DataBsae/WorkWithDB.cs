using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Npgsql;
using System.Data.Common;
using System.Data;

namespace DataBsae
{
    public class WorkWithDB
    {

        public static int InsertUser(string login, string password, string first_name, string last_name, string role)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";
            int ans;

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("INSERT INTO Users(login, password, first_name, last_name, role) VALUES (@login, @password, @first_name, @last_name, @role)", npgSqlConnection);

                NpgsqlParameter loginParam = new NpgsqlParameter("@login", login);
                npgSqlCommand.Parameters.Add(loginParam);

                NpgsqlParameter passwordParam = new NpgsqlParameter("@password", password);
                npgSqlCommand.Parameters.Add(passwordParam);

                NpgsqlParameter fnParam = new NpgsqlParameter("@first_name", first_name);
                npgSqlCommand.Parameters.Add(fnParam);

                NpgsqlParameter lnParam = new NpgsqlParameter("@last_name", last_name);
                npgSqlCommand.Parameters.Add(lnParam);

                NpgsqlParameter roleParam = new NpgsqlParameter("@role", role);
                npgSqlCommand.Parameters.Add(roleParam);

                int count = npgSqlCommand.ExecuteNonQuery();

                if (count == 1)
                    ans = 1;
                else
                    ans = 0;

                return ans;
            }
        }

        public static List<string[]> Select()
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";
            List<string[]> r = new List<string[]>();
            string[] f;

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM Users", npgSqlConnection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
                               
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    f = new string[] { Convert.ToString(dbDataRecord["login"]), Convert.ToString(dbDataRecord["password"]), Convert.ToString(dbDataRecord["first_name"]), Convert.ToString(dbDataRecord["last_name"]), Convert.ToString(dbDataRecord["role"]) };

                    r.Add(f);
                }
                
                return r;
            }
        }

        public static string[] FindUser(string login, string password)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";           
            string[] f = new string[] { "NULL" };

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM Users WHERE (login = @login) AND (password = @password)", npgSqlConnection);

                NpgsqlParameter loginParam = new NpgsqlParameter("@login", login);
                npgSqlCommand.Parameters.Add(loginParam);

                NpgsqlParameter passwordParam = new NpgsqlParameter("@password", password);
                npgSqlCommand.Parameters.Add(passwordParam);

                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                if (npgSqlDataReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    {
                        f = new string[] { Convert.ToString(dbDataRecord["login"]), Convert.ToString(dbDataRecord["password"]), Convert.ToString(dbDataRecord["first_name"]), Convert.ToString(dbDataRecord["last_name"]), Convert.ToString(dbDataRecord["role"]) };
                    }
                }                                
            }

            return f;
        }

        public static void UpdateUser(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"UPDATE Users SET role = 1 WHERE login = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", id);
                npgSqlCommand.Parameters.Add(idParam);

                npgSqlCommand.ExecuteNonQuery();
            }
        }

        public static List<string[]> SelectAdmins()
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";
            List<string[]> r = new List<string[]>();
            string[] f;

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM Users WHERE role = '1'", npgSqlConnection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    f = new string[] { Convert.ToString(dbDataRecord["login"]), Convert.ToString(dbDataRecord["first_name"]), Convert.ToString(dbDataRecord["last_name"])};

                    r.Add(f);
                }

                return r;
            }
        }

        public static void DeleteAdmin(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"UPDATE Users SET role = 2 WHERE login = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", id);
                npgSqlCommand.Parameters.Add(idParam);

                npgSqlCommand.ExecuteNonQuery();
            }
        }

 




        public static void InsertLink(string passport, string number_of_order)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO Link(number_of_order, passport) VALUES (@number_of_order, @passport)", npgSqlConnection);

                NpgsqlParameter numParam = new NpgsqlParameter("@number_of_order", number_of_order);
                npgSqlCommand.Parameters.Add(numParam);

                NpgsqlParameter passParam = new NpgsqlParameter("@passport", passport);
                npgSqlCommand.Parameters.Add(passParam);

                npgSqlCommand.ExecuteNonQuery();
            }
        }

        public static List<string[]> SelectLink()
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";
            List<string[]> r = new List<string[]>();
            string[] f;

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT Users.login, Users.first_name, Users.last_name, Parcel.number_of_order, Parcel.name, Parcel.warehouse, Parcel.date_of_arriving FROM Users JOIN Link ON Users.login = Link.passport JOIN Parcel ON Link.number_of_order = Parcel.number_of_order", npgSqlConnection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    f = new string[] { Convert.ToString(dbDataRecord["login"]), Convert.ToString(dbDataRecord["first_name"]), Convert.ToString(dbDataRecord["last_name"]), Convert.ToString(dbDataRecord["number_of_order"]), Convert.ToString(dbDataRecord["name"]), Convert.ToString(dbDataRecord["warehouse"]), Convert.ToString(dbDataRecord["date_of_arriving"])};

                    r.Add(f);
                }

                return r;
            }
        }

        public static void DeleteLink(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"DELETE FROM Link WHERE number_of_order = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", id);
                npgSqlCommand.Parameters.Add(idParam);

                npgSqlCommand.ExecuteNonQuery();
            }
        }





        public static void InsertParcel(string id, string name, string warehouse, DateTime date)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {

                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO Parcel(number_of_order, name, warehouse, date_of_arriving) VALUES (@id, @name, @warehouse, @date)", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", id);
                npgSqlCommand.Parameters.Add(idParam);

                NpgsqlParameter nameParam = new NpgsqlParameter("@name", name);
                npgSqlCommand.Parameters.Add(nameParam);

                NpgsqlParameter whParam = new NpgsqlParameter("@warehouse", warehouse);
                npgSqlCommand.Parameters.Add(whParam);

                NpgsqlParameter dateParam = new NpgsqlParameter("@date", date);
                npgSqlCommand.Parameters.Add(dateParam);

                npgSqlCommand.ExecuteNonQuery();


                npgSqlCommand = new NpgsqlCommand($"INSERT INTO Parcel(number_of_order, name, warehouse, date_of_arriving) VALUES (@id, @name, @warehouse, @date)", npgSqlConnection);
            }
        }

        public static List<string[]> SelectParcels()
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";
            List<string[]> r = new List<string[]>();
            string[] f;

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM Parcel", npgSqlConnection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    f = new string[] { Convert.ToString(dbDataRecord["number_of_order"]), Convert.ToString(dbDataRecord["name"]), Convert.ToString(dbDataRecord["warehouse"]), Convert.ToString(dbDataRecord["date_of_arriving"]) };

                    r.Add(f);
                }

                return r;
            }
        }

        public static List<string[]> SelectUserParcels(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";
            List<string[]> r = new List<string[]>();
            string[] f;

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT Parcel.number_of_order, Parcel.name, Parcel.warehouse, Parcel.date_of_arriving FROM Parcel JOIN Link ON Link.passport = @id AND  Link.number_of_order = Parcel.number_of_order", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", id);
                npgSqlCommand.Parameters.Add(idParam);

                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    f = new string[] { Convert.ToString(dbDataRecord["number_of_order"]), Convert.ToString(dbDataRecord["name"]), Convert.ToString(dbDataRecord["warehouse"]), Convert.ToString(dbDataRecord["date_of_arriving"]) };

                    r.Add(f);
                }

                return r;
            }
        }

        public static void DeleteParcel(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"DELETE FROM Parcel WHERE number_of_order = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", id);
                npgSqlCommand.Parameters.Add(idParam);

                npgSqlCommand.ExecuteNonQuery();
            }
        }




        public static void InsertWarehouse(string address, string capacity)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";
            

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {

                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO Warehouses(address, capacity, fullness) VALUES (@address, @capacity, 0)", npgSqlConnection);

                NpgsqlParameter addressParam = new NpgsqlParameter("@address", address);
                npgSqlCommand.Parameters.Add(addressParam);

                NpgsqlParameter capaParam = new NpgsqlParameter("@capacity", capacity);
                npgSqlCommand.Parameters.Add(capaParam);

                npgSqlCommand.ExecuteNonQuery();                               
            }
        }

        public static List<string[]> SelectWarehouses()
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";
            List<string[]> r = new List<string[]>();
            string[] f;

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM Warehouses", npgSqlConnection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    f = new string[] { Convert.ToString(dbDataRecord["number_of_warehouse"]), Convert.ToString(dbDataRecord["address"]), Convert.ToString(dbDataRecord["capacity"]), Convert.ToString(dbDataRecord["fullness"])};
                    
                    r.Add(f);
                }

                return r;
            }
        }
        
        public static void AddInWarehouse(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT * FROM Warehouses WHERE number_of_warehouse = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", Convert.ToInt32(id));
                npgSqlCommand.Parameters.Add(idParam);

                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    int a = Convert.ToInt32(dbDataRecord["fullness"]);
                    a++;

                    string temp = Convert.ToString(a);

                    Add(id, temp);
                }
            }

            
        }

        public static void Add(string id, string temp)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"UPDATE Warehouses SET fullness = @temp WHERE number_of_warehouse = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", Convert.ToInt32(id));
                npgSqlCommand.Parameters.Add(idParam);

                NpgsqlParameter tempParam = new NpgsqlParameter("@temp", temp);
                npgSqlCommand.Parameters.Add(tempParam);

                npgSqlCommand.ExecuteNonQuery();
            }
        }

        public static void DelInWarehouse(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT warehouse FROM Parcel WHERE number_of_order = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", id);
                npgSqlCommand.Parameters.Add(idParam);

                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    PreDel(Convert.ToString(dbDataRecord["warehouse"]));                  
                }
            }
        }

        public static void PreDel(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT * FROM Warehouses WHERE number_of_warehouse = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", Convert.ToInt32(id));
                npgSqlCommand.Parameters.Add(idParam);

                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    int a = Convert.ToInt32(dbDataRecord["fullness"]);
                    a--;

                    if (a < 0)
                        a = 0;

                    string temp = Convert.ToString(a);

                    Del(id, temp);
                }
            }
        }

        public static void Del(string id, string temp)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"UPDATE Warehouses SET fullness = @temp WHERE number_of_warehouse = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", Convert.ToInt32(id));
                npgSqlCommand.Parameters.Add(idParam);

                NpgsqlParameter tempParam = new NpgsqlParameter("@temp", temp);
                npgSqlCommand.Parameters.Add(tempParam);

                npgSqlCommand.ExecuteNonQuery();
            }
        }

        public static void DeleteWarehouse(string id)
        {
            String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3468;Database=postgres;";

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"DELETE FROM Warehouses WHERE number_of_warehouse = @id", npgSqlConnection);

                NpgsqlParameter idParam = new NpgsqlParameter("@id", Convert.ToInt32(id));
                npgSqlCommand.Parameters.Add(idParam);

                npgSqlCommand.ExecuteNonQuery();
            }
        }  
    }
}
