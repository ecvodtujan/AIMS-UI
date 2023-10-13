using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AIMS.Report;
using AMSLogic.Model;

namespace AIMS.Report.Report_control
{
    public partial class ByCompanyControl : UserControl
    {
        ReportForm _parent;
        public ByCompanyControl(ReportForm _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
        }

        private void ByCompanyControl_Load(object sender, EventArgs e)
        {

        }
    }
}
