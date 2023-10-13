using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMSLogic;
using AMS.MasterFile.Employee;
using AMSLogic.Model;
using AMSLogic.Master.Repository;
using AMS.MasterFile;

namespace AMS.Inquiry
{
    public partial class EmployeeMonitoringform : Form
    {
        int _id = 0;

        public EmployeeMonitoringform()
        {
            InitializeComponent();
        }

        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    _id = int.Parse(dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString());
                    EmployeeNewMasterform _f = new EmployeeNewMasterform(_id);
                    _f.Tag = _id.ToString();
                    _f.BringToFront();
                    _f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            EmployeeNewMasterform _empform = new EmployeeNewMasterform(0);
            _empform.BringToFront();
            _empform.Show();
            SetHightlight(add_btn);
        }

        private void EmployeeMonitoringform_Load(object sender, EventArgs e)
        {
            DisplayRecords2();
            this.dgvEmp.Sort(this.dgvEmp.Columns[1], ListSortDirection.Ascending);
        }
        void DisplayRecords2()
        {
            EmployeeRepository _emprepo = new EmployeeRepository();
            dgvEmp.RowCount = 0;
            prb.Value = 0;
            int m = 0;
            try
            {
                List<UDSP_I_GET_EMPLOYEE_MONITORINGResult> _lists = _emprepo.GetEmployees(chkCompany.Checked,
                   int.Parse(txtCompany.Tag.ToString()),
                    chkDepartment.Checked,
                   int.Parse(txtDepartment.Tag.ToString()),
                   txtKeyword.Text);

                prb.Maximum = _lists.Count();
                if (_lists != null)
                {
                    if (_lists.Count != 0)

                    {
                        foreach (UDSP_I_GET_EMPLOYEE_MONITORINGResult _list in _lists)

                        {
                            prb.Value = prb.Value + 1;
                            m = dgvEmp.Rows.Add();
                            dgvEmp.Rows[m].Cells[0].Value = _list.id.ToString();
                            dgvEmp.Rows[m].Cells[1].Value = _list.lastname.ToUpper() + "," + " "+ _list.firstname.ToUpper() + " " + _list.middlename.ToUpper();
                            dgvEmp.Rows[m].Cells[2].Value = _list.Company;
                            dgvEmp.Rows[m].Cells[3].Value = _list.Department;
                            dgvEmp.Rows[m].Cells[4].Value = _list.Status;
                            dgvEmp.Rows[m].Cells[5].Value = _list.username;
                            dgvEmp.Rows[m].Cells[6].Value = _list.date_created;

                            int Rcount = dgvEmp.Rows.Count;
                            lblCount.Text = Rcount.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecords()

        {
            //EmployeeRepository _emprepo = new EmployeeRepository();
            //dgvEmp.RowCount = 0;
            //prb.Value = 0;
            //int n = 0;

            //try
            //{
            //    List<EMP_EMPLOYEE> _emps = _emprepo.GetEmployees(txtKeyword.Text);
            //    prb.Maximum = _emps.Count();
            //    if (_emps != null)
            //    {
            //        if (_emps.Count != 0)
            //        {
            //            foreach (EMP_EMPLOYEE _e in _emps)
            //            {
            //                prb.Value = prb.Value + 1;
            //                n = dgvEmp.Rows.Add();
            //                dgvEmp.Rows[n].Cells[0].Value = _e.id.ToString();
            //                dgvEmp.Rows[n].Cells[1].Value = _e.lastname.ToUpper() + "," + _e.firstname.ToUpper() + " " + _e.middlename.ToUpper();
            //                dgvEmp.Rows[n].Cells[2].Value = _e.SYS_COMPANY.description;
            //                dgvEmp.Rows[n].Cells[3].Value = _e.INV_DEPARTMENT.department;
            //                dgvEmp.Rows[n].Cells[4].Value = _e.status ? "Active" : "Inactive";
            //                dgvEmp.Rows[n].Cells[5].Value = _e.SYS_USER.username;
            //                dgvEmp.Rows[n].Cells[6].Value = _e.date_created.ToShortDateString();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            DisplayRecords2();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DisplayRecords2();
            SetHightlight(refresh_btn);
        }

        private void SetHightlight(Button _btn)
        {
            SidePanel.Top = _btn.Top;
        }
        void AddControl(Control _control)
        {

        }

        private void txtKeyword_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_filter.PerformClick();
            }

           // DisplayRecords2();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if (!chkCompany.Checked) { return; }
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "COMPANY";
            _Searchform.ShowDialog();

            SYS_COMPANY _obj = _Searchform.ReturnSearchCompany;
            if (_obj != null)
            {
                txtCompany.Text = _obj.description;
                txtCompany.Tag = _obj.id;
            }

            DisplayRecords2();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            if (!chkDepartment.Checked)

            { return; }

            if (txtCompany.Text == "") { return; }
            Searchform _Searchform = new Searchform();
               _Searchform._companyid = int.Parse(txtCompany.Tag.ToString());
                _Searchform._searchby = "DEPARTMENT BY COMPANY";
                _Searchform.ShowDialog();

                INV_DEPARTMENT _obj = _Searchform.ReturnSearchDepartment;
                if (_obj != null)
                {
                    txtDepartment.Text = _obj.department;
                    txtDepartment.Tag = _obj.id;
                }
        
               DisplayRecords2();
         }
        private void txtCompany_Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                btnCompany.PerformClick();
            }
        }

        private void txtDepartment_Keydown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Return)
            {
                btnDepartment.PerformClick();
            }
        }

        private void chkCompany_CheckChange(object sender, EventArgs e)
        {
            if(!chkCompany.Checked)
            {
                txtCompany.Text = "";
            }
        }

        private void chkDepartment_CheckChanged(object sender, EventArgs e)
        {
            if(!chkDepartment.Checked)
            {
                txtDepartment.Text = "";
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
