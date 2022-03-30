namespace Client.Screens
{
  partial class MainForm : BaseForm
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
      this.LoadDataButton = new System.Windows.Forms.Button();
      this.LoadPeopleButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LoadDataButton
      // 
      this.LoadDataButton.Location = new System.Drawing.Point(12, 12);
      this.LoadDataButton.Name = "LoadDataButton";
      this.LoadDataButton.Size = new System.Drawing.Size(162, 47);
      this.LoadDataButton.TabIndex = 0;
      this.LoadDataButton.Text = "Load Weather";
      this.LoadDataButton.UseVisualStyleBackColor = true;
      this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
      // 
      // LoadPeopleButton
      // 
      this.LoadPeopleButton.Location = new System.Drawing.Point(258, 12);
      this.LoadPeopleButton.Name = "LoadPeopleButton";
      this.LoadPeopleButton.Size = new System.Drawing.Size(162, 47);
      this.LoadPeopleButton.TabIndex = 1;
      this.LoadPeopleButton.Text = "Load People";
      this.LoadPeopleButton.UseVisualStyleBackColor = true;
      this.LoadPeopleButton.Click += new System.EventHandler(this.LoadPeopleButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.LoadPeopleButton);
      this.Controls.Add(this.LoadDataButton);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.ResumeLayout(false);

    }

    #endregion

    private Button LoadDataButton;
    private Button LoadPeopleButton;
  }
}