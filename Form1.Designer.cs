namespace MegaMill
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.currentNumbers = new System.Windows.Forms.ListView();
            this.runButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(24, 172);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(138, 31);
            this.startDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(190, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(186, 172);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(137, 31);
            this.endDatePicker.TabIndex = 3;
            // 
            // currentNumbers
            // 
            this.currentNumbers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentNumbers.Location = new System.Drawing.Point(29, 53);
            this.currentNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentNumbers.Name = "currentNumbers";
            this.currentNumbers.Size = new System.Drawing.Size(495, 52);
            this.currentNumbers.TabIndex = 8;
            this.currentNumbers.UseCompatibleStateImageBehavior = false;
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.SteelBlue;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.runButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.runButton.Location = new System.Drawing.Point(29, 237);
            this.runButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(196, 42);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Current Mega Millions Numbers";
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.displayBox.ForeColor = System.Drawing.SystemColors.Window;
            this.displayBox.FormattingEnabled = true;
            this.displayBox.ItemHeight = 25;
            this.displayBox.Location = new System.Drawing.Point(24, 315);
            this.displayBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayBox.Name = "displayBox";
            this.displayBox.ScrollAlwaysVisible = true;
            this.displayBox.Size = new System.Drawing.Size(500, 229);
            this.displayBox.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(251, 237);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 42);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Enabled = false;
            this.copyButton.Location = new System.Drawing.Point(457, 552);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(67, 42);
            this.copyButton.TabIndex = 13;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Built with ❤️by Danny Del Grosso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(543, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.currentNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDatePicker);
            this.Name = "Form1";
            this.Text = "Mega Millions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker startDatePicker;
        private Label label1;
        private Label label2;
        private DateTimePicker endDatePicker;
        private ListView currentNumbers;
        private Button runButton;
        private Label label3;
        private ListBox displayBox;
        private Button clearButton;
        private Button copyButton;
        private Label label4;
    }
}