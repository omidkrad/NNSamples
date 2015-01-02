﻿using System;
using System.Windows.Forms;

namespace NeuralNetworksProject
{
    public partial class TrainingInputDialog : Form
    {
        public int epohces;
        public double errorLimit;
        public TrainingInputDialog()
        {
            InitializeComponent();
        }

        private void OkClick(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtbxEpoches.Text,out epohces) && double.TryParse(this.txtbxErrorLimit.Text, out errorLimit))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();                
            }
            else
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void CancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}