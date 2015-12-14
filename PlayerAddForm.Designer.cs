namespace Flame_Manager {
    partial class PlayerAddForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerAddForm));
            this.nickName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.post1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.skype = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(93, 19);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(156, 20);
            this.nickName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Позывной:";
            // 
            // post1
            // 
            this.post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.post1.FormattingEnabled = true;
            this.post1.Items.AddRange(new object[] {
            "Зам. Командира",
            "Командир",
            "Стрелок",
            "Штурмовик",
            "Медик"});
            this.post1.Location = new System.Drawing.Point(93, 134);
            this.post1.Name = "post1";
            this.post1.Size = new System.Drawing.Size(156, 21);
            this.post1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Очки:";
            // 
            // scores
            // 
            this.scores.Location = new System.Drawing.Point(93, 99);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(80, 20);
            this.scores.TabIndex = 5;
            this.scores.Text = "0";
            this.scores.TextChanged += new System.EventHandler(this.scores_TextChanged);
            this.scores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scores_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Звание:";
            // 
            // rank
            // 
            this.rank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank.FormattingEnabled = true;
            this.rank.Location = new System.Drawing.Point(93, 59);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(156, 21);
            this.rank.TabIndex = 8;
            this.rank.SelectionChangeCommitted += new System.EventHandler(this.rank_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Имя:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(93, 225);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 20);
            this.name.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Skype:";
            // 
            // skype
            // 
            this.skype.Location = new System.Drawing.Point(93, 264);
            this.skype.Name = "skype";
            this.skype.Size = new System.Drawing.Size(156, 20);
            this.skype.TabIndex = 11;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(15, 311);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(101, 38);
            this.insertButton.TabIndex = 13;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(148, 311);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(101, 38);
            this.skipButton.TabIndex = 14;
            this.skipButton.Text = "Отмена";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Зам. Командира",
            "Командир",
            "Стрелок",
            "Штурмовик",
            "Медик"});
            this.comboBox1.Location = new System.Drawing.Point(93, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Зам. Командира",
            "Командир",
            "Стрелок",
            "Штурмовик",
            "Медик"});
            this.comboBox2.Location = new System.Drawing.Point(93, 188);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // PlayerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 362);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.skype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.post1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nickName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayerAddForm";
            this.Text = "Новый игрок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nickName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox post1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox skype;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}