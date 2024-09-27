using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Generator_App
{
    public class clsUtil
    {
        public static void ColorText(string Text, Color color, RichTextBox rtxbox)
        {
            int Index = rtxbox.Text.IndexOf(Text);
            if (Index != -1)
            {
                int Length = Text.Length;
                rtxbox.Select(Index, Length);
                rtxbox.SelectionColor = color;
            }
        }
    }
}
