using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OZero.Answer
{
    public class SaveAnswer
    {
        public SaveAnswer()
        {

        }
        public void save(int eid,int qid,int euid,string ans)
        {
            string query = Getquery(qid, euid, ans);
            using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
            {
                var affrows = connection.Execute(query);
            }
        }

        private string  Getquery(int qid, int euid, string ans)
        {
            return @"insert into AnsLog (EventID,QuestionID,EventUsersID,Ans,AnsStatus,AttemptCount,Marks)
                values(
                eid,
                qid,
                euid,
                ans,
                select
                 case 
                when(select count(*) from TableQuestions where QuestionID = " + qid + " and Ans ='" + ans + @"') = 1 then
                1
                else
                0
                end,

                select count(*) + 1 from AnsLog where QuestionID = " + qid + " and EventUsersID =" + euid + @" ,
                select
                 case 
                when(select count(*) from TableQuestions where  QuestionID = " + qid + " and Ans ='" + ans + @"') = 1 then
                select maxmarks from QuestionsSettings where QuestionSettingID = (select QuestionSettingID from TableQuestions where QuestionID = " + qid + @"  )
                else
                 select NegativeMarksForWrongAns from QuestionsSettings where QuestionSettingID = (select QuestionSettingID from TableQuestions where QuestionID = " + qid + @" ) end
                 )";
             
        }
    }
}