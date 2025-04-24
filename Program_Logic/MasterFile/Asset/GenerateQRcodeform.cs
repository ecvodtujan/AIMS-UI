using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QRCoder;
using AMSLogic.Model;
using System.IO;

using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

//using Spire.Barcode;
//using Spire.License;


namespace AMS.MasterFile.Asset
{
    public partial class GenerateQRcodeform : Form
    {
        AssetQRInformation _qrinformation;
        public GenerateQRcodeform(AssetQRInformation _Qrinformation)
        {
            InitializeComponent();

            _qrinformation = _Qrinformation;
        }

        private void GenerateQRcodeform_Load(object sender, EventArgs e)
        {

        }

        private void btn_itemtype_Click(object sender, EventArgs e)
        {
            //AssetQRInformation _qrinformation = new AssetQRInformation();
            //_qrinformation._asset_id = _parent._asset_id;
            //_qrinformation._asset_code = txtBarcode.Text;
            //_qrinformation._item_type = txtItemType.Text;
            //_qrinformation._brand_name = txtBrand.Text;
            //_qrinformation._serial_no = txtSerialno.Text;
            //_qrinformation._host_name = txtHostname.Text;
            //_qrinformation._manufacturing_date = dtDateofMfg.Checked ? dtDateofMfg.Value.ToShortDateString() : "N/A";
            //_qrinformation._purchase_date = dtpPurchaseDate.Checked ? dtpPurchaseDate.Value.ToShortDateString() : "N/A";
            //_qrinformation._warranty_date = dtpDateWarranty.Checked ? dtpDateWarranty.Value.ToShortDateString() : "N/A";
            //_qrinformation._current_owner = txtOwner.Text;
            //_qrinformation._date_issued = dtDeployed.Text == "" ? dtDeployed.Text : "N/A";
            //_qrinformation._date_generated = DateTime.Now.ToShortDateString();
            //_qrinformation._time_generated = DateTime.Now.ToShortTimeString();

            try
            {
                string _qrcode = //"asset id           : " + _qrinformation._asset_id.ToString() + System.Environment.NewLine +
                                 //  --   "Asset Code         : " + _qrinformation._asset_code + System.Environment.NewLine +
                                 //     //   "item type          : " + _qrinformation._item_type + System.Environment.NewLine +
                                 //--     "Brand/Model              : " + _qrinformation._brand_name + System.Environment.NewLine +
                                 //  //   "Model              : " + _qrinformation._model + System.Environment.NewLine +
                                 // --    "Serial no          : " + _qrinformation._serial_no + System.Environment.NewLine +
                                 //     //  "host name          : " + _qrinformation._host_name + System.Environment.NewLine +
                                 //     // "manufacturing date : " + _qrinformation._manufacturing_date + System.Environment.NewLine +
                                 //     //  "date purchase      : " + _qrinformation._purchase_date + System.Environment.NewLine +
                                 //  --   "Warranty date      : " + _qrinformation._warranty_date + System.Environment.NewLine  +//+
                                 //     // "Current owener     : " + _qrinformation._current_owner + System.Environment.NewLine +
                                 //     //  "date issued        : " + _qrinformation._date_issued + System.Environment.NewLine +
                                 //     // "date generated     : " + _qrinformation._date_generated + System.Environment.NewLine +
                                 //     // "time generated     :" + _qrinformation._time_generated;
                                //"http://www.AIMS.wardhowell.com.ph/192.168.20.68/Asset/Information?GUID=" + _qrinformation._guid + System.Environment.NewLine;
                                "http://www.AIMS.wardhowell.com.ph/Asset/Information?GUID=" + _qrinformation._guid + System.Environment.NewLine;

                // QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
                // QRCodeData data = qr.CreateQrCode(_qrcode, QRCoder.QRCodeGenerator.ECCLevel.Q);
                // QRCode code = new QRCode(data);
                //// picQR.Image = code.GetGraphic(5);
                // Bitmap bitmap = new Bitmap(@"/ZMGwhite.png");
                // Color clr = bitmap.GetPixel(0, 0);
                // Bitmap qrCodeImage = code.GetGraphic(20);

             // current to 
                                ////
                                BarcodeWriter barcodeWriter = new BarcodeWriter();
                                EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
                                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                                barcodeWriter.Renderer = new BitmapRenderer();
                                //{ Foreground = Color.FromArgb(8, 42, 94) };
                                barcodeWriter.Options = encodingOptions;
                                barcodeWriter.Format = BarcodeFormat.QR_CODE;

                                Bitmap bitmap = barcodeWriter.Write(_qrcode);
                                //string logopath = @"C:\Users\eclvillanueva\Pictures\zmg logo2.png";
                                Bitmap logo = new Bitmap($"{Application.StartupPath}/ZMGwhite.png");
                                //Bitmap logo = new Bitmap(logopath);
                                Graphics g = Graphics.FromImage(bitmap);

                                //int _width = (logo.Width - bitmap.Width ) / 2;
                                //int _height = (logo.Height - bitmap.Height ) / 2;

                                g.DrawImage(logo, new Point(  100, 120));
                                picQR.Image = bitmap;
                
                /*
      
                            //    Load a license file if you have one
                            //    LicenseProvider.SetLicenseFileFullPath("license.elic.xml");
                             //   Spire.License.

                              //  Instantiate a BarcodeSettings object    //Spire barcode
                                BarcodeSettings settings = new BarcodeSettings();

                             //   Specify barcode type, data, etc.
                                settings.Type = BarCodeType.QRCode;
                                settings.QRCodeECL = QRCodeECL.M;
                                settings.ShowText = false;
                                settings.X = 2.5f;
                                string data = _qrcode;
                                settings.Data = data;
                                settings.Data2D = data;

                              //  Add an image to QR code
                                settings.QRCodeLogoImage = Image.FromFile(@"C:\ZMG SYSDEV\ZMG SYSTEM\AIMS-UI\AIMS-UI\Program_Logic\bin\Debug\ZMGwhite.png");

                             //   Instantiate a BarCodeGenerator object
                                BarCodeGenerator generator = new BarCodeGenerator(settings);
                             //   Generate QR image
                           picQR.Image  = generator.GenerateImage();
                             //   Save the image
                          //      image.Save("QR.png", System.Drawing.Imaging.ImageFormat.Png);
                            */ 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateQRcodeform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
                PrintDialog myPrinDialog1 = new PrintDialog();
                myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
                myPrinDialog1.Document = myPrintDocument1;
                if (myPrinDialog1.ShowDialog() == DialogResult.OK)
                {
                    myPrintDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(picQR.Width, picQR.Height);
            picQR.DrawToBitmap(myBitmap1, new Rectangle(0, 0, picQR.Width, picQR.Height));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
        }
    }
}
