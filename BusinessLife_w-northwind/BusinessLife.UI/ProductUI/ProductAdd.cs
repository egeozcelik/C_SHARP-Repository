﻿using BusinessLife.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLife.UI.ProductUI
{
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }
        ProductRepository proRep = new ProductRepository();
        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
