using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace cpp_PROJECT
{   
    public partial class home : Form
    {
       



        AITUCDataSet set;

        public static object AITUC { get; private set; }

        public home()
        {
            InitializeComponent();
        
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            panel_reg.Visible = true;
            panel_search.Visible = false;
            panel_area.Visible = false;
        }

        private void Cntct_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("contact:- prasenjeetbansode@gmail.com");
        }

        private void home_Load(object sender, EventArgs e)
        {
             
            // TODO: This line of code loads data into the 'aITUCDataSet.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.aITUCDataSet.Registration);

            this.areaTableAdapter.Fill(this.aITUCDataSet.Area);
            date_txt.Text = DateTime.Now.ToLongDateString();
            date_txt.Enabled = false;
            
            
            
            //panels
            panel_reg.Visible = false;
            panel_search.Visible = false;
            panel_area.Visible = false;

            set = new AITUCDataSet();
            registrationBindingSource.DataSource = set.Registration.ToList();

        }

        

        private void Area_btn_Click(object sender, EventArgs e)
        {
            panel_search.Visible = false;
            panel_reg.Visible = false;
           
            panel_area.Visible = true;
        }

        private void srh_btn_Click(object sender, EventArgs e)
        {
            panel_search.Visible = true;
            panel_reg.Visible = false;
            panel_area.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //date
            DateTimePicker dateTimePicker = new DateTimePicker();
            date_txt.Text = dateTimePicker.ToString();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try {
                OleDbConnection connection = new OleDbConnection();
        
                connection.ConnectionString= @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\SAMAEL\Desktop\AITUC.mdb;Jet OLEDB:Database Password=Saanchi@2014";
               
                
                connection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;

                cmd.CommandText = "insert into table Registration(RegID,CDate,MemberName,Address,Mobile,Education,Workexp,Work)" +
                   
                    " values('"+textBox1.Text+"','"+date_txt.Text+"','"+textBox2.Text+"','"+ richTextBox1.Text+ "','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')";
                
                cmd.ExecuteNonQuery();

                registrationBindingSource.EndEdit();
                    
            }
            catch(Exception ex){

                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                registrationBindingSource.ResetBindings(false);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString= @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\SAMAEL\Desktop\AITUC.mdb;Persist Security Info=True";

                connection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                string q = "SELECT * FROM Registration WHERE " +
                    "RegID='" + textBox9.Text + "' or MemberName='" + textBox9.Text + "' or Mobile='" + textBox9.Text + "' or Work='" + textBox9.Text + "'";



                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                registrationBindingSource.EndEdit();

            }
            catch {

                MessageBox.Show("error");
            }

        }

        private void Rpt_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
