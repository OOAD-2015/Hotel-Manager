using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.General
{
    class CheckInformationEntered
    {
        public static void checkCharacterInput(KeyPressEventArgs _event, int _allow)
        {
            switch (_allow)
            {
                case 0://chỉ cho nhập ký tự Unicode
                    {
                        if (char.IsDigit(_event.KeyChar) || char.IsSymbol(_event.KeyChar) || char.IsPunctuation(_event.KeyChar))
                        {
                            _event.Handled = true;
                        }
                        break;
                    }
                case 1://Chỉ cho phép nhập số vào
                    {
                        if ((char.IsLetter(_event.KeyChar) && _event.KeyChar != '.') || char.IsSymbol(_event.KeyChar) || char.IsPunctuation(_event.KeyChar))
                        {
                            _event.Handled = true;
                        }
                        break;
                    }
                case 2://Cho phép nhập số, ký tự unicode, dấu ".", ",", "-", "/", "@"
                    {
                        if (char.IsSymbol(_event.KeyChar) || char.IsPunctuation(_event.KeyChar))
                        {
                            if ((_event.KeyChar == '-' || _event.KeyChar == '/' || _event.KeyChar == ','))
                            {
                            }
                            else
                            {
                                _event.Handled = true;
                            }
                        }
                        break;
                    }
                case 3://Cho phép nhập số, Ký tự Unicode, ko có dấu "-"
                    {
                        if (char.IsSymbol(_event.KeyChar) || char.IsPunctuation(_event.KeyChar))
                        {
                            if (!(_event.KeyChar == '-'))
                                _event.Handled = true;

                        }
                        break;
                    }
            }

        }
        public static bool checkDataInput(Control _control, String _erroContent, ref DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider _dxErroControl)
        {
            if (String.IsNullOrEmpty(_control.Text) || String.IsNullOrWhiteSpace(_control.Text) || _control.Text == "0")
            {
                _dxErroControl.SetError(_control, _erroContent);
                return false;
            }
            else
            {
                _dxErroControl.ClearErrors();
                return true;
            }
        }

        //Hàm kiểm tra thử địa chỉ Email có đúng định dạng hay không?
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return true;
            else
                return false;
        }

        //Hàm để kiểm tra với ngày nhập vào với ngày cho trước
        public static bool checkDate(DateTime dateInput, DateTime dateCondition)
        {
            if ((dateInput - dateCondition).Days >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
