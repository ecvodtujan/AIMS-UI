using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMSLogic.Model;
using AMS.Admin;
using AMS.Report;
using AMS.Inquiry;
using AMSLogic.Master.Repository;
using AMS.MasterFile.Plan;

namespace AMS.MasterFile
{
    public partial class PlanMasterform : Form
    {
        
        public int _plan_id = 0;
        public string _plancontent;
        public int _id = 0;
        int _mode = 0;
       
        public object PlanInclusioncontrol
        { get; internal set; }
        public PlanMasterform(int _Plan_Id)
        {
            InitializeComponent();  
            _plan_id = _Plan_Id;
        }

        private void PlanMasterform_Load(object sender, EventArgs e)
        {
          //  DisplayRecords123();
           DisplayRecords();
            PlanRepository _plan = new PlanRepository();
            DisplayRecord(_plan.GetSysPlan(_id));

            ClickPlanInclusion();
            // Inclusion();
           btnInclusion.PerformClick();
           planLsvList.Focus();
            txtPlanFilter.Text = "Search Plan...";
            
        }
        void InitializeForm()
        {
            txtDescription.Text = "";
            txtHandset.Text = "";
            txtRemarks.Text = "";
            txtUser.Text = "";
            txtDateCreated.Text = "";

        }
        
        void EnableForm(bool _plan)

        {
            txtDescription.ReadOnly = !_plan;
            txtHandset.ReadOnly = !_plan;
            txtRemarks.ReadOnly = !_plan;            
        }

        void EnableSaveButton(bool _plan)
        {
            plan_add_btn.Enabled = !_plan;
            plan_edit_btn.Enabled = !_plan;
            plan_print_btn.Enabled = !_plan;

            plan_save_btn.Enabled = _plan;
            plan_cancel_btn.Enabled = _plan;
          
        }
        void Cancel()
        {
            PlanRepository _planrepo = new PlanRepository();
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecord(_planrepo.GetSysPlan(_id));
            DisplayRecords();
        }

