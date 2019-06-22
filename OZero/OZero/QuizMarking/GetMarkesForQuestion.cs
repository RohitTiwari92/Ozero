using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using log4net;

namespace OZero.QuizMarking
{
    public class GetMarkesForQuestion
    {
        ILog _log;
        public GetMarkesForQuestion(ILog log)
        {
            _log = log;
        }

        public decimal GetMarks(int questionid, int EventUserID)
        {
            try
            {
                string query = "select sum(Marks) from anslog where QuestionID = " + questionid + " and EventUsersID = " + EventUserID;
                using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
                {
                    decimal marks = connection.Query<decimal>(query).FirstOrDefault();
                    return marks;
                }
            }
            catch (Exception ex)
            {
                _log.Error("exception occur while getting the marks for question " + ex.Message + " /n inner ex: " + ex.InnerException.Message, ex);
                throw ex;
            }
        }
    }
}