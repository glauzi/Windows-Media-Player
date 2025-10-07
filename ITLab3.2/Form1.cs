using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

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
            dialog.Filter = "Windows Media Video (*.wmv)|*.wmv|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filename = dialog.FileName;
                files.Items.Add(filename);

                try
                {
                    var file = TagLib.File.Create(filename);
                    int width = file.Properties.VideoWidth;
                    int height = file.Properties.VideoHeight;

                    // Показываем информацию (временно)
                    MessageBox.Show($"Размер видео: {width}x{height}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения метаданных: {ex.Message}");
                }
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
            statusLabel.Text = $"Воспроизведение: {playlist.count} файлов";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            player.close();
            statusLabel.Text = "Воспроизведение остановлено";
        }

        private void files_DoubleClick(object sender, EventArgs e)
        {
            if (files.SelectedItem != null)
            {
                string filename = files.SelectedItem.ToString();
                player.URL = filename;
                player.Ctlcontrols.play();
            }
        }
    }
}
