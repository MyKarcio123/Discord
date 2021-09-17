using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace Discord
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string sslmode;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "discord";
            uid = "admin";
            password = "admin123";
            sslmode = "none";

            string connectionString;
            connectionString = "datasource=" + server + ";" + "DATABASE=" + database + ";" 
            + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SslMode=" + sslmode + "";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        /*
        //Insert statement
        public void Insert()
        {
        }
        /*
        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }
        //Select statement
        public List<string>[] Select(string col,string table)
        {
        }
        */
        //Count statement
        public (int,string,byte[]) Auth(string login, string password)
        {
            byte[] image = null;
            string pwd;
            string query;
            string username = "";
            int id=-1;
            if (this.IsValidEmail(login))
            {
                query = "select ID,password,username,photo from users where mail = '" + login + "'";
            }
            else
            {
                return (id, username, image);
            }
            if(this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                try { 
                    rdr.Read();
                    pwd = rdr.GetString(1);
                    username = rdr.GetString(2);
                    image = (byte[])(rdr["photo"]);
                    if (BCrypt.Net.BCrypt.Verify(password, pwd))
                    {
                        id = rdr.GetInt32(0);
                        this.CloseConnection();
                        return (id,username, image);
                    }
                    else
                    {
                        this.CloseConnection();
                        return (id, username, image);
                    }
                }
                catch
                {
                    this.CloseConnection();
                    return (id, username, image);
                }
            }
            else
            {
                return (id, username, image);
            }
            
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public int IsUserExist(string mail)
        {
            if (this.OpenConnection())
            {
                string query;
                query = "SELECT COUNT(id) from users where mail='"+mail+"'";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                var result = cmd.ExecuteScalar().ToString();
                if (result == "0")
                {
                    this.CloseConnection();
                    return 0;
                }
                else
                {
                    this.CloseConnection();
                    return 1;
                }
            }
            else
            {
                return 11;
            }
        }
        public bool AddUser(string mail, string username,string password,string day,string month,string year)
        {
            if (this.OpenConnection())
            {
                password = BCrypt.Net.BCrypt.HashPassword(password);
                if (day.Length==1)
                {
                    day = "0" + day;
                }
                month = GetMonthNumber_From_MonthName(month);
                string date = year + "-" + month + "-" + day;
                string query = "INSERT INTO `users` (`ID`, `username`, `mail`, `phone`, `dob`, `photo`, `description`, `status`, `password`) VALUES (NULL, '"+username+"', '"+mail+ "', NULL, '"+date+"', 'NULL', 'NULL', 'online', '"+password+"')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }
        private string GetMonthNumber_From_MonthName(string month)
        {
            int monthNumber = 0;
            monthNumber = DateTime.ParseExact(month, "MMMM", new CultureInfo("en-US")).Month;
            return monthNumber.ToString();
        }

        public List<string[]> friendList(int id,int type)
        {
            if (this.OpenConnection())
            {
                List<string[]> results = new List<string[]>();
                string query;
                if (type == 0)
                {
                    //online
                    query = "SELECT username,photo,description,ID FROM users WHERE users.ID IN ((SELECT firstID FROM friends WHERE secondID = " + id.ToString() + " AND type =0) UNION (SELECT secondID FROM friends WHERE firstID=" + id.ToString() + " AND type =0)) AND status = 'online' ORDER BY username desc";
                }
                else if (type == 1)
                {
                    //all
                    query = "SELECT username,photo,description,ID FROM users WHERE users.ID IN ((SELECT firstID FROM friends WHERE secondID = " + id.ToString() + " AND type =0) UNION (SELECT secondID FROM friends WHERE firstID=" + id.ToString() + " AND type =0)) ORDER BY username desc";
                }
                else if (type == 2)
                {
                    //pedning
                    query = "SELECT username,photo,description,ID FROM users WHERE users.ID IN ((SELECT firstID FROM friends WHERE secondID = " + id.ToString() + " AND type =1) UNION (SELECT secondID FROM friends WHERE firstID=" + id.ToString() + " AND type =1)) ORDER BY username desc";
                }
                else
                {
                    //block
                    query = "SELECT username,photo,description,ID FROM users WHERE users.ID IN ((SELECT firstID FROM friends WHERE secondID = " + id.ToString() + " AND type =2) UNION (SELECT secondID FROM friends WHERE firstID=" + id.ToString() + " AND type =2)) ORDER BY username desc";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string[] queryResult = new string[4];
                    queryResult[0] = rdr.GetString(0);
                    string result = Convert.ToBase64String((byte[])(rdr["photo"]));
                    Console.WriteLine(result);
                    queryResult[1] = result;
                    queryResult[2] = rdr.GetString(2);
                    queryResult[3] = rdr.GetString(3);
                    results.Add(queryResult);
                }
                this.CloseConnection();
                return results;
            }
            else
            {
                List<string[]> results = new List<string[]>();
                return results;
            }
        }
    }
}
