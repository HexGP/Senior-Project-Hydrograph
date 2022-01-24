using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydrograph
{
    public partial class GenerateDialogue : Form
    {
        public GenerateDialogue()
        {
            InitializeComponent();
        }
        public delegate void OptionSelectHandler(object sender, OptionSelectEvent e);

        public event OptionSelectHandler optionSelected;

        private void PreDev_Click(object sender, EventArgs e)
        {
            optionSelected(this, new OptionSelectEvent(Options.PRE_DEVELOPED));
            this.Close();
        }

        private void PostDev_Click(object sender, EventArgs e)
        {
            optionSelected(this, new OptionSelectEvent(Options.POST_DEVELOPED));
            this.Close();
        }

        private void Indiv_Click(object sender, EventArgs e)
        {
            optionSelected(this, new OptionSelectEvent(Options.INDIVIDUAL));
            this.Close();
        }
    }
    public enum Options { PRE_DEVELOPED, POST_DEVELOPED, INDIVIDUAL };
    public class OptionSelectEvent : System.EventArgs
    {
        private Options choice;

        public OptionSelectEvent(Options choice)
        {
            this.choice = choice;
        }

        public Options getChoice()
        {
            return choice;
        }

    }
}