        void ManageRecord()
        {
            PlanRepository _planrepo = new PlanRepository();
            SYS_PLAN _obj = new SYS_PLAN();
            try
            {
                _obj.id = _id;
                _obj.description = txtDescription.Text;
                _obj.handset_value = decimal.Parse(txtHandset.Text);
                _obj.remarks = txtRemarks.Text;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;
                _id = _planrepo.ManageSysPlan(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Saved Successfully"); }
                Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void planLsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (planLsvList.SelectedItems.Count == 0) { return; }
            try
            {
                {
                    _id = int.Parse(planLsvList.SelectedItems[0].Text);
                    PlanRepository _planrepo = new PlanRepository();
                    DisplayRecord(_planrepo.GetSysPlan(_id));  
           
                  //  lbl8.Text = _id.ToString();

                    
                        //btnInclusionclick();
                        if (_plancontent == "INCLUSION")
                        {
                            btnInclusion.PerformClick();
                        }

                        else if (_plancontent == "INCLUSIVE")
                        {
                            btnInclusive.PerformClick();
                        }
                        else if (_plancontent == "UPGRADE")
                        {
                            btnUpgrade.PerformClick();
                        }
                    
                }
           

                }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        //void btnInclusionclick()
        //{
            
        //    btnInclusion.PerformClick();
        //    btnInclusion.Focus();
        //}

        //void btnInclusiveclick()
        //{
        //    btnInclusion.PerformClick();
        //    btnInclusion.Focus();
        //}

        void planLsvclick()
        {

            //if (btnInclusion != null)
            //{
            //    btnInclusion.PerformClick();
            //    PlanInclusioncontrol _inclusion = new PlanInclusioncontrol();
            //    _inclusion.Focus();
            //}
            //else if (btnInclusive !=null)
            //{
            //    btnInclusive.PerformClick();
            //    PlanInclusivecontrol _inclusive = new PlanInclusivecontrol();
            //    _inclusive.Focus();
            //}

            //else if (btnUpgrade !=null)
            //{
            //    btnUpgrade.PerformClick();
            //    PlanUpgradecontrol _upgrade = new PlanUpgradecontrol();
            //    _upgrade.Focus();
            //}
        }
        void Refreshform()
        {
            //PlanInclusioncontrol _inclusion = new PlanInclusioncontrol(_id);
            //_inclusion.Refresh();

        }

        private void btn_plan_inclusion(object sender, KeyEventArgs e)
        {
           
        }

        private void btn_plan_inclusive(object sender, KeyEventArgs e)
        {

        }

        private void btn_plan_upgrade(object sender, KeyEventArgs e)
        {

        }

        void DisplayRecords123()
        {
            ////PlanRepository _planrepo = new PlanRepository();
            ////Lsv.Items.Clear();
            ////try
            ////{
            ////    List<SYS_PLAN> _plan = new List<SYS_PLAN>();
            ////    _plan = (from d in _planrepo.GetSysPlans(txtPlanFilter.Text) orderby d.description select d).ToList();
            ////    foreach (SYS_PLAN _d in _plan)
            ////    {
            ////        ListViewItem _plans = new ListViewItem
            ////       (_d.id.ToString());
            ////        _plans.SubItems.Add(_d.description);
            ////        _plans.SubItems.Add(_d.handset_value.ToString());
            ////        Lsv.Items.Add(_plans);

            //    }
            //}
            //catch (Exception ex)
            //{ MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void DisplayRecords()
        {
            PlanRepository _planrepo = new PlanRepository();
            planLsvList.Items.Clear();
            try
            {
                List<SYS_PLAN> _plan = new List<SYS_PLAN>();
                _plan = (from d in _planrepo.GetSysPlans(txtPlanFilter.Text) orderby d.description select d).ToList();
                foreach ( SYS_PLAN _d in _plan)
                {
                    ListViewItem _plans = new ListViewItem
                        (_d.id.ToString());
                    _plans.SubItems.Add(_d.description);
                    _plans.SubItems.Add(_d.handset_value.ToString());
                    planLsvList.Items.Add(_plans);
                   
                }
            }
            catch( Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        void DisplayRecord(SYS_PLAN _obj)
        {
            PlanRepository _planrepo = new PlanRepository();
            try
            {
                SYS_PLAN _sobj = new SYS_PLAN();
                _sobj = _planrepo.GetSysPlan(_id);
                if ( _sobj != null)
                {
                    _id = _obj.id;
                    txtDescription.Text = _obj.description;
                    txtHandset.Text = _obj.handset_value.ToString();
                    txtRemarks.Text = _obj.remarks;
                    txtUser.Text = _obj.SYS_USER.username;
                    txtDateCreated.Text = _obj.date_created.ToShortDateString();
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void ClickPlanInclusion()
        {
            ClearPanel();

            var _control = new PlanInclusioncontrol(this);
            AddControl(_control);
        }
        void ClearPanel()
        {
            panExpanPlan.Controls.Clear();
          
        }
        void AddControl(Control _control)
        {
            _control.Dock = DockStyle.Fill;
            panExpanPlan.Controls.Add(_control);
        }

        private void btnInclusion_Clck(object sender, EventArgs e)
        {
            ClickPlanInclusion();
         
            _plancontent = "INCLUSION";
        }

        private void btnInclusive_Click(object sender, EventArgs e)
        {
           ClickPlanInclusive();
            _plancontent = "INCLUSIVE";
    

        }

        void ClickPlanInclusive()
        {

            ClearPanel();

            var _control = new PlanInclusivecontrol(this);
            AddControl(_control);
        }

        void ClickPlanUpgrade()
        {
            ClearPanel();
                
            var _control = new PlanUpgradecontrol(this);
            AddControl(_control);
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            ClickPlanUpgrade();
            _plancontent = "UPGRADE";
         

        }

        private void plan_save_btn_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                btxMsg.ShowBalloon(txtDescription);
                txtDescription.Focus();
                return;
            }
            ManageRecord();
        }

        private void plan_print_btn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Coming Soon", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReportViewerform _report = new ReportViewerform("PLAN PRINT OUT");
            _report._plan_id = _id;
            _report.BringToFront();
            _report.Show();


        }

        private void plan_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableForm(true);
            EnableSaveButton(true);
            txtDescription.Focus();
        }

        private void plan_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            EnableForm(true);
            EnableSaveButton(true);
            txtDescription.Focus();
            InitializeForm();
        }

        //private void txtPlanFilter(object sender, KeyEventArgs e)
        //{

        //}

        private void txtPlanFilter_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayRecords();
            }
        }

        private void PlanMasterfile_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void plan_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            PlanRepository _planrepo = new PlanRepository();
            DisplayRecord(_planrepo.GetSysPlan(_id));
        }

        private void lbl8_Click(object sender, EventArgs e)
        {

        }

        private void txtFilter_click(object sender, EventArgs e)
        {
           txtPlanFilter.Text = "";
        }

        private void txtPlanFilter_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtPlanFilter_cursor(object sender, EventArgs e)
        {
            
        }

        private void txtfiltermouseleave(object sender, EventArgs e)
        {
           
        }

        private void txtPlanFilter_mouseleave(object sender, EventArgs e)
        {
           txtPlanFilter.Text = "Search Plan....";
        }

        private void planListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lsv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPlanFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void panFoot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
