
namespace CvStuff
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputBox = new Emgu.CV.UI.ImageBox();
            this.Mat2 = new Emgu.CV.UI.ImageBox();
            this.Mat1 = new Emgu.CV.UI.ImageBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Spilt = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.MinR = new System.Windows.Forms.TrackBar();
            this.MinG = new System.Windows.Forms.TrackBar();
            this.MinB = new System.Windows.Forms.TrackBar();
            this.MaxB = new System.Windows.Forms.TrackBar();
            this.MaxG = new System.Windows.Forms.TrackBar();
            this.MaxR = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.OutputBox);
            this.panel1.Controls.Add(this.Mat2);
            this.panel1.Controls.Add(this.Mat1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 341);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(28, 315);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1350, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(1056, 20);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(75, 23);
            this.OutputBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OutputBox.TabIndex = 2;
            this.OutputBox.TabStop = false;
            // 
            // Mat2
            // 
            this.Mat2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mat2.Location = new System.Drawing.Point(39, 20);
            this.Mat2.Name = "Mat2";
            this.Mat2.Size = new System.Drawing.Size(110, 51);
            this.Mat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Mat2.TabIndex = 2;
            this.Mat2.TabStop = false;
            this.Mat2.Click += new System.EventHandler(this.Mat2_Click);
            // 
            // Mat1
            // 
            this.Mat1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mat1.Location = new System.Drawing.Point(564, 20);
            this.Mat1.Name = "Mat1";
            this.Mat1.Size = new System.Drawing.Size(110, 51);
            this.Mat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Mat1.TabIndex = 2;
            this.Mat1.TabStop = false;
            this.Mat1.Click += new System.EventHandler(this.Mat1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1022, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 955);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Max, min";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(350, 988);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 947);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(6, 577);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar1.Location = new System.Drawing.Point(12, 1124);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1191, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar2.Location = new System.Drawing.Point(12, 1048);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(1191, 45);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 1016);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 1096);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Min";
            // 
            // Spilt
            // 
            this.Spilt.Location = new System.Drawing.Point(12, 399);
            this.Spilt.Name = "Spilt";
            this.Spilt.Size = new System.Drawing.Size(75, 23);
            this.Spilt.TabIndex = 15;
            this.Spilt.Text = "Spilt";
            this.Spilt.UseVisualStyleBackColor = true;
            this.Spilt.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imageBox1.Location = new System.Drawing.Point(921, 487);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(75, 23);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            this.imageBox1.MouseHover += new System.EventHandler(this.imageBox1_MouseHover);
            // 
            // MinR
            // 
            this.MinR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinR.Location = new System.Drawing.Point(873, 884);
            this.MinR.Maximum = 255;
            this.MinR.Name = "MinR";
            this.MinR.Size = new System.Drawing.Size(228, 45);
            this.MinR.TabIndex = 16;
            this.MinR.Scroll += new System.EventHandler(this.MinR_Scroll);
            // 
            // MinG
            // 
            this.MinG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinG.Location = new System.Drawing.Point(873, 935);
            this.MinG.Maximum = 255;
            this.MinG.Name = "MinG";
            this.MinG.Size = new System.Drawing.Size(228, 45);
            this.MinG.TabIndex = 17;
            this.MinG.Scroll += new System.EventHandler(this.MinR_Scroll);
            // 
            // MinB
            // 
            this.MinB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinB.Location = new System.Drawing.Point(873, 986);
            this.MinB.Maximum = 255;
            this.MinB.Name = "MinB";
            this.MinB.Size = new System.Drawing.Size(228, 45);
            this.MinB.TabIndex = 18;
            this.MinB.Scroll += new System.EventHandler(this.MinR_Scroll);
            // 
            // MaxB
            // 
            this.MaxB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaxB.Location = new System.Drawing.Point(1219, 986);
            this.MaxB.Maximum = 255;
            this.MaxB.Name = "MaxB";
            this.MaxB.Size = new System.Drawing.Size(228, 45);
            this.MaxB.TabIndex = 21;
            this.MaxB.Scroll += new System.EventHandler(this.MinR_Scroll);
            // 
            // MaxG
            // 
            this.MaxG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaxG.Location = new System.Drawing.Point(1219, 935);
            this.MaxG.Maximum = 255;
            this.MaxG.Name = "MaxG";
            this.MaxG.Size = new System.Drawing.Size(228, 45);
            this.MaxG.TabIndex = 20;
            this.MaxG.Scroll += new System.EventHandler(this.MinR_Scroll);
            // 
            // MaxR
            // 
            this.MaxR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaxR.Location = new System.Drawing.Point(1219, 884);
            this.MaxR.Maximum = 255;
            this.MaxR.Name = "MaxR";
            this.MaxR.Size = new System.Drawing.Size(228, 45);
            this.MaxR.TabIndex = 19;
            this.MaxR.Scroll += new System.EventHandler(this.MinR_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(921, 848);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Min ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1283, 848);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Max";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1128, 986);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "RGB";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1147, 955);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "label6";
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imageBox2.Location = new System.Drawing.Point(292, 577);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(75, 23);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1181);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxB);
            this.Controls.Add(this.MaxG);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MaxR);
            this.Controls.Add(this.MinB);
            this.Controls.Add(this.MinG);
            this.Controls.Add(this.MinR);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.Spilt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Emgu.CV.UI.ImageBox Mat1;
        private Emgu.CV.UI.ImageBox OutputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Emgu.CV.UI.ImageBox Mat2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button Spilt;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TrackBar MinR;
        private System.Windows.Forms.TrackBar MinG;
        private System.Windows.Forms.TrackBar MinB;
        private System.Windows.Forms.TrackBar MaxB;
        private System.Windows.Forms.TrackBar MaxG;
        private System.Windows.Forms.TrackBar MaxR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private Emgu.CV.UI.ImageBox imageBox2;
    }
}

