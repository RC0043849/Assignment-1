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
            this.tabControl1.SuspendLayout();
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
            this.Cuboid.Location = new System.Drawing.Point(4, 22);
            this.Cuboid.Name = "Cuboid";
            this.Cuboid.Padding = new System.Windows.Forms.Padding(3);
            this.Cuboid.Size = new System.Drawing.Size(792, 424);
            this.Cuboid.TabIndex = 0;
            this.Cuboid.Text = "Cuboid";
            this.Cuboid.UseVisualStyleBackColor = true;
            // 
            // Sphere
            // 
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
            this.Cone.Location = new System.Drawing.Point(4, 22);
            this.Cone.Name = "Cone";
            this.Cone.Size = new System.Drawing.Size(792, 424);
            this.Cone.TabIndex = 2;
            this.Cone.Text = "Cone";
            this.Cone.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cuboid;
        private System.Windows.Forms.TabPage Sphere;
        private System.Windows.Forms.TabPage Cone;
    }
}

