namespace Assignment_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cuboid = new System.Windows.Forms.TabPage();
            this.V1 = new System.Windows.Forms.Label();
            this.SA1 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sphere = new System.Windows.Forms.TabPage();
            this.V2 = new System.Windows.Forms.Label();
            this.SA2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cone = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Calculate2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Cuboid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Sphere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Cone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cuboid);
            this.tabControl1.Controls.Add(this.Sphere);
            this.tabControl1.Controls.Add(this.Cone);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Cuboid
            // 
            this.Cuboid.Controls.Add(this.V1);
            this.Cuboid.Controls.Add(this.SA1);
            this.Cuboid.Controls.Add(this.calculate);
            this.Cuboid.Controls.Add(this.textBox3);
            this.Cuboid.Controls.Add(this.textBox2);
            this.Cuboid.Controls.Add(this.textBox1);
            this.Cuboid.Controls.Add(this.pictureBox1);
            this.Cuboid.Location = new System.Drawing.Point(4, 22);
            this.Cuboid.Name = "Cuboid";
            this.Cuboid.Padding = new System.Windows.Forms.Padding(3);
            this.Cuboid.Size = new System.Drawing.Size(792, 424);
            this.Cuboid.TabIndex = 0;
            this.Cuboid.Text = "Cuboid";
            this.Cuboid.UseVisualStyleBackColor = true;
            this.Cuboid.Click += new System.EventHandler(this.Cuboid_Click);
            // 
            // V1
            // 
            this.V1.AutoSize = true;
            this.V1.Location = new System.Drawing.Point(582, 226);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(45, 13);
            this.V1.TabIndex = 6;
            this.V1.Text = "Volume:";
            // 
            // SA1
            // 
            this.SA1.AutoSize = true;
            this.SA1.Location = new System.Drawing.Point(579, 188);
            this.SA1.Name = "SA1";
            this.SA1.Size = new System.Drawing.Size(72, 13);
            this.SA1.TabIndex = 5;
            this.SA1.Text = "Surface Area:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(589, 91);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(111, 42);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(451, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment_1.Properties.Resources._4_40680_cone_clipart_cuboid_shape_cuboid_png;
            this.pictureBox1.Location = new System.Drawing.Point(114, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Sphere
            // 
            this.Sphere.Controls.Add(this.Calculate2);
            this.Sphere.Controls.Add(this.V2);
            this.Sphere.Controls.Add(this.SA2);
            this.Sphere.Controls.Add(this.textBox4);
            this.Sphere.Controls.Add(this.pictureBox2);
            this.Sphere.Location = new System.Drawing.Point(4, 22);
            this.Sphere.Name = "Sphere";
            this.Sphere.Padding = new System.Windows.Forms.Padding(3);
            this.Sphere.Size = new System.Drawing.Size(792, 424);
            this.Sphere.TabIndex = 1;
            this.Sphere.Text = "Sphere";
            this.Sphere.UseVisualStyleBackColor = true;
            // 
            // V2
            // 
            this.V2.AutoSize = true;
            this.V2.Location = new System.Drawing.Point(630, 250);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(45, 13);
            this.V2.TabIndex = 3;
            this.V2.Text = "Volume:";
            // 
            // SA2
            // 
            this.SA2.AutoSize = true;
            this.SA2.Location = new System.Drawing.Point(630, 217);
            this.SA2.Name = "SA2";
            this.SA2.Size = new System.Drawing.Size(72, 13);
            this.SA2.TabIndex = 2;
            this.SA2.Text = "Surface Area:";
            this.SA2.Click += new System.EventHandler(this.SA2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Assignment_1.Properties.Resources.sphere_calc;
            this.pictureBox2.Location = new System.Drawing.Point(177, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(421, 306);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Cone
            // 
            this.Cone.Controls.Add(this.button1);
            this.Cone.Controls.Add(this.label4);
            this.Cone.Controls.Add(this.label3);
            this.Cone.Controls.Add(this.textBox6);
            this.Cone.Controls.Add(this.textBox5);
            this.Cone.Controls.Add(this.pictureBox3);
            this.Cone.Location = new System.Drawing.Point(4, 22);
            this.Cone.Name = "Cone";
            this.Cone.Size = new System.Drawing.Size(792, 424);
            this.Cone.TabIndex = 2;
            this.Cone.Text = "Cone";
            this.Cone.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(598, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surface Area:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(223, 381);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(39, 189);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(93, 20);
            this.textBox5.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Assignment_1.Properties.Resources.filecone_geometrypng_wikimedia_commons_math_geometry_png_300_390;
            this.pictureBox3.Location = new System.Drawing.Point(138, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(359, 330);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Calculate2
            // 
            this.Calculate2.Location = new System.Drawing.Point(644, 84);
            this.Calculate2.Name = "Calculate2";
            this.Calculate2.Size = new System.Drawing.Size(98, 45);
            this.Calculate2.TabIndex = 4;
            this.Calculate2.Text = "Calculate";
            this.Calculate2.UseVisualStyleBackColor = true;
            this.Calculate2.Click += new System.EventHandler(this.Calculate2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Cuboid.ResumeLayout(false);
            this.Cuboid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Sphere.ResumeLayout(false);
            this.Sphere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Cone.ResumeLayout(false);
            this.Cone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cuboid;
        private System.Windows.Forms.TabPage Sphere;
        private System.Windows.Forms.TabPage Cone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label V1;
        private System.Windows.Forms.Label SA1;
        private System.Windows.Forms.Label V2;
        private System.Windows.Forms.Label SA2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate2;
    }
}

