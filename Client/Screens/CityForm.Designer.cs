namespace Client.Screens
{
  partial class CityForm
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
      this.CityButton = new System.Windows.Forms.Button();
      this.CitiesComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // CityButton
      // 
      this.CityButton.Location = new System.Drawing.Point(307, 131);
      this.CityButton.Name = "CityButton";
      this.CityButton.Size = new System.Drawing.Size(87, 36);
      this.CityButton.TabIndex = 0;
      this.CityButton.Text = "Select City";
      this.CityButton.UseVisualStyleBackColor = true;
      this.CityButton.Click += new System.EventHandler(this.CityButton_Click);
      // 
      // CitiesComboBox
      // 
      this.CitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CitiesComboBox.FormattingEnabled = true;
      this.CitiesComboBox.Location = new System.Drawing.Point(82, 91);
      this.CitiesComboBox.Name = "CitiesComboBox";
      this.CitiesComboBox.Size = new System.Drawing.Size(312, 23);
      this.CitiesComboBox.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(82, 73);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "List of Cities";
      // 
      // CityForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(476, 241);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.CitiesComboBox);
      this.Controls.Add(this.CityButton);
      this.Name = "CityForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "CityForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button CityButton;
    private ComboBox CitiesComboBox;
    private Label label1;
  }
}