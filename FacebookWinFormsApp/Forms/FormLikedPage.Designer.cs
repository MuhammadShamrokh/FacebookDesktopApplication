namespace BasicFacebookFeatures.Forms
{
    partial class FormLikedPage
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
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imageLargeLabel;
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label isPublishedLabel;
            System.Windows.Forms.Label isCommunityPageLabel;
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.isCommunityPageCheckBox = new System.Windows.Forms.CheckBox();
            this.isPublishedCheckBox = new System.Windows.Forms.CheckBox();
            categoryLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            imageLargeLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            isPublishedLabel = new System.Windows.Forms.Label();
            isCommunityPageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(27, 141);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(74, 16);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(137, 138);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(223, 22);
            this.categoryTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(27, 29);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(67, 16);
            idLabel.TabIndex = 3;
            idLabel.Text = "Page ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(137, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(223, 22);
            this.idTextBox.TabIndex = 4;
            // 
            // imageLargeLabel
            // 
            imageLargeLabel.AutoSize = true;
            imageLargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageLargeLabel.Location = new System.Drawing.Point(28, 191);
            imageLargeLabel.Name = "imageLargeLabel";
            imageLargeLabel.Size = new System.Drawing.Size(54, 16);
            imageLargeLabel.TabIndex = 5;
            imageLargeLabel.Text = "Image:";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(138, 191);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(223, 136);
            this.imageLargePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLargePictureBox.TabIndex = 6;
            this.imageLargePictureBox.TabStop = false;
            this.imageLargePictureBox.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            likesCountLabel.Location = new System.Drawing.Point(387, 29);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(91, 16);
            likesCountLabel.TabIndex = 11;
            likesCountLabel.Text = "Likes Count:";
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountTextBox.Location = new System.Drawing.Point(546, 23);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.ReadOnly = true;
            this.likesCountTextBox.Size = new System.Drawing.Size(168, 22);
            this.likesCountTextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(27, 63);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 16);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(137, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(223, 22);
            this.nameTextBox.TabIndex = 14;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(27, 102);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 16);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(137, 99);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(223, 22);
            this.phoneTextBox.TabIndex = 16;
            // 
            // isCommunityPageCheckBox
            // 
            this.isCommunityPageCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pageBindingSource, "IsCommunityPage", true));
            this.isCommunityPageCheckBox.Enabled = false;
            this.isCommunityPageCheckBox.Location = new System.Drawing.Point(546, 63);
            this.isCommunityPageCheckBox.Name = "isCommunityPageCheckBox";
            this.isCommunityPageCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isCommunityPageCheckBox.TabIndex = 8;
            this.isCommunityPageCheckBox.Text = "Yes";
            this.isCommunityPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // isPublishedCheckBox
            // 
            this.isPublishedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pageBindingSource, "IsPublished", true));
            this.isPublishedCheckBox.Enabled = false;
            this.isPublishedCheckBox.Location = new System.Drawing.Point(546, 101);
            this.isPublishedCheckBox.Name = "isPublishedCheckBox";
            this.isPublishedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isPublishedCheckBox.TabIndex = 10;
            this.isPublishedCheckBox.Text = "Yes";
            this.isPublishedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isPublishedLabel
            // 
            isPublishedLabel.AutoSize = true;
            isPublishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isPublishedLabel.Location = new System.Drawing.Point(387, 107);
            isPublishedLabel.Name = "isPublishedLabel";
            isPublishedLabel.Size = new System.Drawing.Size(96, 16);
            isPublishedLabel.TabIndex = 9;
            isPublishedLabel.Text = "Is Published:";
            // 
            // isCommunityPageLabel
            // 
            isCommunityPageLabel.AutoSize = true;
            isCommunityPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isCommunityPageLabel.Location = new System.Drawing.Point(387, 69);
            isCommunityPageLabel.Name = "isCommunityPageLabel";
            isCommunityPageLabel.Size = new System.Drawing.Size(143, 16);
            isCommunityPageLabel.TabIndex = 7;
            isCommunityPageLabel.Text = "Is Community Page:";
            // 
            // FormLikedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(imageLargeLabel);
            this.Controls.Add(this.imageLargePictureBox);
            this.Controls.Add(isCommunityPageLabel);
            this.Controls.Add(this.isCommunityPageCheckBox);
            this.Controls.Add(isPublishedLabel);
            this.Controls.Add(this.isPublishedCheckBox);
            this.Controls.Add(likesCountLabel);
            this.Controls.Add(this.likesCountTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLikedPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Page details";
            this.Load += new System.EventHandler(this.FormLikedPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox likesCountTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.CheckBox isCommunityPageCheckBox;
        private System.Windows.Forms.CheckBox isPublishedCheckBox;
    }
}