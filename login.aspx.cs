using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//using System.Threading;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string usn = TextBox1.Text.Trim();
        string psw = TextBox2.Text.Trim();
        if (usn == "" || psw == "")
        {
            Label1.Text = "用户名密码不能为空";
            return;
        }
        else
        {
            if (usn.Length > 16)
            {
                usn = usn.Substring(0, 16);
            }
        }

        try
        {
            //开始访问数据库
            string Constr = "Data Source=.\\SQLEXPRESS;Initial Catalog=userdatabase;Integrated Security=True";
            SqlConnection cns = new SqlConnection(Constr);
            cns.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cns;
            //SqlCommand cmd = cns.CreateCommand();

            cmd.CommandText = "select password from [userss] where username='" + usn + "'";
            object tmp = cmd.ExecuteScalar();

            if (tmp == null || tmp == DBNull.Value)
            {
                Label1.Text = "用户名不存在";
            }
            else
            {
                if (psw == tmp.ToString().Trim())
                {
                    //Label1.Text = "登录成功";
                    //Thread.Sleep(5000);
                    Session["username"] = usn;
                    // Response.Redirect("loginsuf.aspx");
                    Response.Write("<script>alert('登陆成功');window.location='loginsuf.aspx';</script>");
                }
                else
                {
                    Label1.Text = "密码不正确";
                }
            }

            cns.Close();
        }
        catch (SqlException)
        {
            Label1.Text = "无法访问数据库";
        }
    }
}