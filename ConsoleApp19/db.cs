using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class db
    {
        internal static string SelectStuff(int ID)
        {
            int Cerberus = 0;
            string BudgetName=null;
            OpenConnection();
            SqlCommand getS = new SqlCommand("  SELECT BudgetName FROM Budgets WHERE ID = @ID", myConnection);
            getS.Parameters.Add("@ID", SqlDbType.VarChar);
            getS.Parameters["@ID"].Value = ID;
            SqlDataReader reader = getS.ExecuteReader();
            while (reader.Read())
            {
                BudgetName = reader.GetString(0);
                Cerberus++;
            }
            try
            {
                CloseConnection();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }
            if (Cerberus != 1)
            {
                if (Cerberus == 0)
                {
                    throw new LessThanOneBudgetNameException("Budget name does not exist");
                }
                else if (Cerberus > 1)
                {
                    throw new MoreThanOneBudgetNameException("Several of the same ID");
                }
            }
            return BudgetName;
        }
        public static SqlConnection myConnection;
        public static void OpenConnection()
        {
            myConnection = new SqlConnection(
                "Data Source=.;Initial Catalog=BudgetMan;Integrated Security=True"
                );
            myConnection.Open();
        }
        public static void CloseConnection()
        {
            myConnection.Close();
        }
    }
}
