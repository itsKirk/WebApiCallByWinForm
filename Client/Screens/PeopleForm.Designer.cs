namespace Client.Screens
{
  partial class PeopleForm : BaseForm
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
      this.peopleDgv = new System.Windows.Forms.DataGridView();
      this.AddButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.peopleDgv)).BeginInit();
      this.SuspendLayout();
      // 
      // peopleDgv
      // 
      this.peopleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.peopleDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.peopleDgv.Location = new System.Drawing.Point(0, 42);
      this.peopleDgv.Name = "peopleDgv";
      this.peopleDgv.RowTemplate.Height = 25;
      this.peopleDgv.Size = new System.Drawing.Size(442, 467);
      this.peopleDgv.TabIndex = 0;
      // 
      // AddButton
      // 
      this.AddButton.Location = new System.Drawing.Point(12, 12);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(120, 24);
      this.AddButton.TabIndex = 1;
      this.AddButton.Text = "Add Person";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // PeopleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(442, 509);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.peopleDgv);
      this.Name = "PeopleForm";
      this.Text = "People";
      ((System.ComponentModel.ISupportInitialize)(this.peopleDgv)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DataGridView peopleDgv;
    private Button AddButton;
  }
}