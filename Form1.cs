using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Daniels_LightTestApplication
{
    public partial class MainForm : Form
    {
        //comport 7 controls interior which response to @1
        //comport 8 controls exterior which responds to @0

        private SerialPort comport7_interior    = new SerialPort();
        private SerialPort comport8_exterior    = new SerialPort();
        private SerialPort comport2_lightsensor = new SerialPort();

        //
        // ***************Commands***************
        //

        // Interior U1 Comport 7 Commands

        byte[] u1_move_interior_160s = System.Text.Encoding.UTF8.GetBytes("@1N178"); // 5 degree move
        byte[] u1_home               = System.Text.Encoding.UTF8.GetBytes("@1P0");
        byte[] u1_right              = System.Text.Encoding.UTF8.GetBytes("@1+");
        byte[] u1_left               = System.Text.Encoding.UTF8.GetBytes("@1-");


        // Exterior U0 Comport 8 Commands

        byte[] u0_move_exterior_160s = System.Text.Encoding.UTF8.GetBytes("@0N178"); // 5 degree move 
        byte[] u0_home               = System.Text.Encoding.UTF8.GetBytes("@0P0");
        byte[] u0_clockwise          = System.Text.Encoding.UTF8.GetBytes("@0+");
        byte[] u0_counterclock       = System.Text.Encoding.UTF8.GetBytes("@0-");

        //Execute Commands

        byte[] u0_go = System.Text.Encoding.UTF8.GetBytes("@0G");
        byte[] u1_go = System.Text.Encoding.UTF8.GetBytes("@1G");

        //
        // **************************************
        //


        public void
        OpenComport7()
        {
            if (comport7_interior.IsOpen)
            {
                comport7_interior.Close();
            }
            else
            {
                comport7_interior.PortName = "Comport 7";
                comport7_interior.BaudRate = 38400;
                comport7_interior.DataBits = 8;
                comport7_interior.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1"); ;
                comport7_interior.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                comport7_interior.Open();
            }
        }

        public void
        OpenComport8()
        {
            if (comport8_exterior.IsOpen)
            {
                comport8_exterior.Close();
            }
            else
            {
                comport8_exterior.PortName = "Comport 8";             
                comport8_exterior.BaudRate = 38400;
                comport8_exterior.DataBits = 8;
                comport8_exterior.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                comport8_exterior.Parity   = (Parity)Enum.Parse(typeof(Parity), "None");
                comport8_exterior.Open();
            }
        }

        public void
        OpenComport2()
        // Open Comport 2 for any various light sensor
        {
            if (comport2_lightsensor.IsOpen)
            {
                comport2_lightsensor.Close();
            }
            else
            {
                comport2_lightsensor.PortName = "Comport 2";
                comport2_lightsensor.BaudRate = int.Parse(lightsensor_baudrate_db.Text);
                comport2_lightsensor.DataBits = int.Parse(lightsensor_databits_db.Text);
                comport2_lightsensor.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                comport2_lightsensor.Parity   = (Parity)Enum.Parse(typeof(Parity), lightsensor_parity_db.Text);
                comport2_lightsensor.Open();
            }
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_runtest_Click(object sender, EventArgs e)
        {


            // Exterior Platform Loop
            for (int i = 0; i <= 3200; i += 178)
            {
                // Interior Platform Loop
                for (int ii = 0; i <= 6400; ii += 178)
                {
                    comport7_interior.Write(u1_move_interior_160s, 0, 8);
                    comport7_interior.Write(u1_go, 0, 8);
                    Thread.Sleep(2000);
                    
                    //
                    // Read data from compart2_lightsensor, Parse byte, store Lux value, store angle (i,ii)
                    //

                }
                comport8_exterior.Write(u0_move_exterior_160s, 0, 8);
                comport8_exterior.Write(u0_go, 0, 8);
                Thread.Sleep(2000);

                //
                // Read data from compart2_lightsensor, Parse byte, store Lux value, store angle (i,ii)
                //

            }

            // manually reverse mount direction
            // repeat the whole double for loop
     
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            comport7_interior.Close();
            comport8_exterior.Close();
            comport2_lightsensor.Close();
        }



        private void home_btn_Click(object sender, EventArgs e)
        {
            // May be possible to replace by using the Home command, need to test @H0, vs @H1 before actually using.
            comport7_interior.Write(u1_home, 0, 8);
            comport7_interior.Write(u1_go, 0, 8);
            comport8_exterior.Write(u0_home, 0, 8);
            comport8_exterior.Write(u0_go, 0, 8);

        }

        private void comport_dc_Click(object sender, EventArgs e)
        {
            comport7_interior.Close();
            comport8_exterior.Close();
            comport2_lightsensor.Close();
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            // go up 5 degrees
            comport8_exterior.Write(u0_move_exterior_160s, 0, 8);
            comport8_exterior.Write(u0_go, 0, 8); 

        }

        private void dwn_btn_Click(object sender, EventArgs e)
        {
            // go down 5 degrees
            comport8_exterior.Write(u0_counterclock, 0, 8);
            comport8_exterior.Write(u0_move_exterior_160s, 0, 8);
            comport8_exterior.Write(u0_go, 0, 8);
            comport8_exterior.Write(u0_clockwise, 0 , 8);
        }

       
    }
}
