﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace madoguchi
{
    public partial class madoguchi : Form
    {
        public madoguchi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Later on, make this use a saved lang configuration.
            res.Culture = CultureInfo.GetCultureInfo("en");
            Text = res.WindowTitle;

        }
    }
}
