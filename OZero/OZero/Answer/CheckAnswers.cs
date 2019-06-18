using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using OZero.HelperClasses;
namespace OZero.Answer
{
    public class CheckAnswers
    {
        public CheckAnswers()
        {
            //code for log 
        }
        public bool check(int qid, string ans)
        {
            string query = "select count(*) from tablequestions where questionid="+qid+" and ans='" + ans+"'";
            using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
            {
                int Count = connection.Query<int>(query).FirstOrDefault();
                if (Count == 0)
                    return false;
                else
                   return  true;
            }
        }
    }
}