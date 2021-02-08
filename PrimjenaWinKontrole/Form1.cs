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
    public delegate void NotifyEvent(string name, string description);
    public partial class Form1 : Form
    {
        public NotifyEvent notifyDelegate;

        FormaText textForma = null;
        public Form1()
        {
            InitializeComponent();
            notifyDelegate += new NotifyEvent(ButtonClickedOnForm2);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite zatvoriti aplikaciju?", "Potvrda", buttons, icon);
            switch (result)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void runProgramButton_Click(object sender, EventArgs e)
        {
            if (runProgramCombo.Text == "Notepad") System.Diagnostics.Process.Start(@"C:\Windows\System32\Notepad.exe");
            else if (runProgramCombo.Text == "Paint") System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
        }

        private void showProgramActionBox_CheckedChanged(object sender, EventArgs e)
        {
            runProgramGroupBox.Enabled = showProgramActionBox.Checked ? true : false;
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show("Odaberite neki dugmić", "Obavijest", buttons, icon);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textForma = new FormaText(notifyDelegate);
            textForma.Show();
            programNameText.Text = textForma.name;
            programDescriptionText.Text = textForma.description;
        }

        public void ButtonClickedOnForm2(string name, string description)
        {
            programNameText.Text = name;
            programDescriptionText.Text = description;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            programNameText.Text = "";
            programDescriptionText.Text = "";
        }
    }
}
