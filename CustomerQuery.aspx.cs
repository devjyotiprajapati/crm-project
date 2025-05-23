﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//for DB connectivity: ADO.NET
using System.Configuration;//for web.config
using System.Net.Mail;// for sending mail


namespace CRM_Final_Project
{
    public partial class CustomerQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);//create DB Connection
            con.Open();//open DB connection            
            string qry = "select max(QueryID) from Query";//SQL Query
            SqlCommand cmd = new SqlCommand(qry, con);//Send Query for execution
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int cid = Convert.ToInt32(dr[0]);
            cid++;
            TextBox1.Text = cid.ToString();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);//create DB Connection
                con.Open();//open DB connection


                string qry = "insert into Query(QueryID,CustID,Email,ProductNo,ProductName,Query,DateofQuery,Status) values(@t1,@t2,@t3,@t4,@t5,@t6,@t7,@t8)";//SQL Query
                SqlCommand cmd = new SqlCommand(qry, con);//Send Query for execution
                cmd.Parameters.AddWithValue("@t1", TextBox1.Text);
                cmd.Parameters.AddWithValue("@t2", TextBox2.Text);               
                cmd.Parameters.AddWithValue("@t3", TextBox3.Text);
                cmd.Parameters.AddWithValue("@t4", TextBox4.Text);
                cmd.Parameters.AddWithValue("@t5", TextBox5.Text);
                cmd.Parameters.AddWithValue("@t6", TextBox6.Text);
                DateTime dt = DateTime.Now;
                cmd.Parameters.AddWithValue("@t7", dt);
                cmd.Parameters.AddWithValue("@t8", "Under-Processing");

                //code to send Email message
                MailMessage msg = new MailMessage();
                msg.To.Add(TextBox3.Text);
                msg.From = new MailAddress("jprajapati0702@gamil.com");
                msg.Body = TextBox1.Text + " is your complaint Id";
                SmtpClient sm = new SmtpClient("smtp.gmail.com");
                sm.Port = 587;
                sm.Credentials = new System.Net.NetworkCredential("jprajapati0702@gmail.com", "drdkdvjdxhcjgrip");
                sm.EnableSsl = true;
                sm.Send(msg);

                int i = cmd.ExecuteNonQuery();//
                if (i == 1)
                {

                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label8.Text = "Record Saved SuccesFully";

                    Label9.Text = "Your Query id is:" + TextBox1.Text + "Query id send you by mail";
                }
                con.Close();//close DB Connection;
            }
            catch (SqlException ex)//Exception  for catching error By using SqlException class
            {
                Response.Write(ex);
            }
        
    }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("PredefinedQueryandAnswer.aspx");
        }
    }
}