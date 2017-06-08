using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using LabTech.Interfaces;

namespace labtech_plugin_computer
{
    /// <summary>
    /// Class that implements the ITabs interface to add TabPage controls to Control Center.
    /// </summary>
    /// <seealso cref="LabTech.Interfaces.ITabs" />
    public class TabClass : ITabs
    {
        /// <summary>
        /// IControlCenter object.
        /// </summary>
        private IControlCenter objHost;

        /// <summary>
        /// Gets the name to be used in the Control Center Dashboard.
        /// </summary>
        /// <value>
        /// The name string.
        /// </value>
        public string Name
        {
            get
            {
                return "labtech-plugin-computer";
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TabClass"/> class.
        /// </summary>
        public TabClass()
        {

        }
        /// <summary>
        /// Called when the Control Center is opened.
        /// </summary>
        /// <param name="Host">The IControlCenter object.</param>
        public void Initialize(IControlCenter Host)
        {
            this.objHost = Host;
        }

        /// <summary>
        /// Called when the Control Center is closed.
        /// </summary>
        public void Decommision()
        {
            this.objHost = (IControlCenter)null;
            return;
        }

        /// <summary>
        /// Called when the Dashboard screen is opened.
        /// </summary>
        /// <returns>
        /// The TabPage to be added to Dashboard.
        /// </returns>
        public TabPage ConfigInit()
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Dashboard screen is closed.
        /// </summary>
        public void ConfigClose()
        {
            return;
        }

        /// <summary>
        /// Called when the Client screen is opened.
        /// </summary>
        /// <param name="ID">The Client ID integer.</param>
        /// <returns>
        /// The TabPage to be added to the Client screen.
        /// </returns>
        public TabPage ClientInit(int ID)
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Client screen is closed.
        /// </summary>
        /// <param name="ID">The Client ID integer.</param>
        public void ClientClose(int ID)
        {
            return;
        }

        /// <summary>
        /// Called when the Computer screen is opened. Creates a new TabPage object and attaches an instance of ComputerControl to the TabPage.
        /// </summary>
        /// <param name="ID">The Computer ID integer.</param>
        /// <returns>
        /// The TabPage to be added to the Computer screen.
        /// </returns>
        public TabPage ComputerInit(int ID)
        {
            try
            {
                TabPage computerTab = new TabPage("labtech-plugin-computer");
                ComputerControl computerControl = new ComputerControl(ID, this.objHost);
                computerControl.Dock = DockStyle.Fill;

                computerTab.Controls.Add((Control)computerControl);

                return computerTab;
            }
            catch (Exception ex)
            {
                string errorString = String.Format("labtech-plugin-computer encountered an exception:\n {0}\n {1}", ex.TargetSite.Name, ex.Message);
                this.objHost.LogMessage(errorString);

                return (TabPage)null;
            }         
        }

        /// <summary>
        /// Called when the Computer screen is closed.
        /// </summary>
        /// <param name="ID">The Computer ID integer.</param>
        public void ComputerClose(int ID)
        {
            return;
        }

        /// <summary>
        /// Called when the Location screen is opened.
        /// </summary>
        /// <param name="ID">The Location ID integer.</param>
        /// <returns>
        /// The TabPage to be added to the Location screen.
        /// </returns>
        public TabPage LocationInit(int ID)
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Location screen is closed.
        /// </summary>
        /// <param name="ID">The Location ID integer.</param>
        public void LocationClose(int ID)
        {
            return;
        }

        /// <summary>
        /// Called when the Device screen is opened.
        /// </summary>
        /// <param name="ID">The Device ID integer.</param>
        /// <returns>
        /// The TabPage to be added to the Device screen.
        /// </returns>
        public TabPage DeviceInit(int ID)
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Device screen is closed.
        /// </summary>
        /// <param name="ID">The Device ID integer.</param>
        public void DeviceClose(int ID)
        {
            return;
        }

        /// <summary>
        /// Called when the Group screen is opened.
        /// </summary>
        /// <param name="ID">The Group ID integer.</param>
        /// <returns>
        /// The TabPage to be added to the Group screen.
        /// </returns>
        public TabPage GroupInit(int ID)
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Group screen is closed.
        /// </summary>
        /// <param name="ID">The Group ID integer.</param>
        public void GroupClose(int ID)
        {
            return;
        }

        /// <summary>
        /// Tickets the initialize.
        /// </summary>
        /// <param name="ID">The Ticket ID integer.</param>
        /// <returns>
        /// The TabPage to be added to the Tickets screen.
        /// </returns>
        public TabPage TicketInit(int ID)
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Ticket screen is opened.
        /// </summary>
        /// <param name="ID">The Ticket ID integer.</param>
        public void TicketClose(int ID)
        {
            return;
        }

        /// <summary>
        /// Called when the Search screen is opened.
        /// </summary>
        /// <returns>
        /// The TabPage to be added to the Search screen.
        /// </returns>
        public TabPage SearchInit()
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Search screen is closed.
        /// </summary>
        public void SearchClose()
        {
            return;
        }

        /// <summary>
        /// Called when the Alerts screen is opened.
        /// </summary>
        /// <returns>
        /// The TabPage to be added to the Alerts screen.
        /// </returns>
        public TabPage AlertsInit()
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Alerts screen is closed.
        /// </summary>
        public void AlertsClose()
        {
            return;
        }

        /// <summary>
        /// Called when the Monitors screen is opened.
        /// </summary>
        /// <returns>
        /// The TabPage to be added to the Monitors screen.
        /// </returns>
        public TabPage MonitorsInit()
        {
            return (TabPage)null;
        }

        /// <summary>
        /// Called when the Monitors screen is closed.
        /// </summary>
        public void MonitorsClose()
        {
            return;
        }
    }
}
