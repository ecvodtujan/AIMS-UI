using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic.Model;
using AMSLogic.Transaction;
using AMSLogic.Master;
using AMSLogic.Master.Repository;
using AMS.Transaction.Issuance;

namespace AMS.MasterFile.Asset
{
    public partial class AssetOwnerHistorycontrol : UserControl
    {
        //information here will coming from inv_issuance
        AssetMasterform _parent;
        int _issuance_id = 0;

        public AssetOwnerHistorycontrol(AssetMasterform _Parent)
        {
            InitializeComponent();
            
            _parent = _Parent;
        }

        private void AssetOwnerHistorycontrol_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        void DisplayRecords()
        {
            AssetRepository _iAsset = new AssetRepository();
            dgvHistory.RowCount = 0;
            int n = 0;

            try
            {
                List<INV_ISSUANCE> _issuances = _iAsset.GetAssetOwnerHistory(_parent._asset_id);
                if (_issuances.Count != 0)
                {
                    foreach (INV_ISSUANCE _list in _issuances)
                    {
                        n = dgvHistory.Rows.Add();
                        dgvHistory.Rows[n].Cells[0].Value = _list.id.ToString();
                        dgvHistory.Rows[n].Cells[1].Value = _list.date_issued.ToShortDateString();
                        dgvHistory.Rows[n].Cells[2].Value = _list.EMP_EMPLOYEE.lastname + ", " + _list.EMP_EMPLOYEE.firstname;
                        dgvHistory.Rows[n].Cells[3].Value = _list.SYS_USER.employee_name;

                        dgvHistory.Rows[n].Cells[4].Value = _list.remarks;

                        if (_list.is_history) { dgvHistory.Rows[n].Cells[5].Value = "Pullout"; }
                        else { dgvHistory.Rows[n].Cells[5].Value = "Current Owner"; }
                        
                        if (_list.date_pullout != null)
                        {
                            dgvHistory.Rows[n].Cells[6].Value = _list.date_pullout.Value.ToShortDateString();
                        }
                        else
                        {
                            dgvHistory.Rows[n].Cells[6].Value = "-";
                        }

                        if (_list.pullout_by != 0)
                        {
                            UserRepository _iuser = new UserRepository();
                            dgvHistory.Rows[n].Cells[7].Value = _iuser.GetUser(int.Parse(_list.pullout_by.ToString())).employee_name;
                        }
                        else { dgvHistory.Rows[n].Cells[7].Value = "-"; }      
                    }
                }
                else
                {
                    MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvRequest_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dgvHistory.HitTest(e.X, e.Y).RowIndex;

                if (rowIndex == -1) { return; }

                dgvHistory.ClearSelection();
                dgvHistory.Rows[rowIndex].Selected = true;

                _issuance_id = int.Parse(dgvHistory.Rows[rowIndex].Cells[0].Value.ToString());
                string _status = dgvHistory.Rows[rowIndex].Cells[5].Value.ToString();

                if (_status == "Current Owner") { tsmUpdate.Enabled = false; }
                else { tsmUpdate.Enabled = true; }

                dgvHistory.ContextMenuStrip = cntxMnu;
            }
        }

        private void AddEmployeeTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AssetPulloutform _pullout = new AssetPulloutform(6, _issuance_id ,0);
                _pullout.BringToFront();
                _pullout.ShowDialog();

                DisplayRecords();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
