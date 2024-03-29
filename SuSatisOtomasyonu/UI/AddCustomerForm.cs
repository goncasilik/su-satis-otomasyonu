﻿using SuSatisOtomasyonu.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuSatisOtomasyonu
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers
            {
                firstName = textBox1.Text,
                lastName = textBox2.Text,
                phoneNumber = maskedTextBox1.Text,
                address = textBox4.Text
            };
            bool success = CustomerHepler.AddCustomer(newCustomer);
            if (success)
            {
                MessageBox.Show("Kayıt Başarılı");
                this.Close();

            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!!!");
            }
        }
    }
}
