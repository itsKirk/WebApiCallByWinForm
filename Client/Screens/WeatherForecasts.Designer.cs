namespace Client.Screens
{
  partial class WeatherForecasts
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
      this.forecastsDgv = new System.Windows.Forms.DataGridView();
      this.labelText = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.forecastsDgv)).BeginInit();
      this.SuspendLayout();
      // 
      // forecastsDgv
      // 
      this.forecastsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.forecastsDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.forecastsDgv.Location = new System.Drawing.Point(0, 53);
      this.forecastsDgv.Name = "forecastsDgv";
      this.forecastsDgv.RowTemplate.Height = 25;
      this.forecastsDgv.Size = new System.Drawing.Size(523, 427);
      this.forecastsDgv.TabIndex = 0;
      // 
      // labelText
      // 
      this.labelText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.labelText.Location = new System.Drawing.Point(6, 15);
      this.labelText.Name = "labelText";
      this.labelText.Size = new System.Drawing.Size(511, 18);
      this.labelText.TabIndex = 1;
      this.labelText.Text = "[city weather]";
      this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // WeatherForecasts
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(523, 480);
      this.Controls.Add(this.labelText);
      this.Controls.Add(this.forecastsDgv);
      this.Name = "WeatherForecasts";
      this.Text = "WeatherForecasts";
      this.Load += new System.EventHandler(this.WeatherForecasts_Load);
      ((System.ComponentModel.ISupportInitialize)(this.forecastsDgv)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DataGridView forecastsDgv;
    private Label labelText;
  }
}