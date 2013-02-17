using System;
using Extensibility;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.CommandBars;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace WebKitBrowser
{
    public class Connect : IDTExtensibility2, IDTCommandTarget
    {
        public Connect()
        {
        }

        public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
        {
            _applicationObject = (DTE2)application;
            _addInInstance = (AddIn)addInInst;

            if (connectMode == ext_ConnectMode.ext_cm_UISetup)
            {
                var contextGUIDS = new object[] { };
                var commands = (Commands2)_applicationObject.Commands;
                var viewMenuName = "View";

                Microsoft.VisualStudio.CommandBars.CommandBar menuBarCommandBar =
                    ((Microsoft.VisualStudio.CommandBars.CommandBars)_applicationObject.CommandBars)["MenuBar"];

                var toolsControl = menuBarCommandBar.Controls[viewMenuName];
                var viewPopup = (CommandBarPopup)toolsControl;

                try
                {
                    var command = commands.AddNamedCommand2(_addInInstance, "WebKitBrowser", "WebKit Browser", 
                        "Executes the command for WebKitBrowser", true, 59, ref contextGUIDS, 
                        (int)vsCommandStatus.vsCommandStatusSupported + (int)vsCommandStatus.vsCommandStatusEnabled, 
                        (int)vsCommandStyle.vsCommandStyleText, vsCommandControlType.vsCommandControlTypeButton);

                    if ((command != null) && (viewPopup != null))
                    {
                        command.AddControl(viewPopup.CommandBar, 1);
                    }
                }
                catch { }
            }
        }

        public void OnDisconnection(ext_DisconnectMode disconnectMode, ref Array custom)
        {
        }

        public void OnAddInsUpdate(ref Array custom)
        {
        }

        public void OnStartupComplete(ref Array custom)
        {
        }

        public void OnBeginShutdown(ref Array custom)
        {
        }

        public void QueryStatus(string commandName, vsCommandStatusTextWanted neededText, ref vsCommandStatus status, ref object commandText)
        {
            if (neededText == vsCommandStatusTextWanted.vsCommandStatusTextWantedNone)
            {
                if (commandName == "WebKitBrowser.Connect.WebKitBrowser")
                {
                    status = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported | vsCommandStatus.vsCommandStatusEnabled;
                    return;
                }
            }
        }

        public void Exec(string commandName, vsCommandExecOption executeOption, ref object varIn, ref object varOut, ref bool handled)
        {
            handled = false;
            if (executeOption == vsCommandExecOption.vsCommandExecOptionDoDefault)
            {
                if (commandName == "WebKitBrowser.Connect.WebKitBrowser")
                {
                    var window = CreateBrowserWindow();
                    if (window == null)
                    {
                        return;
                    }
                    window.IsFloating = false;
                    window.Linkable = false;
                    window.Visible = true;
                    handled = true;
                    return;
                }
            }
        }

        private Window CreateBrowserWindow()
        {
            try
            {
                var form = new UI.BrowserForm();
                object obj = (object)form;
                dynamic v = this._applicationObject;
                EnvDTE.DTE dte = (dynamic)_applicationObject;
                Windows2 win2 = (Windows2)dte.Windows;

                return win2.CreateToolWindow2(_addInInstance, GetType().Assembly.Location,
                    typeof(UI.BrowserForm).FullName, "Webkit Browser", form.UID, ref obj);
            }
            catch (Exception e)
            {
#if DEBUG
                System.Windows.Forms.MessageBox.Show(e.Message);
#endif
            }
            return null;
        }

        private DTE2 _applicationObject;
        private AddIn _addInInstance;
    }
}