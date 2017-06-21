using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniDbTest.Models;


//namespace MiniDbTest
//{
//    public class TblconsumerHistoryInsert
//    {
//        public static void AddNewConsumerHistoryRow()
//        {
//            try
//            {
//                aeghealthEntities dataModel = new aeghealthEntities();
//                tblConsumerHistory consumerHistorydata = new tblConsumerHistory()
//                {
//                    ConsumerHistoryID = 1234,
//                    ConsumerID = 12345,
//                };
//                dataModel.tblConsumerHistories.Add(consumerHistorydata);
//                dataModel.SaveChanges();
//            }
//            catch (Exception ex) { Console.WriteLine(ex.InnerException); }
//        }
//    }
//}