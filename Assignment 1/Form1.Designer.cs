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
            this.Sphere = new System.Windows.Forms.TabPage();
            this.Cone = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Cuboid.SuspendLayout();
            this.Sphere.SuspendLayout();
            this.Cone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // Sphere
            // 
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
            // Cone
            // 
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Assignment_1.Properties.Resources.filecone_geometrypng_wikimedia_commons_math_geometry_png_300_390;
            this.pictureBox3.Location = new System.Drawing.Point(199, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(298, 277);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(451, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(100, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(93, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(236, 341);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(589, 91);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(111, 42);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Cuboid.ResumeLayout(false);
            this.Cuboid.PerformLayout();
            this.Sphere.ResumeLayout(false);
            this.Sphere.PerformLayout();
            this.Cone.ResumeLayout(false);
            this.Cone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

