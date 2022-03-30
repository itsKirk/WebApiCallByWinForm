namespace Client.Screens
{
  partial class AddPersonForm
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
      this.SaveButton = new System.Windows.Forms.Button();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.emailAddressTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // SaveButton
      // 
      this.SaveButton.Location = new System.Drawing.Point(277, 168);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(75, 23);
      this.SaveButton.TabIndex = 3;
      this.SaveButton.Text = "Save";
      this.SaveButton.UseVisualStyleBackColor = true;
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(134, 84);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(218, 22);
      this.firstNameTextBox.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 87);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "First Name";
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(134, 112);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(218, 22);
      this.lastNameTextBox.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 115);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Last Name";
      // 
      // emailAddressTextBox
      // 
      this.emailAddressTextBox.Location = new System.Drawing.Point(134, 140);
      this.emailAddressTextBox.Name = "emailAddressTextBox";
      this.emailAddressTextBox.Size = new System.Drawing.Size(218, 22);
      this.emailAddressTextBox.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(37, 143);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(88, 16);
      this.label3.TabIndex = 2;
      this.label3.Text = "Email Address";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label4.Location = new System.Drawing.Point(151, 36);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(124, 23);
      this.label4.TabIndex = 2;
      this.label4.Text = "New Person";
      // 
      // AddPersonForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(420, 291);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.emailAddressTextBox);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(this.firstNameTextBox);
      this.Controls.Add(this.SaveButton);
      this.Name = "AddPersonForm";
      this.Text = "Add Person";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button SaveButton;
    private TextBox firstNameTextBox;
    private Label label1;
    private TextBox lastNameTextBox;
    private Label label2;
    private TextBox emailAddressTextBox;
    private Label label3;
    private Label label4;
  }
}