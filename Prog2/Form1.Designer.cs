namespace Prog2
{
    partial class Form1
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
            this.infoPrompt = new System.Windows.Forms.Label();
            this.lastNamePrompt = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.classStandingGroupBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.sophRadioButton = new System.Windows.Forms.RadioButton();
            this.froshRadioButton = new System.Windows.Forms.RadioButton();
            this.registerTimeLabel = new System.Windows.Forms.Label();
            this.registerTimeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.classStandingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPrompt
            // 
            this.infoPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPrompt.Location = new System.Drawing.Point(70, 9);
            this.infoPrompt.Name = "infoPrompt";
            this.infoPrompt.Size = new System.Drawing.Size(151, 56);
            this.infoPrompt.TabIndex = 0;
            this.infoPrompt.Text = "Enter Required Information";
            this.infoPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNamePrompt
            // 
            this.lastNamePrompt.AutoSize = true;
            this.lastNamePrompt.Location = new System.Drawing.Point(52, 75);
            this.lastNamePrompt.Name = "lastNamePrompt";
            this.lastNamePrompt.Size = new System.Drawing.Size(89, 13);
            this.lastNamePrompt.TabIndex = 2;
            this.lastNamePrompt.Text = "Enter Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(147, 72);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // classStandingGroupBox
            // 
            this.classStandingGroupBox.Controls.Add(this.seniorRadioButton);
            this.classStandingGroupBox.Controls.Add(this.juniorRadioButton);
            this.classStandingGroupBox.Controls.Add(this.sophRadioButton);
            this.classStandingGroupBox.Controls.Add(this.froshRadioButton);
            this.classStandingGroupBox.Location = new System.Drawing.Point(82, 113);
            this.classStandingGroupBox.Name = "classStandingGroupBox";
            this.classStandingGroupBox.Size = new System.Drawing.Size(127, 129);
            this.classStandingGroupBox.TabIndex = 4;
            this.classStandingGroupBox.TabStop = false;
            this.classStandingGroupBox.Text = "Class Standing";
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(6, 30);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(55, 17);
            this.seniorRadioButton.TabIndex = 5;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(6, 53);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(53, 17);
            this.juniorRadioButton.TabIndex = 2;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophRadioButton
            // 
            this.sophRadioButton.AutoSize = true;
            this.sophRadioButton.Location = new System.Drawing.Point(6, 76);
            this.sophRadioButton.Name = "sophRadioButton";
            this.sophRadioButton.Size = new System.Drawing.Size(79, 17);
            this.sophRadioButton.TabIndex = 1;
            this.sophRadioButton.TabStop = true;
            this.sophRadioButton.Text = "Sophomore";
            this.sophRadioButton.UseVisualStyleBackColor = true;
            // 
            // froshRadioButton
            // 
            this.froshRadioButton.AutoSize = true;
            this.froshRadioButton.Location = new System.Drawing.Point(6, 99);
            this.froshRadioButton.Name = "froshRadioButton";
            this.froshRadioButton.Size = new System.Drawing.Size(71, 17);
            this.froshRadioButton.TabIndex = 0;
            this.froshRadioButton.TabStop = true;
            this.froshRadioButton.Text = "Freshman";
            this.froshRadioButton.UseVisualStyleBackColor = true;
            // 
            // registerTimeLabel
            // 
            this.registerTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTimeLabel.Location = new System.Drawing.Point(62, 312);
            this.registerTimeLabel.Name = "registerTimeLabel";
            this.registerTimeLabel.Size = new System.Drawing.Size(166, 23);
            this.registerTimeLabel.TabIndex = 6;
            this.registerTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerTimeButton
            // 
            this.registerTimeButton.Location = new System.Drawing.Point(102, 248);
            this.registerTimeButton.Name = "registerTimeButton";
            this.registerTimeButton.Size = new System.Drawing.Size(86, 51);
            this.registerTimeButton.TabIndex = 7;
            this.registerTimeButton.Text = "Determine Register Date and Time";
            this.registerTimeButton.UseVisualStyleBackColor = true;
            this.registerTimeButton.Click += new System.EventHandler(this.registerTimeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(108, 352);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.registerTimeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(291, 389);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.registerTimeButton);
            this.Controls.Add(this.registerTimeLabel);
            this.Controls.Add(this.classStandingGroupBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNamePrompt);
            this.Controls.Add(this.infoPrompt);
            this.Name = "Form1";
            this.Text = "Student Regsitration";
            this.classStandingGroupBox.ResumeLayout(false);
            this.classStandingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoPrompt;
        private System.Windows.Forms.Label lastNamePrompt;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox classStandingGroupBox;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophRadioButton;
        private System.Windows.Forms.RadioButton froshRadioButton;
        private System.Windows.Forms.Label registerTimeLabel;
        private System.Windows.Forms.Button registerTimeButton;
        private System.Windows.Forms.Button clearButton;
    }
}

