namespace BasicFacebookFeatures.Forms
{
    partial class FormEvent
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
            System.Windows.Forms.Label attendingCountLabel;
            System.Windows.Forms.Label declinedCountLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imageLargeLabel;
            System.Windows.Forms.Label interestedCountLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label maybeCountLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label noReplyCountLabel;
            System.Windows.Forms.Label privacyLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label timezoneLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nameLabel1;
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendingCountTextBox = new System.Windows.Forms.TextBox();
            this.declinedCountTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.interestedCountTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.maybeCountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.noReplyCountTextBox = new System.Windows.Forms.TextBox();
            this.privacyTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timezoneTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            attendingCountLabel = new System.Windows.Forms.Label();
            declinedCountLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            imageLargeLabel = new System.Windows.Forms.Label();
            interestedCountLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            maybeCountLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            noReplyCountLabel = new System.Windows.Forms.Label();
            privacyLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            timezoneLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // attendingCountLabel
            // 
            attendingCountLabel.AutoSize = true;
            attendingCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            attendingCountLabel.Location = new System.Drawing.Point(468, 170);
            attendingCountLabel.Name = "attendingCountLabel";
            attendingCountLabel.Size = new System.Drawing.Size(119, 16);
            attendingCountLabel.TabIndex = 1;
            attendingCountLabel.Text = "Attending Count:";
            // 
            // attendingCountTextBox
            // 
            this.attendingCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "AttendingCount", true));
            this.attendingCountTextBox.Location = new System.Drawing.Point(640, 167);
            this.attendingCountTextBox.Name = "attendingCountTextBox";
            this.attendingCountTextBox.ReadOnly = true;
            this.attendingCountTextBox.Size = new System.Drawing.Size(224, 22);
            this.attendingCountTextBox.TabIndex = 2;
            // 
            // declinedCountLabel
            // 
            declinedCountLabel.AutoSize = true;
            declinedCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            declinedCountLabel.Location = new System.Drawing.Point(468, 198);
            declinedCountLabel.Name = "declinedCountLabel";
            declinedCountLabel.Size = new System.Drawing.Size(116, 16);
            declinedCountLabel.TabIndex = 3;
            declinedCountLabel.Text = "Declined Count:";
            // 
            // declinedCountTextBox
            // 
            this.declinedCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "DeclinedCount", true));
            this.declinedCountTextBox.Location = new System.Drawing.Point(640, 195);
            this.declinedCountTextBox.Name = "declinedCountTextBox";
            this.declinedCountTextBox.ReadOnly = true;
            this.declinedCountTextBox.Size = new System.Drawing.Size(224, 22);
            this.declinedCountTextBox.TabIndex = 4;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endTimeLabel.Location = new System.Drawing.Point(468, 49);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(77, 16);
            endTimeLabel.TabIndex = 7;
            endTimeLabel.Text = "End Time:";
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Enabled = false;
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(640, 45);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.endTimeDateTimePicker.TabIndex = 8;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(23, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(69, 16);
            idLabel.TabIndex = 9;
            idLabel.Text = "Event ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(195, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(224, 22);
            this.idTextBox.TabIndex = 10;
            // 
            // imageLargeLabel
            // 
            imageLargeLabel.AutoSize = true;
            imageLargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageLargeLabel.Location = new System.Drawing.Point(23, 131);
            imageLargeLabel.Name = "imageLargeLabel";
            imageLargeLabel.Size = new System.Drawing.Size(98, 16);
            imageLargeLabel.TabIndex = 11;
            imageLargeLabel.Text = "Image Large:";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(195, 131);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(163, 95);
            this.imageLargePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLargePictureBox.TabIndex = 12;
            this.imageLargePictureBox.TabStop = false;
            this.imageLargePictureBox.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // interestedCountLabel
            // 
            interestedCountLabel.AutoSize = true;
            interestedCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            interestedCountLabel.Location = new System.Drawing.Point(468, 226);
            interestedCountLabel.Name = "interestedCountLabel";
            interestedCountLabel.Size = new System.Drawing.Size(123, 16);
            interestedCountLabel.TabIndex = 13;
            interestedCountLabel.Text = "Interested Count:";
            // 
            // interestedCountTextBox
            // 
            this.interestedCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "InterestedCount", true));
            this.interestedCountTextBox.Location = new System.Drawing.Point(640, 223);
            this.interestedCountTextBox.Name = "interestedCountTextBox";
            this.interestedCountTextBox.ReadOnly = true;
            this.interestedCountTextBox.Size = new System.Drawing.Size(224, 22);
            this.interestedCountTextBox.TabIndex = 14;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.Location = new System.Drawing.Point(23, 78);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(70, 16);
            locationLabel.TabIndex = 15;
            locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(195, 75);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(224, 22);
            this.locationTextBox.TabIndex = 16;
            // 
            // maybeCountLabel
            // 
            maybeCountLabel.AutoSize = true;
            maybeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maybeCountLabel.Location = new System.Drawing.Point(468, 257);
            maybeCountLabel.Name = "maybeCountLabel";
            maybeCountLabel.Size = new System.Drawing.Size(101, 16);
            maybeCountLabel.TabIndex = 17;
            maybeCountLabel.Text = "Maybe Count:";
            // 
            // maybeCountTextBox
            // 
            this.maybeCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "MaybeCount", true));
            this.maybeCountTextBox.Location = new System.Drawing.Point(640, 254);
            this.maybeCountTextBox.Name = "maybeCountTextBox";
            this.maybeCountTextBox.ReadOnly = true;
            this.maybeCountTextBox.Size = new System.Drawing.Size(224, 22);
            this.maybeCountTextBox.TabIndex = 18;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(23, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 16);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(195, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(224, 22);
            this.nameTextBox.TabIndex = 20;
            // 
            // noReplyCountLabel
            // 
            noReplyCountLabel.AutoSize = true;
            noReplyCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noReplyCountLabel.Location = new System.Drawing.Point(468, 288);
            noReplyCountLabel.Name = "noReplyCountLabel";
            noReplyCountLabel.Size = new System.Drawing.Size(119, 16);
            noReplyCountLabel.TabIndex = 21;
            noReplyCountLabel.Text = "No Reply Count:";
            // 
            // noReplyCountTextBox
            // 
            this.noReplyCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "NoReplyCount", true));
            this.noReplyCountTextBox.Location = new System.Drawing.Point(640, 285);
            this.noReplyCountTextBox.Name = "noReplyCountTextBox";
            this.noReplyCountTextBox.ReadOnly = true;
            this.noReplyCountTextBox.Size = new System.Drawing.Size(224, 22);
            this.noReplyCountTextBox.TabIndex = 22;
            // 
            // privacyLabel
            // 
            privacyLabel.AutoSize = true;
            privacyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            privacyLabel.Location = new System.Drawing.Point(23, 106);
            privacyLabel.Name = "privacyLabel";
            privacyLabel.Size = new System.Drawing.Size(63, 16);
            privacyLabel.TabIndex = 23;
            privacyLabel.Text = "Privacy:";
            // 
            // privacyTextBox
            // 
            this.privacyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Privacy", true));
            this.privacyTextBox.Location = new System.Drawing.Point(195, 103);
            this.privacyTextBox.Name = "privacyTextBox";
            this.privacyTextBox.ReadOnly = true;
            this.privacyTextBox.Size = new System.Drawing.Size(224, 22);
            this.privacyTextBox.TabIndex = 24;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startTimeLabel.Location = new System.Drawing.Point(468, 21);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(82, 16);
            startTimeLabel.TabIndex = 25;
            startTimeLabel.Text = "Start Time:";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Enabled = false;
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(640, 17);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.startTimeDateTimePicker.TabIndex = 26;
            // 
            // timezoneLabel
            // 
            timezoneLabel.AutoSize = true;
            timezoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timezoneLabel.Location = new System.Drawing.Point(468, 104);
            timezoneLabel.Name = "timezoneLabel";
            timezoneLabel.Size = new System.Drawing.Size(79, 16);
            timezoneLabel.TabIndex = 27;
            timezoneLabel.Text = "Timezone:";
            // 
            // timezoneTextBox
            // 
            this.timezoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Timezone", true));
            this.timezoneTextBox.Location = new System.Drawing.Point(640, 101);
            this.timezoneTextBox.Name = "timezoneTextBox";
            this.timezoneTextBox.ReadOnly = true;
            this.timezoneTextBox.Size = new System.Drawing.Size(224, 22);
            this.timezoneTextBox.TabIndex = 28;
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updateTimeLabel.Location = new System.Drawing.Point(468, 77);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(101, 16);
            updateTimeLabel.TabIndex = 29;
            updateTimeLabel.Text = "Update Time:";
            // 
            // updateTimeDateTimePicker
            // 
            this.updateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "UpdateTime", true));
            this.updateTimeDateTimePicker.Enabled = false;
            this.updateTimeDateTimePicker.Location = new System.Drawing.Point(640, 73);
            this.updateTimeDateTimePicker.Name = "updateTimeDateTimePicker";
            this.updateTimeDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.updateTimeDateTimePicker.TabIndex = 30;
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(35, 260);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(73, 16);
            idLabel1.TabIndex = 30;
            idLabel1.Text = "Owner ID:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Owner.Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(195, 257);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.ReadOnly = true;
            this.idTextBox1.Size = new System.Drawing.Size(224, 22);
            this.idTextBox1.TabIndex = 31;
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(35, 291);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(96, 16);
            nameLabel1.TabIndex = 31;
            nameLabel1.Text = "Owner name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Owner.Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(195, 288);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.ReadOnly = true;
            this.nameTextBox1.Size = new System.Drawing.Size(224, 22);
            this.nameTextBox1.TabIndex = 32;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 524);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(attendingCountLabel);
            this.Controls.Add(this.attendingCountTextBox);
            this.Controls.Add(declinedCountLabel);
            this.Controls.Add(this.declinedCountTextBox);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(this.endTimeDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(imageLargeLabel);
            this.Controls.Add(this.imageLargePictureBox);
            this.Controls.Add(interestedCountLabel);
            this.Controls.Add(this.interestedCountTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(maybeCountLabel);
            this.Controls.Add(this.maybeCountTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(noReplyCountLabel);
            this.Controls.Add(this.noReplyCountTextBox);
            this.Controls.Add(privacyLabel);
            this.Controls.Add(this.privacyTextBox);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimeDateTimePicker);
            this.Controls.Add(timezoneLabel);
            this.Controls.Add(this.timezoneTextBox);
            this.Controls.Add(updateTimeLabel);
            this.Controls.Add(this.updateTimeDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event details";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox attendingCountTextBox;
        private System.Windows.Forms.TextBox declinedCountTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox interestedCountTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox maybeCountTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox noReplyCountTextBox;
        private System.Windows.Forms.TextBox privacyTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.TextBox timezoneTextBox;
        private System.Windows.Forms.DateTimePicker updateTimeDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
    }
}