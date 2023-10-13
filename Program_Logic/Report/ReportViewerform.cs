using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using AIMS.Report;

namespace AMS.Report
{
    public partial class ReportViewerform : Form
    {
        private string _reporttype = "";
        public int _request_id = 0;
        public int _plan_id = 0;
        public int _emp_id = 0;

        public bool _by_itemtype = true;
        public int _itemtype_id = 0;
        public bool _by_brand = true;
        public int _brand_id = 0;
        public bool _byyear = true;
        public string _datevalue = "";
        public DateTime _from = DateTime.Parse("2022-01-01");
        public DateTime _to = DateTime.Parse("2022-12-31");
               
        
        public bool _bycompany = true;
        public string _company = "";
        public string _keyword = "";
        public string _companyname = "";
        public string _itemtype = "";
        public string _brand = "";
        public string _supplier = "";
        public string _total = "";


        public ReportViewerform(string _Reporttype)
        {
            InitializeComponent();
            _reporttype = _Reporttype;
        }

        void DisplayReport()
        {
            ReportDocument _reportdoc = new ReportDocument();

            ReportForm _form = new ReportForm();

           //string _report_path = @"C:\ZMG SYSTEM\ASSET\Report\";
            //string _report_path = @"\\whzmg-dirsync\zmg\ASSET\Report\";
           // string _report_path = @"C:\Users\eclvillanueva\Documents\PO AIMS\Report\";
            string _report_path = @"\\192.168.20.21\it teamfiles\ZMG System\AIMS\Reports\";
            try
            {

                if (_reporttype == "BRAND MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Brand Master file.rpt");
                    goto Report_Path;
                }

                else if (_reporttype == "EMPLOYEE MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Employee Master file.rpt");
                    goto Report_Path;
                }

                else if (_reporttype == "COMPANY MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Company Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "ITEM TYPE MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Item Type Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "SUPPLIER MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Supplier Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "USER MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"User Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "ASSET MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Asset Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "LOCATION MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Location Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "REASON MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Reason Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "DOCUMENT TYPE MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Document Type Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "POSITION MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Position Master file.rpt");
                    goto Report_Path;
                }
                else if (_reporttype == "DEPARTMENT MASTER FILE")
                {
                    _reportdoc.Load(_report_path + @"Department Master file.rpt");
                    goto Report_Path;
                }

                else if (_reporttype == "REQUEST PRINT OUT")
                {
                    _reportdoc.Load(_report_path + @"AIMS Request form.rpt");
                    _reportdoc.DataDefinition.FormulaFields["RequestId"].Text = "" + _request_id + "";
                    _reportdoc.DataDefinition.FormulaFields["Supplier"].Text = "'" + _supplier + "'";
                    _reportdoc.DataDefinition.FormulaFields["TotalPrice"].Text = "'" + _total + "'";

                    goto Report_Path;
                }
                else if (_reporttype == "PLAN PRINT OUT")
                {
                    _reportdoc.Load(_report_path + @"Plan Printout Master file.rpt");
                    _reportdoc.DataDefinition.FormulaFields["plan_id"].Text = "" + _plan_id + "";
                    goto Report_Path;
                }
                else if (_reporttype == "ACCOUNTABILITY PRINT OUT")
                {
                    _reportdoc.Load(_report_path + @"Employee AccountabilityForm.rpt");
                    _reportdoc.DataDefinition.FormulaFields["employee_id"].Text = "" + _emp_id + "";
                    goto Report_Path;
                }

                else if (_reporttype == "ASSET REPORT BY COMPANY")
                {
                    if (_company == "ZMG")
                    {
                        _companyname = "ZMG Wardhowell Inc.";
                    }
                    else if (_company == "APW")
                    {
                        _companyname = "Asia Peopleworks Inc.";
                    }
                    else if (_company == "APS")
                    {
                        _companyname = "Asia PeopleSearch Inc.";
                    }
                    else if (_company == "ASI")
                    {
                        _companyname = "Asia Select Inc.";
                    }
                    else if (_companyname == "")
                    {
                        _companyname = "ZMG Group";
                    }
                  
                    _reportdoc.Load(_report_path + @"Asset Master file by Company.rpt");
                    _reportdoc.DataDefinition.FormulaFields["comp"].Text = "'" + _companyname + "'";
                    _reportdoc.SetParameterValue("@BYCOMPANY",_bycompany);
                    _reportdoc.SetParameterValue("@COMPANY", _company);
                    goto Report_Path;
                }

