﻿namespace IRC
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.nickLabel = new System.Windows.Forms.Label();
            this.channelLabel = new System.Windows.Forms.Label();
            this.passCheckBox = new System.Windows.Forms.CheckBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.keyButton = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.nickErrorLabel = new System.Windows.Forms.Label();
            this.channelErrorLabel = new System.Windows.Forms.Label();
            this.passErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickLabel.Location = new System.Drawing.Point(54, 55);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(79, 18);
            this.nickLabel.TabIndex = 0;
            this.nickLabel.Text = "Nickname:";
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelLabel.Location = new System.Drawing.Point(54, 119);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(66, 18);
            this.channelLabel.TabIndex = 1;
            this.channelLabel.Text = "Channel:";
            // 
            // passCheckBox
            // 
            this.passCheckBox.AutoSize = true;
            this.passCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCheckBox.Location = new System.Drawing.Point(84, 85);
            this.passCheckBox.Name = "passCheckBox";
            this.passCheckBox.Size = new System.Drawing.Size(134, 22);
            this.passCheckBox.TabIndex = 2;
            this.passCheckBox.Text = "I have password";
            this.passCheckBox.UseVisualStyleBackColor = true;
            this.passCheckBox.CheckedChanged += new System.EventHandler(this.passCheckBox_CheckedChanged);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(112, 19);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(184, 20);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Think of a nickname...";
            // 
            // nickTextBox
            // 
            this.nickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickTextBox.Location = new System.Drawing.Point(135, 52);
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(161, 24);
            this.nickTextBox.TabIndex = 4;
            // 
            // channelTextBox
            // 
            this.channelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelTextBox.Location = new System.Drawing.Point(135, 113);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(135, 24);
            this.channelTextBox.TabIndex = 5;
            this.channelTextBox.Text = "#labas";
            // 
            // keyButton
            // 
            this.keyButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyButton.Image = ((System.Drawing.Image)(resources.GetObject("keyButton.Image")));
            this.keyButton.Location = new System.Drawing.Point(268, 113);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(28, 24);
            this.keyButton.TabIndex = 6;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(54, 153);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(37, 18);
            this.keyLabel.TabIndex = 7;
            this.keyLabel.Text = "Key:";
            this.keyLabel.Visible = false;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTextBox.Location = new System.Drawing.Point(135, 147);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.PasswordChar = '*';
            this.keyTextBox.Size = new System.Drawing.Size(161, 24);
            this.keyTextBox.TabIndex = 8;
            this.keyTextBox.Visible = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.MistyRose;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(103, 217);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 35);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start...";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(54, 119);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(79, 18);
            this.passLabel.TabIndex = 10;
            this.passLabel.Text = "Password:";
            this.passLabel.Visible = false;
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(135, 113);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(161, 24);
            this.passTextBox.TabIndex = 11;
            this.passTextBox.Visible = false;
            // 
            // nickErrorLabel
            // 
            this.nickErrorLabel.AutoSize = true;
            this.nickErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.nickErrorLabel.Location = new System.Drawing.Point(302, 57);
            this.nickErrorLabel.Name = "nickErrorLabel";
            this.nickErrorLabel.Size = new System.Drawing.Size(92, 16);
            this.nickErrorLabel.TabIndex = 12;
            this.nickErrorLabel.Text = "*No nickname";
            this.nickErrorLabel.Visible = false;
            // 
            // channelErrorLabel
            // 
            this.channelErrorLabel.AutoSize = true;
            this.channelErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.channelErrorLabel.Location = new System.Drawing.Point(302, 118);
            this.channelErrorLabel.Name = "channelErrorLabel";
            this.channelErrorLabel.Size = new System.Drawing.Size(81, 16);
            this.channelErrorLabel.TabIndex = 13;
            this.channelErrorLabel.Text = "*No channel";
            this.channelErrorLabel.Visible = false;
            // 
            // passErrorLabel
            // 
            this.passErrorLabel.AutoSize = true;
            this.passErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.passErrorLabel.Location = new System.Drawing.Point(302, 121);
            this.passErrorLabel.Name = "passErrorLabel";
            this.passErrorLabel.Size = new System.Drawing.Size(85, 16);
            this.passErrorLabel.TabIndex = 14;
            this.passErrorLabel.Text = "*Invalid pass";
            this.passErrorLabel.Visible = false;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.passErrorLabel);
            this.Controls.Add(this.channelErrorLabel);
            this.Controls.Add(this.nickErrorLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.nickTextBox);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.passCheckBox);
            this.Controls.Add(this.channelLabel);
            this.Controls.Add(this.nickLabel);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.CheckBox passCheckBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox nickTextBox;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.Label keyButton;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label nickErrorLabel;
        private System.Windows.Forms.Label channelErrorLabel;
        private System.Windows.Forms.Label passErrorLabel;
    }
}