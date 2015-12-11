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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Клым",
            "480000",
            "Командующий",
            "Максим Клименко"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Хитрец",
            "500000",
            "Военачальник",
            "Олег Перятинский"}, -1);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerView = new System.Windows.Forms.ListView();
            this.NickHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScoresHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RankHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerEditMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Options = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.playerEditMenu.SuspendLayout();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PlayerView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Options, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 443);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.PlayerView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.PlayerView.Location = new System.Drawing.Point(3, 3);
            this.PlayerView.MultiSelect = false;
            this.PlayerView.Name = "PlayerView";
            this.PlayerView.Size = new System.Drawing.Size(464, 304);
            this.PlayerView.TabIndex = 0;
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
            this.RankHeader.Width = 112;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Имя";
            this.NameHeader.Width = 158;
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
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
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
            this.Options.Location = new System.Drawing.Point(3, 313);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(464, 127);
            this.Options.TabIndex = 1;
            this.Options.TabStop = false;
            this.Options.Text = "Опции";
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(6, 37);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 55);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить игрока";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(173, 36);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 55);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить в файл";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.AutoSize = true;
            this.viewButton.Location = new System.Drawing.Point(339, 37);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(119, 55);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "Просмотреть";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Flame Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.playerEditMenu.ResumeLayout(false);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView PlayerView;
        private System.Windows.Forms.ColumnHeader NickHeader;
        private System.Windows.Forms.ColumnHeader ScoresHeader;
        private System.Windows.Forms.ColumnHeader RankHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ContextMenuStrip playerEditMenu;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
    }
}

