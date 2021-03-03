using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class MainForm : Form
    {
        String file;
        public MainForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Files (*.html)|*.html";
        }

        private void информацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                 "Рушев Алексей Михайлович, Вариант 6",
                  "Информация о студенте",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string temp = openFileDialog1.FileName;
            webOtobragenie.Navigate(new Uri(temp));

            String[] arr = temp.Split('\\');
            file = arr.Last();

            this.ClientSize = new System.Drawing.Size(1062, 567);
        }
        private void clearBox() {
            tbxInputX.Clear();
            tbxInputY.Clear();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbxInputY.Text != "" && isProverka(tbxInputY.Text) && tbxInputX.Text != "" && isProverka(tbxInputX.Text))
            {
                if (file == "FirstSheet.html") vivodResultataFirstSheet(Convert.ToDouble(tbxInputX.Text), Convert.ToDouble(tbxInputY.Text));
                if (file == "TwoSheet.html") vivodResultataTwoSheet(Convert.ToDouble(tbxInputX.Text), Convert.ToDouble(tbxInputY.Text));
            }
            clearBox();
        }
        private bool isProverka(String str)
        {
            char[] chArr = str.ToCharArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                if (!(chArr[i] >= '0' && chArr[i] <= '9') && chArr[i] != '-')
                {
                    return false;
                }
            }
            return true;
        }
        private void vivodResultataFirstSheet(double x, double y)
        {
            if (y <= 4 * x && y <= -4 * x && y >= x * x - 5)
            {

                lblStatusOne.Visible = true;
                lblStatusOne.Text = "Принадлежит";
                MessageBox.Show(
                 "Принадлежит",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                lblStatusOne.Visible = true;
                lblStatusOne.Text = "Не принадлежит";
                MessageBox.Show(
                 "Не принадлежит",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void vivodResultataTwoSheet(double x, double y)
        {
            if (y >= x && y >= -x && y <= 2)
            {

                lblStatusOne.Visible = true;
                lblStatusOne.Text = "Принадлежит";
                MessageBox.Show(
                 "Принадлежит",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                lblStatusOne.Visible = true;
                lblStatusOne.Text = "Не принадлежит";
                MessageBox.Show(
                 "Не принадлежит",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
