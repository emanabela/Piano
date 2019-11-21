using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
/*  (above line) enables to play different sound(s)*/
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano2
{
    /*  note, this is the Form1*/
    public partial class PianoForm : Form
    {

        #region
        /*variables & arrays*/
        int count = 0;
        int xLoc = 100;
        int yLoc = 200;
        SoundPlayer sp;
        int[] whitePitch = {1,3,5,6,8,10,12,13,15,17,18,20,22,24};
        //int[] whitePitch = {10,30,50,60,80,100,120,130,150,170,180,200,220,240};
        int[] blackPitch = {20,4,7,9,11,14,16,19,21,23};
        //int[] xPos= {100,300,700,900,1100,1500,1700,2100,2300,2500};
        int[] xPos= {10,30,70,90,110,150,170,210,230,250};
        private Panel panel1= new Panel();
        

        #endregion
        /*  this is the constructor of the "Form1"/PianoForm*/
        public PianoForm()
        {
            InitializeComponent();    
        }

        private void DrawPianoButtons()
        {
            Muskey mk;
            BlackMuskey bmk;
            /*  draw the white buttons*/
            for (int k = 0; k < 7; k++)
            {
                int pitch = whitePitch[k];
                int xPos = k * 20;
                mk = new Muskey(pitch,xPos,50);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(mk);
            }
            int Offs = 20;
            for (int k = 0; k < 5; k++)
            {
                int pitch = blackPitch[k];
                /*  note here we are using xPoss unlike in notes (xPos)*/
                int xPoss = xPos[k];
                bmk = new BlackMuskey(pitch,xPoss,50);
                /*  note here we use bmk unlike in the notes*/
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(bmk);
                //this.panel1.Controls[this.panel1.Controls.Count-1].BringToFront();
                this.Controls[this.panel1.Controls.Count-1].BringToFront();
            }
        }




        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PianoForm_Load(object sender, EventArgs e)
        {
            this.panel1.Location = new Point(xLoc,yLoc);
            //this.panel1.BackColor = Color.Azure;
            this.panel1.Size = new Size(600,200);
            this.Controls.Add(panel1);
           
            Muskey mk;
            BlackMuskey bmk;
            /*  draw the white buttons*/

            for (int k = 0; k < whitePitch.Length; k++)
            {
                int pitch = whitePitch[k];
                int xPos = k * 40;
                mk = new Muskey(pitch, xPos, 10);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(mk);
                
            }
            int Offs = 20;
            for (int k = 0; k < blackPitch.Length; k++)
            {
                int pitch = blackPitch[k];
                /*  note here we are using xPoss unlike in notes (xPos)*/
                int xP = xPos[k]*2;
                bmk = new BlackMuskey(pitch, xP, 10);
                /*  note here we use bmk unlike in the notes*/
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(bmk);
                this.panel1.Controls[this.panel1.Controls.Count-1].BringToFront();
                
            }
            








            #region
            //DrawPianoButtons();
            //this.btnAdd.BackColor = Color.Gray;
            //this.btnAdd.Text = "Add";
            //this.btnAdd.Location = new Point(90, 25);
            //this.btnAdd.Size =new Size(50, 25);
            //this.Controls.Add(btnAdd);
            #endregion
        }
    }
}
