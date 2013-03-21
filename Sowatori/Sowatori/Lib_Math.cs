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
    public partial class Form1 : Form
    {
        int Difficulty;
        int Xsize;
        int Ysize;
        bool right;
        bool left;
        long ticks = 0;
        Size ButtonSize;
        GameWorkspace place = new GameWorkspace();
        Button[,] cells = new Button[1000, 1000];

        public Random rand = new Random();
        private GameWorkspace Generate(int x, int y)
        {
            this.Controls.Add(menuStrip1);
            for (int k = 0; k < x; k++)
                for (int h = 0; h < y; h++)
                {
                    cells[k,h] = new Button();
                    cells[k, h].Name = Convert.ToString(k) + " " + Convert.ToString(h);
                    cells[k, h].Size = ButtonSize;
                    this.Controls.Add(cells[k, h]);
                    cells[k, h].MouseDown += Cell_Clicked;
                    cells[k, h].MouseUp += Cell_MouseUp;
                    cells[k, h].Location = new Point((k) * ButtonSize.Width, (h) * ButtonSize.Height+27);
                    double q = rand.NextDouble();
                    if (q < Difficulty * 0.1) place.space[k, h] = 1; else place.space[k, h] = 0;
                }
            return place;
        }

        private void Cell_MouseUp(object sender, MouseEventArgs e)
        {
            Button a = (Button)sender;
            int x = a.Location.X / ButtonSize.Width;
            int y = a.Location.Y / ButtonSize.Height - 1;
            
             if (e.Button == MouseButtons.Right)
            {
                if ((a.BackColor != Color.Red) && (a.Text == "")) a.BackColor = Color.Red;
                else a.BackColor = DefaultBackColor;
            }
            else if (a.BackColor != Color.Red)
            {
                if (place.space[x, y] == 0) a.Text = Convert.ToString(CountBombsNear(x, y));
                else
                {
                    a.BackColor = Color.Black;
                    MessageBox.Show("Игра проиграна, но не расстраивайся! Попробуй лучше еще :3");
                    this.Hide();
                    this.Controls.Clear();
                    Generate(Xsize, Ysize);
                    this.Show();
                }               
            }
            if (a.Text == "0")
             {
                 if ((x > 0) && (cells[x - 1, y].Text == "")) Cell_MouseUp(cells[x - 1, y], e);
                 if ((x < Xsize - 1) && (cells[x + 1, y].Text == "")) Cell_MouseUp(cells[x + 1, y], e);
                 if ((y > 0) && (cells[x, y - 1].Text == "")) Cell_MouseUp(cells[x, y - 1], e);
                 if ((y < Ysize - 1) && (cells[x, y + 1].Text == "")) Cell_MouseUp(cells[x, y + 1], e);
                 if ((x > 0) && (y > 0) && (cells[x - 1, y - 1].Text == "")) Cell_MouseUp(cells[x - 1, y - 1], e);
                 if ((x > 0) && (y < Ysize - 1) && (cells[x - 1, y + 1].Text == "")) Cell_MouseUp(cells[x - 1, y + 1], e);
                 if ((x < Xsize - 1) && (y > 0) && (cells[x + 1, y - 1].Text == "")) Cell_MouseUp(cells[x + 1, y - 1], e);
                 if ((x < Xsize - 1) && (y < Ysize - 1) && (cells[x + 1, y + 1].Text == "")) Cell_MouseUp(cells[x + 1, y + 1], e);
             }
            bool win = true;
            for (int l = 0; l < Xsize; l++)
                for (int b = 0; b < Ysize; b++)
                {
                    if ((cells[l, b].BackColor == Color.Red) && (place.space[l, b] != 1)) win = false;
                    if ((place.space[l, b] == 1) && (cells[l, b].BackColor != Color.Red)) win = false;
                    if ((cells[l, b].Text == "") && (place.space[l, b] != 1)) win = false;
                }
            if (win)
            {
                MessageBox.Show("Победа! :D");
                this.Hide();
                Application.Exit();
            }
            left = false;
            right = false;
        }

        private void Cell_Clicked(object sender, MouseEventArgs e)
        {
            Button a = (Button)sender;
            int x = a.Location.X / ButtonSize.Width;
            int y = a.Location.Y / ButtonSize.Height - 1;

            if (e.Button == MouseButtons.Right) right = true;
            if (e.Button == MouseButtons.Left) left = true;
            if (right & left)
            {
                if ((x > 0) && (cells[x - 1, y].Text == "")) Cell_MouseUp(cells[x - 1, y], new MouseEventArgs(MouseButtons.Left,1,2,2,0));
                if ((x < Xsize - 1) && (cells[x + 1, y].Text == "")) Cell_MouseUp(cells[x + 1, y], new MouseEventArgs(MouseButtons.Left,1,2,2,0));
                if ((y > 0) && (cells[x, y - 1].Text == "")) Cell_MouseUp(cells[x, y - 1], new MouseEventArgs(MouseButtons.Left,1,2,2,0));
                if ((y < Ysize - 1) && (cells[x, y + 1].Text == "")) Cell_MouseUp(cells[x, y + 1], new MouseEventArgs(MouseButtons.Left,1,2,2,0));
                if ((x > 0) && (y > 0) && (cells[x - 1, y - 1].Text == "")) Cell_MouseUp(cells[x - 1, y - 1], new MouseEventArgs(MouseButtons.Left,1,2,2,0));
                if ((x > 0) && (y < Ysize - 1) && (cells[x - 1, y + 1].Text == "")) Cell_MouseUp(cells[x - 1, y + 1], new MouseEventArgs(MouseButtons.Left,1,2,2,0));
                if ((x < Xsize - 1) && (y > 0) && (cells[x + 1, y - 1].Text == "")) Cell_MouseUp(cells[x + 1, y - 1], new MouseEventArgs(MouseButtons.Left,1,2,2,0));
                if ((x < Xsize - 1) && (y < Ysize - 1) && (cells[x + 1, y + 1].Text == "")) Cell_MouseUp(cells[x + 1, y + 1], new MouseEventArgs(MouseButtons.Left,1,2,2,0));
                right = false;
                left = false;
            }
        }
                
        public void Properties_Load()
        {
            Difficulty = Properties.Settings.Default.Difficulty;
            Xsize = Properties.Settings.Default.Xsize;
            Ysize = Properties.Settings.Default.Ysize;
            ButtonSize = Properties.Settings.Default.ButtonSize;
        }

        private void TwiceButtons(int ticks)
        {
            MessageBox.Show("HHHH"); // просто выводит количество миллисекунд
        }

        public int CountBombsNear(int x, int y)
        {
            int ans = 0;
            if ((x < Xsize + 1) && (y < Ysize + 1)) ans += place.space[x + 1, y + 1];
            if (y > 0) ans += place.space[x, y - 1];
            if (x > 0) ans += place.space[x - 1, y];
            if ((x > 0) & (y > 0)) ans += place.space[x - 1, y - 1];
            if (y < Ysize + 1) ans += place.space[x, y + 1];
            if (x < Xsize + 1) ans += place.space[x + 1, y];
            if ((x < Xsize + 1) && (y > 0)) ans += place.space[x + 1, y - 1];
            if ((y < Ysize + 1) && (x > 0)) ans += place.space[x - 1, y + 1];
            return ans;
        }
        
    }
}
