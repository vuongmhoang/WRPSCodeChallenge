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
                // convert the 2 strings to 2 lists with some clean up
                char[] charsToTrim = {' ', '\r', '\n'};
                string[] english = eng.Replace(" ", "").Replace("\r\n", " ").Replace("  ", " ").Trim(charsToTrim).Split(' ');
                string[] spanish = spa.Replace(" ", "").Replace("\r\n", " ").Replace("  ", " ").Trim(charsToTrim).Split(' ');
                
                // remove the duplicate before convert to dictionary
                Dictionary<string, string> spanish_dict = spanish.Distinct().ToList().ToDictionary(key => key, value => "");
                
                // traverse all the words in the English and check if they are in the Spanish
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
            LabelResult.Text = "";
        }
    }
}