﻿using FootBall.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall
{
    public partial class stadion : Form
    {
        FootBallEntities db = new FootBallEntities();
        public stadion()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Stadion_Load(object sender, EventArgs e)
        {

        }
    }
}
