
namespace Worker_Data
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
            this.workerInformationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.returnDataLabel = new System.Windows.Forms.Label();
            this.empNumLabel = new System.Windows.Forms.Label();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.workShiftLabel = new System.Windows.Forms.Label();
            this.wageLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.hourlyWageTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.shiftNumberLabel = new System.Windows.Forms.Label();
            this.hourlyWageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workerInformationLabel
            // 
            this.workerInformationLabel.AutoSize = true;
            this.workerInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.workerInformationLabel.Location = new System.Drawing.Point(12, 60);
            this.workerInformationLabel.Name = "workerInformationLabel";
            this.workerInformationLabel.Size = new System.Drawing.Size(196, 20);
            this.workerInformationLabel.TabIndex = 0;
            this.workerInformationLabel.Text = "Enter Worker Information :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shift (1 = Day, 2 = Night) ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hourly Wage";
            // 
            // returnDataLabel
            // 
            this.returnDataLabel.AutoSize = true;
            this.returnDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.returnDataLabel.Location = new System.Drawing.Point(103, 204);
            this.returnDataLabel.Name = "returnDataLabel";
            this.returnDataLabel.Size = new System.Drawing.Size(105, 20);
            this.returnDataLabel.TabIndex = 5;
            this.returnDataLabel.Text = "Return Data :";
            // 
            // empNumLabel
            // 
            this.empNumLabel.AutoSize = true;
            this.empNumLabel.Location = new System.Drawing.Point(215, 239);
            this.empNumLabel.Name = "empNumLabel";
            this.empNumLabel.Size = new System.Drawing.Size(93, 13);
            this.empNumLabel.TabIndex = 6;
            this.empNumLabel.Text = "Employee Number";
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(215, 266);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(84, 13);
            this.empNameLabel.TabIndex = 7;
            this.empNameLabel.Text = "Employee Name";
            // 
            // workShiftLabel
            // 
            this.workShiftLabel.AutoSize = true;
            this.workShiftLabel.Location = new System.Drawing.Point(215, 293);
            this.workShiftLabel.Name = "workShiftLabel";
            this.workShiftLabel.Size = new System.Drawing.Size(123, 13);
            this.workShiftLabel.TabIndex = 8;
            this.workShiftLabel.Text = "Shift (1 = Day, 2 = Night)";
            // 
            // wageLabel
            // 
            this.wageLabel.AutoSize = true;
            this.wageLabel.Location = new System.Drawing.Point(215, 320);
            this.wageLabel.Name = "wageLabel";
            this.wageLabel.Size = new System.Drawing.Size(69, 13);
            this.wageLabel.TabIndex = 9;
            this.wageLabel.Text = "Hourly Wage";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(158, 361);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(329, 361);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(524, 361);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Location = new System.Drawing.Point(570, 99);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeNumberTextBox.TabIndex = 13;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(570, 125);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeNameTextBox.TabIndex = 14;
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.Location = new System.Drawing.Point(570, 151);
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(100, 20);
            this.shiftTextBox.TabIndex = 15;
            // 
            // hourlyWageTextBox
            // 
            this.hourlyWageTextBox.Location = new System.Drawing.Point(570, 177);
            this.hourlyWageTextBox.Name = "hourlyWageTextBox";
            this.hourlyWageTextBox.Size = new System.Drawing.Size(100, 20);
            this.hourlyWageTextBox.TabIndex = 16;
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Location = new System.Drawing.Point(570, 239);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.employeeNumberLabel.TabIndex = 17;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(570, 266);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(0, 13);
            this.employeeNameLabel.TabIndex = 18;
            // 
            // shiftNumberLabel
            // 
            this.shiftNumberLabel.AutoSize = true;
            this.shiftNumberLabel.Location = new System.Drawing.Point(570, 293);
            this.shiftNumberLabel.Name = "shiftNumberLabel";
            this.shiftNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.shiftNumberLabel.TabIndex = 19;
            // 
            // hourlyWageLabel
            // 
            this.hourlyWageLabel.AutoSize = true;
            this.hourlyWageLabel.Location = new System.Drawing.Point(570, 320);
            this.hourlyWageLabel.Name = "hourlyWageLabel";
            this.hourlyWageLabel.Size = new System.Drawing.Size(0, 13);
            this.hourlyWageLabel.TabIndex = 20;
            // 
            // Form1
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hourlyWageLabel);
            this.Controls.Add(this.shiftNumberLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.employeeNumberLabel);
            this.Controls.Add(this.hourlyWageTextBox);
            this.Controls.Add(this.shiftTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.wageLabel);
            this.Controls.Add(this.workShiftLabel);
            this.Controls.Add(this.empNameLabel);
            this.Controls.Add(this.empNumLabel);
            this.Controls.Add(this.returnDataLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workerInformationLabel);
            this.Name = "Form1";
            this.Text = "Worker Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerInformationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label returnDataLabel;
        private System.Windows.Forms.Label empNumLabel;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label workShiftLabel;
        private System.Windows.Forms.Label wageLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox shiftTextBox;
        private System.Windows.Forms.TextBox hourlyWageTextBox;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label shiftNumberLabel;
        private System.Windows.Forms.Label hourlyWageLabel;
    }
}

