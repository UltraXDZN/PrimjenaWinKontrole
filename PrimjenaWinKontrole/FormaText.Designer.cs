
namespace PrimjenaWinKontrole
{
    partial class FormaText
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
            this.programNameLabel = new System.Windows.Forms.Label();
            this.programDescriptionLabel = new System.Windows.Forms.Label();
            this.programDescriptionText = new System.Windows.Forms.TextBox();
            this.programNameText = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(12, 9);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(78, 13);
            this.programNameLabel.TabIndex = 0;
            this.programNameLabel.Text = "Program name:";
            // 
            // programDescriptionLabel
            // 
            this.programDescriptionLabel.AutoSize = true;
            this.programDescriptionLabel.Location = new System.Drawing.Point(12, 63);
            this.programDescriptionLabel.Name = "programDescriptionLabel";
            this.programDescriptionLabel.Size = new System.Drawing.Size(103, 13);
            this.programDescriptionLabel.TabIndex = 1;
            this.programDescriptionLabel.Text = "Program description:";
            // 
            // programDescriptionText
            // 
            this.programDescriptionText.Location = new System.Drawing.Point(120, 63);
            this.programDescriptionText.Multiline = true;
            this.programDescriptionText.Name = "programDescriptionText";
            this.programDescriptionText.Size = new System.Drawing.Size(181, 130);
            this.programDescriptionText.TabIndex = 2;
            // 
            // programNameText
            // 
            this.programNameText.Location = new System.Drawing.Point(120, 9);
            this.programNameText.Name = "programNameText";
            this.programNameText.Size = new System.Drawing.Size(181, 20);
            this.programNameText.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 197);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(226, 199);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FormaText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 232);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.programNameText);
            this.Controls.Add(this.programDescriptionText);
            this.Controls.Add(this.programDescriptionLabel);
            this.Controls.Add(this.programNameLabel);
            this.Name = "FormaText";
            this.Text = "Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label programDescriptionLabel;
        private System.Windows.Forms.TextBox programDescriptionText;
        private System.Windows.Forms.TextBox programNameText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}