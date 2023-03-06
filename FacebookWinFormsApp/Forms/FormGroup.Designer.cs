namespace BasicFacebookFeatures.Forms
{
    partial class FormGroup
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imageLargeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label privacyLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label birthdayLabel;
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.privacyTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.idLabel2 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            imageLargeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            privacyLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(39, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(72, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Group ID:";
            // 
            // imageLargeLabel
            // 
            imageLargeLabel.AutoSize = true;
            imageLargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageLargeLabel.Location = new System.Drawing.Point(40, 167);
            imageLargeLabel.Name = "imageLargeLabel";
            imageLargeLabel.Size = new System.Drawing.Size(100, 16);
            imageLargeLabel.TabIndex = 3;
            imageLargeLabel.Text = "Group Image:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(39, 64);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(95, 16);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Group name:";
            // 
            // privacyLabel
            // 
            privacyLabel.AutoSize = true;
            privacyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            privacyLabel.Location = new System.Drawing.Point(39, 92);
            privacyLabel.Name = "privacyLabel";
            privacyLabel.Size = new System.Drawing.Size(108, 16);
            privacyLabel.TabIndex = 7;
            privacyLabel.Text = "Group privacy:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updateTimeLabel.Location = new System.Drawing.Point(39, 121);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(101, 16);
            updateTimeLabel.TabIndex = 9;
            updateTimeLabel.Text = "Update Time:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel1.Location = new System.Drawing.Point(291, 200);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(73, 16);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Owner ID:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel1.Location = new System.Drawing.Point(291, 231);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(96, 16);
            nameLabel1.TabIndex = 2;
            nameLabel1.Text = "Owner name:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(291, 261);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(68, 16);
            birthdayLabel.TabIndex = 4;
            birthdayLabel.Text = "Birthday:";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(170, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(309, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(43, 198);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(204, 122);
            this.imageLargePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLargePictureBox.TabIndex = 4;
            this.imageLargePictureBox.TabStop = false;
            this.imageLargePictureBox.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(170, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(309, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // privacyTextBox
            // 
            this.privacyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Privacy", true));
            this.privacyTextBox.Location = new System.Drawing.Point(170, 89);
            this.privacyTextBox.Name = "privacyTextBox";
            this.privacyTextBox.ReadOnly = true;
            this.privacyTextBox.Size = new System.Drawing.Size(309, 22);
            this.privacyTextBox.TabIndex = 8;
            // 
            // updateTimeDateTimePicker
            // 
            this.updateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.groupBindingSource, "UpdateTime", true));
            this.updateTimeDateTimePicker.Enabled = false;
            this.updateTimeDateTimePicker.Location = new System.Drawing.Point(170, 117);
            this.updateTimeDateTimePicker.Name = "updateTimeDateTimePicker";
            this.updateTimeDateTimePicker.Size = new System.Drawing.Size(309, 22);
            this.updateTimeDateTimePicker.TabIndex = 10;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Owner.Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(403, 261);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(190, 23);
            this.birthdayLabel1.TabIndex = 5;
            this.birthdayLabel1.Text = "label2";
            // 
            // nameLabel2
            // 
            this.nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Owner.Name", true));
            this.nameLabel2.Location = new System.Drawing.Point(403, 231);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(190, 23);
            this.nameLabel2.TabIndex = 3;
            this.nameLabel2.Text = "label2";
            // 
            // idLabel2
            // 
            this.idLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Owner.Id", true));
            this.idLabel2.Location = new System.Drawing.Point(403, 200);
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.Size = new System.Drawing.Size(190, 23);
            this.idLabel2.TabIndex = 1;
            this.idLabel2.Text = "label2";
            // 
            // FormGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.birthdayLabel1);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(idLabel);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idLabel2);
            this.Controls.Add(imageLargeLabel);
            this.Controls.Add(this.imageLargePictureBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(privacyLabel);
            this.Controls.Add(this.privacyTextBox);
            this.Controls.Add(updateTimeLabel);
            this.Controls.Add(this.updateTimeDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Group details";
            this.Load += new System.EventHandler(this.FormGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox privacyTextBox;
        private System.Windows.Forms.DateTimePicker updateTimeDateTimePicker;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label idLabel2;
    }
}