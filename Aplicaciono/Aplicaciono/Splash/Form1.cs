﻿using Aplicaciono.Conexion;
using Aplicaciono.Splash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicaciono
{
    public partial class SplashView : Form
    {
        public SplashView()
        {
            InitializeComponent();

            Conexione repo = new Conexione();
            SplashInicia splashInicia = new SplashInicia(repo);
        }  
    }
}
