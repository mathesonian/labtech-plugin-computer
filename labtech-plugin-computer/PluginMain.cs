using System;
using System.Collections.Generic;
using System.Text;
using LabTech.Interfaces;

namespace labtech_plugin_computer
{
    public class PluginMain : IPlugin
    {
        private string mMD5;
        private string mFilename;

        public string Name
        {
            get
            {
                return "labtech-plugin-computer";
            }
        }

        public string About
        {
            get
            {
                return "Example ConnectWise Automate Plugin.";
            }
        }

        public string Author
        {
            get
            {
                return "Plugin Author";
            }
        }

        public int Version
        {
            get
            {
                return 1;
            }
        }

        public string Filename
        {
            get
            {
                return this.mFilename;
            }
            set
            {
                this.mFilename = value;
            }
        }

        public string hMD5
        {
            get
            {
                return this.mMD5;
            }
            set
            {
                this.mMD5 = value;
            }
        }

        public PluginMain()
        {

        }

        public bool IsCompatible(IControlCenter Objhost)
        {
            return true;
        }

        public bool IsLicensed()
        {
            return true;
        }

        public bool IsLicensed(IControlCenter Objhost)
        {
            return true;
        }

        public bool Remove(IControlCenter Objhost)
        {
            return true;
        }

        public bool Install(IControlCenter Objhost)
        {
            return true;
        }
    }
}
