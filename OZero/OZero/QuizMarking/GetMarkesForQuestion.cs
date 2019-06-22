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

        public decimal GetMarks(int questionid, int EventUserID)
        {
            string query = "select sum(Marks) from anslog where QuestionID = "+ questionid + " and EventUsersID = "+ EventUserID;
            using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
            {
                decimal marks = connection.Query<decimal>(query).FirstOrDefault();
                return marks;
            }
        }
    }
}