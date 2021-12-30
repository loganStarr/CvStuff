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
using System.Linq;

namespace CvStuff
{
    public partial class Form1 : Form
    {
        Mat Fistmat;
        Mat SecondMat;
        Mat mat = new Mat();
        Mat Demicract = new Mat();
        VideoCapture capture;
        const int cameraIndex = 0;

        //GameManager game = new GameManager();
        bool toCapture = false; //true if we should capture the hitboxes this turn

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
            capture = new VideoCapture(0);
            
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
            Mat src = new Mat();
            Mat oupit = new Mat();
            // var lowerBound = (ScalarArray)new MCvScalar(MinR.Value, MinG.Value, MinB.Value);
            // var upperBound = (ScalarArray)new MCvScalar(Ma, 100, 50);
            // CvInvoke.InRange(src, lowerBound, upperBound, oupit);

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
            CvInvoke.BitwiseAnd(SecondMat, mat, SecondMat);
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

            CvInvoke.Rotate(mat, mat, Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise);
            CvInvoke.BitwiseNot(mat, mat);
            CvInvoke.BitwiseAnd(mat, Fistmat, mat);
            CvInvoke.BitwiseNot(mat, mat);
            //CvInvoke.BitwiseOr(SecondMat, mat, SecondMat);
            OutputBox.Image = mat;

        }
        private Bitmap R(Bitmap bitmap)
        {
            Bitmap bit = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var s = bitmap.GetPixel(i, y);
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
                    bit.SetPixel(i, y, Color.FromArgb(te, te, te));
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
            CvInvoke.Resize(SecondMat, SecondMat, new Size(400, 400));
            //CvInvoke.CvtColor(SecondMat, SecondMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            //VectorOfPoint oints = new VectorOfPoint();
            // CvInvoke.DrawContours(SecondMat, oints, 3, new MCvScalar(255, 255, 255));
            Stuf();
            imageBox1.Image = SecondMat;
            //Blurr(SecondMat);


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
            mat = new Mat();
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                bit = new Mat(file.FileName);
                other = new Mat(file.FileName);

            }
            VectorOfVectorOfPoint vecs = new VectorOfVectorOfPoint();

            CvInvoke.Resize(bit, mat, new Size(400, 400));
            CvInvoke.Resize(bit, other, new Size(400, 400));
            Bitmap bits = other.ToBitmap();


            //CvInvoke.CvtColor(mat, mat, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            //CvInvoke.Threshold(mat, mat, 100, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

            //CvInvoke.FindContours(mat, vecs, new Mat(), Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);

            //CvInvoke.CvtColor(mat, mat, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);

            //OpenFileDialog ffile = new OpenFileDialog();
            //var dfone = file.ShowDialog();
            //if (dfone == DialogResult.OK || dfone == DialogResult.Yes)
            //{
            //    //bit = new Mat(file.FileName);
            //    other = new Mat(file.FileName);

