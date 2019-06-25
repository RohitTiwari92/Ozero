using log4net;
using OZero.Answer;
using OZero.Models;
using OZero.QuizMarking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OZero.Users;

namespace OZero.Controllers
{
    public class QuizController : Controller
    {
        private ILog _log;
        // GET: Quiz
        public ActionResult Index()
        {
            log4net.Config.XmlConfigurator.Configure();
            _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            return View();
        }

        QuestionModel GetNextQuestion(int eid,int qid=0)
        {
            Question.GetQuestion getQuestion = new Question.GetQuestion(_log);
            return getQuestion.GetNextQuestion(qid,eid);
        }
        QuestionModel GetPreviousQuestion(int eid, int qid = 0)
        {
            Question.GetQuestion getQuestion = new Question.GetQuestion(_log);
            return getQuestion.GetPreviousQuestion(qid, eid);
        }

        bool CheckAns(int qid,string ans)
        {
            CheckAnswers Cans = new CheckAnswers(_log);
            return Cans.check(qid, ans);
        }

        decimal GetUserMarks(int Eventid, int UserID)
        {
            GetMarkesForUser umarks = new GetMarkesForUser(_log);
            return umarks.GetMarks(Eventid, UserID);
        }
        decimal GetMarksForQuestion(int Qid, int UserID)
        {
            GetMarkesForUser umarks = new GetMarkesForUser(_log);
            return umarks.GetMarks(Qid, UserID);
        }

        void SaveAnswers(int eid, int qid, int euid, string ans)
        {
            SaveAnswer saveobj = new SaveAnswer(_log);
            saveobj.save(eid, qid, euid, ans);
        }
        int GetEventUserid (int userid,int eventid)
        {
            GetEventUser getEventUser = new GetEventUser(_log);
           return getEventUser.GetID(userid, eventid);

        }
    }
}