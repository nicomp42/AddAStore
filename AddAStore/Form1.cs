using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddAStore
{
    public partial class frmAddAStore : Form
    {
        public frmAddAStore()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int storeID = UtilsNamespace.Utils.AddStore("StoreABC",
                                                        "111 Main",
                                                        "",
                                                        "Cincinnati",
                                                        "OH",
                                                        "45103",
                                                        1,
                                                        "9999",
                                                        false,
                                                        1);
            MessageBox.Show("Store ID = " + storeID);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddAStore_Load(object sender, EventArgs e)
        {
            UtilsNamespace.Utils.LoadEmployeeListBox(lbEmpl);
        }
    }
}
