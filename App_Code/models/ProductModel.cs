using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
namespace Models
{

    public class ProductModel
    {
        public string InsertMaterial(RAWMATERIAL rm)
        {
            try
            {
                RMSC1Entities1 rmsdb = new RMSC1Entities1();
                rmsdb.RAWMATERIALs.Add(rm);
                rmsdb.SaveChanges();
                return rm.r_Name + "was successfully inserted";

            }
            catch (Exception e)
            {

                return "error:" + e;
            }
        }
        public string UpdateMaterial(int id, RAWMATERIAL rm)
        {
            try
            {
                RMSC1Entities1 rmsdb = new RMSC1Entities1();
                //fetch object from db
                RAWMATERIAL r = rmsdb.RAWMATERIALs.Find(id);
                r.r_Name = rm.r_Name;
                r.r_Price = rm.r_Price;
                r.r_QuantityInStock = rm.r_QuantityInStock;
                r.RawID = rm.RawID;
                r.r_Description = rm.r_Description;
                r.r_MinOrder = rm.r_MinOrder;
                r.r_image1 = rm.r_image1;
                r.r_NeedQuantity = rm.r_NeedQuantity;
                rmsdb.SaveChanges();
                return rm.r_Name + "was successfully Updated";

            }
            catch (Exception e)
            {

                return "error:" + e;
            }
        }
        public string DeleteMaterial(int id)
        {
            try
            {
                RMSC1Entities1 rmsdb = new RMSC1Entities1();
                //fetch object from db
                RAWMATERIAL r = rmsdb.RAWMATERIALs.Find(id);
                rmsdb.RAWMATERIALs.Attach(r);
                rmsdb.RAWMATERIALs.Remove(r);
                rmsdb.SaveChanges();
                return r.r_Name + "was successfully Deleted";

            }
            catch (Exception e)
            {

                return "error:" + e;
            }
        }
    }

}
