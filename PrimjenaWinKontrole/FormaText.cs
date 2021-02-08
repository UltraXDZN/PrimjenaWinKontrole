using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWinKontrole
{
    public partial class FormaText : Form
    {
        NotifyEvent notifyDel;
        public string name;
        public string description;
        public FormaText(NotifyEvent notify)
        {
            InitializeComponent();
            notifyDel = notify;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            name = programNameText.Text;
            description = programDescriptionText.Text;
            notifyDel.Invoke(programNameText.Text, programDescriptionText.Text);
            Hide();
        }
    }
}
