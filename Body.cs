class DrawCircle : Form
{
    private const int formwidth = 1920;
    private const int formheight = 1080;

    private System.Windows.Forms.Label title = new System.Windows.Forms.Label();
    // Creating buttons
    private Button redbutton = new Button();
    private Button greenbutton = new Button();
    private Button bluebutton = new Button();

    private Button radius100button = new Button();
    private Button radius200button = new Button();
    private Button radius300button = new Button();

    private Button clearbutton = new Button();
    private Button drawbutton = new Button();
    private Button quitbutton = new Button();

    //Deciding button locations

    private Point location_of_redbutton = new Point(150, 560);
    private Point location_of_greenbutton = new Point(150, 600);
    private Point location_of_bluebutton = new Point(150, 640);

    private Point location_of_radius100button = new Point(550, 560);
    private Point location_of_radius200button = new Point(550, 600);
    private Point location_of_radius300button = new Point(550, 640);

    private Point location_of_clearbutton = new Point(980, 560);
    private Point location_of_drawbutton = new Point(980, 600);
    private Point location_of_quitbutton = new Point(980, 640);

    static bool red_btn_clicked = false;
    static bool blue_btn_clicked = false;
    static bool green_btn_click = false;

    static bool radius_100_clicked = false;
    static bool radius_200_clicked = false;
    static bool radius_300_clicked = false;


    public DrawCircle()
    {
        Text = "Assignment 1";
        System.Console.WriteLine("Form with : {0}. Form length : {1} ", formwidth, formheight);
        Size = new Size(formwidth, formheight);
        BackColor = Color.Black;
        title.Text = "Drawing Circles by Albin Vinoy";
        title.Font = new Font("Comic Sans MS", 12);
        title.Size = new Size(240, 30);
        //title.ImageAlign = ContentAlignment.BottomCenter;
        title.Location = new Point(520, 20);
        title.BackColor = Color.Yellow;

        redbutton.Text = "RED";
        redbutton.Size = new Size(85, 25);
        redbutton.BackColor = Color.Red;
        redbutton.Location = location_of_redbutton;

        greenbutton.Text = "GREEN";
        greenbutton.Size = new Size(85, 25);
        greenbutton.BackColor = Color.Green;
        greenbutton.Location = location_of_greenbutton;

        bluebutton.Text = "BLUE";
        bluebutton.BackColor = Color.Blue;
        bluebutton.Size = new Size(85, 25);
        bluebutton.Location = location_of_bluebutton;

        radius100button.Text = "Radius 100";
        radius100button.Size = new Size(85, 25);
        radius100button.Location = location_of_radius100button;
        radius100button.BackColor = Color.Tan;

        radius200button.Text = "Radius 200";
        radius200button.Size = new Size(85, 25);
        radius200button.Location = location_of_radius200button;
        radius200button.BackColor = Color.SaddleBrown;

        radius300button.Text = "Radius 300";
        radius300button.Size = new Size(85, 25);
        radius300button.Location = location_of_radius300button;
        radius300button.BackColor = Color.Teal;

        clearbutton.Text = "CLEAR";
        clearbutton.Size = new Size(85, 25);
        clearbutton.Location = location_of_clearbutton;
        clearbutton.BackColor = Color.WhiteSmoke;

        quitbutton.Text = "QUIT";
        quitbutton.Size = new Size(85, 25);
        quitbutton.Location = location_of_quitbutton;
        quitbutton.BackColor = Color.YellowGreen;

        drawbutton.Text = "DRAW"; ;
        drawbutton.Size = new Size(85, 25);
        drawbutton.Location = location_of_drawbutton;
        drawbutton.BackColor = Color.LemonChiffon;

        //Adding control the buttons
        Controls.Add(title);
        Controls.Add(redbutton);
        Controls.Add(bluebutton);
        Controls.Add(greenbutton);

        Controls.Add(drawbutton);
        Controls.Add(quitbutton);
        Controls.Add(clearbutton);

        Controls.Add(radius100button);
        Controls.Add(radius200button);
        Controls.Add(radius300button);

        // What do the clicks do
        quitbutton.Click += new EventHandler(quitbutton_Click);
        clearbutton.Click += clearbutton_Click;
        drawbutton.Click += drawbutton_Click;

        redbutton.Click += redbutton_Click;
        greenbutton.Click += greenbutton_Click;
        bluebutton.Click += bluebutton_Click;

        radius100button.Click += radius100button_Click;
        radius200button.Click += radius200button_Click;
        radius300button.Click += radius300button_Click;

    }

    private void radius100button_Click(object sender, EventArgs e)
    {
        if (radius100button.Enabled == true)
        {
            radius_100_clicked = true;
            radius_200_clicked = false;
            radius_300_clicked = false;
        }
    }
    private void radius200button_Click(object sender, EventArgs e)
    {
        if (radius200button.Enabled == true)
        {
            radius_100_clicked = false;
            radius_200_clicked = true;
            radius_300_clicked = false;
        }
    }
    private void radius300button_Click(object sender, EventArgs e)
    {
        if (radius300button.Enabled == true)
        {
            radius_100_clicked = false;
            radius_200_clicked = false;
            radius_300_clicked = true;
        }
    }

    void greenbutton_Click(object sender, EventArgs e)
    {
        if (greenbutton.Enabled == true)
        {
            red_btn_clicked = false;
            blue_btn_clicked = false;
            green_btn_click = true;
        }
    }
    void bluebutton_Click(object sender, EventArgs e)
    {
        if (bluebutton.Enabled == true)
        {
            red_btn_clicked = false;
            green_btn_click = false;
            blue_btn_clicked = true;
        }
    }
    void redbutton_Click(object sender, EventArgs e)
    {
        if (redbutton.Enabled == true)
        {
            red_btn_clicked = true;
            blue_btn_clicked = false;
            green_btn_click = false;
        }
    }

    void clearbutton_Click(object sender, EventArgs e)
    {
        red_btn_clicked = false;
        blue_btn_clicked = false;
        green_btn_click = false;

        radius_100_clicked = false;
        radius_200_clicked = false;
        radius_300_clicked = false;

        this.CreateGraphics().Clear(Form.ActiveForm.BackColor);
    }
    void drawbutton_Click(object sender, EventArgs e)
    {
        if (red_btn_clicked == true)
        {

            SolidBrush red_color = new SolidBrush(Color.Red);
            var controlGraphics = CreateGraphics();

            if (radius_100_clicked == true)
            {
                controlGraphics.FillEllipse(red_color, 653, 250, 100, 100);

            }
            else if (radius_200_clicked == true)
            {
                controlGraphics.FillEllipse(red_color, 601, 200, 200, 200);
            }
            else if (radius_300_clicked == true)
            {
                controlGraphics.FillEllipse(red_color, 550, 150, 300, 300);
            }
            else
            {
                MessageBox.Show("Invalid Option", "Invaid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        else if (green_btn_click)
        {
            SolidBrush green_color = new SolidBrush(Color.Green);
            var controlGraphics = CreateGraphics();

            if (radius_100_clicked == true)
            {
                controlGraphics.FillEllipse(green_color, 653, 250, 100, 100);
            }
            else if (radius_200_clicked == true)
            {
                controlGraphics.FillEllipse(green_color, 601, 200, 200, 200);
            }
            else if (radius_300_clicked == true)
            {
                controlGraphics.FillEllipse(green_color, 550, 150, 300, 300);
            }
            else
            {
                MessageBox.Show("Invalid Option", "Invaid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        else if (blue_btn_clicked)
        {
            SolidBrush blue_color = new SolidBrush(Color.DarkBlue);
            var controlGraphics = CreateGraphics();
            if (radius_100_clicked == true)
            {
                controlGraphics.FillEllipse(blue_color, 653, 250, 100, 100);
            }
            else if (radius_200_clicked == true)
            {
                controlGraphics.FillEllipse(blue_color, 601, 200, 200, 200);
            }
            else if (radius_300_clicked == true)
            { 
                controlGraphics.FillEllipse(blue_color, 550, 150, 300, 300);
            }
            else
            {
                MessageBox.Show("Invaid Option", "Invaid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        else
        {
            MessageBox.Show("Invaid Option ", "Invaid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
    void quitbutton_Click(object sender, EventArgs e)
    {
        System.Console.WriteLine("The program will now shut down");
        Close();
    }

}
