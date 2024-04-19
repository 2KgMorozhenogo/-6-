using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void StopB_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Пробный варинт
        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        //
        private void StartB_Click(object sender, EventArgs e)
        {
            Programma frm2 = new Programma();
            //frm2.TopMost = true;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            this.Hide();
            frm2.ShowDialog();
            //Programma frm2 = new Programma();
            //frm2.Show();
            //frm2.TopMost = true;
            //frm2.WindowState = FormWindowState.Maximized;
            //this.Hide();
            ////frm2.ShowDialog();
            ////this.Show();
        }
        
        public bool checkMain = false;
        Help frm3 = new Help();
        private void SpravB_Click(object sender, EventArgs e)
        {
            

            if (checkMain == false)
            {
                checkMain = true;
                frm3.Show();
                //frm3.ShowDialog();
            }
            else if (checkMain == true)
            {
                checkMain = false;
                frm3.Hide();
            }




            //this.Hide();
        }
    }
}
