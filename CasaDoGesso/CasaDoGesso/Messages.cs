using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDoGesso
{
    public class Messages
    {
        public static DialogResult Dialog(string text)
        {
            return MessageBox.Show(text, "Casa do Gesso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void Info(string txt)
        {
            MessageBox.Show(txt, "Casa do Gesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string txt, Exception ex = null)
        {
            string msg = "";
            if (ex != null)
            {
                msg += ex.Message;
                if (ex.InnerException != null)
                {
                    msg += $"\n{ex.InnerException.Message}";
                    if (ex.InnerException.InnerException != null)
                        msg += $"\n{ex.InnerException.InnerException.Message}";
                }
            }

            if (!string.IsNullOrEmpty(msg))
                txt += $"\n\nDetalhes do erro: {msg}";

            MessageBox.Show(txt, "Casa do Gesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
