﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinderManager
{
    public partial class VentanaPrincipal : Form
    {
        public static Form Interfaz;
        public VentanaPrincipal () {
            Interfaz = this;
            InitializeComponent ();
            this.ControlAdded += VentanaPrincipal_ControlAdded;
            this.Controls.Add ( new Menu () );
            this.FormClosed += VentanaPrincipal_FormClosed;
            this.CenterToScreen ();
        }

        void VentanaPrincipal_FormClosed ( object sender, FormClosedEventArgs e ) {
            Environment.Exit ( 0 );
        }

        void VentanaPrincipal_ControlAdded ( object sender, ControlEventArgs e ) {
            this.Size = new Size ( Controls[0].Size.Width + 15, Controls[0].Size.Height + 40 );
            CenterToScreen ();
        }
    }
}
