using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniDbTest.Models;

namespace MiniDbTest
{
    public class ConsumerRepository
    {
        public static void UpdateConsumer(long consumerId, string valueone, string valuetwo)
        {
            var dataModel = new aeghealthEntities();

            var consumerRecord = dataModel.tblConsumers
                .OrderByDescending(i => i.CreateDT)
                .First(i => i.ConsumerID == consumerId);

            //values you are updating 
            consumerRecord.MlAddr1 = valueone;
            consumerRecord.C_SSN = valuetwo;

            dataModel.SaveChanges();
        }

        public static tblConsumer GetConsumerId(string fn, string ln)
        {

            var dataModel = new aeghealthEntities();

            var consumerlookup = dataModel.tblConsumers //look in the table (from) 
                .First(i => i.FN == fn // what value are you looking for(where clause) 
                            && i.LN == ln); // another Value in the (where clause) 

            return consumerlookup;

        }

        public static void AddNewConsumerRow(TestConsumer consumer)
        {
            aeghealthEntities context = new aeghealthEntities();
            tblConsumer consumerdata = new tblConsumer()
            {
               ConsumerID = consumer.ConsumerID,
               GroupID = consumer.GroupID,
               LN = consumer.LN,
               FN =consumer.FN,
               MI =  consumer.MI,
               LNSoundex = consumer.LNSoundex,
               MlAddr1 = consumer.MlAddr1,
               MlCity = consumer.MlCity,
               MlState = consumer.MlState,
               MlZip  = consumer.MlZip,
               AcTel = consumer.AcTel,
               Tel = consumer.Tel,
               //RaceID = consumer.RaceID,
               C_SSN = consumer.C_SSN,
               DOB = consumer.DOB,
               bChildren = consumer.bChildren,
               MaritalStatusID = consumer.MaritalStatusID,
               bFamilyIns = consumer.bFamilyIns,
               bHasDr = consumer.bHasDr,
               DrLocCit = consumer.DrLocCit,
               DrLocSt = consumer.DrLocSt,
               Gender = consumer.Gender,
               EmploymentStatusID = consumer.EmploymentStatusID,
               CreatedByID = consumer.CreatedByID
            };
            context.tblConsumers.Add(consumerdata);
            context.SaveChanges();
        }


    }
}




