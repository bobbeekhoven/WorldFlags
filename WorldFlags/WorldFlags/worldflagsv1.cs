using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;

namespace WorldFlags
{
    public partial class worldflagsv1 : Form
    {
        Random r = new Random();
        List<int> RemainNums;
        int ARandomNumber;

        public worldflagsv1()
        {
            InitializeComponent();

            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            RemainNums = new List<int>();
            RemainNums.AddRange(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });

        }
        // Shuffle/Next button
        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(r.Next(12).ToString() + "");

            int index = r.Next(0, RemainNums.Count -1);

            ARandomNumber = RemainNums[index];
            RemainNums.RemoveAt(index);

            string path = @"C:\Users\bobva_000\Downloads\vlaggen\";
            pictureBox1.Image = Image.FromFile(path + ARandomNumber + ".png");
            //index = r.Next(0, RemainNums.Count - 1);
            //RemainNums.RemoveAt(index);


        }
        //Box that shows the Flags
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
