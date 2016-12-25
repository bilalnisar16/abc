using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDetailModel
/// </summary>
namespace Models{

public class UserDetailModel
{
     public int GetUserInformation(string guId)
        {
            RMSC1Entities1 db = new RMSC1Entities1();
            int info = (from x in db.CLIENTs
                        where x.c_Email == guId
                        select x.ClientID).FirstOrDefault();
            return info;
        }
     public string GetUserName(string guId)
     {
         RMSC1Entities1 db = new RMSC1Entities1();
         string info = (from x in db.CLIENTs
                     where x.c_Email == guId
                     select x.c_Fname).FirstOrDefault();
         return info;
     }

        public void InsertUserDetail(CLIENT userDetails)
        {
            RMSC1Entities1 db = new RMSC1Entities1();
            db.CLIENTs.Add(userDetails);
            db.SaveChanges();
        }
    }
}