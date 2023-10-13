using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic.Master.Repository;
using AMSLogic.Model;
using System.Threading;
using AMS.Inquiry;
using System.Diagnostics;
using AMS.Admin;
using AMSLogic.Transaction.Repository;

namespace AMS.Transaction.Request
{
    public partial class RequestDocumentform : Form
    {
        Requestform _parent;
        int _id = 0;
        int _mode = 0;

        private string _scandocument;
        private string _docext;
        private string _filename;
        private string _location;
        private string _previous_location;

        public RequestDocumentform(Requestform _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
        }

        private void RequestDocumentform_Load(object sender, EventArgs e)
        {
            RequestRepository _i = new RequestRepository();
            try
            {
                DisplayRecord(_i.GetRequestDocument(_parent._id, 0));
                DisplayAssetDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(INV_REQUEST_DOCUMENT _obj)
        {
            try
            {
                if (_obj != null)
                {
                    _id = _obj.id;

                    txtDocumentType.Text = _obj.SYS_DOCUMENT_TYPE.document_name;
                    txtDocumentType.Tag = _obj.document_type_id.ToString();


                    txtRemarks.Text = _obj.remarks;
                    txtFilepath.Text = _obj.file_location;

                    if (_obj.file_location == null) { _previous_location = ""; }
                    else { _previous_location = _obj.file_location + @"\\" + _obj.file_name; }

                    _docext = _obj.doc_extension;
                    _filename = _obj.file_name;
                    _location = _obj.file_location;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtDocumentType.Text = "";
            txtDocumentType.Tag = 0;
            txtRemarks.Text = "";
            txtFilepath.Text = "";

            _id = 0;
            _docext = "";
            _filename = "";
            _location = "";
        }

        void DisplayAssetDocuments()
        {
            RequestRepository _i = new RequestRepository();
            dgvDoc.RowCount = 0;
            int n;

            try
            {
                List<INV_REQUEST_DOCUMENT> _files = _i.GetRequestDocuments(_parent._id);
                foreach (INV_REQUEST_DOCUMENT _list in _files)
                {
                    n = dgvDoc.Rows.Add();
                    dgvDoc.Rows[n].Cells[0].Value = _list.id.ToString();
                    dgvDoc.Rows[n].Cells[1].Value = "Open";
                    dgvDoc.Rows[n].Cells[2].Value = _list.SYS_DOCUMENT_TYPE.document_name;
                    dgvDoc.Rows[n].Cells[3].Value = _list.remarks;


                    if (_list.doc_extension == ".xlsx" || _list.doc_extension == ".xls")
                    { dgvDoc.Rows[n].Cells[4].Value = AIMS.Properties.Resources.Excel_48; }
                    else if (_list.doc_extension == ".docx" || _list.doc_extension == ".doc")
                    { dgvDoc.Rows[n].Cells[4].Value = AIMS.Properties.Resources.Word_32; }
                    else if (_list.doc_extension == ".JPG" || _list.doc_extension == ".jpeg" || _list.doc_extension == ".JPEG" || _list.doc_extension == ".JPG" || _list.doc_extension == ".jpg" || _list.doc_extension == ".bmp" || _list.doc_extension == ".gif" || _list.doc_extension == ".png" || _list.doc_extension == "ico" || _list.doc_extension == ".xps" || _list.doc_extension == ".XPS")
                    { dgvDoc.Rows[n].Cells[4].Value = AIMS.Properties.Resources.JPG; }
                    else if (_list.doc_extension == ".pdf" || _list.doc_extension == ".PDF")
                    { dgvDoc.Rows[n].Cells[4].Value = AIMS.Properties.Resources.Reader_48; }
                    else if (_list.doc_extension == ".ppt" || _list.doc_extension == ".pptx")
                    { dgvDoc.Rows[n].Cells[4].Value = AIMS.Properties.Resources.PowerPoint_48; }
                    else
                    { dgvDoc.Rows[n].Cells[4].Value = AIMS.Properties.Resources.Cancel; }

                    dgvDoc.Rows[n].Cells[5].Value = _list.SYS_USER.username;
                    dgvDoc.Rows[n].Cells[6].Value = _list.date_created.ToShortDateString();

                    n++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_documentype_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }

            Searchform _searchform = new Searchform();
            _searchform._searchby = "DOCUMENT TYPE";
            _searchform.BringToFront();
            _searchform.ShowDialog();

            SYS_DOCUMENT_TYPE _documenttype = _searchform.ReturnSearchDocumentType;
            if (_documenttype != null)
            {
                txtDocumentType.Text = _documenttype.document_name;
                txtDocumentType.Tag = int.Parse(_documenttype.id.ToString());
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }
            try
            {
                OFD1.Title = "Select a file";

                OFD1.Filter = "MS Excel(*.xls;*.xlsx)|*.xls;*.xlsx|" +
                "MS Word(*.doc;*.docx)|*.doc;*.docx|" +
                "MS Powerpoint(*.ppt;*.pptx)|*.ppt;*.pptx|" +
                "Acrobat reader(*.pdf)|*.pdf|" +
                "Picture(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png|" +
                "All Files(*.*)|*.*";

                OFD1.FilterIndex = 6;
                OFD1.FileName = "";
                OFD1.ShowDialog();

                if (OFD1.FileName == "") { return; }

                txtFilepath.Text = OFD1.FileName;

                _scandocument = OFD1.FileName;
                _docext = System.IO.Path.GetExtension(_scandocument);
                _filename = System.IO.Path.GetFileNameWithoutExtension(_scandocument);
                _location = System.IO.Path.GetDirectoryName(_scandocument);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            ClickAddBtn();
        }

        void ClickAddBtn()
        {
            _mode = 0;

            EnabledButton(true);
            EnableForm(true);

            InitializeField();
            txtDocumentType.Focus();
        }

        void EnabledButton(bool _cond)
        {
            add_btn.Enabled = !_cond;
            edit_btn.Enabled = !_cond;
            delete_btn.Enabled = !_cond;
            print_btn.Enabled = !_cond;

            save_btn.Enabled = _cond;
            cancel_btn.Enabled = _cond;
        }

        void EnableForm(bool _cond)
        {
            txtRemarks.ReadOnly = !_cond;
        }

        private void dgvDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            try
            {
                RequestRepository _i = new RequestRepository();
                _id = int.Parse(dgvDoc.Rows[e.RowIndex].Cells[0].Value.ToString());
                DisplayRecord(_i.GetRequestDocument(_parent._id, _id));

                if (e.ColumnIndex == 1)                     //Open
                {
                    OpenFile();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void OpenFile()
        {
            RequestRepository _i = new RequestRepository();
            string _path = _i.GetDocumentPath(_parent._id, _id);

            if (_path != "File not found")
            {
                Process.Start(_path);
            }
            else { MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancel();
        }

        void cancel()
        {
            EnabledButton(false);
            EnableForm(false);

            RequestRepository _i = new RequestRepository();
            DisplayRecord(_i.GetRequestDocument(_parent._id, _id));
            DisplayAssetDocuments();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (txtDocumentType.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDocumentType);
                txtDocumentType.Focus();
                return;
            }

            if (txtFilepath.Text == "")
            {
                btxMsg.ShowBalloon(txtFilepath);
                txtFilepath.Focus();
                return;
            }

            ManageAssetDocument();
        }

        void ManageAssetDocument()
        {
            RequestRepository _i = new RequestRepository();
            INV_REQUEST_DOCUMENT _file = new INV_REQUEST_DOCUMENT();

            try
            {
                _file.request_id = _parent._id;
                _file.id = _id;

                _file.document_type_id = int.Parse(txtDocumentType.Tag.ToString());
                _file.remarks = txtRemarks.Text;

                if (txtFilepath.Text == "")
                {
                    _file.doc_extension = null;
                    _file.file_name = null;
                    _file.file_location = null;
                }
                else
                {
                    _file.doc_extension = _docext;
                    _file.file_name = _filename;
                    _file.file_location = _location;
                }

                _id = _i.ManageRequestDocument(_file, _mode);

                if (_mode == 0) { _file.id = _id; }


                if (_mode == 2)         //delete save file
                {
                    _id = _i.ManageScannedRqesutDocument(_file, _mode);
                }
                else
                {
                    //save scanned documents
                    if (_previous_location == "" && _file.file_location != "")
                    {
                        _id = _i.ManageScannedRqesutDocument(_file, _mode);
                    }
                    else if (_previous_location != "" && _previous_location != (_file.file_location + @"\\" + _file.file_name))
                    {
                        _id = _i.ManageScannedRqesutDocument(_file, _mode);
                    }
                }

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Successfully Saved"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deleted!"); }

                cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Kindly select a record first before editing.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EnabledButton(true);
            EnableForm(true);

            _mode = 1;
            txtDocumentType.Focus();
        }

        private void txtDocumentType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_documentype.PerformClick(); }
        }

        private void OFD1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
