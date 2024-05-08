namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Recursively draw a binary tree branch
        private void DrawBranch(Graphics gr, Pen pen, int depth, float x, float y, float length, float theta, float length_sclae, float dtheta)
        {
            //See where this branch should end
            float x1 = (float)(x + length * Math.Cos(theta));
            float y1 = (float)(y + length * Math.Sin(theta));

            gr.DrawLine(pen, x, y, x1, y1);

            // if depth > 1, draw the attached branches.
            if (depth > 1)
            {
                DrawBranch(gr, pen, depth - 1, x1, y1,
                    length * length_sclae, theta + dtheta, length_sclae, dtheta);

                DrawBranch(gr, pen, depth - 1, x1, y1,
                    length * length_sclae, theta - dtheta, length_sclae, dtheta);


            }


        }

        private void depth_ValueChanged(object sender, EventArgs e)
        {
            float f;
            float.TryParse(txtlength_scale.Text, out f);
            DrawBranch(pictureBox1.CreateGraphics(), Pens.Green, (int)numdepth.Value, 252, 421, (float)numlength.Value, 0, f, (float)numdtheta.Value);
        }
    }
}
