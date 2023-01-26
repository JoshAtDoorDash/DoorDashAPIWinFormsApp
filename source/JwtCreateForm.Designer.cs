namespace DoorDashAPIWinFormsApp
{
    partial class JwtCreateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeveloperIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SigningSecretTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JwtPayloadTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.JwtHeaderTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.JwtTextBox = new System.Windows.Forms.TextBox();
            this.UpdateJwtButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.JwtSignatureLabel = new System.Windows.Forms.Label();
            this.JwtSignatureTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeveloperIdTextBox
            // 
            this.DeveloperIdTextBox.Location = new System.Drawing.Point(126, 48);
            this.DeveloperIdTextBox.Name = "DeveloperIdTextBox";
            this.DeveloperIdTextBox.Size = new System.Drawing.Size(292, 23);
            this.DeveloperIdTextBox.TabIndex = 0;
            this.DeveloperIdTextBox.Leave += new System.EventHandler(this.DeveloperIdTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Developer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key ID";
            // 
            // KeyIdTextBox
            // 
            this.KeyIdTextBox.Location = new System.Drawing.Point(126, 81);
            this.KeyIdTextBox.Name = "KeyIdTextBox";
            this.KeyIdTextBox.Size = new System.Drawing.Size(292, 23);
            this.KeyIdTextBox.TabIndex = 1;
            this.KeyIdTextBox.Leave += new System.EventHandler(this.KeyIdTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Signing Secret";
            // 
            // SigningSecretTextBox
            // 
            this.SigningSecretTextBox.Location = new System.Drawing.Point(126, 113);
            this.SigningSecretTextBox.Name = "SigningSecretTextBox";
            this.SigningSecretTextBox.Size = new System.Drawing.Size(292, 23);
            this.SigningSecretTextBox.TabIndex = 3;
            this.SigningSecretTextBox.Leave += new System.EventHandler(this.SigningSecretTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payload";
            // 
            // JwtPayloadTextBox
            // 
            this.JwtPayloadTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JwtPayloadTextBox.Location = new System.Drawing.Point(126, 329);
            this.JwtPayloadTextBox.Multiline = true;
            this.JwtPayloadTextBox.Name = "JwtPayloadTextBox";
            this.JwtPayloadTextBox.ReadOnly = true;
            this.JwtPayloadTextBox.Size = new System.Drawing.Size(444, 121);
            this.JwtPayloadTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Header";
            // 
            // JwtHeaderTextBox
            // 
            this.JwtHeaderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JwtHeaderTextBox.Location = new System.Drawing.Point(126, 223);
            this.JwtHeaderTextBox.Multiline = true;
            this.JwtHeaderTextBox.Name = "JwtHeaderTextBox";
            this.JwtHeaderTextBox.ReadOnly = true;
            this.JwtHeaderTextBox.Size = new System.Drawing.Size(444, 89);
            this.JwtHeaderTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(41, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "DoorDash Merchant Values";
            // 
            // JwtTextBox
            // 
            this.JwtTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JwtTextBox.Location = new System.Drawing.Point(126, 611);
            this.JwtTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.JwtTextBox.Multiline = true;
            this.JwtTextBox.Name = "JwtTextBox";
            this.JwtTextBox.ReadOnly = true;
            this.JwtTextBox.Size = new System.Drawing.Size(444, 106);
            this.JwtTextBox.TabIndex = 20;
            // 
            // UpdateJwtButton
            // 
            this.UpdateJwtButton.Location = new System.Drawing.Point(126, 151);
            this.UpdateJwtButton.Name = "UpdateJwtButton";
            this.UpdateJwtButton.Size = new System.Drawing.Size(106, 38);
            this.UpdateJwtButton.TabIndex = 4;
            this.UpdateJwtButton.Text = "Update JWT";
            this.UpdateJwtButton.UseVisualStyleBackColor = true;
            this.UpdateJwtButton.Click += new System.EventHandler(this.UpdateJwtButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Encoded Token";
            // 
            // JwtSignatureLabel
            // 
            this.JwtSignatureLabel.AutoSize = true;
            this.JwtSignatureLabel.Location = new System.Drawing.Point(65, 473);
            this.JwtSignatureLabel.Name = "JwtSignatureLabel";
            this.JwtSignatureLabel.Size = new System.Drawing.Size(57, 15);
            this.JwtSignatureLabel.TabIndex = 21;
            this.JwtSignatureLabel.Text = "Signature";
            // 
            // JwtSignatureTextBox
            // 
            this.JwtSignatureTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JwtSignatureTextBox.Location = new System.Drawing.Point(126, 470);
            this.JwtSignatureTextBox.Multiline = true;
            this.JwtSignatureTextBox.Name = "JwtSignatureTextBox";
            this.JwtSignatureTextBox.ReadOnly = true;
            this.JwtSignatureTextBox.Size = new System.Drawing.Size(444, 121);
            this.JwtSignatureTextBox.TabIndex = 22;
            // 
            // JwtCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 746);
            this.Controls.Add(this.JwtSignatureLabel);
            this.Controls.Add(this.JwtSignatureTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateJwtButton);
            this.Controls.Add(this.JwtTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.JwtPayloadTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.JwtHeaderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SigningSecretTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeveloperIdTextBox);
            this.Name = "JwtCreateForm";
            this.Text = "JWT Create";
            this.Load += new System.EventHandler(this.JwtCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox DeveloperIdTextBox;
        private Label label1;
        private Label label2;
        private TextBox KeyIdTextBox;
        private Label label3;
        private TextBox SigningSecretTextBox;
        private Label label5;
        private TextBox JwtPayloadTextBox;
        private Label label6;
        private TextBox JwtHeaderTextBox;
        private Label label7;
        private TextBox JwtTextBox;
        private Button UpdateJwtButton;
        private Label label4;
        private Label JwtSignatureLabel;
        private TextBox JwtSignatureTextBox;
    }
}