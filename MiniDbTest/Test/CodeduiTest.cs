using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiniDbTest
{
    [CodedUITest]
    public class CodedUiTest1
    {
        private readonly IList<TestAnswers> _answerValues;
        private readonly IList<TestConsumerHistory> _consumerHistoryvalues;
        private readonly IList<TestConsumer> _consumervalues;

        public CodedUiTest1()
        {
            _answerValues = HydrateAnswerValues();
            _consumervalues = HydrateConsumerValues();
            _consumerHistoryvalues = HydrateConsumerHistoryValues();
        }

        private IList<TestAnswers> HydrateAnswerValues()
        {
            var returnList = new List<TestAnswers>();

            var answer = new TestAnswers
            {
                ConsumerHistoryId = 1234,
                QuestionId = 10,
                Answer = "this is my answer",
                CreatedById = 69,
                ModifiedById = 68,
                ConsumerHistoryLookup = 1234,
                AnswerId = 20,
                Updatednewvalue = "New Answer"
            };

            returnList.Add(answer);

            return returnList;
        }

        private IList<TestConsumer> HydrateConsumerValues()
        {
            var returnList = new List<TestConsumer>();

            var consumerData = new TestConsumer
            {
                GroupID = 12345,
                LN = "Mctest",
                FN = "Tester",
                MI = "T",
                LNSoundex = "Sdn",
                MlAddr1 = "123 Test St",
                MlCity = "Nashville",
                MlState = "TN",
                MlZip = "37211",
                AcTel = "615",
                Tel = "615",
                C_SSN = "123456789",
                DOB = Convert.ToDateTime("1/1/1982"),
                bChildren = 0,
                MaritalStatusID = 113,
                bFamilyIns = 1,
                bHasDr = 1,
                DrLocCit = "Nashville",
                DrLocSt = "TN",
                Gender = "M",
                EmploymentStatusID = 18,
                bFamHisCancer = 0,
                bFamHisHd = 0,
                bFamHisDiabetes = 0,
                InsCarrier = "Testinsurace",
                CreatedByID = 68,
                Update_SSN = "123121234",
                Update_MlAddr1 = "124 Updated St"
            };

            returnList.Add(consumerData);

            return returnList;
        }

        private IList<TestConsumerHistory> HydrateConsumerHistoryValues()
        {
            var returnList = new List<TestConsumerHistory>();

            var consumerHistoryvalues = new TestConsumerHistory
            {
                ConsumerID = 680802,
                EventID = 1234567,
                LDL = 100,
                Update_LDL = 200,
                Update_WeightInLbs = 200
            };

            returnList.Add(consumerHistoryvalues);

            return returnList;
        }

        [TestMethod]
        public void TestInsert()
        {
            //Insert to tables
            foreach (var answer in _answerValues)
                AnswerRepository.AddNewAnswerRow(answer);

            foreach (var consumerdata in _consumervalues)
                ConsumerRepository.AddNewConsumerRow(consumerdata);

            foreach (var consumerHistoryvalues in _consumerHistoryvalues)
                ConsumerHistoryRepository.AddNewConsumerHistoryRow(consumerHistoryvalues);
        }

        [TestMethod]
        public void Testupdate()
        {
            foreach (var answer in _answerValues)
            {
                var answerRecord = AnswerRepository.GetAnswer(answer.ConsumerHistoryId, answer.QuestionId);

                AnswerRepository.UpdateAnswer(answerRecord.AnswerID, answer.Updatednewvalue);

                Assert.AreEqual(1234, answer.ConsumerHistoryId);
                Assert.AreEqual(answer.Updatednewvalue, answerRecord.Answer);
            }

            foreach (var consumerupdatevalues in _consumervalues)
            {
                var consumervalue = ConsumerRepository.GetConsumerId(consumerupdatevalues.FN, consumerupdatevalues.LN);
                ConsumerRepository.UpdateConsumer(consumervalue.ConsumerID, consumerupdatevalues.Update_MlAddr1,
                    consumerupdatevalues.Update_SSN);

                Assert.AreEqual("Tester", consumervalue.FN);
                Assert.AreEqual("Mctest", consumervalue.LN);
            }

            foreach (var consumerHistoryupdatevalues in _consumerHistoryvalues)
            {
                var consumerHistoryIdvalue =
                    ConsumerHistoryRepository.GetConsumerHistoryId(consumerHistoryupdatevalues.ConsumerID,
                        consumerHistoryupdatevalues.EventID);
                ConsumerHistoryRepository.UpdateConsumerHistory(consumerHistoryIdvalue.ConsumerHistoryID,
                    consumerHistoryupdatevalues.Update_WeightInLbs, consumerHistoryupdatevalues.Update_LDL);
                Assert.AreEqual(100, consumerHistoryIdvalue.LDL);
            }
        }

        [TestMethod]
        public void DeleteRows()
        {
            foreach (var answer in _answerValues)
            {
                var answerRecord = AnswerRepository.GetAnswer(answer.ConsumerHistoryId, answer.QuestionId);

                AnswerRepository.DeleteAnswerRow(answerRecord.AnswerID);
            }
        }
    }
}