namespace BasicFacebookFeatures.Forms
{
    partial class FormAlbum
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imageAlbumLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label privcaySettingsLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.Windows.Forms.Label createdTimeLabel1;
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.privcaySettingsTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxAlbumPhotos = new System.Windows.Forms.ListBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelAlbumPictures = new System.Windows.Forms.Label();
            this.createdTimeDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            imageAlbumLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            privcaySettingsLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            createdTimeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.Location = new System.Drawing.Point(31, 52);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(106, 16);
            createdTimeLabel.TabIndex = 1;
            createdTimeLabel.Text = "creation Time:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(31, 23);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(73, 16);
            idLabel.TabIndex = 3;
            idLabel.Text = "Album ID:";
            // 
            // imageAlbumLabel
            // 
            imageAlbumLabel.AutoSize = true;
            imageAlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageAlbumLabel.Location = new System.Drawing.Point(513, 23);
            imageAlbumLabel.Name = "imageAlbumLabel";
            imageAlbumLabel.Size = new System.Drawing.Size(95, 16);
            imageAlbumLabel.TabIndex = 5;
            imageAlbumLabel.Text = "Cover photo:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.Location = new System.Drawing.Point(31, 79);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(70, 16);
            locationLabel.TabIndex = 7;
            locationLabel.Text = "Location:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(31, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 16);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name:";
            // 
            // privcaySettingsLabel
            // 
            privcaySettingsLabel.AutoSize = true;
            privcaySettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            privcaySettingsLabel.Location = new System.Drawing.Point(31, 135);
            privcaySettingsLabel.Name = "privcaySettingsLabel";
            privcaySettingsLabel.Size = new System.Drawing.Size(123, 16);
            privcaySettingsLabel.TabIndex = 11;
            privcaySettingsLabel.Text = "Privcay Settings:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.Location = new System.Drawing.Point(31, 163);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(47, 16);
            typeLabel.TabIndex = 13;
            typeLabel.Text = "Type:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updateTimeLabel.Location = new System.Drawing.Point(31, 192);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(101, 16);
            updateTimeLabel.TabIndex = 15;
            updateTimeLabel.Text = "Update Time:";
            // 
            // createdTimeLabel1
            // 
            createdTimeLabel1.AutoSize = true;
            createdTimeLabel1.Location = new System.Drawing.Point(495, 277);
            createdTimeLabel1.Name = "createdTimeLabel1";
            createdTimeLabel1.Size = new System.Drawing.Size(92, 16);
            createdTimeLabel1.TabIndex = 18;
            createdTimeLabel1.Text = "Created Time:";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Enabled = false;
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(215, 48);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(270, 22);
            this.createdTimeDateTimePicker.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(215, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(270, 22);
            this.idTextBox.TabIndex = 4;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(516, 52);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(206, 114);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPictureBox.TabIndex = 6;
            this.imageAlbumPictureBox.TabStop = false;
            this.imageAlbumPictureBox.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(215, 76);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(270, 22);
            this.locationTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(215, 104);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(270, 22);
            this.nameTextBox.TabIndex = 10;
            // 
            // privcaySettingsTextBox
            // 
            this.privcaySettingsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "PrivcaySettings", true));
            this.privcaySettingsTextBox.Location = new System.Drawing.Point(215, 132);
            this.privcaySettingsTextBox.Name = "privcaySettingsTextBox";
            this.privcaySettingsTextBox.ReadOnly = true;
            this.privcaySettingsTextBox.Size = new System.Drawing.Size(270, 22);
            this.privcaySettingsTextBox.TabIndex = 12;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(215, 160);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(270, 22);
            this.typeTextBox.TabIndex = 14;
            // 
            // updateTimeDateTimePicker
            // 
            this.updateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "UpdateTime", true));
            this.updateTimeDateTimePicker.Enabled = false;
            this.updateTimeDateTimePicker.Location = new System.Drawing.Point(215, 188);
            this.updateTimeDateTimePicker.Name = "updateTimeDateTimePicker";
            this.updateTimeDateTimePicker.Size = new System.Drawing.Size(270, 22);
            this.updateTimeDateTimePicker.TabIndex = 16;
            // 
            // listBoxAlbumPhotos
            // 
            this.listBoxAlbumPhotos.DataSource = this.photoBindingSource;
            this.listBoxAlbumPhotos.DisplayMember = "Id";
            this.listBoxAlbumPhotos.FormattingEnabled = true;
            this.listBoxAlbumPhotos.ItemHeight = 16;
            this.listBoxAlbumPhotos.Location = new System.Drawing.Point(34, 277);
            this.listBoxAlbumPhotos.Name = "listBoxAlbumPhotos";
            this.listBoxAlbumPhotos.Size = new System.Drawing.Size(455, 164);
            this.listBoxAlbumPhotos.TabIndex = 17;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // labelAlbumPictures
            // 
            this.labelAlbumPictures.AutoSize = true;
            this.labelAlbumPictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumPictures.Location = new System.Drawing.Point(30, 254);
            this.labelAlbumPictures.Name = "labelAlbumPictures";
            this.labelAlbumPictures.Size = new System.Drawing.Size(137, 20);
            this.labelAlbumPictures.TabIndex = 18;
            this.labelAlbumPictures.Text = "Album Pictures";
            // 
            // createdTimeDateTimePicker1
            // 
            this.createdTimeDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.photoBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker1.Enabled = false;
            this.createdTimeDateTimePicker1.Location = new System.Drawing.Point(593, 272);
            this.createdTimeDateTimePicker1.Name = "createdTimeDateTimePicker1";
            this.createdTimeDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker1.TabIndex = 19;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(498, 300);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(295, 141);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 21;
            this.imageNormalPictureBox.TabStop = false;
            this.imageNormalPictureBox.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 461);
            this.Controls.Add(createdTimeLabel1);
            this.Controls.Add(this.createdTimeDateTimePicker1);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(this.labelAlbumPictures);
            this.Controls.Add(this.listBoxAlbumPhotos);
            this.Controls.Add(createdTimeLabel);
            this.Controls.Add(this.createdTimeDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(imageAlbumLabel);
            this.Controls.Add(this.imageAlbumPictureBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(privcaySettingsLabel);
            this.Controls.Add(this.privcaySettingsTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(updateTimeLabel);
            this.Controls.Add(this.updateTimeDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Album Details";
            this.Load += new System.EventHandler(this.FormAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox privcaySettingsTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.DateTimePicker updateTimeDateTimePicker;
        private System.Windows.Forms.ListBox listBoxAlbumPhotos;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.Label labelAlbumPictures;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
    }
}