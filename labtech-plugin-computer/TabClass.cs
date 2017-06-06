using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using LabTech.Interfaces;

namespace labtech_plugin_computer
{
    public class TabClass : ITabs
    {
        private IControlCenter objHost;

        public string Name
        {
            get
            {
                return "labtech-plugin-computer";
            }
        }

        public TabClass()
        {

        }
        public void Initialize(IControlCenter Host)
        {
            this.objHost = Host;
        }

        public void Decommision()
        {
            this.objHost = (IControlCenter)null;
            return;
        }

        public TabPage ConfigInit()
        {
            return (TabPage)null;
        }

        public void ConfigClose()
        {
            return;
        }

        public TabPage ClientInit(int ID)
        {
            return (TabPage)null;
        }

        public void ClientClose(int ID)
        {
            return;
        }

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

        public void ComputerClose(int ID)
        {
            return;
        }

        public TabPage LocationInit(int ID)
        {
            return (TabPage)null;
        }

        public void LocationClose(int ID)
        {
            return;
        }

        public TabPage DeviceInit(int ID)
        {
            return (TabPage)null;
        }

        public void DeviceClose(int ID)
        {
            return;
        }

        public TabPage GroupInit(int ID)
        {
            return (TabPage)null;
        }

        public void GroupClose(int ID)
        {
            return;
        }

        public TabPage TicketInit(int ID)
        {
            return (TabPage)null;
        }

        public void TicketClose(int ID)
        {
            return;
        }

        public TabPage SearchInit()
        {
            return (TabPage)null;
        }

        public void SearchClose()
        {
            return;
        }

        public TabPage AlertsInit()
        {
            return (TabPage)null;
        }

        public void AlertsClose()
        {
            return;
        }

        public TabPage MonitorsInit()
        {
            return (TabPage)null;
        }

        public void MonitorsClose()
        {
            return;
        }
    }
}
