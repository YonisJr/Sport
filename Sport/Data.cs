using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Sport
{
    internal class Data
    {
        private NpgsqlConnection conn;

        public Data()
        {
            conn = new NpgsqlConnection("Host=localhost;Database=sport;Username=YonisJr;Password=0907;Port=5432");
        }

        public bool AuthenticateUser(string username, string password)
        {
            conn.Open();

            // Проверка учетных данных пользователя
            string sql = "SELECT COUNT(*) FROM employee WHERE login = @username AND parol = @password";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(command.ExecuteScalar());
                bool isAuthenticated = count > 0;

                // Если пользователь аутентифицирован, сохраняем его вход
                if (isAuthenticated)
                {
                    string insertLogSql = "INSERT INTO audit (id_emp, time) VALUES ((SELECT id_emp FROM employee WHERE login = @username), @loginTime)";
                    using (NpgsqlCommand insertLogCommand = new NpgsqlCommand(insertLogSql, conn))
                    {
                        insertLogCommand.Parameters.AddWithValue("@username", username);
                        insertLogCommand.Parameters.AddWithValue("@loginTime", DateTime.Now);
                        insertLogCommand.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                return isAuthenticated;
                
            }
            
        }
        

        public string GetEmployeePosition(string username)
        {
            conn.Open();
            string position = null;

            // Запрос для получения должности сотрудника
            string sql = "SELECT post FROM employee WHERE login = @username";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
            {
                command.Parameters.AddWithValue("@username", username);
                position = (string)command.ExecuteScalar();
            }
            conn.Close();
            return position;
        }
    }
}
