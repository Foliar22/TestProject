using System;
using System.Data.SqlClient;
using System.Reflection;

namespace TestProject.DataBase
{
    class DBconnection
    {



        private static string getLocation()
        {
            string location = AppDomain.CurrentDomain.BaseDirectory;
            if (location.EndsWith(@"bin\Debug\"))
            {
                location = location.Replace("bin\\Debug\\", "");
            }
            else if(location.EndsWith(@"bin\Release\"))
            {
                location = location.Replace("bin\\Release\\", "");
            }
            else
            {
                return location;
            }

            return location;
        }


        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+@getLocation()+@"LocalDataBase.mdf;Integrated Security=True");

    }
}
