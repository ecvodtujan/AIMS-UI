using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Microsoft.Win32;

using AMS;
using AMS.Admin;

using AMSLogic.Admin;
using AMSLogic.Model;

namespace AMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;

            try
            {
                var mutex = new System.Threading.Mutex(true, "AIMS", out result);

                if (!result)
                {
                    MessageBox.Show("Another instance of Asset Information and Management System is already running.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                AdminRepository _i = new AdminRepository(); 
                string _msg = _i.CheckIfValidAppVerion("AIMS");
                if (_msg != "")
                {
                    MessageBox.Show(_msg, "Version Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new mdiMain());

                GC.KeepAlive(mutex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
