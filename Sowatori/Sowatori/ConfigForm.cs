using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sowatori
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void LengthBar_Scroll(object sender, EventArgs e)
        {
            LengthNumLabel.Text = Convert.ToString(LengthBar.Value * 25);
        }

        private void HeightBar_Scroll(object sender, EventArgs e)
        {
            HeightNumLabel.Text = Convert.ToString(HeightBar.Value * 25);
        }

        private void DiffBar_Scroll(object sender, EventArgs e)
        {
            DiffNumLabel.Text = Convert.ToString(DiffBar.Value);
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            DiffBar.Value = Properties.Settings.Default.Difficulty;
            HeightBar.Value = Properties.Settings.Default.Ysize / 25;
            LengthBar.Value = Properties.Settings.Default.Xsize / 25;
            DiffNumLabel.Text = Convert.ToString(Properties.Settings.Default.Difficulty);
            HeightNumLabel.Text = Convert.ToString(Properties.Settings.Default.Ysize);
            LengthNumLabel.Text = Convert.ToString(Properties.Settings.Default.Xsize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = DiffBar.Value;
            Properties.Settings.Default.Ysize = HeightBar.Value * 25;
            Properties.Settings.Default.Xsize = LengthBar.Value * 25;
            Properties.Settings.Default.Save();
            MessageBox.Show("Чтобы настройки вступили в силу, перезапустите программу или выберете пункт *Создать* в меню *Игра*.");
            this.Close();
        }
    }
}
