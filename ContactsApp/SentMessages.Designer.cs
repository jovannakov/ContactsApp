﻿namespace ContactsApp
{
    partial class SentMessages
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.displayMessage = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // displayMessage
            // 
            this.displayMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMessage.Location = new System.Drawing.Point(13, 36);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.ReadOnly = true;
            this.displayMessage.Size = new System.Drawing.Size(209, 170);
            this.displayMessage.TabIndex = 1;
            this.displayMessage.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(14, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // SentMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 215);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SentMessages";
            this.ShowInTaskbar = false;
            this.Text = "Sent messages";
            this.Load += new System.EventHandler(this.SentMessages_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox displayMessage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}