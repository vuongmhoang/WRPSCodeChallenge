using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WRPSCodeChallenge
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        string getSimilarity(string eng, string spa)
        {
            string return_val = "";
            try
            {
                char[] charsToTrim = {' ', '\r', '\n'};
                string[] english = eng.Replace(" ", "").Replace("\r\n", " ").Replace("  ", " ").Trim(charsToTrim).Split(' ');
                string[] spanish = spa.Replace(" ", "").Replace("\r\n", " ").Replace("  ", " ").Trim(charsToTrim).Split(' ');

                Dictionary<string, string> spanish_dict = spanish.ToDictionary(key => key, value => value);
                foreach(string aword in english)
                {
                    if (spanish_dict.ContainsKey(aword)){
                        return_val += aword + "<br />";
                    }
                }
            }
            catch (InvalidCastException e)
            {
                return_val = e.Message;
            }

            return return_val;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            LabelResult.Text =  getSimilarity(TextBoxEnglish.Text, TextBoxSpanish.Text);
        }

        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxEnglish.Text = "";
            TextBoxSpanish.Text = "";
        }
    }
}