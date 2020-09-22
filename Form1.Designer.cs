namespace SClipper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getProcessButton = new System.Windows.Forms.Button();
            this.processListBox = new System.Windows.Forms.ListBox();
            this.selectedProcessTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterProcessTextBox = new System.Windows.Forms.TextBox();
            this.enableFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // getProcessButton
            // 
            this.getProcessButton.Location = new System.Drawing.Point(12, 97);
            this.getProcessButton.Name = "getProcessButton";
            this.getProcessButton.Size = new System.Drawing.Size(75, 23);
            this.getProcessButton.TabIndex = 0;
            this.getProcessButton.Text = "Fetch Processes";
            this.getProcessButton.UseVisualStyleBackColor = true;
            this.getProcessButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // processListBox
            // 
            this.processListBox.FormattingEnabled = true;
            this.processListBox.ItemHeight = 15;
            this.processListBox.Location = new System.Drawing.Point(12, 12);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(352, 79);
            this.processListBox.TabIndex = 2;
            this.processListBox.SelectedIndexChanged += new System.EventHandler(this.processListBox_SelectedIndexChanged);
            // 
            // selectedProcessTextBox
            // 
            this.selectedProcessTextBox.Location = new System.Drawing.Point(12, 126);
            this.selectedProcessTextBox.Name = "selectedProcessTextBox";
            this.selectedProcessTextBox.Size = new System.Drawing.Size(352, 23);
            this.selectedProcessTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter Process:";
            // 
            // filterProcessTextBox
            // 
            this.filterProcessTextBox.Location = new System.Drawing.Point(97, 162);
            this.filterProcessTextBox.Name = "filterProcessTextBox";
            this.filterProcessTextBox.Size = new System.Drawing.Size(267, 23);
            this.filterProcessTextBox.TabIndex = 5;
            // 
            // enableFilterCheckBox
            // 
            this.enableFilterCheckBox.AutoSize = true;
            this.enableFilterCheckBox.Location = new System.Drawing.Point(12, 193);
            this.enableFilterCheckBox.Name = "enableFilterCheckBox";
            this.enableFilterCheckBox.Size = new System.Drawing.Size(90, 19);
            this.enableFilterCheckBox.TabIndex = 6;
            this.enableFilterCheckBox.Text = "Enable Filter";
            this.enableFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
            this.SystemTrayIcon.Text = "SClipper";
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 224);
            this.Controls.Add(this.enableFilterCheckBox);
            this.Controls.Add(this.filterProcessTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedProcessTextBox);
            this.Controls.Add(this.processListBox);
            this.Controls.Add(this.getProcessButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Resize1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button getProcessButton;
        private System.Windows.Forms.ListBox processListBox;
        private System.Windows.Forms.TextBox selectedProcessTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterProcessTextBox;
        private System.Windows.Forms.CheckBox enableFilterCheckBox;
        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
    }
}

