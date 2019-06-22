using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using log4net;
using OZero.HelperClasses;
namespace OZero.Answer
{
    public class CheckAnswers
    {
        ILog _log;
        public CheckAnswers(ILog log)
        {
            _log = log;
            //code for log 
        }
        public bool check(int qid, string ans)
        {
            try
            {
                string query = "select count(*) from tablequestions where questionid=" + qid + " and ans='" + ans + "'";
                using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
                {
                    int Count = connection.Query<int>(query).FirstOrDefault();
                    if (Count == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch(Exception ex)
            {
                _log.Error("exception occur while checking the ans " +ex.Message + " /n inner ex: " + ex.InnerException.Message,ex );
                throw ex;
            }
        }
    }
}