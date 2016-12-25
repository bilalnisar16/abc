using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IdentityModel;
using System.IO;



public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
    }

    private CATEGORY createCategory()
    {
        
        
        CATEGORY c = new CATEGORY();
        c.cat_Name = txtName1.Text;
        c.CategoryID = Int32.Parse(TextBox1.Text);
       
        return c;
    }

   
    
       


    protected void btnadd_Click(object sender, EventArgs e)
    {
        HttpPostedFile postFile = FileUpload1.PostedFile;
        string fileName = Path.GetFileName(postFile.FileName);
        string fileExtension = Path.GetExtension(fileName);
        int fileSize = postFile.ContentLength;
        if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == "bmp" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
        {
            Stream stream = postFile.InputStream;
            BinaryReader binaryreader = new BinaryReader(stream);
            byte[] bytes = binaryreader.ReadBytes((int)stream.Length);

            string cs = ConfigurationManager.ConnectionStrings["RMSC1ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("addcategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = txtName1.Text
                };
                cmd.Parameters.Add(parameter);

                SqlParameter paraname = new SqlParameter()
                {
                    ParameterName = "@newid",
                    Value = Int32.Parse(TextBox1.Text)
                };
                cmd.Parameters.Add(paraname);

                SqlParameter paraImage = new SqlParameter()
                {
                    ParameterName = "@cimage",
                    Value = bytes
                };
                cmd.Parameters.Add(paraImage);


                con.Open();
                cmd.ExecuteNonQuery();

                lb1Result.Visible = true;
                lb1Result.Text = "upload successful";
                lb1Result.ForeColor = System.Drawing.Color.Green;

                Response.Redirect("~/admin/Default.aspx");

            }
        }
        else
        {
            lb1Result.Visible = true;
            lb1Result.Text = "only image";
            lb1Result.ForeColor = System.Drawing.Color.Red;
        }
       

    }

    }

    
