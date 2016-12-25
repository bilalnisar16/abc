using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cart
/// </summary>
namespace Models
{

    public class cart
    {
        public string InsertCart(CART c)
        {
            try
            {
                RMSC1Entities1 csdb = new RMSC1Entities1();
                csdb.CARTs.Add(c);
                csdb.SaveChanges();
                return c.RawID + "was successfully inserted";

            }
            catch (Exception e)
            {

                return "error:" + e;
            }
        }
        public string UpdateCart(int id, CART c)
        {
            try
            {
                RMSC1Entities1 csdb = new RMSC1Entities1();
                //fetch object from db
                CART r = csdb.CARTs.Find(id);
                r.CartID = c.CartID;
                r.NumOfRM = c.NumOfRM;
                r.TotalPrice = c.TotalPrice;
                r.RawID = c.RawID;
                csdb.SaveChanges();
                return c.RawID + "was successfully Updated";



            }
            catch (Exception e)
            {

                return "error:" + e;
            }
        }
        public string DeleteCart(int id)
        {
            try
            {
                RMSC1Entities1 csdb = new RMSC1Entities1();
                //fetch object from db
                CART r = csdb.CARTs.Find(id);
                csdb.CARTs.Attach(r);
                csdb.CARTs.Remove(r);
                csdb.SaveChanges();
                return r.RawID + "was successfully Deleted";

            }
            catch (Exception e)
            {

                return "error:" + e;
            }
        }
    }
}