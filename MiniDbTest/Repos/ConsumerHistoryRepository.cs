using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniDbTest.Models;

namespace MiniDbTest
{
    class ConsumerHistoryRepository
    {
        public static void UpdateConsumerHistory(long consumerHistoryId, short valueone, short valuetwo)
        {
            var dataModel = new aeghealthEntities();

            var consumerHistoryRecord = dataModel.tblConsumerHistories
                .OrderByDescending(i => i.CreateDT)
                .First(i => i.ConsumerHistoryID == consumerHistoryId);

            //values you are updating 
            consumerHistoryRecord.WeightInLbs = valueone;
            consumerHistoryRecord.LDL = valuetwo;
            dataModel.SaveChanges();
        }

        public static tblConsumerHistory GetConsumerHistoryId(int consumerId, int eventid)
        {

            var dataModel = new aeghealthEntities();

            var consumerHistorylookup = dataModel.tblConsumerHistories //look in the table (from) 
                .First(i => i.ConsumerID == consumerId // what value are you looking for(where clause) 
                            && i.EventID == eventid); // another Value in the (where clause) 

            return consumerHistorylookup;

        }

        public static void AddNewConsumerHistoryRow(TestConsumerHistoryModel consumerhistory)
        {

            {
                aeghealthEntities dataModel = new aeghealthEntities();
                tblConsumerHistory consumerHistorydata = new tblConsumerHistory()
                {
                    EventID = consumerhistory.EventID,
                    ConsumerID = consumerhistory.ConsumerID,
                    LDL = consumerhistory.LDL

                };
                dataModel.tblConsumerHistories.Add(consumerHistorydata);
                dataModel.SaveChanges();
            }
        }


        public static void DeleteConsumerHistoryRow(long consumerHistoryId)
        {
            var deleteAnswer = new aeghealthEntities();
            var deleterow = deleteAnswer.tblConsumerHistories
                .First(x => x.ConsumerHistoryID == consumerHistoryId);

            deleteAnswer.tblConsumerHistories.Remove(deleterow);
            deleteAnswer.SaveChanges();
        }
    }
}

