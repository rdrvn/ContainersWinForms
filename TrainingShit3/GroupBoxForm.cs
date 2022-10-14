namespace TrainingShit3
{
    public partial class GroupBoxForm : Form
    {
        public GroupBoxForm()
        {
            InitializeComponent();
        }

        private void GroupBox_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(300, 300);

            GroupBox newGroupBox = new();
            newGroupBox.Text = "Example of GroupBox";
            newGroupBox.BackColor = Color.Aquamarine;

            newGroupBox.Left = (this.ClientSize.Width - newGroupBox.Width) / 2;
            newGroupBox.Top = (this.ClientSize.Height - newGroupBox.Height) / 2;
            newGroupBox.Anchor = AnchorStyles.None;

            #region Creating new options
            RadioButton rb1 = new();
            rb1.Text = "Example 1";
            rb1.Location = new Point(20, 20);

            RadioButton rb2 = new();
            rb2.Text = "Example 2";
            rb2.Location = new Point(20, 40);


            RadioButton rb3 = new();
            rb3.Text = "Example 3";
            rb3.Location = new Point(20, 60);
            #endregion

            newGroupBox.Controls.Add(rb1);
            newGroupBox.Controls.Add(rb2);
            newGroupBox.Controls.Add(rb3);

            this.Controls.Add(newGroupBox);
        }
    }
}
