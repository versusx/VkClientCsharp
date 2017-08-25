namespace VkClientCsharp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Default = new System.Windows.Forms.TabControl();
            this.authentication = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Friends = new System.Windows.Forms.TabControl();
            this.allFrineds = new System.Windows.Forms.TabPage();
            this.allFrinedsList = new System.Windows.Forms.ListBox();
            this.onlineFriends = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.feedTab = new System.Windows.Forms.TabPage();
            this.friendsCnt = new System.Windows.Forms.Label();
            this.Default.SuspendLayout();
            this.authentication.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Friends.SuspendLayout();
            this.allFrineds.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(104, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(104, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(303, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(291, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Default
            // 
            this.Default.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Default.Controls.Add(this.authentication);
            this.Default.Controls.Add(this.tabPage2);
            this.Default.Controls.Add(this.tabPage1);
            this.Default.Controls.Add(this.tabPage3);
            this.Default.Controls.Add(this.feedTab);
            this.Default.Location = new System.Drawing.Point(12, 12);
            this.Default.Name = "Default";
            this.Default.SelectedIndex = 0;
            this.Default.Size = new System.Drawing.Size(434, 292);
            this.Default.TabIndex = 4;
            // 
            // authentication
            // 
            this.authentication.BackColor = System.Drawing.Color.LightSteelBlue;
            this.authentication.Controls.Add(this.textBox2);
            this.authentication.Controls.Add(this.label2);
            this.authentication.Controls.Add(this.textBox1);
            this.authentication.Controls.Add(this.label1);
            this.authentication.Controls.Add(this.button1);
            this.authentication.Location = new System.Drawing.Point(4, 22);
            this.authentication.Name = "authentication";
            this.authentication.Padding = new System.Windows.Forms.Padding(3);
            this.authentication.Size = new System.Drawing.Size(426, 266);
            this.authentication.TabIndex = 0;
            this.authentication.Text = "Authentication";
            this.authentication.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Friends);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Friends";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Friends
            // 
            this.Friends.Controls.Add(this.allFrineds);
            this.Friends.Controls.Add(this.onlineFriends);
            this.Friends.Location = new System.Drawing.Point(3, 3);
            this.Friends.Name = "Friends";
            this.Friends.SelectedIndex = 0;
            this.Friends.Size = new System.Drawing.Size(413, 259);
            this.Friends.TabIndex = 0;
            this.Friends.Visible = false;
            // 
            // allFrineds
            // 
            this.allFrineds.Controls.Add(this.friendsCnt);
            this.allFrineds.Controls.Add(this.allFrinedsList);
            this.allFrineds.Location = new System.Drawing.Point(4, 22);
            this.allFrineds.Name = "allFrineds";
            this.allFrineds.Padding = new System.Windows.Forms.Padding(3);
            this.allFrineds.Size = new System.Drawing.Size(405, 233);
            this.allFrineds.TabIndex = 0;
            this.allFrineds.Text = "All";
            this.allFrineds.UseVisualStyleBackColor = true;
            // 
            // allFrinedsList
            // 
            this.allFrinedsList.FormattingEnabled = true;
            this.allFrinedsList.Location = new System.Drawing.Point(6, 3);
            this.allFrinedsList.Name = "allFrinedsList";
            this.allFrinedsList.Size = new System.Drawing.Size(393, 225);
            this.allFrinedsList.TabIndex = 0;
            this.allFrinedsList.SelectedIndexChanged += new System.EventHandler(this.allFrinedsList_SelectedIndexChanged);
            // 
            // onlineFriends
            // 
            this.onlineFriends.Location = new System.Drawing.Point(4, 22);
            this.onlineFriends.Name = "onlineFriends";
            this.onlineFriends.Padding = new System.Windows.Forms.Padding(3);
            this.onlineFriends.Size = new System.Drawing.Size(405, 233);
            this.onlineFriends.TabIndex = 1;
            this.onlineFriends.Text = "Online";
            this.onlineFriends.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 266);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(143, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "nameLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(426, 266);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Messagess";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // feedTab
            // 
            this.feedTab.Location = new System.Drawing.Point(4, 22);
            this.feedTab.Name = "feedTab";
            this.feedTab.Padding = new System.Windows.Forms.Padding(3);
            this.feedTab.Size = new System.Drawing.Size(426, 266);
            this.feedTab.TabIndex = 4;
            this.feedTab.Text = "Feed";
            this.feedTab.UseVisualStyleBackColor = true;
            // 
            // friendsCnt
            // 
            this.friendsCnt.AutoSize = true;
            this.friendsCnt.Location = new System.Drawing.Point(16, 12);
            this.friendsCnt.Name = "friendsCnt";
            this.friendsCnt.Size = new System.Drawing.Size(66, 13);
            this.friendsCnt.TabIndex = 1;
            this.friendsCnt.Text = "friendsCount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 309);
            this.Controls.Add(this.Default);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vk";
            this.Default.ResumeLayout(false);
            this.authentication.ResumeLayout(false);
            this.authentication.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.Friends.ResumeLayout(false);
            this.allFrineds.ResumeLayout(false);
            this.allFrineds.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl Default;
        private System.Windows.Forms.TabPage authentication;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl Friends;
        private System.Windows.Forms.TabPage allFrineds;
        private System.Windows.Forms.TabPage onlineFriends;
        private System.Windows.Forms.ListBox allFrinedsList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabPage feedTab;
        private System.Windows.Forms.Label friendsCnt;
    }
}

