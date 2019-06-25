using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using log4net;
using OZero.Models;

namespace OZero.Question
{
    public class GetQuestion

    {
        ILog _log;
        public GetQuestion(ILog log)
        {
            _log = log;
        }
        public QuestionModel GetNextQuestion(int qid,int eventid)
        {
            QuestionModel question = new QuestionModel();
            string query = "select QuestionID ,EventID ,Question ,QuestionType ,Option1 ,Option2 ,Option3 ,Option4  from TableQuestions  where QuestionID > " + qid + " and EventID ="+ eventid +"  order by QuestionID";
            question=RunQuery(query);
            return question;
        }

        public QuestionModel GetPreviousQuestion(int qid, int eventid)
        {
            QuestionModel question = new QuestionModel();
            string query = "select QuestionID ,EventID ,Question ,QuestionType ,Option1 ,Option2 ,Option3 ,Option4  from TableQuestions  where QuestionID < " + qid + " and EventID =" + eventid + "  order by QuestionID";
            question = RunQuery(query);
            return question;
        }

        QuestionModel RunQuery(string query)
        {
            try
            {
                using (var connection = new SqlConnection(HelperClasses.ConnectionHelper.ConnectionString()))
                {
                    QuestionModel model = connection.Query<QuestionModel>(query).FirstOrDefault();
                    return model;
                }
            }
            catch (Exception ex)
            {
                _log.Error("exception occur while getting the question " + ex.Message + " /n inner ex: " + ex.InnerException.Message, ex);
                throw ex;
            }
        }
    }
}