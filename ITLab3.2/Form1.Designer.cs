namespace ITLab3._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open = new System.Windows.Forms.Button();
            this.files = new System.Windows.Forms.ListBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.playAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(35, 44);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // files
            // 
            this.files.FormattingEnabled = true;
            this.files.Location = new System.Drawing.Point(35, 73);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(217, 277);
            this.files.TabIndex = 1;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(258, 12);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(530, 338);
            this.player.TabIndex = 2;
            // 
            // playAll
            // 
            this.playAll.Location = new System.Drawing.Point(140, 44);
            this.playAll.Name = "playAll";
            this.playAll.Size = new System.Drawing.Size(112, 23);
            this.playAll.TabIndex = 3;
            this.playAll.Text = "Воспроизведение";
            this.playAll.UseVisualStyleBackColor = true;
            this.playAll.Click += new System.EventHandler(this.playAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.playAll);
            this.Controls.Add(this.player);
            this.Controls.Add(this.files);
            this.Controls.Add(this.open);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.ListBox files;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button playAll;
    }
}

