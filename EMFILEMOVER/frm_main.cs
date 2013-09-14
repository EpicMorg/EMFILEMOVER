using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace EMFILEMOVER
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            var files = Properties.Resources.ResourceManager.GetString("src").Split(new char[] { '\n' });
            txt_mask.Items.AddRange(files);
            txt_mask.SelectedIndex = 0;
            pic_icon.Image = Properties.Resources.thedir;
        }

      

        void MoveFiles(string input_dir, string input_pattern, string output_path)
        {
            input_pattern = String.IsNullOrEmpty(input_pattern) ? "*" : input_pattern;
            foreach (var app in Directory.EnumerateFiles(input_dir, input_pattern, SearchOption.AllDirectories))
            {
                try
                {
                    File.Move(app, Path.Combine(output_path, Path.GetFileName(app)));
                }
                catch { }
            }

        }

        private void btn_path1_Click(object sender, EventArgs e)
        {
            if (dialog_browse1.ShowDialog() == DialogResult.OK)
            {
                txt_path1.Text = dialog_browse1.SelectedPath;
            }
        }

        private void btn_path2_Click(object sender, EventArgs e)
        {
            if (dialog_browse2.ShowDialog() == DialogResult.OK)
            {
                txt_path2.Text = dialog_browse2.SelectedPath;
            }
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txt_path1.Text) || !Directory.Exists(txt_path2.Text))
            {
                MessageBox.Show("Папка не существует!", "Внимание!", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {

                if (MessageBox.Show("Данная программа перемещает все файлы,выбранные по маске,\nиз одной указанной дирректории в другую.\n\nНе следует выбирать в качестве исходной папки системную!", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    pic_icon.Image = Properties.Resources.bus269;

                    MoveFiles(txt_path1.Text, txt_mask.Text, txt_path2.Text);
                    MessageBox.Show("Перемещение выполенено успешно!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pic_icon.Image = Properties.Resources.thedir;
                }
                else
                {
                   // MessageBox.Show("001");
                }
            }

           
            
        }

        private void lnk_info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://ww.epicm.org/");  
            }
            catch
            {
            }
        }

         
    }
}
