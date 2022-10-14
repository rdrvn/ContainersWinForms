namespace TrainingShit3
{
    public partial class FlowBox : Form
    {
        public FlowBox()
        {
            InitializeComponent();
        }

        private void FlowBox_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 400);

            FlowLayoutPanel flowLayoutPanel = new();
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Size = new Size(300, 100);
            flowLayoutPanel.BackColor = Color.DarkSeaGreen;
            // flowLayoutPanel.WrapContents = false;
            // flowLayoutPanel.AutoScroll = true;

            flowLayoutPanel.Left = (this.ClientSize.Width - flowLayoutPanel.Width) / 2;
            flowLayoutPanel.Top = (this.ClientSize.Height - flowLayoutPanel.Height) / 2;
            flowLayoutPanel.Anchor = AnchorStyles.None;

            Button b1 = new();
            b1.Text = "Button1";
            Button b2 = new();
            b2.Text = "Button2";
            Button b3 = new();
            b3.Text = "Button3";
            Button b4 = new();
            b4.Text = "Button4";
            Button b5 = new();
            b5.Text = "Button5";

            flowLayoutPanel.Controls.Add(b1);
            flowLayoutPanel.Controls.Add(b2);
            flowLayoutPanel.Controls.Add(b3);
            flowLayoutPanel.Controls.Add(b4);
            flowLayoutPanel.Controls.Add(b5);

            this.Controls.Add(flowLayoutPanel);
        }
    }
}
