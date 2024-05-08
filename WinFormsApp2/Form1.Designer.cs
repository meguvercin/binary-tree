namespace WinFormsApp2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numdepth = new NumericUpDown();
            numlength = new NumericUpDown();
            numdtheta = new NumericUpDown();
            txtlength_scale = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numdepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numlength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numdtheta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Depth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 51);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Length:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 83);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Length Scale:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 110);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "DTheata:";
            // 
            // numdepth
            // 
            numdepth.Location = new Point(131, 17);
            numdepth.Name = "numdepth";
            numdepth.Size = new Size(62, 23);
            numdepth.TabIndex = 4;
            numdepth.Value = new decimal(new int[] { 13, 0, 0, 0 });
            numdepth.ValueChanged += depth_ValueChanged;
            // 
            // numlength
            // 
            numlength.Location = new Point(131, 51);
            numlength.Name = "numlength";
            numlength.Size = new Size(62, 23);
            numlength.TabIndex = 5;
            numlength.Value = new decimal(new int[] { 59, 0, 0, 0 });
            // 
            // numdtheta
            // 
            numdtheta.Location = new Point(131, 110);
            numdtheta.Name = "numdtheta";
            numdtheta.Size = new Size(57, 23);
            numdtheta.TabIndex = 6;
            numdtheta.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // txtlength_scale
            // 
            txtlength_scale.Location = new Point(131, 80);
            txtlength_scale.Name = "txtlength_scale";
            txtlength_scale.Size = new Size(62, 23);
            txtlength_scale.TabIndex = 7;
            txtlength_scale.Text = "0.85";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(271, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 421);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtlength_scale);
            Controls.Add(numdtheta);
            Controls.Add(numlength);
            Controls.Add(numdepth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numdepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numlength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numdtheta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numdepth;
        private NumericUpDown numlength;
        private NumericUpDown numdtheta;
        private TextBox txtlength_scale;
        private PictureBox pictureBox1;
    }
}
