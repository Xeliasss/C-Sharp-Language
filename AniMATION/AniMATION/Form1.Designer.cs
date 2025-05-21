namespace AniMATION
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Speed = new Label();
            numspeed = new NumericUpDown();
            notbremse = new Button();
            enginestart = new Button();
            pictureBoxRot = new PictureBox();
            pictureBoxGelb = new PictureBox();
            pictureBoxGruen = new PictureBox();
            ampeltimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBoxGruen2 = new PictureBox();
            pictureBoxGelb2 = new PictureBox();
            pictureBoxRot2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numspeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGelb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGruen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGruen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGelb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRot2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(642, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Speed
            // 
            Speed.AutoSize = true;
            Speed.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Speed.Location = new Point(496, 13);
            Speed.Name = "Speed";
            Speed.Size = new Size(64, 25);
            Speed.TabIndex = 1;
            Speed.Text = "Speed";
            // 
            // numspeed
            // 
            numspeed.Location = new Point(593, 13);
            numspeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numspeed.Name = "numspeed";
            numspeed.Size = new Size(120, 23);
            numspeed.TabIndex = 2;
            numspeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numspeed.ValueChanged += numspeed_ValueChanged;
            // 
            // notbremse
            // 
            notbremse.BackColor = Color.Red;
            notbremse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            notbremse.Location = new Point(618, 47);
            notbremse.Name = "notbremse";
            notbremse.Size = new Size(141, 27);
            notbremse.TabIndex = 3;
            notbremse.Text = "Notbremse";
            notbremse.UseVisualStyleBackColor = false;
            notbremse.Click += notbremse_Click;
            // 
            // enginestart
            // 
            enginestart.BackColor = Color.Lime;
            enginestart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            enginestart.Location = new Point(465, 47);
            enginestart.Name = "enginestart";
            enginestart.Size = new Size(136, 27);
            enginestart.TabIndex = 4;
            enginestart.Text = "Engine Start";
            enginestart.UseVisualStyleBackColor = false;
            enginestart.Click += enginestart_Click;
            // 
            // pictureBoxRot
            // 
            pictureBoxRot.Image = (Image)resources.GetObject("pictureBoxRot.Image");
            pictureBoxRot.Location = new Point(85, 91);
            pictureBoxRot.Name = "pictureBoxRot";
            pictureBoxRot.Size = new Size(100, 50);
            pictureBoxRot.TabIndex = 5;
            pictureBoxRot.TabStop = false;
            // 
            // pictureBoxGelb
            // 
            pictureBoxGelb.Image = (Image)resources.GetObject("pictureBoxGelb.Image");
            pictureBoxGelb.Location = new Point(85, 91);
            pictureBoxGelb.Name = "pictureBoxGelb";
            pictureBoxGelb.Size = new Size(100, 50);
            pictureBoxGelb.TabIndex = 6;
            pictureBoxGelb.TabStop = false;
            // 
            // pictureBoxGruen
            // 
            pictureBoxGruen.Image = (Image)resources.GetObject("pictureBoxGruen.Image");
            pictureBoxGruen.Location = new Point(85, 91);
            pictureBoxGruen.Name = "pictureBoxGruen";
            pictureBoxGruen.Size = new Size(100, 50);
            pictureBoxGruen.TabIndex = 7;
            pictureBoxGruen.TabStop = false;
            // 
            // ampeltimer
            // 
            ampeltimer.Enabled = true;
            ampeltimer.Interval = 2000;
            ampeltimer.Tick += ampeltimer_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(539, 385);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxGruen2
            // 
            pictureBoxGruen2.Image = (Image)resources.GetObject("pictureBoxGruen2.Image");
            pictureBoxGruen2.Location = new Point(748, 305);
            pictureBoxGruen2.Name = "pictureBoxGruen2";
            pictureBoxGruen2.Size = new Size(100, 50);
            pictureBoxGruen2.TabIndex = 9;
            pictureBoxGruen2.TabStop = false;
            // 
            // pictureBoxGelb2
            // 
            pictureBoxGelb2.Image = (Image)resources.GetObject("pictureBoxGelb2.Image");
            pictureBoxGelb2.Location = new Point(748, 305);
            pictureBoxGelb2.Name = "pictureBoxGelb2";
            pictureBoxGelb2.Size = new Size(100, 50);
            pictureBoxGelb2.TabIndex = 10;
            pictureBoxGelb2.TabStop = false;
            // 
            // pictureBoxRot2
            // 
            pictureBoxRot2.Image = (Image)resources.GetObject("pictureBoxRot2.Image");
            pictureBoxRot2.Location = new Point(748, 305);
            pictureBoxRot2.Name = "pictureBoxRot2";
            pictureBoxRot2.Size = new Size(100, 50);
            pictureBoxRot2.TabIndex = 11;
            pictureBoxRot2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 578);
            Controls.Add(pictureBoxRot2);
            Controls.Add(pictureBoxGelb2);
            Controls.Add(pictureBoxGruen2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxGruen);
            Controls.Add(pictureBoxGelb);
            Controls.Add(pictureBoxRot);
            Controls.Add(enginestart);
            Controls.Add(notbremse);
            Controls.Add(numspeed);
            Controls.Add(Speed);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numspeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGelb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGruen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGruen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGelb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRot2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label Speed;
        private NumericUpDown numspeed;
        private Button notbremse;
        private Button enginestart;
        private PictureBox pictureBoxRot;
        private PictureBox pictureBoxGelb;
        private PictureBox pictureBoxGruen;
        private System.Windows.Forms.Timer ampeltimer;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxGruen2;
        private PictureBox pictureBoxGelb2;
        private PictureBox pictureBoxRot2;
    }
}
