
namespace PrimjenaWinKontrole
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runProgramGroupBox = new System.Windows.Forms.GroupBox();
            this.runProgramCombo = new System.Windows.Forms.ComboBox();
            this.runProgramButton = new System.Windows.Forms.Button();
            this.showProgramActionBox = new System.Windows.Forms.CheckBox();
            this.programControlGroupBox = new System.Windows.Forms.GroupBox();
            this.programNameText = new System.Windows.Forms.TextBox();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.programDescriptionLabel = new System.Windows.Forms.Label();
            this.programDescriptionText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.runProgramGroupBox.SuspendLayout();
            this.programControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // runProgramGroupBox
            // 
            this.runProgramGroupBox.Controls.Add(this.runProgramButton);
            this.runProgramGroupBox.Controls.Add(this.runProgramCombo);
            this.runProgramGroupBox.Location = new System.Drawing.Point(12, 42);
            this.runProgramGroupBox.Name = "runProgramGroupBox";
            this.runProgramGroupBox.Size = new System.Drawing.Size(280, 60);
            this.runProgramGroupBox.TabIndex = 1;
            this.runProgramGroupBox.TabStop = false;
            this.runProgramGroupBox.Text = "Run a program";
            // 
            // runProgramCombo
            // 
            this.runProgramCombo.FormattingEnabled = true;
            this.runProgramCombo.Items.AddRange(new object[] {
            "Paint",
            "Notepad"});
            this.runProgramCombo.Location = new System.Drawing.Point(6, 19);
            this.runProgramCombo.Name = "runProgramCombo";
            this.runProgramCombo.Size = new System.Drawing.Size(121, 21);
            this.runProgramCombo.TabIndex = 0;
            // 
            // runProgramButton
            // 
            this.runProgramButton.Location = new System.Drawing.Point(147, 17);
            this.runProgramButton.Name = "runProgramButton";
            this.runProgramButton.Size = new System.Drawing.Size(127, 23);
            this.runProgramButton.TabIndex = 1;
            this.runProgramButton.Text = "Run Program";
            this.runProgramButton.UseVisualStyleBackColor = true;
            this.runProgramButton.Click += new System.EventHandler(this.runProgramButton_Click);
            // 
            // showProgramActionBox
            // 
            this.showProgramActionBox.AutoSize = true;
            this.showProgramActionBox.Checked = true;
            this.showProgramActionBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showProgramActionBox.Location = new System.Drawing.Point(12, 108);
            this.showProgramActionBox.Name = "showProgramActionBox";
            this.showProgramActionBox.Size = new System.Drawing.Size(128, 17);
            this.showProgramActionBox.TabIndex = 2;
            this.showProgramActionBox.Text = "Show Program Action";
            this.showProgramActionBox.UseVisualStyleBackColor = true;
            this.showProgramActionBox.CheckedChanged += new System.EventHandler(this.showProgramActionBox_CheckedChanged);
            // 
            // programControlGroupBox
            // 
            this.programControlGroupBox.Controls.Add(this.clearButton);
            this.programControlGroupBox.Controls.Add(this.programDescriptionText);
            this.programControlGroupBox.Controls.Add(this.programDescriptionLabel);
            this.programControlGroupBox.Controls.Add(this.programNameLabel);
            this.programControlGroupBox.Controls.Add(this.programNameText);
            this.programControlGroupBox.Location = new System.Drawing.Point(12, 131);
            this.programControlGroupBox.Name = "programControlGroupBox";
            this.programControlGroupBox.Size = new System.Drawing.Size(280, 171);
            this.programControlGroupBox.TabIndex = 2;
            this.programControlGroupBox.TabStop = false;
            this.programControlGroupBox.Text = "Program Control";
            // 
            // programNameText
            // 
            this.programNameText.Location = new System.Drawing.Point(6, 35);
            this.programNameText.Name = "programNameText";
            this.programNameText.Size = new System.Drawing.Size(121, 20);
            this.programNameText.TabIndex = 0;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(6, 19);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(75, 13);
            this.programNameLabel.TabIndex = 1;
            this.programNameLabel.Text = "Program name";
            // 
            // programDescriptionLabel
            // 
            this.programDescriptionLabel.AutoSize = true;
            this.programDescriptionLabel.Location = new System.Drawing.Point(9, 62);
            this.programDescriptionLabel.Name = "programDescriptionLabel";
            this.programDescriptionLabel.Size = new System.Drawing.Size(100, 13);
            this.programDescriptionLabel.TabIndex = 2;
            this.programDescriptionLabel.Text = "Program description";
            // 
            // programDescriptionText
            // 
            this.programDescriptionText.Location = new System.Drawing.Point(6, 79);
            this.programDescriptionText.Multiline = true;
            this.programDescriptionText.Name = "programDescriptionText";
            this.programDescriptionText.Size = new System.Drawing.Size(121, 86);
            this.programDescriptionText.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(147, 35);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 314);
            this.Controls.Add(this.programControlGroupBox);
            this.Controls.Add(this.showProgramActionBox);
            this.Controls.Add(this.runProgramGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.runProgramGroupBox.ResumeLayout(false);
            this.programControlGroupBox.ResumeLayout(false);
            this.programControlGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox runProgramGroupBox;
        private System.Windows.Forms.Button runProgramButton;
        private System.Windows.Forms.ComboBox runProgramCombo;
        private System.Windows.Forms.CheckBox showProgramActionBox;
        private System.Windows.Forms.GroupBox programControlGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox programDescriptionText;
        private System.Windows.Forms.Label programDescriptionLabel;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.TextBox programNameText;
    }
}

