 using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class Overlay : Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Unlimited";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Black;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(12, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(164, 22);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ping Téléportation";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Black;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(12, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(92, 22);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "GodMod";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Black;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(12, 96);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(150, 22);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Unlimited Ammo";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Black;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(12, 124);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(156, 22);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Auto ETO Enemy";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(12, 152);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 22);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Night";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(83, 152);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 22);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Day";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(176, 198);
            this.ControlBox = false;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Overlay";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        public Overlay()
        {

            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Mem.CheatEnable["Unlimited"] = checkBox1.Checked;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Mem.CheatEnable["PingTeleport"] = checkBox2.Checked;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Mem.CheatEnable["GodMod"] = checkBox3.Checked;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Mem.CheatEnable["UnlimitedAmmo"] = checkBox4.Checked;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Mem.CheatEnable["AutoETO"] = checkBox5.Checked;
        }
        private void Overlay_Load(object sender, EventArgs e)
        {
            TopMost = true;
            Location = new Point(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y);
            uint initialStyle = Imports.GetWindowLong(this.Handle, -20);
            Imports.SetWindowLong(this.Handle, -20, initialStyle);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Mem.CheatEnable["Night"] = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Mem.CheatEnable["Night"] = !radioButton2.Checked;
        }
    }
