using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GARMU.Vue
{
    public partial class NumberedRichTextBox : UserControl
    {
        public string Text 
        { 
            get {return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        public NumberedRichTextBox()
        {
            InitializeComponent();

            numberLabel.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size + 1.019f);
        }


        private void updateNumberLabel()
        {
            // We get index of first visible char and number of first visible line
            Point pos = new Point(0, 0);
            int firstIndex = richTextBox1.GetCharIndexFromPosition(pos);
            int firstLine = richTextBox1.GetLineFromCharIndex(firstIndex);

            // Now we get index of last visible char and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = richTextBox1.GetCharIndexFromPosition(pos);
            int lastLine = richTextBox1.GetLineFromCharIndex(lastIndex);

            // Small correction (JS)
            if (richTextBox1.Text.EndsWith("\n"))
                lastLine++;

            // Finally, renumber label (JS: slightly corrected) 
            StringBuilder sb = new StringBuilder();
            for (int i = firstLine; i <= lastLine; i++)
            {
                sb.AppendLine((i + 1).ToString());
            }
            numberLabel.Text = sb.ToString();

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            updateNumberLabel();
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            //move location of numberLabel for amount of pixels caused by scrollbar
            int d = richTextBox1.GetPositionFromCharIndex(0).Y % (richTextBox1.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            updateNumberLabel();
        }

        private void richTextBox1_Resize(object sender, EventArgs e)
        {
            richTextBox1_VScroll(null, null);
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            updateNumberLabel();
            richTextBox1_VScroll(null, null);
        }
    }
}
