﻿namespace NT106_Lab3
{
    partial class frmB3
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
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(48, 27);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(192, 54);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "TCP Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(287, 27);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(192, 54);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "TCP Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // frmB3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 109);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Name = "frmB3";
            this.Text = "BÀI 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient;
    }
}