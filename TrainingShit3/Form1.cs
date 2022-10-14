namespace TrainingShit3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "TrainingShit3";
            this.Size = new System.Drawing.Size(300, 300);
       
            Button groupBoxButton = new();
            this.Controls.Add(groupBoxButton);
            Button panelBoxButton = new();
            this.Controls.Add(panelBoxButton);
            Button flowLayoutPanel = new();
            this.Controls.Add(flowLayoutPanel);

            groupBoxButton.Text = "GroupBox";
            groupBoxButton.Left = (this.ClientSize.Width - groupBoxButton.Width) / 2;
            groupBoxButton.Top = (this.ClientSize.Height - groupBoxButton.Height) / 4;
            groupBoxButton.Anchor = AnchorStyles.Top;

            panelBoxButton.Text = "PanelBox";
            panelBoxButton.Left = (this.ClientSize.Width - panelBoxButton.Width) / 2;
            panelBoxButton.Top = (this.ClientSize.Height - panelBoxButton.Height) / 2;
            panelBoxButton.Anchor = AnchorStyles.None;

            flowLayoutPanel.Text = "FlowBox";
            flowLayoutPanel.Left = (this.ClientSize.Width - flowLayoutPanel.Width) / 2;
            flowLayoutPanel.Top = Convert.ToInt32((this.ClientSize.Height - flowLayoutPanel.Height) * 0.75);
            flowLayoutPanel.Anchor = AnchorStyles.Bottom;

            groupBoxButton.Click += GroupBoxButton_Click;
            panelBoxButton.Click += PanelBoxButton_Click;
            flowLayoutPanel.Click += FlowLayoutPanel_Click;
        }

        private void FlowLayoutPanel_Click(object? sender, EventArgs e)
        {
            FlowBox newFlowBox = new();
            newFlowBox.Show();
        }

        private void PanelBoxButton_Click(object? sender, EventArgs e)
        {
            PanelForm newPanelForm = new();
            newPanelForm.Show();
        }

        private void GroupBoxButton_Click(object? sender, EventArgs e)
        {
            GroupBoxForm groupBoxForm = new();
            groupBoxForm.Show();
        }
    }
}