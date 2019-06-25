using Dapper;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OZero.QuizMarking
{
    public class GetMarkesForUser
    {
        ILog _log;
        public GetMarkesForUser(ILog log)
        {
            _log = log;
        }
        public decimal GetMarks(int Eventid, int UserID)
        {
            try
            {
                string query = "select sum(Marks) from anslog where and UsersID = " + UserID + " and eventid =" + Eventid;
                using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
                {
                    decimal marks = connection.Query<decimal>(query).FirstOrDefault();
                    return marks;
                }
            }
            catch (Exception ex)
            {
                _log.Error("exception occur while getting the marks for user " + ex.Message + " /n inner ex: " + ex.InnerException.Message, ex);
                throw ex;
            }
        }
    }
}