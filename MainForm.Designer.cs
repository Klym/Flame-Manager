namespace Flame_Manager {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Options = new System.Windows.Forms.GroupBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.playersBox = new System.Windows.Forms.GroupBox();
            this.PlayerView = new System.Windows.Forms.ListView();
            this.NickHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScoresHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RankHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerEditMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.playersCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Options.SuspendLayout();
            this.playersBox.SuspendLayout();
            this.playerEditMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Options.AutoSize = true;
            this.Options.Controls.Add(this.viewButton);
            this.Options.Controls.Add(this.saveButton);
            this.Options.Controls.Add(this.addButton);
            this.Options.Location = new System.Drawing.Point(12, 407);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(476, 111);
            this.Options.TabIndex = 1;
            this.Options.TabStop = false;
            this.Options.Text = "Опции";
            // 
            // viewButton
            // 
            this.viewButton.AutoSize = true;
            this.viewButton.Location = new System.Drawing.Point(330, 37);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(140, 55);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "Просмотреть";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(168, 36);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 55);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить в файл";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(6, 37);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 55);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить игрока";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // playersBox
            // 
            this.playersBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersBox.Controls.Add(this.PlayerView);
            this.playersBox.Location = new System.Drawing.Point(12, 106);
            this.playersBox.Name = "playersBox";
            this.playersBox.Size = new System.Drawing.Size(470, 295);
            this.playersBox.TabIndex = 2;
            this.playersBox.TabStop = false;
            this.playersBox.Text = "Состав";
            // 
            // PlayerView
            // 
            this.PlayerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NickHeader,
            this.ScoresHeader,
            this.RankHeader,
            this.NameHeader});
            this.PlayerView.ContextMenuStrip = this.playerEditMenu;
            this.PlayerView.FullRowSelect = true;
            this.PlayerView.GridLines = true;
            this.PlayerView.Location = new System.Drawing.Point(0, 19);
            this.PlayerView.MultiSelect = false;
            this.PlayerView.Name = "PlayerView";
            this.PlayerView.Size = new System.Drawing.Size(470, 276);
            this.PlayerView.TabIndex = 1;
            this.PlayerView.UseCompatibleStateImageBehavior = false;
            this.PlayerView.View = System.Windows.Forms.View.Details;
            // 
            // NickHeader
            // 
            this.NickHeader.Text = "Позывной";
            this.NickHeader.Width = 110;
            // 
            // ScoresHeader
            // 
            this.ScoresHeader.Text = "Очки";
            this.ScoresHeader.Width = 80;
            // 
            // RankHeader
            // 
            this.RankHeader.Text = "Звание";
            this.RankHeader.Width = 108;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Имя";
            this.NameHeader.Width = 167;
            // 
            // playerEditMenu
            // 
            this.playerEditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.playerEditMenu.Name = "playerEditMenu";
            this.playerEditMenu.Size = new System.Drawing.Size(155, 48);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.playersCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "Игроков:";
            // 
            // playersCountLabel
            // 
            this.playersCountLabel.Name = "playersCountLabel";
            this.playersCountLabel.Size = new System.Drawing.Size(13, 17);
            this.playersCountLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.playersBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Flame Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.playersBox.ResumeLayout(false);
            this.playerEditMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip playerEditMenu;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox playersBox;
        private System.Windows.Forms.ListView PlayerView;
        private System.Windows.Forms.ColumnHeader NickHeader;
        private System.Windows.Forms.ColumnHeader ScoresHeader;
        private System.Windows.Forms.ColumnHeader RankHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel playersCountLabel;
    }
}

