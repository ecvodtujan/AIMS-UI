using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic.Model;
using AMS.MasterFile;

using AMSLogic.Master.Repository;

namespace AMS.Inquiry
{
    public partial class Searchform : Form
    {
        public string _searchby;
        public int _companyid;
        public string _class;

        private int _id = 0;
        BrandRepository _brandrepo = new BrandRepository();
        EmployeeRepository _employeerepo = new EmployeeRepository();
        ItemTypeRepository _itemtyperepo = new ItemTypeRepository();
        UserRepository _userrepo = new UserRepository();
        CompanyRepository _companyrepo = new CompanyRepository();
        SupplierRepository _supplierrepo = new SupplierRepository();
        DepartmentRepository _deptrepo = new DepartmentRepository();
        DocumentTypeRepository _documentrepo = new DocumentTypeRepository();
        PositionRepository _postrepo = new PositionRepository();
        ReasonRepository _reasonrepo = new ReasonRepository();

        #region ReturnValue
        public SYS_BRAND ReturnSearchBrand
        {
            get { return _id == 0 ? null : _brandrepo.GetBrand(_id); }
        }

        public EMP_EMPLOYEE ReturnSearchEmployee
        {
            get { return _id == 0 ? null : _employeerepo.GetEmployee(_id); }
        }

        public INV_TYPE ReturnSearchItemtype
        {
            get { return _id == 0 ? null : _itemtyperepo.GetitemType(_id); }
        }

        public SYS_USER ReturnSearchUser
        {
            get { return _id == 0 ? null : _userrepo.GetUser(_id); }
        }

        public SYS_COMPANY ReturnSearchCompany
        {
            get { return _id == 0 ? null : _companyrepo.GetCompany(_id); }
        }

        public SYS_SUPPLIER ReturnSearchSupplier
        {
            get { return _id == 0 ? null : _supplierrepo.GetSupplier(_id); }
        }
        public INV_DEPARTMENT ReturnSearchDepartment
        {
            get { return _id == 0 ? null : _deptrepo.GetDept(_id); }
        }

        public SYS_DOCUMENT_TYPE ReturnSearchDocumentType
        {
            get { return _id == 0 ? null : _documentrepo.GetDocumentType(_id); }
        }
        public SYS_POSITION ReturnSearchPosition
        {
            get { return _id == 0 ? null : _postrepo.GetPosition(_id); }
        }
        public SYS_REASON ReturnSearchReason
        {
            get { return _id == 0 ? null : _reasonrepo.GetReason(_id); }
        }
        #endregion

        public Searchform()
        {
            InitializeComponent();
        }

        void InitializeGrid()
        {

          
            
            //set the listview column based on the search by variable
            try
            {
                if (_searchby == "BRAND")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Brand name", 400, HorizontalAlignment.Left);
                }
                else if (_searchby == "EMPLOYEE")
                {
                   
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Employee name", 350, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Company", 100, HorizontalAlignment.Left);
                   

                    
                 }
                else if (_searchby == "ITEM TYPE")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Item type", 400, HorizontalAlignment.Left);
                }

