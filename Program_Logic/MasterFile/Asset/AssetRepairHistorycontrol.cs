using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AMS.MasterFile.Asset
{
    public partial class AssetRepairHistorycontrol : UserControl
    {
        AssetMasterform _parent;
        public AssetRepairHistorycontrol(AssetMasterform _Parent)
        {
            InitializeComponent();

            _parent = _Parent;

           // Bitmap logo = new Bitmap($"{Application.StartupPath}/ZMGwhite.png");
            
        }

        private void AssetRepairHistorycontrol_Load(object sender, EventArgs e)
        {
            Control ctr = new Control();
            try
            {
                //var imagePath = @"C:\Image.png";

                //Image bmp = new Bitmap(ctr.Width, ctr.Height);
                //var gg = Graphics.FromImage(bmp);
                //var rect = ctr.RectangleToScreen(ctr.ClientRectangle);
                //gg.CopyFromScreen(rect.Location, Point.Empty, ctr.Size);

                //bmp.Save(imagePath);
                //Process.Start(imagePath);
                MessageBox.Show("Coming Soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
