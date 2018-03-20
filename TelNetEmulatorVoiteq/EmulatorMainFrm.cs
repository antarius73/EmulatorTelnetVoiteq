using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelnetServer;

namespace TelNetEmulatorVoiteq
{
    public partial class EmulatorMainFrm : Form
    {
        private static Server s;
        private Project currentProject;

        public EmulatorMainFrm()
        {
            InitializeComponent();
            InitializeDefaultHostparam();
        }

        private void InitializeDefaultHostparam()
        {
            hostIpTxt.Text = "127.0.0.1";
            hostPortTxt.Text = "23";

            currentProjectCbx.DataSource = Project.getAllProjects();
            currentProjectCbx.DisplayMember = "Name";
            currentProject = currentProjectCbx.SelectedItem as Project;

            currentProjectCbx.SelectedIndexChanged += CurrentProjectCbx_SelectedIndexChanged;
        }

        private void CurrentProjectCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProject = currentProjectCbx.SelectedItem as Project;
        }

        private void startServer_Click(object sender, EventArgs e)
        {
         
            s = new Server(getIpAddress());
            s.ClientConnected += clientConnected;
            s.ClientDisconnected += clientDisconnected;
            s.ConnectionBlocked += connectionBlocked;
            s.MessageReceived += messageReceived;
            s.start(this.getPort());
            this.stopServerBtn.Enabled = true;
            //this.
            // Console.WriteLine("SERVER STARTED: " + DateTime.Now);
            this.terminalDataFluxRtb.Text += "SERVER STARTED: " + DateTime.Now + "\r\n";
            this.terminalDataFluxRtb.Text += "PROJECT LOADED: " + currentProject.Name + "\r\n";
            this.terminalDataFluxRtb.Text += "HOST: " + s.Ip.ToString()+" : "+s.Port.ToString()+ "\r\n";
            /*do
            {
                ; // nothing really
            } while (serveurIsRunning);

            s.stop();*/
        }

       private IPAddress getIpAddress()
        {
            IPAddress definedIp;
            if (!IPAddress.TryParse(hostIpTxt.Text, out definedIp))
            {
                definedIp = IPAddress.Any;
            }
            return definedIp;
        }

        private int getPort()
        {
            int resultPort;
            if (!int.TryParse(hostPortTxt.Text, out resultPort)){
                resultPort = Server.STANDARD_PORT;
            }
            return resultPort;
        }

        private static void clientConnected(Client c)
        {
            Console.WriteLine("CONNECTED: " + c);

            s.sendMessageToClient(c, "Telnet Server\r\nLogin: \x1b[6;10H");
        }

        private static void clientDisconnected(Client c)
        {
            Console.WriteLine("DISCONNECTED: " + c);
        }

        private static void connectionBlocked(IPEndPoint ep)
        {
            Console.WriteLine(string.Format("BLOCKED: {0}:{1} at {2}", ep.Address, ep.Port, DateTime.Now));
        }

        private static void messageReceived(Client c, string message)
        {
            Console.WriteLine("MESSAGE: " + message);

            if (message != "kickmyass")
            {
                EClientStatus status = c.getCurrentStatus();

                if (status == EClientStatus.Guest)
                {
                    if (message == "root")
                    {
                        s.sendMessageToClient(c, "\r\nPassword: ");
                        c.setStatus(EClientStatus.Authenticating);
                    }
                }

                else if (status == EClientStatus.Authenticating)
                {
                    if (message == "r00t")
                    {
                        s.clearClientScreen(c);
                        s.sendMessageToClient(c, "Successfully authenticated.\r\n > ");
                        c.setStatus(EClientStatus.LoggedIn);
                    }
                }

                else
                    s.sendMessageToClient(c, "\r\n > ");
            }

            else
                s.kickClient(c);
        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            s.stop();
            this.terminalDataFluxRtb.Text += "SERVER STOPPED: " + DateTime.Now + "\r\n";
            stopServerBtn.Enabled = false;
        }
    }
}
