using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.MasterFile.Employee;


namespace AMS.MasterFile
{
    public partial class EmployeeNewMasterform : Form
    {
        public int _emp_id = 0;
        
        public object EmployeeInformationControl { get; internal set; }


        public EmployeeNewMasterform(int _Emp_Id)
        {
            InitializeComponent();
            _emp_id = _Emp_Id;
        }

        //public EmployeeNewMasterform()
        //{
        //}

        void ClickEmployeeInformation()
        {
           ClearPanel();

            var _control = new EmployeeInformationControl(this);
            AddControl(_control); 
        }
        private void pane1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeNewMasterform_Load(object sender, EventArgs e)
        {
            ClickEmployeeInformation();
        }

        void ClearPanel()
        {
            panExpanEmp.Controls.Clear();
        }
       private void SetHighlight(Button _btn)

        {
            SidePanel.Top = _btn.Top;
        }
        void AddControl(Control _control)
        {
            _control.Dock = DockStyle.Fill;
            panExpanEmp.Controls.Add(_control);
        }

        private void EmployeeNewMasterform_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                  this.Close();   
            }
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            SetHighlight(history_btn);
            var _control = new EmployeeAssetHistory(this);
            AddControl(_control);
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            SetHighlight(info_btn);
            ClickEmployeeInformation();
        }

       
    }


  
}
