﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            frmB1 frm = new frmB1();
            if (Application.OpenForms.OfType<frmB1>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                frm.Show();

        }

        private void btnVD_Click(object sender, EventArgs e)
        {
            frmVd1_Server frmVd1_Server = new frmVd1_Server();
            if (Application.OpenForms.OfType<frmVd1_Server>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                frmVd1_Server.Show();

            frmVd1_Client frmClient = new frmVd1_Client();
            frmClient.Show();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            frmB3 frm = new frmB3();
            if (Application.OpenForms.OfType<frmB3>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                frm.Show();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            frmB2 frm = new frmB2();
            if (Application.OpenForms.OfType<frmB2>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                frm.Show();
        }
    }
}
