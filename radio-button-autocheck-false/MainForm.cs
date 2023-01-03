namespace radio_button_autocheck_false
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            radioButton1.AutoCheck = false;
            radioButton1.MouseDown += (sender, e) =>radioButton1.Checked = !radioButton1.Checked;
            radioButton2.AutoCheck = false;
            radioButton2.MouseDown += (sender, e) =>radioButton2.Checked = !radioButton2.Checked;
        }
    }
}