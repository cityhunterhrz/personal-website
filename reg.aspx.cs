using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string usn = TextBox1.Text.Trim();

            //开始访问数据库
            string Constr = "Data Source=.\\SQLEXPRESS;Initial Catalog=userdatabase;Integrated Security=True";
            SqlConnection cns = new SqlConnection(Constr);
            cns.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cns;
            //SqlCommand cmd = cns.CreateCommand();

            cmd.CommandText = "select username from [userss] where username='" + usn + "'";
            SqlDataAdapter check = new SqlDataAdapter();       //实例化数据适配器
            check.SelectCommand = cmd;                    //让适配器执行SELECT命令
            DataSet checkData = new DataSet();                 //实例化结果数据集
            int n = check.Fill(checkData, "userss");         //将结果放入数据适配器，返回元祖个数
            if (n != 0)
            {
                Label1.Text = "用户名已存在，请重新输入！";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
            else
            {
                if (TextBox2.Text.Trim() == "" || TextBox2.Text != TextBox3.Text)
                {
                    Label1.Text = "......请输入一致的密码";
                }
                else
                {
                    cmd.CommandText = "insert into [userss](username,password) values ('" + TextBox1.Text + "','" + TextBox2.Text + "')";
                    int temp = cmd.ExecuteNonQuery();
                    if (temp > 0)
                    {
                        //Label1.Text = "注册成功";
                        Response.Write("<script>alert('注册成功');window.location='Home.aspx';</script>");
                    }
                    else
                    {
                        Label1.Text = "注册失败，请重试";
                    }

                    cns.Close();                       //关闭连接
                                                       //cns.Dispose();                     //释放对象
                }
            }
        }
        catch (SqlException)
        {
            Label1.Text = "用户名或密码长度不能超过10位...请重新输入";
        }
                  
    }
}