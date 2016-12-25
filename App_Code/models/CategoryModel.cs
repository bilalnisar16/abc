using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoryModel
/// </summary>
namespace Models
{

    public class CategoryModel
    {
        public string InsertCategory(CATEGORY cat)
        {
            try
            {
                RMSC1Entities1 catsdb = new RMSC1Entities1();
                catsdb.CATEGORies.Add(cat);
                catsdb.SaveChanges();
                return cat.cat_Name + " was successfully inserted";

            }
            catch (Exception e)
            {

                return "error:" + e;
            }
        }
        public string UpdateCategory(int id, CATEGORY cat)
        {
            try
            {
                RMSC1Entities1 catsdb = new RMSC1Entities1();
                //fetch object from db
                CATEGORY r = catsdb.CATEGORies.Find(id);
                r.cat_Name = cat.cat_Name;

                catsdb.SaveChanges();
                return cat.cat_Name + "was successfully Updated";

            }
            catch (Exception e)
            {

                return "error:" + e;
            }
        }
        public string DeleteCategory(int id)
        {
            try
            {
                RMSC1Entities1 catsdb = new RMSC1Entities1();
                //fetch object from db
                CATEGORY r = catsdb.CATEGORies.Find(id);
                catsdb.CATEGORies.Attach(r);
                catsdb.CATEGORies.Remove(r);
                catsdb.SaveChanges();
                return r.cat_Name + "was successfully Deleted";

            }
            catch (Exception e)
            {

                return "error:" + e;
            }

        }
    }
}