
namespace SmsSender
{
    partial class Form2
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
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.saveApiKeyButton = new System.Windows.Forms.Button();
            this.msgProfileTextBox = new System.Windows.Forms.TextBox();
            this.msgProfileButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(128, 18);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(343, 20);
            this.apiKeyTextBox.TabIndex = 0;
            // 
            // saveApiKeyButton
            // 
            this.saveApiKeyButton.Location = new System.Drawing.Point(480, 17);
            this.saveApiKeyButton.Name = "saveApiKeyButton";
            this.saveApiKeyButton.Size = new System.Drawing.Size(57, 23);
            this.saveApiKeyButton.TabIndex = 2;
            this.saveApiKeyButton.Text = "Save";
            this.saveApiKeyButton.UseVisualStyleBackColor = true;
            this.saveApiKeyButton.Click += new System.EventHandler(this.saveApiKeyButton_Click);
            // 
            // msgProfileTextBox
            // 
            this.msgProfileTextBox.Location = new System.Drawing.Point(128, 50);
            this.msgProfileTextBox.Name = "msgProfileTextBox";
            this.msgProfileTextBox.Size = new System.Drawing.Size(343, 20);
            this.msgProfileTextBox.TabIndex = 4;
            // 
            // msgProfileButton
            // 
            this.msgProfileButton.Location = new System.Drawing.Point(480, 48);
            this.msgProfileButton.Name = "msgProfileButton";
            this.msgProfileButton.Size = new System.Drawing.Size(57, 23);
            this.msgProfileButton.TabIndex = 5;
            this.msgProfileButton.Text = "Save";
            this.msgProfileButton.UseVisualStyleBackColor = true;
            this.msgProfileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(13, 54);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Messaging Profile ID :";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(71, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(51, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "API Key :";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 90);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.msgProfileButton);
            this.Controls.Add(this.msgProfileTextBox);
            this.Controls.Add(this.saveApiKeyButton);
            this.Controls.Add(this.apiKeyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Telnyx Sender : API Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Button saveApiKeyButton;
        private System.Windows.Forms.TextBox msgProfileTextBox;
        private System.Windows.Forms.Button msgProfileButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}