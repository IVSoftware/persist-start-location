
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persist_start_location
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonSaveSizeAndPosition.Click += saveSizeAndPosition;
        }

        private async void saveSizeAndPosition(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.Size =Size;
            Properties.Settings.Default.Save();
            var textB4 = Text;
            Text = $"Location = {Location} Size = {Size}";
            await Task.Delay(1000);
            Text = textB4;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!Properties.Settings.Default.Size.Equals(new Size()))
            {
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
        }
    }
}
