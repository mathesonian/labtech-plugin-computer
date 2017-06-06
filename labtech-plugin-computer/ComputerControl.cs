using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LabTech.Interfaces;

namespace labtech_plugin_computer
{
    public partial class ComputerControl : UserControl
    {
        private IControlCenter objHost;
        private int ID;

        public ComputerControl()
        {
            
        }

        public ComputerControl(int ID, IControlCenter objHost)
        {
            InitializeComponent();
            this.ID = ID;
            this.objHost = objHost;
        }
    }
}
