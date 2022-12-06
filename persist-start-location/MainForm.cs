using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Properties.Settings.Default.Location = JsonConvert.SerializeObject(Location);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Size = JsonConvert.SerializeObject(Size);
            Properties.Settings.Default.Save();
            var textB4 = Text;
            Text = $"Location = {Location} Size = {Size}";
            await Task.Delay(1000);
            Text = textB4;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(string.IsNullOrWhiteSpace(Properties.Settings.Default.Location))
            {
                saveSizeAndPosition(this, EventArgs.Empty);
            }
            Location = JsonConvert.DeserializeObject<Point>(Properties.Settings.Default.Location);
            Size = JsonConvert.DeserializeObject<Size>(Properties.Settings.Default.Size);
        }
    }
}
