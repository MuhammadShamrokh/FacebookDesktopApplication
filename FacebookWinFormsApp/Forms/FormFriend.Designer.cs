namespace BasicFacebookFeatures.Forms
{
    partial class FormFriend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label favoriteTeamLabel;
            System.Windows.Forms.Label nameLabel;
            this.dummyFriendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.favoriteTeamTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFriendProfilePic = new System.Windows.Forms.PictureBox();
            birthdayLabel = new System.Windows.Forms.Label();
            favoriteTeamLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dummyFriendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // dummyFriendBindingSource
            // 
            this.dummyFriendBindingSource.DataSource = typeof(LogicEngine.DummyFriend);
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(37, 75);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(68, 16);
            birthdayLabel.TabIndex = 1;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dummyFriendBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(177, 75);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.Size = new System.Drawing.Size(210, 22);
            this.birthdayTextBox.TabIndex = 2;
            // 
            // favoriteTeamLabel
            // 
            favoriteTeamLabel.AutoSize = true;
            favoriteTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            favoriteTeamLabel.Location = new System.Drawing.Point(37, 124);
            favoriteTeamLabel.Name = "favoriteTeamLabel";
            favoriteTeamLabel.Size = new System.Drawing.Size(112, 16);
            favoriteTeamLabel.TabIndex = 3;
            favoriteTeamLabel.Text = "Favorite Team:";
            // 
            // favoriteTeamTextBox
            // 
            this.favoriteTeamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dummyFriendBindingSource, "FavoriteTeam", true));
            this.favoriteTeamTextBox.Location = new System.Drawing.Point(177, 124);
            this.favoriteTeamTextBox.Name = "favoriteTeamTextBox";
            this.favoriteTeamTextBox.ReadOnly = true;
            this.favoriteTeamTextBox.Size = new System.Drawing.Size(210, 22);
            this.favoriteTeamTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(37, 28);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 16);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dummyFriendBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(177, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(210, 22);
            this.nameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Profile picture:";
            // 
            // pictureBoxFriendProfilePic
            // 
            this.pictureBoxFriendProfilePic.Location = new System.Drawing.Point(177, 178);
            this.pictureBoxFriendProfilePic.Name = "pictureBoxFriendProfilePic";
            this.pictureBoxFriendProfilePic.Size = new System.Drawing.Size(210, 138);
            this.pictureBoxFriendProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendProfilePic.TabIndex = 10;
            this.pictureBoxFriendProfilePic.TabStop = false;
            this.pictureBoxFriendProfilePic.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // FormFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pictureBoxFriendProfilePic);
            this.Controls.Add(this.label1);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(favoriteTeamLabel);
            this.Controls.Add(this.favoriteTeamTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Friend details";
            this.Load += new System.EventHandler(this.FormFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dummyFriendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dummyFriendBindingSource;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox favoriteTeamTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfilePic;
    }
}