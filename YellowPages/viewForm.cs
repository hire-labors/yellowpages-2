using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace YellowPages
{

    public partial class viewForm : Form
    {
        
        public viewForm()
        {
            InitializeComponent();
        }
        AddForm secondform = new AddForm();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            secondform.Show();
        }
        
         
        public static int MaxRec = 0;
        public static int inc = 0;
        public static SqlConnection Cconnect;
        public static DataSet dsContacts;
        public static SqlDataAdapter daContacts;
        string contString = Properties.Settings.Default.ContactsDBConnectionString;
        private void viewForm_Load(object sender, EventArgs e)
        {
            Cconnect = new SqlConnection(contString);
            dsContacts = new DataSet();

            Cconnect.Open();
            string sql = "SELECT * From Contacts";
            daContacts = new SqlDataAdapter(sql, Cconnect);
            daContacts.Fill(dsContacts, "Contacts");
            NavRec();
            MaxRec = dsContacts.Tables["Contacts"].Rows.Count;
            Cconnect.Close();

            Cconnect.Dispose();
        }
        private void NavRec()
        {
            DataRow dRow = dsContacts.Tables["Contacts"].Rows[inc];
            txtFName.Text = dRow.ItemArray.GetValue(1).ToString();
            txtSName.Text = dRow.ItemArray.GetValue(2).ToString();
            txtAddress.Text = dRow.ItemArray.GetValue(3).ToString();
            txtEmail.Text = dRow.ItemArray.GetValue(4).ToString();
            txtPhone.Text = dRow.ItemArray.GetValue(5).ToString();
            txtBday.Text = dRow.ItemArray.GetValue(6).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(inc < MaxRec - 1)
            {
                inc++;
                NavRec();
            }
            else
            {
                MessageBox.Show("Stop hitting the button. \nNo more contacts");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
           if(inc > 0)
            {
                inc--;
                NavRec();
            }
            else
            {
                MessageBox.Show("Stop hitting the button. \nThis is the first Contact");
            }
        }

        private void btnEOR_Click(object sender, EventArgs e)
        {
            if (inc != MaxRec - 1)
            {
                inc = MaxRec-1;
                NavRec();
            }
            else
            {
                MessageBox.Show("Stop hitting the button. \nNo more contacts");
            }
        }

        private void btnBOR_Click(object sender, EventArgs e)
        {
            if (inc !=0)
            {
                inc = 0;
                NavRec();
            }
            else
            {
                MessageBox.Show("Stop hitting the button. \nThis is the first Contact");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
