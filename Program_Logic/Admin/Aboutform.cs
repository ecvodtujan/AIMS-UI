using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMSLogic.Admin;
using AMSLogic.Model;


namespace AMS.Admin
{
    public partial class Aboutform : Form
    {
        public Aboutform()
        {
            InitializeComponent();
        }

        private void Aboutform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }



        private void Aboutform_Load(object sender, EventArgs e)
        {
            DisplayAbouts();
        }



        void DisplayAbouts()
        {
            AdminRepository _i = new AdminRepository();
            lsvList.Items.Clear();



            try
            {
                List<SYS_ABOUT> _abouts = _i.GetAbouts();
                foreach (SYS_ABOUT _x in _abouts)
                {
                    ListViewItem _item = new ListViewItem(_x.id.ToString());
                    _item.SubItems.Add(_x.full_name);
                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        void SetAbout()
        {
            string _wordings = "ZMG Devt team......";
            toolTip1.SetToolTip(pictureBox1, _wordings);
        }



        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
