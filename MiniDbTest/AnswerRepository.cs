using System.Linq;
using MiniDbTest.Models;

namespace MiniDbTest
{
    public class AnswerRepository
    {
        public static void UpdateAnswer(long answerId, string value)
        {
            var dataModel = new aeghealthEntities();

            var answerRecord = dataModel.tblAnswers
                .OrderByDescending(i => i.CreateDt)
                .First(i => i.AnswerID == answerId);

            answerRecord.Answer = value;
            dataModel.SaveChanges();
        }

        public static tblAnswer GetAnswer(int consumerHistoryId, int questionId)
        {
            var dataModel = new aeghealthEntities();

            var updateAnswerrecord = dataModel.tblAnswers //look in the table (from) 
                .First(i => i.ConsumerHistoryID == consumerHistoryId // what value are you looking for(where clause) 
                            && i.QuestionID == questionId); // another Value in the (where clause) 

            return updateAnswerrecord;
        }

        public static void AddNewAnswerRow(TestAnswers context)
        {
            var entities = new aeghealthEntities();
            var answerdata = new tblAnswer
            {
                ConsumerHistoryID = context.ConsumerHistoryId,
                QuestionID = context.QuestionId,
                Answer = context.Answer,
                CreatedByID = context.CreatedById,
                ModifiedByID = context.ModifiedById
            };
            entities.tblAnswers.Add(answerdata);
            entities.SaveChanges();
        }

        public static void DeleteAnswerRow(long answerId)
        {
            var deleteAnswer = new aeghealthEntities();
            var deleterow = deleteAnswer.tblAnswers
                .First(x => x.AnswerID == answerId);

            deleteAnswer.tblAnswers.Remove(deleterow);
            deleteAnswer.SaveChanges();
        }
    }
}