                else if (_searchby == "USER")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Username", 250, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Employee Name", 200, HorizontalAlignment.Left);
                    

                }
                else if (_searchby == "COMPANY")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Code", 80, HorizontalAlignment.Center);
                    lsvList.Columns.Add("Company Name", 300, HorizontalAlignment.Left);
                }
                else if (_searchby == "SUPPLIER")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Supplier name", 400, HorizontalAlignment.Left);
                    lsvList.Columns.Add("TIN no.", 80, HorizontalAlignment.Left);
                }
                else if (_searchby == "DEPARTMENT" || _searchby == "DEPARTMENT BY COMPANY")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Department", 200, HorizontalAlignment.Left);
                    //         lsvList.Columns.Add("Company", 300, HorizontalAlignment.Left);
                }
                else if (_searchby == "DOCUMENT TYPE")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Document type", 200, HorizontalAlignment.Left);
                }
                else if (_searchby == "POSITION")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Position", 200, HorizontalAlignment.Left);
                }

                else if (_searchby == "REASON" || _searchby == "REASON BY CLASS")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Reason Description", 200, HorizontalAlignment.Left);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecords()
        {
            //display record based on the search by variable
            try
            {
                if (txtKeyword.Text == "Enter Keyword here") { txtKeyword.Text = ""; }
                lsvList.Items.Clear();

                if (_searchby == "BRAND")
                {
                    List<SYS_BRAND> _lists = (from d in _brandrepo.GetBrands(txtKeyword.Text) orderby d.description select d).ToList();
                    foreach (SYS_BRAND _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.description);
                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == "EMPLOYEE")

                {
                    List<EMP_EMPLOYEE> _lists = (from e in _employeerepo.GetEmployees(txtKeyword.Text) orderby e.lastname select e).ToList();

                    foreach (EMP_EMPLOYEE _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.lastname + ", " + _list.firstname);
                        _item.SubItems.Add(_list.SYS_COMPANY.code);

                        lsvList.Items.Add(_item);
                    }



                }

                else if (_searchby == "ITEM TYPE")
                {
                    List<INV_TYPE> _lists = (from d in _itemtyperepo.GetitemTypes(txtKeyword.Text) orderby d.description select d).ToList();
                    foreach (INV_TYPE _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.description);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == "USER")
                {
                    List<SYS_USER> _lists = _userrepo.Getusers(txtKeyword.Text);
                    foreach (SYS_USER _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.username);
                        _item.SubItems.Add(_list.employee_name);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == "COMPANY")
                {
                    List<SYS_COMPANY> _lists = (from d in _companyrepo.GetCompanies(txtKeyword.Text) orderby d.code, d.description select d).ToList();
                    foreach (SYS_COMPANY _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.code);
                        _item.SubItems.Add(_list.description);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == "SUPPLIER")
                {
                    List<SYS_SUPPLIER> _lists = _supplierrepo.GetSuppliers(txtKeyword.Text);
                    foreach (SYS_SUPPLIER _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.supplier_name);
                        _item.SubItems.Add(_list.tin);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == "DEPARTMENT")
                {
                    List<INV_DEPARTMENT> _lists = _deptrepo.GetDepts(txtKeyword.Text);
                    foreach (INV_DEPARTMENT _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.department);
                        //   _item.SubItems.Add(_list.SYS_COMPANY.description);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == "DEPARTMENT BY COMPANY")
                {
                    List<INV_DEPARTMENT> _lists = (from d in _deptrepo.GetDepartmentByCompany(txtKeyword.Text, _companyid) orderby d.department select d).ToList();
                    foreach (INV_DEPARTMENT _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.department);
                        //   _item.SubItems.Add(_list.SYS_COMPANY.description);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == "DOCUMENT TYPE")
                {
                    List<SYS_DOCUMENT_TYPE> _lists = _documentrepo.GetDocumentTypes(txtKeyword.Text);
                    foreach (SYS_DOCUMENT_TYPE _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.document_name);

                        lsvList.Items.Add(_item);
                    }
                }


                else if (_searchby == "POSITION")
                {
                    List<SYS_POSITION> _lists = _postrepo.GetPositions(txtKeyword.Text);
                    foreach (SYS_POSITION _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.description);

                        lsvList.Items.Add(_item);
                    }

                }

                else if (_searchby == "REASON")
                {
                    List<SYS_REASON> _lists = _reasonrepo.GetReasons(txtKeyword.Text);
                    foreach (SYS_REASON _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.reaseon_description);
                        lsvList.Items.Add(_item);
                    }
                }

                else if (_searchby == "REASON BY CLASS")
                {
                    List<SYS_REASON> _lists = _reasonrepo.GetReasonsbyClass(txtKeyword.Text, _class);
                    foreach (SYS_REASON _list in _lists)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.reaseon_description);
                        lsvList.Items.Add(_item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void txtkeyword_GotFocus(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "Enter Keyword here")
            {
                Color _color_focus = Color.FromArgb(255, 255, 136);
                txtKeyword.Text = "";
                txtKeyword.BackColor = _color_focus;
            }
        }

        protected void txtkeyword_LostFocus(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "")
            {
                txtKeyword.Text = "Enter Keyword here";
                txtKeyword.BackColor = Color.White;
            }
        }

        private void lsvList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                _id = int.Parse(lsvList.SelectedItems[0].Text); 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Searchform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { return; }

            if (e.KeyCode == Keys.F1)
            {
                if (_searchby == "BRAND")
                {
                    BrandMasterform _brand = new BrandMasterform();
                    _brand.BringToFront();
                    _brand.ShowDialog();
                }
                else if (_searchby == "EMPLOYEE")
                {
                    EmployeeNewMasterform _employee = new EmployeeNewMasterform(0);
                    _employee.BringToFront();
                    _employee.ShowDialog();

                }
                else if (_searchby == "SUPPLIER")
                {
                    SupplierMasterform _supp = new SupplierMasterform();
                    _supp.BringToFront();
                    _supp.ShowDialog();
                }
                else if (_searchby == "COMPANY")
                {
                    CompanyMasterform _company = new CompanyMasterform();
                    _company.BringToFront();
                    _company.ShowDialog();
                }
                else if (_searchby == "ITEM TYPE")
                {
                    ItemTypeMasterform _type = new ItemTypeMasterform();
                    _type.BringToFront();
                    _type.ShowDialog();
                }
                else if (_searchby == "USER")
                {
                    UserMasterform _user = new UserMasterform();
                    _user.BringToFront();
                    _user.ShowDialog();
                }
                else if (_searchby == "DEPARTMENT" || _searchby == "DEPARTMENT BY COMPANY")
                {
                    DepartmentNewMasterform _dept = new DepartmentNewMasterform();
                    _dept.BringToFront();
                    _dept.ShowDialog();

                }
                else if (_searchby == "DOCUMENT TYPE")
                {
                    DocumentTypeMasterform _document = new DocumentTypeMasterform();
                    _document.BringToFront();
                    _document.ShowDialog();
                }
                else if (_searchby == "POSITION")
                {
                    DesignationMasterfile _post = new DesignationMasterfile();
                    _post.BringToFront();
                    _post.ShowDialog();
                }
                else if (_searchby =="REASON" || _searchby == "REASON BY CLASS")
                {
                    ReasonMasterform _reason = new ReasonMasterform();
                    _reason.BringToFront();
                    _reason.ShowDialog();
                }
            }
       
        }

        private void Searchform_Load(object sender, EventArgs e)
        {
            try
            {                
                InitializeGrid();
                
                DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)           //enter key pressed
            {
                DisplayRecords();
                lsvList.Focus();
            }
        }

        private void lsvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    _id = int.Parse(lsvList.SelectedItems[0].Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
