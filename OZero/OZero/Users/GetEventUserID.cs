using Dapper;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OZero.Users
{
    public class GetEventUser
    {
        ILog _log;
        public GetEventUser(ILog log)
        {
            _log = log;
        }
        public int  GetID(int Userid, int eventid)
        {
            try
            {
                string query = "select top 1 eventuserid from TableEventUsers where Userid= " + Userid + " Eventid="+ eventid;
                using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
                {
                    int marks = connection.Query<int>(query).FirstOrDefault();
                    return marks;
                }
            }
            catch (Exception ex)
            {
                _log.Error("exception occur while getting the Event user id " + ex.Message + " /n inner ex: " + ex.InnerException.Message, ex);
                throw ex;
            }
        }
    }
}