namespace Flame_Manager {
    partial class PlayerEditForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerEditForm));
            this.updateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.skype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.rank = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.post1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kills = new System.Windows.Forms.TextBox();
            this.deathes = new System.Windows.Forms.TextBox();
            this.addScoresButton = new System.Windows.Forms.Button();
            this.subScoresButton = new System.Windows.Forms.Button();
            this.scoresToAdd = new System.Windows.Forms.TextBox();
            this.stripe = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.viewPlayerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.stripe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(19, 19);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(101, 38);
            this.updateButton.TabIndex = 27;
            this.updateButton.Text = "Сохранить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Skype:";
            // 
            // skype
            // 
            this.skype.Location = new System.Drawing.Point(94, 259);
            this.skype.Name = "skype";
            this.skype.Size = new System.Drawing.Size(156, 20);
            this.skype.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Имя:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(94, 220);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 20);
            this.name.TabIndex = 23;
            // 
            // rank
            // 
            this.rank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank.FormattingEnabled = true;
            this.rank.Location = new System.Drawing.Point(95, 52);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(156, 21);
            this.rank.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Звание:";
            // 
            // scores
            // 
            this.scores.Location = new System.Drawing.Point(95, 92);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(80, 20);
            this.scores.TabIndex = 20;
            this.scores.Text = "0";
            this.scores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kills_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Очки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Должность:";
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
            this.post1.Location = new System.Drawing.Point(95, 131);
            this.post1.Name = "post1";
            this.post1.Size = new System.Drawing.Size(155, 21);
            this.post1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Позывной:";
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(95, 12);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(156, 20);
            this.nickName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Убийства:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Смерти:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(311, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Очки:";
            // 
            // kills
            // 
            this.kills.Location = new System.Drawing.Point(376, 8);
            this.kills.Name = "kills";
            this.kills.Size = new System.Drawing.Size(79, 20);
            this.kills.TabIndex = 32;
            this.kills.Text = "0";
            this.kills.TextChanged += new System.EventHandler(this.kills_TextChanged);
            this.kills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kills_KeyPress);
            // 
            // deathes
            // 
            this.deathes.Location = new System.Drawing.Point(376, 36);
            this.deathes.Name = "deathes";
            this.deathes.Size = new System.Drawing.Size(79, 20);
            this.deathes.TabIndex = 33;
            this.deathes.Text = "0";
            this.deathes.TextChanged += new System.EventHandler(this.kills_TextChanged);
            this.deathes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kills_KeyPress);
            // 
            // addScoresButton
            // 
            this.addScoresButton.Location = new System.Drawing.Point(184, 90);
            this.addScoresButton.Name = "addScoresButton";
            this.addScoresButton.Size = new System.Drawing.Size(30, 23);
            this.addScoresButton.TabIndex = 35;
            this.addScoresButton.Text = "+";
            this.addScoresButton.UseVisualStyleBackColor = true;
            this.addScoresButton.Click += new System.EventHandler(this.addScoresButton_Click);
            // 
            // subScoresButton
            // 
            this.subScoresButton.Location = new System.Drawing.Point(220, 90);
            this.subScoresButton.Name = "subScoresButton";
            this.subScoresButton.Size = new System.Drawing.Size(30, 23);
            this.subScoresButton.TabIndex = 36;
            this.subScoresButton.Text = "-";
            this.subScoresButton.UseVisualStyleBackColor = true;
            this.subScoresButton.Click += new System.EventHandler(this.subScoresButton_Click);
            // 
            // scoresToAdd
            // 
            this.scoresToAdd.Location = new System.Drawing.Point(376, 68);
            this.scoresToAdd.Name = "scoresToAdd";
            this.scoresToAdd.Size = new System.Drawing.Size(79, 20);
            this.scoresToAdd.TabIndex = 37;
            this.scoresToAdd.Text = "0";
            this.scoresToAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kills_KeyPress);
            // 
            // stripe
            // 
            this.stripe.Location = new System.Drawing.Point(24, 19);
            this.stripe.Name = "stripe";
            this.stripe.Size = new System.Drawing.Size(74, 131);
            this.stripe.TabIndex = 38;
            this.stripe.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stripe);
            this.groupBox1.Location = new System.Drawing.Point(314, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 159);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нашивка";
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
            this.comboBox1.Location = new System.Drawing.Point(95, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 40;
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
            this.comboBox2.Location = new System.Drawing.Point(95, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 41;
            // 
            // viewPlayerButton
            // 
            this.viewPlayerButton.Location = new System.Drawing.Point(172, 19);
            this.viewPlayerButton.Name = "viewPlayerButton";
            this.viewPlayerButton.Size = new System.Drawing.Size(101, 38);
            this.viewPlayerButton.TabIndex = 42;
            this.viewPlayerButton.Text = "Просмотр";
            this.viewPlayerButton.UseVisualStyleBackColor = true;
            this.viewPlayerButton.Click += new System.EventHandler(this.viewPlayerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(326, 19);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(101, 38);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resetButton);
            this.groupBox2.Controls.Add(this.viewPlayerButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 70);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Опции";
            // 
            // PlayerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scoresToAdd);
            this.Controls.Add(this.subScoresButton);
            this.Controls.Add(this.addScoresButton);
            this.Controls.Add(this.deathes);
            this.Controls.Add(this.kills);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Name = "PlayerEditForm";
            this.Text = "Редактирование игрока: ";
            ((System.ComponentModel.ISupportInitialize)(this.stripe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox skype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox rank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox post1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nickName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kills;
        private System.Windows.Forms.TextBox deathes;
        private System.Windows.Forms.Button addScoresButton;
        private System.Windows.Forms.Button subScoresButton;
        private System.Windows.Forms.TextBox scoresToAdd;
        private System.Windows.Forms.PictureBox stripe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button viewPlayerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}