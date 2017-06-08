using System;
using System.Collections.Generic;
using System.Text;
using LabTech.Interfaces;

namespace labtech_plugin_computer
{
    /// <summary>
    /// Registers the plugin with Automate system using the IPlugin interface.
    /// </summary>
    /// <seealso cref="LabTech.Interfaces.IPlugin" />
    public class PluginMain : IPlugin
    {
        /// <summary>
        /// Stores the MD5 has for the plugin.
        /// </summary>
        private string mMD5;
        /// <summary>
        /// Stores the filename of the plugin.
        /// </summary>
        private string mFilename;

        /// <summary>
        /// Gets the name of the plugin.
        /// </summary>
        /// <value>
        /// The plugin name string.
        /// </value>
        public string Name
        {
            get
            {
                return "labtech-plugin-computer";
            }
        }

        /// <summary>
        /// Gets information about the plugin.
        /// </summary>
        /// <value>
        /// The about string.
        /// </value>
        public string About
        {
            get
            {
                return "Example ConnectWise Automate Plugin.";
            }
        }

        /// <summary>
        /// Gets the author of the plugin.
        /// </summary>
        /// <value>
        /// The author string.
        /// </value>
        public string Author
        {
            get
            {
                return "Plugin Author";
            }
        }

        /// <summary>
        /// Gets the version of the plugin.
        /// </summary>
        /// <value>
        /// The version integer.
        /// </value>
        public int Version
        {
            get
            {
                return 1;
            }
        }

        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>
        /// The filename string.
        /// </value>
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

        /// <summary>
        /// Gets or sets the MD5 hash.
        /// </summary>
        /// <value>
        /// The MD5 string.
        /// </value>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginMain"/> class.
        /// </summary>
        public PluginMain()
        {

        }

        /// <summary>
        /// (Deprecated) Called when the plugin is initialized and performs checks to see if plugin is compatible.
        /// </summary>
        /// <param name="Objhost">The IControlCenter object</param>
        /// <returns>
        /// <c>true</c> if the specified plugin is compatible; otherwise, <c>false</c>.
        /// </returns>
        public bool IsCompatible(IControlCenter Objhost)
        {
            return true;
        }

        /// <summary>
        /// Determines whether the plugin is licensed.
        /// </summary>
        /// <returns>
        /// <c>true</c> if this instance is licensed; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLicensed()
        {
            return true;
        }

        /// <summary>
        /// Determines whether the plugin is licensed.
        /// </summary>
        /// <param name="Objhost">The IControLCenter object.</param>
        /// <returns>
        /// <c>true</c> if the specified objhost is licensed; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLicensed(IControlCenter Objhost)
        {
            return true;
        }

        /// <summary>
        /// (Deprecated) Called when the plugin is uninstalled from the system.
        /// </summary>
        /// <param name="Objhost">The IControlCenter object.</param>
        /// <returns>
        /// <c>true</c> once any needed cleanup is performed.
        /// </returns>
        public bool Remove(IControlCenter Objhost)
        {
            return true;
        }

        /// <summary>
        /// (Deprecated) Called when the plugin is installed into the system. 
        /// </summary>
        /// <param name="Objhost">The IControlCenter object.</param>
        /// <returns>
        /// <c>true</c> once any initialization has been performed.
        /// </returns>
        public bool Install(IControlCenter Objhost)
        {
            return true;
        }
    }
}
