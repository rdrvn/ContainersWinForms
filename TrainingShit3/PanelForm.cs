namespace TrainingShit3
{
    public partial class PanelForm : Form
    {
        public PanelForm()
        {
            InitializeComponent();
        }

        private void PanelForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(300, 300);

            Panel panel1 = new();
            panel1.BackColor = Color.Coral;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Size = new Size(200, 100);
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 8;
            panel1.Anchor = AnchorStyles.Top;

            Label text1 = new();
            text1.Size = new Size(this.Width, this.Height);
            text1.Padding = new Padding(10);
            text1.Text = "I'm an element of Panel";

            panel1.Controls.Add(text1);
            panel1.AutoScroll = true;


            this.Controls.Add(panel1);
        }
    }
}
