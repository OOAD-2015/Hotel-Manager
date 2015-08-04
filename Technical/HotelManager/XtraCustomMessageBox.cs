using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class XtraCustomMessageBox : Form
    {
        private static XtraCustomMessageBox m_message;
        private static DialogResult m_result = DialogResult.OK;
        public XtraCustomMessageBox()
        {
            InitializeComponent();
        }

        /*
        * Type: 1: information
        * Type: 2: Question
        * Type: 3: Warning
        * Type: 4: Error
        * */
        public static DialogResult Show(String Text, String Caption, bool useDefault, int iType)
        {
            m_message = new XtraCustomMessageBox();
            m_message.labInfo.Text = Text;
            m_message.StartPosition = FormStartPosition.CenterParent;
            if (m_message.labInfo.Location.Y + m_message.labInfo.Height > m_message.panelView.Location.Y + m_message.panelView.Height)
                m_message.Height = m_message.Height + m_message.labInfo.Location.Y + m_message.labInfo.Height - m_message.panelView.Location.Y - m_message.panelView.Height;
            m_message.Text = Caption;
            if (useDefault)
            {
                m_message.btnYes.Location = m_message.btnOK.Location;
                m_message.btnNo.Visible = false;
                m_message.btnOK.Visible = false;
                m_message.btnYes.Text = "Vâng";
            }
            //Image for Dialog
            switch (iType)
            {
                case 1://Information
                    m_message.picBoxImageShow.Image = Properties.Resources.ic_information;
                    m_message.btnOK.Visible = true;
                    m_message.btnYes.Visible = false;
                    m_message.btnNo.Visible = false;
                    break;
                case 2://Question
                    m_message.picBoxImageShow.Image = Properties.Resources.ic_question;
                    //m_message.btnYes.Location = m_message.btnOK.Location;
                    m_message.btnOK.Visible = false;
                    m_message.btnYes.Visible = true;
                    m_message.btnNo.Visible = true;
                    break;
                case 3://Warning
                    m_message.picBoxImageShow.Image = Properties.Resources.ic_warning_circle;
                    m_message.btnOK.Visible = true;
                    m_message.btnYes.Visible = false;
                    m_message.btnNo.Visible = false;
                    break;
                case 4://Error
                    m_message.picBoxImageShow.Image = Properties.Resources.ic_error;
                    m_message.btnOK.Visible = true;
                    m_message.btnYes.Visible = false;
                    m_message.btnNo.Visible = false;
                    break;
                case 0:
                    m_message.picBoxImageShow.Image = null;
                    m_message.btnOK.Visible = true;
                    m_message.btnYes.Visible = false;
                    m_message.btnNo.Visible = false;
                    break;
            }

            m_message.ShowDialog();
            return m_result;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            m_result = DialogResult.OK;
            m_message.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            m_result = DialogResult.Yes;
            m_message.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            m_result = DialogResult.No;
            m_message.Close();
        }
    }
}
