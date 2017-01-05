using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VoorbereidingExamenOpgave
{
    public static class Utillity
    {
        public static bool CheckAddOrUpdateMonsterFields(TextBox nameTextBox,TextBox attackTextBox,TextBox hpTextbox)
        {
           if(!hpTextbox.Text.Equals(string.Empty)&&!attackTextBox.Text.Equals(string.Empty)&&!nameTextBox.Text.Equals(string.Empty))
            {
                return true;
            }
           else
            {
                return false;
            }
        }

        public static bool CheckLoginFields(TextBox username, PasswordBox password)
        {
            if(!username.Text.Equals(string.Empty)&&!password.Password.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
