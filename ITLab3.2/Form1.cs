using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLab3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Video files (*.wmv;*.avi;*.mp4)|*.wmv;*.avi;*.mp4|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filename = dialog.FileName;
                files.Items.Add(filename);
            }
        }

        private void playAll_Click(object sender, EventArgs e)
        {
            if (files.Items.Count == 0)
            {
                MessageBox.Show("Сначала добавьте файлы через кнопку 'Открыть'");
                return;
            }
            var playlist = player.newPlaylist("MyPlaylist", "");

            foreach (var selected in files.Items)
            {
                string filename = selected.ToString();
                var mediaItem = player.newMedia(filename);
                playlist.appendItem(mediaItem);
            }

            player.currentPlaylist = playlist;
            player.Ctlcontrols.play();
        }
    }
}
