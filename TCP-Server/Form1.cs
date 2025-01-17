﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        private MyTcpServer _server;
        private bool _serverConnected = false;
        private NetworkStream _stream;

        

        public Form1()
        {
            InitializeComponent();
            
            // Initialize server at any IPv4 to allow connection from outside
            _server = new MyTcpServer(IPAddress.Any.ToString());
            _server.MessageReceived += Server_MessageReceived;
        }
        
        private void Server_MessageReceived(object sender, string message)
        {
            // Update the TextBox control with the received message
            // 'Marshalled' to the UI thread using MethodInvoker
            // NOTE: MethodInvoker can also be replaced with Action (like in slide 8, pg 27)
            // According to SO, MethodInvoker is better use case than Action
            // https://stackoverflow.com/questions/1167771/methodinvoker-vs-action-for-control-begininvoke
            logTextBox.Invoke((MethodInvoker)(() =>
            {
                logTextBox.AppendText(message + Environment.NewLine);
            }));

            

            // Check if message contains LED ON/OFF commands
            if (message.Contains("LED ON"))
            {
                ledPictureBox.Invoke((MethodInvoker)(() =>
                {
                    ledPictureBox.Image = Properties.Resources.on_led;
                }));
            } 
            if (message.Contains("LED OFF"))
            {
                ledPictureBox.Invoke((MethodInvoker)(() =>
                {
                    ledPictureBox.Image = Properties.Resources.off_led;
                }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_serverConnected)
            {
                try
                {
                    _server.Start();
                    localNetworkLabel.Text = $@"127.0.0.1:{_server.Port}";
                    lanNetworkLabel.Text = $@"{GetDeviceLocalIp()}:{_server.Port}";
                    button1.Text = "Stop server";
                    _serverConnected = true;
                }
                catch (Exception exception)
                {
                    logTextBox.AppendText(exception.Message + Environment.NewLine);
                }
            }
            else
            {
                _server.Stop();
                _serverConnected = false;
                localNetworkLabel.Text = @"N/A";
                lanNetworkLabel.Text = @"N/A";
                button1.Text = "Start server";
                logTextBox.Clear();
            }
        }

        static string GetDeviceLocalIp()
        {
            // Credit https://stackoverflow.com/a/57248926/13617136
            IPHostEntry entry = Dns.GetHostEntry(Dns.GetHostName());

            // find IPv4 address
            List<string> ips = (from ip in entry.AddressList where ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork select ip.ToString()).ToList();

            return ips[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _stream = _server.GetStream();

            string[] digits = sndmsgBox.Text.Split(' ')
               .ToArray();
            byte[] byteArray = new byte[digits.Length];
            for(int i=0; i < byteArray.Length;i++)
            {
                byteArray[i] = Convert.ToByte(digits[i]);
            }
            //int intValue = Convert.ToInt32(hexString, 16);
            //Console.WriteLine(intValue); // Output: 6719

            if (_stream != null)
            {
                //byte[] msg = Encoding.UTF8.GetBytes( sndmsgBox.Text + Environment.NewLine) ;
                //_stream.Write(msg, 0, msg.Length);
                _stream.Write(byteArray, 0, byteArray.Length);
            }
        }
    }
}