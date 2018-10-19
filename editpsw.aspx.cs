using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class editpsw : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        else
        {
            TextBox1.Text = Session["username"].ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text.Trim() == "" || TextBox2.Text != TextBox3.Text)
        {
            Label1.Text = "......请输入一致的密码";
        }
        else
        {
            try
            {
                //开始访问数据库
                string Constr = "Data Source=.\\SQLEXPRESS;Initial Catalog=userdatabase;Integrated Security=True";
                SqlConnection cns = new SqlConnection(Constr);
                cns.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cns;
                //SqlCommand cmd = cns.CreateCommand();

                cmd.CommandText = "update [userss] set password='" + TextBox2.Text + "' where username='" + Session["username"].ToString() + "'";
                int tmp = cmd.ExecuteNonQuery();

                if (tmp > 0)
                {
                    Label1.Text = "修改成功";
                }
                else
                {
                    Label1.Text = "修改失败，请重试";
                }

                cns.Close();
            }
            catch (SqlException)
            {
                Label1.Text = "用户名或密码长度不能超过10位...请重新输入";
            }
        }
    }
}