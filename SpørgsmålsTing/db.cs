using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpørgsmålsTing
{
    class db
    {
        public static SqlConnection myConnection;
        public static void OpenConnection()
        {
            myConnection = new SqlConnection(
                "Data Source=.;Initial Catalog=SpoergsmaalTing;Integrated Security=True"
                );
            myConnection.Open();
        }
        internal static Question GetQuestion(Question nQ)
        {
            Question quest = new Question();
            OpenConnection();
            SqlCommand GetQ = new SqlCommand("SELECT * FROM [QuestionsAnswers]", myConnection);
            GetQ.Parameters.Add("@Question nr#", SqlDbType.Int);
            GetQ.Parameters["@[Question nr#]"].Value = nQ.QuestionNumber;
            GetQ.Parameters.Add("@Spoergsmaal", SqlDbType.VarChar);
            GetQ.Parameters["@Spoergsmaal"].Value = nQ.Spoergsmaal;
            GetQ.Parameters.Add("@Answer1", SqlDbType.VarChar);
            GetQ.Parameters["@Answer1"].Value = nQ.Answer1;
            GetQ.Parameters.Add("@Answer2", SqlDbType.VarChar);
            GetQ.Parameters["@Answer2"].Value = nQ.Answer2;
            GetQ.Parameters.Add("@Answer3", SqlDbType.VarChar);
            GetQ.Parameters["@Answer3"].Value = nQ.Answer3;
            GetQ.Parameters.Add("@CorrectAnswer", SqlDbType.VarChar);
            GetQ.Parameters["@CorrectAnswer"].Value = nQ.CorrectAnswer;
            SqlDataReader reader = GetQ.ExecuteReader();
            if (reader.Read())
            {
                quest.QuestionNumber = reader.GetInt32(1);
                quest.Spoergsmaal = reader.GetString(2);
                quest.Answer1 = reader.GetString(3);
                quest.Answer2 = reader.GetString(4);
                quest.Answer3 = reader.GetString(5);
                quest.CorrectAnswer = reader.GetString(6);
            }
            CloseConnection();
            return quest;
        }
        public static void CloseConnection()
        {
            myConnection.Close();
        }
    }
}
