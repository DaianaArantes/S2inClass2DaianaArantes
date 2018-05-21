
//-----------------------
//Microsoft Visual Studio C#
//Daiana Arantes
//Conestoga College
//Feb Monday 05, 2018
//-----------------------



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inclass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string alarmTime = null;
        bool alarmOn = false;
        System.Drawing.Color defaultFormColor;

        
        private void timerClock_Load(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToShortTimeString();
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToShortTimeString();

            //alarm if timer and alarm time are same
            if(alarmOn && labelTimer.Text == alarmTime)
            {
                labelMessage.Text = "WAKE UP!!!!";

                //play a sound when alarm is on
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"c:\windows\media\Windows Logoff Sound.wav";
                player.Play();

                //turn red to green every tick
                if (labelMessage.BackColor == Color.Red)
                {
                    labelMessage.BackColor = Color.Green;
                    labelMessage.ForeColor = Color.Red;
                }
                else
                {
                    labelMessage.BackColor = Color.Red;
                    labelMessage.ForeColor = Color.Green;
                }
            }
            //if timer and alarm time are not the same
            else
            {
                labelMessage.BackColor = defaultFormColor;
               
            }
        }

        private void checkBoxAlarm_Click(object sender, EventArgs e)
        {
            //verify if the check box is checked
            if(checkBoxAlarm.Checked)
            {
                labelMessage.Text = "";
                //verify if comboBoxTime is not null
                if (comboBoxTime.SelectedItem != null)
                {
                    alarmTime = comboBoxTime.SelectedItem.ToString() + " ";
                    //verify if AM is checked
                    if (radioButtonAM.Checked)
                    {
                        alarmTime += radioButtonAM.Text;
                        alarmOn = true;
                        labelMessage.Text = alarmTime;
                    }
                    //verify if PM is checked
                    else if (radioButtonPM.Checked)
                    {
                        alarmTime += radioButtonPM.Text;
                        alarmOn = true;
                        labelMessage.Text = alarmTime;
                    }
                    else
                    {
                        //if AM or PM is ot selected  error message appears
                        labelMessage.Text = "Please select AM or PM";
                        checkBoxAlarm.Checked = false;
                    }
                }
                else
                {
                    //if comboBoxTime is null a error message appears
                    labelMessage.Text = "Please select a time";
                    checkBoxAlarm.Checked = false;
                }
            }

            //if checkBoxAlarm is unchecked, alarmOn is set to false
            else
            {
                alarmOn = false;
                labelMessage.Text = "";
                this.BackColor = defaultFormColor;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defaultFormColor = Form1.DefaultBackColor;
            labelMessage.Text = "Select a time, AM or PM and select Alarm On";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            //when stop button is clicked
            alarmOn = false;
            checkBoxAlarm.Checked = false;
            labelMessage.Text = "";
            this.BackColor = defaultFormColor;
        }
    }
}