            //}
            //CvInvoke.Resize(other, other, new Size(400, 400));
            //CvInvoke.DrawContours(other, vecs, -1, new MCvScalar(255, 0, 0), 5);
            //CvInvoke.DrawContours(other, vecs, 6, new MCvScalar(255, 0, 0), 5);
            //CvInvoke.DrawContours(other, vecs, 5, new MCvScalar(255, 0, 0), 5);
            //PictureUnder(mat);
            pictureBox1.Image = bits;
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
            Mat bit = new Mat();
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                bit = new Mat(file.FileName);

            }
            CvInvoke.Resize(bit, Demicract, new Size(400, 400));

            imageBox1.Image = Demicract;
        }

        private void MinR_Scroll(object sender, EventArgs e)
        {
            //if (button3.Text == "RGB")
            //{
            //    MinR.Maximum = 255;
            //    MinG.Maximum = 255;
            //    MinB.Maximum = 255;
            //    MaxR.Maximum = 255;
            //    MaxG.Maximum = 255;
            //    MaxB.Maximum = 255;
            //    var lowerBound = (ScalarArray)new MCvScalar(MinR.Value, MinG.Value, MinB.Value);
            //    var upperBound = (ScalarArray)new MCvScalar(MaxR.Value, MaxG.Value, MaxB.Value);
            //    Mat temp = Demicract.Clone();
            //    CvInvoke.CvtColor(temp, temp, Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr);
            //    CvInvoke.InRange(Demicract, lowerBound, upperBound, temp);
            //    CvInvoke.BitwiseAnd(Demicract, temp, temp);
            //    imageBox1.Image = temp;
            //}
            //else
            //{
            //    MinR.Maximum = 360;
            //    MinG.Maximum = 100;
            //    MinB.Maximum = 100;
            //    MaxR.Maximum = 360;
            //    MaxG.Maximum = 100;
            //    MaxB.Maximum = 100;
            //    var lowerBound = (ScalarArray)new MCvScalar(MinR.Value / 2f, MinG.Value * (255 / 100f), MinB.Value * (255 / 100f));
            //    var upperBound = (ScalarArray)new MCvScalar(MaxR.Value / 2f, MaxG.Value * (255 / 100f), MaxB.Value * (255 / 100f));
            //    Mat temp = Demicract.Clone();
            //    CvInvoke.CvtColor(temp, temp, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            //    CvInvoke.InRange(Demicract, lowerBound, upperBound, temp);
            //    CvInvoke.CvtColor(temp, temp, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);
            //    CvInvoke.BitwiseAnd(Demicract, temp, temp);
            //    //Hue: CV: 0 - 180 Hueman: 0 - 360
            //    //Saturation: CV: 0 - 255, Human: 0 - 100 
            //    //Value: CV: 0 - 255, Human: 0 - 100
            //    imageBox1.Image = temp;
            //}
            label6.Text = $" {MinR.Value} {MinB.Value} {MinG.Value} ";
        }
        public void Blur()
        {
            Mat kernel = new Mat();
            CvInvoke.Blur(Demicract, kernel, new Size(100, 100), new Point(2, 2));
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "RGB")
            {
                button3.Text = "HSV";
            }
            else
            {
                button3.Text = "RGB";
            }
            ShapeDection();
        }
        public void Blurr(Mat ogs)
        {
            Size kernal = new Size(3, 3);
            int[][] ints = new int[4][];
            Point pont = new Point(0, 0);
            Mat og = ogs;

            Bitmap bit = og.ToBitmap();
            for (int i = 0; i < 4; i++)
            {
                ints[i] = new int[4];
                for (int y = 0; y < 4; y++)
                {
                    ints[i][y] = 1;
                }
            }
            for (int i = 1; i < bit.Width - 1; i++)
            {
                //2,2
                //0,0
                //3,3
                //1,1
                for (int y = 1; y < bit.Height - 1; y++)
                {
                    var s = bit.GetPixel(i, y);
                    double t = 0;

                    for (int i2 = 0; i2 < kernal.Width; i2++)
                    {
                        for (int y2 = 0; y2 < kernal.Height; y2++)
                        {
                            if (y - y2 >= 0 && i - i2 >= 0)
                            {
                                t += ints[i2][y2] * bit.GetPixel(i + i2 - 1, y + y2 - 1).R;
                            }
                        }
                    }
                    t = (int)(t / 9);
                    bit.SetPixel(i, y, Color.FromArgb(s.A, (int)t, (int)t, (int)t));
                }
            }
            //image is grayscale
            SecondMat = bit.ToMat();
            imageBox1.Image = SecondMat;
        }
        public void Stuf()
        {
            VectorOfColorPoint vec = new VectorOfColorPoint();

            CvInvoke.CvtColor(SecondMat, SecondMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(SecondMat, SecondMat, 100, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            VectorOfVectorOfPoint oints = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(SecondMat, oints, new Mat(), Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);
            double max = 0;
            int index = 0;
            //Store bounding rect
            for (int i = 0; i < oints.Size; i++)
            {
                double area = CvInvoke.ContourArea(oints[i]);

                if (area > max)
                {
                    index = i;
                    max = area;
                    //update bounding rect
                }

            }

            //Convert second mat from gray to bgr 
            CvInvoke.CvtColor(SecondMat, SecondMat, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);
            CvInvoke.DrawContours(SecondMat, oints, index, new MCvScalar(255, 0, 0), 3);
            //CvInvoke.

            /*
            //keep trakc of minx, maxx, miny, maxy
            int maxx = 0;
            int maxy = 0;
            int minx = 0;
            int miny = 0;
            for (int i = 0; i < oints[index].Size; i++)
            {
                if (minx > oints[index][i].X)
                {
                    minx = oints[index][i].X;
                }
                if (miny > oints[index][i].Y)
                {
                    miny = oints[index][i].Y;
                }
                if (maxx < oints[index][i].X)
                {
                    maxx = oints[index][i].X;
                }
                if (maxy < oints[index][i].Y)
                {
                    maxy = oints[index][i].Y;
                }
            }
            */
            //Use bounding rect for x, y, width, height

            CvInvoke.PutText(SecondMat, $"{max}", new Point(CvInvoke.BoundingRectangle(SecondMat).X, CvInvoke.BoundingRectangle(SecondMat).Y), Emgu.CV.CvEnum.FontFace.HersheyScriptSimplex, 1, new MCvScalar(0, 0, 255));

        }
        private Rectangle Contos(Bitmap image, int thic)
        {
            int Lessx = 0;
            int lessY = 0;
            int maxx = 0;
            int maxy = 0;
            List<(int, int)> Maxxs = new List<(int, int)>();

            //for (int x = 0; x < image.Width; x++)
            //{
            //    for (int y = 0; y < image.Height; y++)
            //    {
            //        var s = image.GetPixel(x,y);
            //        if(s.R != 0)
            //        {
            //            if (Maxxs.Count == 0)
            //            {
            //                Maxxs.Add((x,0));
            //            }
            //            if(Maxxs.Contains(x))
            //            {
            //                Maxxs.Add();
            //            }
            //        }
            //    }
            //}
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    var s = image.GetPixel(x, y);
                    if (s.R != 0)
                    {
                        if (maxx == 0)
                        {
                            Lessx = x;
                            maxx = x;
                            lessY = y;
                            maxy = y;
                        }
                        if (x < Lessx)
                        {
                            Lessx = x;
                        }
                        if (y < lessY)
                        {
                            lessY = y;
                        }
                        if (y > maxy)
                        {
                            maxy = y;
                        }
                        if (x > maxx)
                        {
                            maxx = x;
                        }
                    }
                }
            }
            Rectangle NewRectange = new Rectangle(Lessx, lessY, maxx, maxy);
            for (int i = Lessx; i < maxx; i++)
            {
                for (int e = 0; e < thic; e++)
                {
                    image.SetPixel(i, lessY, Color.FromArgb(0, 0, 255));
                    image.SetPixel(i, maxy, Color.FromArgb(0, 0, 255));
                }

            }
            for (int i = lessY; i < maxy; i++)
            {
                for (int e = 0; e < thic; e++)
                {
                    image.SetPixel(Lessx, i, Color.FromArgb(0, 0, 255));
                    image.SetPixel(maxx, i, Color.FromArgb(0, 0, 255));
                }
            }

            return NewRectange;
        }
        public void Toys()
        {
            Mat bits = new Mat();
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                bits = new Mat(file.FileName);

            }
            Rectangle rec1 = new Rectangle(4, 4, 367, 245);
            Rectangle rec2 = new Rectangle(4, 252, 367, 245);
            Mat Roi1 = new Mat(bits, rec1);
            Mat Roi2 = new Mat(bits, rec2);

            //Threshold(bit1, bit1, MaxB.Value);
            //Abs diff plus grayscale threshold is the mask, then you find controsers
            Mat diff = new Mat();
            CvInvoke.AbsDiff(Roi1, Roi2, diff);

            CvInvoke.CvtColor(diff, diff, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(diff, diff, 50, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            CvInvoke.GaussianBlur(diff, diff, new Size(3, 3), 1);


            // fuck off
            imageBox1.Image = diff;
            //return;

            VectorOfVectorOfPoint vecs = new VectorOfVectorOfPoint();

            CvInvoke.FindContours(diff, vecs, new Mat(), Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);

            for (int i = 0; i < vecs.Size; i++)
            {
                //CvInvoke.Rectangle();
            }
            CvInvoke.DrawContours(Roi2, vecs, -1, new MCvScalar(200, 0, 0), 5);


            imageBox1.Image = Roi2;
        }
        public void GrayScale(Bitmap bits)
        {
            for (int i = 0; i < bits.Width; i++)
            {
                for (int x = 0; x < bits.Height; x++)
                {
                    var s = bits.GetPixel(i, x);
                    int val = (s.R + s.G + s.B) / 3;
                    bits.SetPixel(i, x, Color.FromArgb(val, val, val));
                }
            }
        }
        public void Threshold(Bitmap one, Bitmap output, int max)
        {
            for (int i = 0; i < one.Width; i++)
            {
                for (int x = 0; x < one.Height; x++)
                {
                    var Onep = one.GetPixel(i, x);
                    int R = 0;
                    int B = 0;
                    int G = 0;
                    if (Onep.R > max)
                    {
                        R = 255;
                    }
                    if (Onep.G > max)
                    {
                        G = 255;
                    }
                    if (Onep.B > max)
                    {
                        B = 255;
                    }
                    output.SetPixel(i, x, Color.FromArgb(R, G, B));
                }
            }
        }
        public void Xor(Bitmap one, Bitmap two, Bitmap output)
        {
            for (int i = 0; i < one.Width; i++)
            {
                for (int x = 0; x < one.Height; x++)
                {
                    var Onep = one.GetPixel(i, x);
                    var Twop = two.GetPixel(i, x);
                    output.SetPixel(i, x, Color.FromArgb(Twop.R ^ Onep.R, Twop.G ^ Onep.G, Twop.B ^ Onep.B));
                }
            }
        }
        public void ShapeDection()
        {
            //Grayscale then binary then blur then Contrors
            Mat bits = new Mat();
            OpenFileDialog file = new OpenFileDialog();
            var done = file.ShowDialog();
            if (done == DialogResult.OK || done == DialogResult.Yes)
            {
                bits = new Mat(file.FileName);

            }
            VectorOfVectorOfPoint vecs = new VectorOfVectorOfPoint();
            CvInvoke.CvtColor(bits,bits, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(bits, bits, 80, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            CvInvoke.Blur(bits,bits,new Size(3,3), Location);
            CvInvoke.FindContours(bits, vecs, new Mat(), Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);

            // Archlenght is perimeter area is contour area
            for (int i = 0; i < vecs.Size; i++)
            {
                Rectangle boudingRect = CvInvoke.BoundingRectangle(vecs[i]);
                RotatedRect Roated = CvInvoke.MinAreaRect(vecs[i]);
                //bool isRotated = (bool)(Roated.Height % 90);

                double space = CvInvoke.ContourArea(vecs[i]);
                double permiter = CvInvoke.ContourArea(vecs[i]);
                var NewContror = new VectorOfPoint();
                string s = "";
                CvInvoke.ApproxPolyDP(vecs[i], NewContror, 10, true);
                if (permiter / boudingRect.Width >= 2 && permiter / boudingRect.Width <= 3.7)
                {
                    s = "Circle";
                }
                else if (NewContror.Size == 4)
                {
                    s = "Rec";
                }
                else if (NewContror.Size == 3)
                {
                    s = "Triangle";
                }
                else if (NewContror.Size == 5)
                {
                    s = "Pentagon";
                }
                else if (NewContror.Size == 6)
                {
                    s = "Hexagon";
                }
                else
                {
                    s = "Polygon/UNSUB";
                }
                CvInvoke.PutText(bits,s,new Point(boudingRect.X,boudingRect.Y),Emgu.CV.CvEnum.FontFace.HersheyComplex,0.5,new MCvScalar(255,0,0),1);
                
            }
            CvInvoke.DrawContours(bits, vecs,-1, new MCvScalar(0,255,0), 5);
            imageBox1.Image = bits;
        }
        public void 
        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void imageBox1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
