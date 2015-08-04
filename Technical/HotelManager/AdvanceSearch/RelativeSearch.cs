using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.AdvanceSearch
{
    public class RelativeSearch
    {

        protected static char[] _Unicode = "ABCDEFGHIJKLMNOPQRSTUVWXYZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠạẢảẤấẦầẨẩẪẫẬậẮắẰằẲẳẴẵẶặẸẹẺẻẼẽẾếỀềỂểỄễỆệỈỉỊịỌọỎỏỐốỒồỔổỖỗỘộỚớỜờỞởỠỡỢợỤụỦủỨứỪừỬửỮữỰự".ToCharArray();
        protected static char[] _UNS = "abcdefghijklmnopqrstuvwxyzaaaaeeeiioooouuyaaaaeeeiioooouuyaaddiiuuoouuaaaaaaaaaaaaaaaaaaaaaaaaeeeeeeeeeeeeeeeeiiiioooooooooooooooooooooooouuuuuuuuuuuuuu".ToCharArray();
        protected static int _UnicodeLastIndex = _Unicode.Length - 1;

        protected char[][] _Template = null;
        // protected int _Index = 0;

        public RelativeSearch()
        {

            // _Index = columnIndex;
        }

        /// <summary>
        /// return false if after SetTemplate(...), _Template == null
        /// </summary>
        public bool SetTemplate(String template)
        {
            if (string.IsNullOrWhiteSpace(template) || template == "Tất cả")
            {
                _Template = null;
            }
            else
            {
                List<char[]> re = new List<char[]>();   // list for templates
                char[] temp = new char[template.Length]; // store chars for one template 
                int it = 0; // index for temp

                foreach (char chr in template)
                {

                    if (chr != ' ' && chr != ',')
                    {
                        if (chr < 97 || chr > 122)  //nếu đúng thì ký tự này có thể là unicode -> cần convert về ascii
                        {
                            //search nhị phân để tìm ra ký tự ascii tương ứng
                            int first = 0;
                            int last = _UnicodeLastIndex;
                            temp[it++] = chr;
                            while (first <= last)
                            {
                                int mid = (first + last) / 2;
                                if (chr > _Unicode[mid])
                                    first = mid + 1;
                                else if (chr < _Unicode[mid])
                                    last = mid - 1;
                                else
                                {
                                    temp[it - 1] = _UNS[mid];
                                    break;
                                }
                            }
                        }
                        else
                        {
                            temp[it++] = chr;
                        }
                    }
                    else
                    {
                        if (it > 0)
                        {
                            char[] tpl = new char[it]; // char array temp
                            for (int i = 0; i < it; i++)
                                tpl[i] = temp[i];
                            re.Add(tpl);
                            it = 0;
                        }
                    }
                }

                if (it > 0)
                {
                    char[] tpl = new char[it]; // char array temp
                    for (int i = 0; i < it; i++)
                        tpl[i] = temp[i];
                    re.Add(tpl);
                    it = 0;
                }
                _Template = re.ToArray();
            }

            return (_Template != null);
        }

        public bool Include(object input)
        {
            string input_ = (string)input;
            if (string.IsNullOrWhiteSpace(input_))
                return false;

            int iIHit; // vị trí ký tự đầu tiên của chuỗi template đụng với chuỗi input
            int nT;
            int iT; // index chuỗi template
            int iI = 0; // index chuỗi input
            int lmI = input_.Length - 1; // giới hạn index của chuỗi input

            foreach (char[] item in _Template) // duyệt qua từng chuỗi template
            {
                nT = item.Length;
                iIHit = -1;
                iT = 0;
                while (iT < nT)
                {
                    // chuỗi input đã kết thúc mà chuỗi template chưa kết thúc thì false
                    if (iI > lmI)
                        return false;

                    char chrI = input_[iI++];

                    // convert về chữ thường ascii (search nhị phân)
                    if (chrI < 97 || chrI > 122)
                    {
                        int first = 0;
                        int last = _UnicodeLastIndex;
                        while (first <= last)
                        {
                            int mid = (first + last) / 2;
                            if (chrI > _Unicode[mid])
                                first = mid + 1;
                            else if (chrI < _Unicode[mid])
                                last = mid - 1;
                            else
                            {
                                chrI = _UNS[mid];
                                break;
                            }
                        }
                    }

                    if (iIHit == -1)
                    {
                        if (item[iT] == chrI)
                        {
                            iIHit = iI;
                            iT++;
                        }
                    }
                    else
                    {
                        if (item[iT++] != chrI)
                        {
                            iI = iIHit;
                            iIHit = -1;
                            iT = 0;
                        }
                    }

                }
            }

            return true;
        }

        public override string ToString()
        {
            string re = "*";
            foreach (char[] item in _Template)
                re += new string(item) + "*";

            return re;
        }

    }

}
