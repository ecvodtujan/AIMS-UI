using Balloon;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AMS.Admin
{
    public class ToolsControl

    {
        public static void CallPopMessage(System.Windows.Forms.Control _form, string _header, string _body)
        {
            try
            {
                ToolsControl _control = new ToolsControl();
                _control.PopMessage(_form, _header, _body);
            }
            catch (Exception ex)
            {

            }

        }

        private AlertCustom m_AlertOnLoad = null;
        public void PopMessage(System.Windows.Forms.Control _form, string _header, string _body)
        {
            m_AlertOnLoad = new AlertCustom(_header, _body);
            Rectangle r = Screen.GetWorkingArea(_form);
            m_AlertOnLoad.Location = new Point(r.Right - m_AlertOnLoad.Width, r.Bottom - m_AlertOnLoad.Height);
            m_AlertOnLoad.AutoClose = true;
            m_AlertOnLoad.AutoCloseTimeOut = 5;
            m_AlertOnLoad.AlertAnimation = eAlertAnimation.BottomToTop;
            m_AlertOnLoad.AlertAnimationDuration = 300;
            m_AlertOnLoad.Show(false);
        }

        public static void CallShowNotification(System.Windows.Forms.Control _form, int _mode, string _message)
        {
            try
            {
                ToolsControl _control = new ToolsControl();
                _control.ShowNotification(_form, _mode, _message);
            }
            catch (Exception ex)
            {

            }
        }

        public void ShowNotification(System.Windows.Forms.Control _form, int _mode, string _message)
        {

            //if (_mode == 2)
            //{
            //    ToastNotification.Show(_form, "Record succesfully Deleted", AMS.Properties.Resources.Cancel.ToBitmap(), 3000);
            //}
            //else 
            //if (_mode == 1 || _mode == 0)
            //{
            //    ToastNotification.Show(_form, "Record succesfully Saved", AMS.Properties.Resources.Save.ToBitmap(), 3000);
            //}

            if (_mode == 1 || _mode == 0)
            {
                ToastNotification.Show(_form, _message, AIMS.Properties.Resources.Information.ToBitmap(), 3000);
            }
            else  if (_mode == 2 || _mode == 3)
            {
                ToastNotification.Show(_form, _message, AIMS.Properties.Resources.Information.ToBitmap(), 3000);
            }
        }
    }
}