                else if (_reporttype == "ASSET REPORT BY ITEMTYPE")
                {
                    _reportdoc.Load(_report_path + @"Asset Master file by ItemType.rpt");
                    //_reportdoc.DataDefinition.FormulaFields["itemtype"].Text = "'" + _companyname + "'";
                    _reportdoc.SetParameterValue("@BY_ITEMTYPE", _by_itemtype);
                    _reportdoc.SetParameterValue("@ITEMTYPE_ID", _itemtype_id);
                    goto Report_Path;

                }
                else if (_reporttype == "ASSET REPORT BY BRAND")
                {
                    _reportdoc.Load(_report_path + @"Asset Master file by Brand.rpt");
                    //_reportdoc.DataDefinition.FormulaFields["itemtype"].Text = "'" + _companyname + "'";
                    _reportdoc.SetParameterValue("@BY_BRAND", _by_brand);
                    _reportdoc.SetParameterValue("@BRAND_ID", _brand_id);
                    goto Report_Path;

                }
                else if (_reporttype == "ASSET REPORT BY MANUFACTURING DATE")
                {
                    _reportdoc.Load(_report_path + @"Asset Master file by Manufacturing Date.rpt");
                    //_reportdoc.DataDefinition.FormulaFields["itemtype"].Text = "'" + _companyname + "'";
                    _reportdoc.SetParameterValue("@BYDATE", _byyear);
                    _reportdoc.SetParameterValue("@BYDATE_VALUE", _datevalue);
                    _reportdoc.SetParameterValue("@FROM", _from.ToString("s"));
                    _reportdoc.SetParameterValue("@TO", _to.ToString("s"));
                    goto Report_Path;

                }

                else if (_reporttype == "ASSET REPORT BY PURCHASING DATE")
                {
                    _reportdoc.Load(_report_path + @"Asset Master file by Purchase Date.rpt");
                    //_reportdoc.DataDefinition.FormulaFields["itemtype"].Text = "'" + _companyname + "'";
                    _reportdoc.SetParameterValue("@BYDATE", _byyear);
                    _reportdoc.SetParameterValue("@BYDATE_VALUE", _datevalue);
                    _reportdoc.SetParameterValue("@FROM", _from.ToString("s"));
                    _reportdoc.SetParameterValue("@TO", _from.ToString("s"));
                    goto Report_Path;
                  

                }
                else if (_reporttype == "ASSET REPORT BY WARRANTY DATE")
                {
                    _reportdoc.Load(_report_path + @"Asset Master file by Warranty Date.rpt");
                    //_reportdoc.DataDefinition.FormulaFields["itemtype"].Text = "'" + _companyname + "'";
                    _reportdoc.SetParameterValue("@BYDATE", _byyear);
                    _reportdoc.SetParameterValue("@BYDATE_VALUE", _datevalue);
                    _reportdoc.SetParameterValue("@FROM", _from.ToString("s"));
                    _reportdoc.SetParameterValue("@TO", _from.ToString("s"));
                    goto Report_Path;

                }
                else if (_reporttype == "ASSET REPORT BY ALL")
                {
                    _reportdoc.Load(_report_path + @"Asset Master file by ALL ACTIVE.rpt");
                    //_reportdoc.DataDefinition.FormulaFields["itemtype"].Text = "'" + _companyname + "'";
                    //_reportdoc.SetParameterValue("@BYDATE", _byyear);
                    //_reportdoc.SetParameterValue("@BYDATE_VALUE", _datevalue);
                    //_reportdoc.SetParameterValue("@FROM", _from.ToString("s"));
                    //_reportdoc.SetParameterValue("@TO", _from.ToString("s"));
                    goto Report_Path;

                }
                else
                {
                    goto Invalid_Path;
                }

                Report_Path:                
                    SetReportDataSource("58.71.51.237", "INV_DB", "Zmgsqluser", "zmgSQLu$er2016**", _reportdoc);
                
                    CrysViewer.ReportSource = _reportdoc;
                    CrysViewer.Refresh();
                    CrysViewer = null;

                    return;

                Invalid_Path:
                   MessageBox.Show("Report type not supported. Kindly check your entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetReportDataSource(string _server, string _database, string _username, string _password, ReportDocument _report)
        {
            ConnectionInfo myConnectionInfo = new ConnectionInfo();
            myConnectionInfo.ServerName = _server;
            myConnectionInfo.DatabaseName = _database;
            myConnectionInfo.UserID = _username;
            myConnectionInfo.Password = _password;

            Tables myTables = _report.Database.Tables;
            TableLogOnInfo myTableLogonInfo = new TableLogOnInfo();
            myTableLogonInfo.ConnectionInfo = myConnectionInfo;

            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                mytable.ApplyLogOnInfo(myTableLogonInfo);

                mytable.LogOnInfo.ConnectionInfo.DatabaseName = myTableLogonInfo.ConnectionInfo.DatabaseName;
                mytable.LogOnInfo.ConnectionInfo.ServerName = myTableLogonInfo.ConnectionInfo.ServerName;
                mytable.LogOnInfo.ConnectionInfo.UserID = myTableLogonInfo.ConnectionInfo.UserID;
                mytable.LogOnInfo.ConnectionInfo.Password = myTableLogonInfo.ConnectionInfo.Password;
            }
        }

        private void ReportViewerform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void ReportViewerform_Load(object sender, EventArgs e)
        {
            DisplayReport();
        }

        private void CrysViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
