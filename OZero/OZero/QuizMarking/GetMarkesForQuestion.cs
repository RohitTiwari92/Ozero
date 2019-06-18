using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace OZero.QuizMarking
{
    public class GetMarkesForQuestion
    {
        public GetMarkesForQuestion()
        {

        }

        public float GetMarks(int questionid, string ans,bool IsCorrect)
        {
            string query = "";
            using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
            {
                return 0;
            }
        }
    }
}