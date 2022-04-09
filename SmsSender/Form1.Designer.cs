
namespace SmsSender
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
            this.sndBtn = new System.Windows.Forms.Button();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.apiKeyFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.smsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.apiKeyStatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msgProfileIDStatusLabel = new System.Windows.Forms.Label();
            this.messageStatusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sndBtn
            // 
            this.sndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sndBtn.ForeColor = System.Drawing.Color.Black;
            this.sndBtn.Location = new System.Drawing.Point(25, 410);
            this.sndBtn.Name = "sndBtn";
            this.sndBtn.Size = new System.Drawing.Size(242, 23);
            this.sndBtn.TabIndex = 0;
            this.sndBtn.Text = "SEND SMS";
            this.sndBtn.UseVisualStyleBackColor = true;
            this.sndBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // senderTextBox
            // 
            this.senderTextBox.Location = new System.Drawing.Point(25, 44);
            this.senderTextBox.MaxLength = 11;
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(242, 20);
            this.senderTextBox.TabIndex = 1;
            this.senderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(25, 90);
            this.numberTextBox.MaxLength = 20;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(242, 20);
            this.numberTextBox.TabIndex = 2;
            this.numberTextBox.Text = "+33600000000";
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // apiKeyFormButton
            // 
            this.apiKeyFormButton.Location = new System.Drawing.Point(166, 464);
            this.apiKeyFormButton.Name = "apiKeyFormButton";
            this.apiKeyFormButton.Size = new System.Drawing.Size(101, 61);
            this.apiKeyFormButton.TabIndex = 3;
            this.apiKeyFormButton.Text = "EDIT API Infos";
            this.apiKeyFormButton.UseVisualStyleBackColor = true;
            this.apiKeyFormButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sender ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number";
            // 
            // smsTextBox
            // 
            this.smsTextBox.Location = new System.Drawing.Point(25, 141);
            this.smsTextBox.Multiline = true;
            this.smsTextBox.Name = "smsTextBox";
            this.smsTextBox.Size = new System.Drawing.Size(242, 253);
            this.smsTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(25, 502);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(125, 23);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // apiKeyStatusLabel
            // 
            this.apiKeyStatusLabel.AutoSize = true;
            this.apiKeyStatusLabel.Location = new System.Drawing.Point(50, 466);
            this.apiKeyStatusLabel.Name = "apiKeyStatusLabel";
            this.apiKeyStatusLabel.Size = new System.Drawing.Size(104, 13);
            this.apiKeyStatusLabel.TabIndex = 9;
            this.apiKeyStatusLabel.Text = "API Key : Not Found";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "------------------------------------------------------------------------------";
            // 
            // msgProfileIDStatusLabel
            // 
            this.msgProfileIDStatusLabel.AutoSize = true;
            this.msgProfileIDStatusLabel.Location = new System.Drawing.Point(24, 486);
            this.msgProfileIDStatusLabel.Name = "msgProfileIDStatusLabel";
            this.msgProfileIDStatusLabel.Size = new System.Drawing.Size(128, 13);
            this.msgProfileIDStatusLabel.TabIndex = 11;
            this.msgProfileIDStatusLabel.Text = "Msg profile ID : Not found";
            // 
            // messageStatusLabel
            // 
            this.messageStatusLabel.AutoSize = true;
            this.messageStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.messageStatusLabel.Location = new System.Drawing.Point(26, 436);
            this.messageStatusLabel.Name = "messageStatusLabel";
            this.messageStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.messageStatusLabel.TabIndex = 12;
            this.messageStatusLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "by RiFi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messageStatusLabel);
            this.Controls.Add(this.msgProfileIDStatusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apiKeyStatusLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apiKeyFormButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.senderTextBox);
            this.Controls.Add(this.sndBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Telnyx Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sndBtn;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button apiKeyFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox smsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label apiKeyStatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label msgProfileIDStatusLabel;
        private System.Windows.Forms.Label messageStatusLabel;
        private System.Windows.Forms.Label label4;
    }
}

