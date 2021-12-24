using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvStuff
{
    public partial class Form1 : Form
    {
        Mat Fistmat;
        Mat SecondMat;
        Mat mat = new Mat();
        Mat 
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("And");
            comboBox1.Items.Add("Or");
            comboBox1.Items.Add("Xor");
            comboBox2.Items.Add("Binary");
            comboBox2.Items.Add("InvertedBinary");
            comboBox2.Items.Add("Mask");
            comboBox3.Items.Add("Mat");
        }

        private void button1_Click(object sender, EventArgs e)
        {



            CvInvoke.Resize(Fistmat, Fistmat, new Size(500, 500));
            CvInvoke.Resize(SecondMat, SecondMat, new Size(500, 500));

        }
        //private void General_Click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    sender.Text 
        //}
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mat1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                Fistmat = CvInvoke.Imread(file.FileName);
            }
        }
        private void INrage()
        {
            Mat src = new Mat();
            Mat oupit = new Mat();
            var lowerBound = (ScalarArray)new MCvScalar(200, 100, 50);
            var upperBound = (ScalarArray)new MCvScalar(255, 100, 50);
            CvInvoke.InRange(src, lowerBound, upperBound, oupit);
        }
        private void SliderInRange(object sender, EventArgs e)
        { 
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mat ouput = new Mat();
            if (comboBox1.Text == "And")
            {
                CvInvoke.Resize(Fistmat, Fistmat, new Size(400, 400));
                CvInvoke.BitwiseAnd(Fistmat, SecondMat, ouput);
            }
            if (comboBox1.Text == "Or")
            {
                CvInvoke.Resize(Fistmat, Fistmat, new Size(400, 400));
                CvInvoke.BitwiseOr(Fistmat, SecondMat, ouput);
            }
            if (comboBox1.Text == "Xor")
            {
                CvInvoke.Resize(Fistmat, Fistmat, new Size(400, 400));
                CvInvoke.BitwiseXor(Fistmat, SecondMat, ouput);
            }
            //CvInvoke.BitwiseAnd(Fistmat, SecondMat, ouput);
            //Space();
            Mat1.Image = Fistmat;
            Mat2.Image = SecondMat;
            OutputBox.Image = ouput;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Target()
        {
            Mat mathCringe = new Mat();
            Mat ouput = new Mat();
            CvInvoke.Rotate(SecondMat, mathCringe, Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise);
            CvInvoke.BitwiseXor(SecondMat, mathCringe, SecondMat);
            CvInvoke.BitwiseAnd(Fistmat, SecondMat, ouput);
            Mat1.Image = Fistmat;
            Mat2.Image = SecondMat;
            OutputBox.Image = mathCringe;
        }
        private void Time()
        {
            Mat mathCringe = new Mat();
            CvInvoke.Rotate(SecondMat, SecondMat, Emgu.CV.CvEnum.RotateFlags.Rotate180);
            CvInvoke.BitwiseOr(Fistmat, SecondMat, mathCringe);
            Mat1.Image = Fistmat;
            Mat2.Image = SecondMat;
            CvInvoke.BitwiseNot(mathCringe, mathCringe);
            OutputBox.Image = mathCringe;
        }
        private void Thing()
        {
            CvInvoke.BitwiseNot(Fistmat, Fistmat);
            Mat mat = new Mat();
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                mat = CvInvoke.Imread(file.FileName);
            }
            CvInvoke.BitwiseAnd(SecondMat, Fistmat, SecondMat);
            CvInvoke.Rotate(mat, mat, Emgu.CV.CvEnum.RotateFlags.Rotate180);
            CvInvoke.BitwiseNot(mat, mat);
            CvInvoke.BitwiseAnd(SecondMat, mat , SecondMat);
            CvInvoke.BitwiseNot(SecondMat, SecondMat);
            OutputBox.Image = SecondMat;
            Mat1.Image = mat;
        }
        private void PictureUnder(Mat mats)
        {
            CvInvoke.CvtColor(mats, mats, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(mats, mats, 10, 255, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
            CvInvoke.BitwiseOr(mats, mat, mat);


        }
        private void PictureOver(Mat mats)
        {
            CvInvoke.CvtColor(mats, mats, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(mats, mats, 245, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            CvInvoke.BitwiseOr(mats, mat, mat);


        }
        public void Space()
        {
            // mat = line
            // Second mat = tri
            // fistmat = right
            Mat mat = new Mat();
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                mat = CvInvoke.Imread(file.FileName);
            }
            Mat1.Image = mat;
            Mat2.Image = SecondMat;

            CvInvoke.Rotate(mat,mat, Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise);
            CvInvoke.BitwiseNot(mat, mat);
            CvInvoke.BitwiseAnd(mat,Fistmat,mat);
            CvInvoke.BitwiseNot(mat, mat);
            //CvInvoke.BitwiseOr(SecondMat, mat, SecondMat);
            OutputBox.Image = mat;

        }
        private Bitmap R(Bitmap bitmap)
        {
            Bitmap bit = new Bitmap(bitmap.Width,bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var s = bitmap.GetPixel(i,y);
                    if (s.R > 0)
                    {
                        bit.SetPixel(i, y, Color.FromArgb(s.R, 0, 0));
                    }
                }
            }
            return bit;

        }
        private Bitmap G(Bitmap bitmap)
        {
            Bitmap bit = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var s = bitmap.GetPixel(i, y);
                    if (s.G > 0)
                    {
                        bit.SetPixel(i, y, Color.FromArgb(0, s.G, 0));
                    }
                }
            }
            return bit;

        }
        private void Picture()
        { 
        
        }
        private Bitmap B(Bitmap bitmap)
        {
            Bitmap bit = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var s = bitmap.GetPixel(i, y);
                    if (s.B > 0)
                    {
                        bit.SetPixel(i, y, Color.FromArgb(0, 0, s.B));
                    }
                }
            }
            return bit;
        }
        private Bitmap Gray(Bitmap bitmap)
        {
            Bitmap bit = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var s = bitmap.GetPixel(i, y);
                    var te = (s.R + s.G + s.B) / 3;
                    bit.SetPixel(i,y, Color.FromArgb(te,te,te));
                }
            }
            return bit;
        }
        private void Mat2_Click(object sender, EventArgs e)
        {
            
            
                OpenFileDialog Flie = new OpenFileDialog();
                var IsDone = Flie.ShowDialog();
                if (IsDone == DialogResult.Yes || IsDone == DialogResult.OK)
                {
                    SecondMat = CvInvoke.Imread(Flie.FileName);
                }
                Mat mathCringe = new Mat();
                CvInvoke.Resize(SecondMat,SecondMat,new Size(400,400));
            

            
            //CvInvoke.Rotate(SecondMat,mathCringe,Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise);
           // CvInvoke.BitwiseXor(SecondMat, mathCringe, SecondMat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mat matNew = new Mat();
            if (comboBox2.Text == "Binary")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.Binary);
            }
            if (comboBox2.Text == "InvertedBinary")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
            }
            if (comboBox2.Text == "Mask")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.Mask);
            }
            pictureBox1.Image = matNew.ToBitmap();
            matNew.Save("Thing.png");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void ConverColorOperation(Mat bit)
        {
            VectorOfMat vector = new VectorOfMat();
            CvInvoke.Split(bit, vector);

            pictureBox1.Image = bit.ToBitmap();

            CvInvoke.CvtColor(bit, bit, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mat bit = new Mat();
            Mat other = new Mat();
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                bit = new Mat(file.FileName);
                other = new Mat(file.FileName);

            }
            CvInvoke.Resize(bit, mat, new Size(400, 400));
            
            //PictureUnder(mat);
            pictureBox1.Image = mat.ToBitmap();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            Mat matNew = new Mat();
            if (comboBox2.Text == "Binary")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.Binary);
            }
            if (comboBox2.Text == "InvertedBinary")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
            }
            if (comboBox2.Text == "Mask")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.Mask);
            }
            pictureBox1.Image = matNew.ToBitmap();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Mat matNew = new Mat();
            if (comboBox2.Text == "Binary")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.Binary);
            }
            if (comboBox2.Text == "InvertedBinary")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
            }
            if (comboBox2.Text == "Mask")
            {
                CvInvoke.Threshold(mat, matNew, trackBar1.Value, trackBar2.Value, Emgu.CV.CvEnum.ThresholdType.Mask);
            }
            pictureBox1.Image = matNew.ToBitmap();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mat bit = new Mat();
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                bit = new Mat(file.FileName);
                //other = new Mat(file.FileName);

            }
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
