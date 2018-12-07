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

namespace YellowPages
{
    public partial class AddForm : Form
    {
        string contString = Properties.Settings.Default.ContactsDBConnectionString;
        public AddForm()
        {
            InitializeComponent();
        }
        SqlConnection cConet;
        DataSet dsContact;
        SqlDataAdapter daContacts;

        int MaxRec = viewForm.MaxRec;
        int inc = viewForm.inc;
        private void AddForm_Load(object sender, EventArgs e)
        {
            cConet = new SqlConnection(contString);
            dsContact = viewForm.dsContacts;
            daContacts = viewForm.daContacts;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string ulo;
        private void btnSave_Click(object sender, EventArgs e)
        {
            ulo = "Apartment "+txtApt.Text +", Floor " +txtFlr.Text+ ", "+txtBlk.Text+" "+txtStr.Text + ", " + cboQtrs.Text;
            cConet.Open();
            DataRow dRow = dsContact.Tables["Contacts"].NewRow();
            dRow[1]= txtFirst.Text;
            dRow[2] = txtSurname.Text;
            dRow[3] = ulo;
            dRow[4] = txtEmail.Text;
            dRow[5] = txtPhone.Text;
            dRow[6] = dtBdae.Text;

            dsContact.Tables["Contacts"].Rows.Add(dRow);
            daContacts.Update(dsContact, "Contacts");
            MaxRec++;
            inc = MaxRec - 1;

            cConet.Close();
            cConet.Dispose();

        }
    }
}
