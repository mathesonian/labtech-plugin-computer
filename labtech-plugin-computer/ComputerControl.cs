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
    /// <summary>
    /// UserControl to be loaded in the Computer TabPage.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ComputerControl : UserControl
    {
        /// <summary>
        /// The IControlCenter object.
        /// </summary>
        private IControlCenter objHost;
        /// <summary>
        /// The Computer ID integer.
        /// </summary>
        private int ID;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerControl"/> class.
        /// </summary>
        public ComputerControl()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerControl"/> class, initializes control components, and sets Computer ID and IControlCenter object.
        /// </summary>
        /// <param name="ID">The Computer ID integer.</param>
        /// <param name="objHost">The IControlCenter object.</param>
        public ComputerControl(int ID, IControlCenter objHost)
        {
            InitializeComponent();
            this.ID = ID;
            this.objHost = objHost;
        }
    }
}
