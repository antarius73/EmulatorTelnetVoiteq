using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelnetServer;

namespace TelNetEmulatorVoiteq
{
    public partial class EmulatorMainFrm : Form
    {
        private static Server s;
        private static Project currentProject;

        private static IPAddress localIp = IPAddress.Parse("127.0.0.1");


        public EmulatorMainFrm()
        {
            InitializeComponent();
            InitializeDefaultHostparam();
        }

        private void InitializeDefaultHostparam()
        {
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
            // à clarifier
            //IPAddress ip = GetIPAddress();
            IPAddress ip = localIp;
            hostLbl.Text = "Host : " + ip.ToString();
            s = new Server(ip);
            s.ClientConnected += clientConnected;
            s.ClientDisconnected += clientDisconnected;
            s.ConnectionBlocked += connectionBlocked;
            s.MessageReceived += messageReceived;
            s.start(this.getPort());
            this.stopServerBtn.Enabled = true;
            
            sendConsoleMessage("SERVER STARTED: " + DateTime.Now);
            sendConsoleMessage("PROJECT LOADED: " + currentProject.Name);
            sendConsoleMessage("HOST: " + s.Ip.ToString() + " : " + s.Port.ToString());

            /*do
            {
                ; // nothing really
            } while (serveurIsRunning);

            s.stop();*/
        }

        public static IPAddress GetIPAddress()
        {
            IPHostEntry host;
            IPAddress localIP = IPAddress.Any;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip;
                }
            }
            return localIP;
        }

        private int getPort()
        {
            int resultPort;
            if (!int.TryParse(hostPortTxt.Text, out resultPort)){
                resultPort = Server.STANDARD_PORT;
            }
            return resultPort;
        }

        private void clientConnected(Client c)
        {
            this.Invoke((MethodInvoker)delegate { sendConsoleMessage("CONNECTED: " + c); });
            s.sendMessageToClient(c, currentProject.ActiveScreen.toTelnet());            
        }

        private  void clientDisconnected(Client c)
        {
            this.Invoke((MethodInvoker)delegate { sendConsoleMessage("DISCONNECTED: " + c); });
        }

        private void connectionBlocked(IPEndPoint ep)
        {
            this.Invoke((MethodInvoker)delegate { sendConsoleMessage(string.Format("BLOCKED: {0}:{1} at {2}", ep.Address, ep.Port, DateTime.Now)); });           
        }

        private static void messageReceived(Client c, string message)
        {
            s.sendMessageToClient(c, currentProject.incomingMessage(message));
            /*  Console.WriteLine("MESSAGE: " + message);

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
                  */
        }

        private void sendConsoleMessage(string message)
        {
            this.terminalDataFluxRtb.Text += message + "\r\n";
        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            s.stop();
            this.terminalDataFluxRtb.Text += "SERVER STOPPED: " + DateTime.Now + "\r\n";
            stopServerBtn.Enabled = false;
        }
    }
}
