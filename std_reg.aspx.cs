using Projectsms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Registration
{
    public partial class std_reg : System.Web.UI.Page
    {
//        StudentDB1
//        CREATE TABLE tblstudent(
//        std_id int IDENTITY(1,1) NOT NULL,
//        std_name NVARCHAR(500) NOT NULL,
//        fname NVARCHAR(500) NULL,
//dob NVARCHAR(50) NULL,
//s_program NVARCHAR(500) NULL,
//region NVARCHAR(50) NULL,
//address NVARCHAR(500) NULL,
//cell_no NVARCHAR(50) NULL,
//gender NVARCHAR(10) NULL
//)
        datalayer dl;
        protected void Page_Load(object sender, EventArgs e)
        {
            dl = new datalayer();
            string qry = "select * from tblstudent";
            dl.fillgridView(qry, gv);
         
        }
        static string std_id;
        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            std_id = gv.SelectedRow.Cells[1].Text.ToString();
            txtStdname.Text = gv.SelectedRow.Cells[2].Text.ToString();
            txtfname.Text = gv.SelectedRow.Cells[3].Text.ToString();
            txtdob.Text = gv.SelectedRow.Cells[4].Text.ToString();
            txtprogram.Text = gv.SelectedRow.Cells[5].Text.ToString();
            txtregion.Text = gv.SelectedRow.Cells[6].Text.ToString();
            txtaddress.Text = gv.SelectedRow.Cells[7].Text.ToString();
            txtcell.Text = gv.SelectedRow.Cells[8].Text.ToString();
            txtgender.Text = gv.SelectedRow.Cells[9].Text.ToString();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "insert into tblstudent(std_name,fname,dob,s_program,region,address,cell_no,gender)" +
                "values('"+txtStdname.Text+"','"+txtfname.Text+"','"+txtdob.Text+"','"+txtprogram.Text
                +"','"+txtregion.SelectedItem.ToString()+"','"+txtaddress.Text+"','"+txtcell.Text+"','"+txtgender.Text+"')";
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);


            txtStdname.Text = "";
            txtfname.Text = "";
            txtdob.Text = "";
            txtprogram.Text = "";
            txtregion.Text = "";
            txtaddress.Text = "";
            txtcell.Text = "";
            txtgender.Text = "";
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            string qry = "update tblstudent set std_name='"+txtStdname.Text+"',fname='"+txtfname.Text+"',dob='"+txtdob.Text
                +"',s_program='"+txtprogram.Text+"',region='"+txtregion.SelectedItem.ToString()+"',address='"+txtaddress.Text
                +"',cell_no='"+txtcell.Text+"',gender='"+txtgender.Text+"' where std_id='"+std_id+"'";
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);
            txtStdname.Text = "";
            txtfname.Text = "";
            txtdob.Text = "";
            txtprogram.Text = "";
            txtregion.Text = "";
            txtaddress.Text = "";
            txtcell.Text = "";
            txtgender.Text = "";
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            string qry = "delete from tblstudent where std_id='"+std_id+"'";
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);
        }
    }
}