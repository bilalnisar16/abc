using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for VendorDetailModel
/// </summary>
public class VendorDetailModel
{
    public VENDOR GetvendorInformation(string guId)
    {
        RMSC1Entities1 db = new RMSC1Entities1();
        var info = (from x in db.VENDORs
                    where x.v_Email == guId
                    select x).FirstOrDefault();
        return info;
    }

    public void InsertVendorDetail(VENDOR vendorDetail)
    {
        RMSC1Entities1 db = new RMSC1Entities1();
        db.VENDORs.Add(vendorDetail);

        db.SaveChanges();
    }
}