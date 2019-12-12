namespace ObserverApp
{
    partial class MainForm
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
            this.regButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.sessionStartButton = new System.Windows.Forms.Button();
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.newEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(16, 211);
            this.regButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(138, 38);
            this.regButton.TabIndex = 0;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 22);
            this.textBox2.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Full Name";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(12, 62);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(48, 17);
            this.groupLabel.TabIndex = 4;
            this.groupLabel.Text = "Group";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Session start",
            "New message",
            "New event"});
            this.checkedListBox1.Location = new System.Drawing.Point(16, 130);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(138, 72);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subscribe on";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(173, 29);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(392, 173);
            this.logTextBox.TabIndex = 7;
            this.logTextBox.Text = "";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(170, 10);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(32, 17);
            this.logLabel.TabIndex = 8;
            this.logLabel.Text = "Log";
            // 
            // sessionStartButton
            // 
            this.sessionStartButton.Location = new System.Drawing.Point(173, 211);
            this.sessionStartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sessionStartButton.Name = "sessionStartButton";
            this.sessionStartButton.Size = new System.Drawing.Size(133, 38);
            this.sessionStartButton.TabIndex = 9;
            this.sessionStartButton.Text = "Session start";
            this.sessionStartButton.UseVisualStyleBackColor = true;
            this.sessionStartButton.Click += new System.EventHandler(this.sessionStartButton_Click);
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(312, 211);
            this.sendMsgButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(145, 38);
            this.sendMsgButton.TabIndex = 10;
            this.sendMsgButton.Text = "Send message";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
            // 
            // newEventButton
            // 
            this.newEventButton.Location = new System.Drawing.Point(463, 211);
            this.newEventButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newEventButton.Name = "newEventButton";
            this.newEventButton.Size = new System.Drawing.Size(102, 38);
            this.newEventButton.TabIndex = 11;
            this.newEventButton.Text = "Send event";
            this.newEventButton.UseVisualStyleBackColor = true;
            this.newEventButton.Click += new System.EventHandler(this.newEventButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 260);
            this.Controls.Add(this.newEventButton);
            this.Controls.Add(this.sendMsgButton);
            this.Controls.Add(this.sessionStartButton);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.regButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Observer App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button sessionStartButton;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.Button newEventButton;
    }
}

