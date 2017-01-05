using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado3LagenMonster
{
    public static class MonsterDB
    {
        private static SqlConnection connection = null;
        private static SqlCommand command = null;
        private static SqlDataReader reader = null;
        private static SqlTransaction transaction = null;

        

        public static int GetNextMonsterId()
        {
            int number;
            try
            {
                connection = ConnectDB.GetConnection();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(MonsterId) FROM ExamenJanuari.Monsters";
                number = (int)command.ExecuteScalar() + 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return number;
        }

        public static void InsertMonster(Monster mon)
        {
            try
            {
                connection = ConnectDB.GetConnection();
                connection.Open();
                transaction = connection.BeginTransaction("InsertMonster");
                command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = " SET IDENTITY_INSERT ExamenJanuari.Monsters ON;INSERT ExamenJanuari.Monsters(MonsterId,HP,Attack,Alive,Name) VALUES(@mId,@HP,@Att,@Alive,@Name)";
                command.Parameters.AddWithValue("@mId", mon.MonsterId);
                command.Parameters.AddWithValue("@HP",mon.HP);
                command.Parameters.AddWithValue("@Att", mon.Attack);
                command.Parameters.AddWithValue("@Alive", mon.Alive);
                command.Parameters.AddWithValue("@Name", mon.Name);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                try
                {
                    transaction.Rollback();
                    throw ex;
                }
                catch (Exception ex2)
                {
                    // Vangt overige exceptions op
                    throw ex2;
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
                if(command != null)
                {
                    command.Dispose();
                }
                if (transaction != null)
                {
                    transaction.Dispose();
                }
            }
        }

        public static void UpdateMonster(Monster mon)
        {
            try
            {
                connection = ConnectDB.GetConnection();
                connection.Open();
                transaction = connection.BeginTransaction("UpdateMonster");
                command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "UPDATE ExamenJanuari.Monsters SET " +    
                    "HP = @HP," +
                    "Attack = @Attack," +
                    "Alive = @Alive," +
                    "Name = @Name WHERE MonsterId = @id";
                command.Parameters.AddWithValue("@id", mon.MonsterId);
                command.Parameters.AddWithValue("@HP", mon.HP);
                command.Parameters.AddWithValue("@Attack", mon.Attack);
                command.Parameters.AddWithValue("@Alive", mon.Alive);
                command.Parameters.AddWithValue("@Name", mon.Name);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                try
                {
                    Console.WriteLine(ex.StackTrace);
                    transaction.Rollback();
                    throw ex;
                }
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
                if(command != null)
                {
                    command.Dispose();
                }
                if(transaction != null)
                {
                    transaction.Dispose();
                }
            }
        }

        public static void DeleteMonster(Monster mon)
        {
            try
            {
                connection = ConnectDB.GetConnection();
                connection.Open();
                transaction = connection.BeginTransaction("DeleteMonster");
                command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM ExamenJanuari.Monsters WHERE MonsterId = @id";
                command.Parameters.AddWithValue("@id", mon.MonsterId);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                try
                {
                    transaction.Rollback();
                    throw ex;
                }
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
                if(command != null)
                {
                    command.Dispose();
                }
                if(transaction != null)
                {
                    transaction.Dispose();
                }
            }

        }

        public static List<Monster> GetMonsters()
        {
            List<Monster> monsterList = new List<Monster>();
            try
            {
                command = new SqlCommand();
                command.CommandText = "SELECT * FROM ExamenJanuari.Monsters";
                connection = ConnectDB.GetConnection();
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Monster mon = new Monster();
                    mon.MonsterId = int.Parse(reader[0].ToString());
                    mon.HP = int.Parse(reader[1].ToString());
                    mon.Attack = int.Parse(reader["Attack"].ToString());
                    mon.Alive = bool.Parse(reader[3].ToString());
                    mon.Name = reader["Name"].ToString();
                    monsterList.Add(mon);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
                if(command != null)
                {
                    command.Dispose();
                }
            }
            return monsterList;
        }




    }
}
