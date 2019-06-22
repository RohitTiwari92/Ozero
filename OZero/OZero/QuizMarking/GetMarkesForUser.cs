using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OZero.QuizMarking
{
    public class GetMarkesForUser
    {
        public GetMarkesForUser()
        {

        }
        public decimal GetMarks(int Eventid, int EventUserID)
        {
            string query = "select sum(Marks) from anslog where and EventUsersID = " + EventUserID + " and eventid =" + Eventid;
            using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
            {
                decimal marks = connection.Query<decimal>(query).FirstOrDefault();
                return marks;
            }
        }
    }
}