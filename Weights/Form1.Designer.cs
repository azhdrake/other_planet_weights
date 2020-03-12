namespace Weights
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
      this.txtEarthWeight = new System.Windows.Forms.TextBox();
      this.txtMercWeight = new System.Windows.Forms.TextBox();
      this.txtVenusWeight = new System.Windows.Forms.TextBox();
      this.txtMarsWeight = new System.Windows.Forms.TextBox();
      this.btnConvert = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtEarthWeight
      // 
      this.txtEarthWeight.Location = new System.Drawing.Point(91, 34);
      this.txtEarthWeight.Name = "txtEarthWeight";
      this.txtEarthWeight.Size = new System.Drawing.Size(106, 31);
      this.txtEarthWeight.TabIndex = 0;
      // 
      // txtMercWeight
      // 
      this.txtMercWeight.Location = new System.Drawing.Point(325, 34);
      this.txtMercWeight.Name = "txtMercWeight";
      this.txtMercWeight.ReadOnly = true;
      this.txtMercWeight.Size = new System.Drawing.Size(106, 31);
      this.txtMercWeight.TabIndex = 1;
      this.txtMercWeight.TabStop = false;
      // 
      // txtVenusWeight
      // 
      this.txtVenusWeight.Location = new System.Drawing.Point(325, 121);
      this.txtVenusWeight.Name = "txtVenusWeight";
      this.txtVenusWeight.ReadOnly = true;
      this.txtVenusWeight.Size = new System.Drawing.Size(106, 31);
      this.txtVenusWeight.TabIndex = 2;
      this.txtVenusWeight.TabStop = false;
      // 
      // txtMarsWeight
      // 
      this.txtMarsWeight.Location = new System.Drawing.Point(325, 205);
      this.txtMarsWeight.Name = "txtMarsWeight";
      this.txtMarsWeight.ReadOnly = true;
      this.txtMarsWeight.Size = new System.Drawing.Size(106, 31);
      this.txtMarsWeight.TabIndex = 3;
      this.txtMarsWeight.TabStop = false;
      // 
      // btnConvert
      // 
      this.btnConvert.Location = new System.Drawing.Point(91, 115);
      this.btnConvert.Name = "btnConvert";
      this.btnConvert.Size = new System.Drawing.Size(106, 43);
      this.btnConvert.TabIndex = 1;
      this.btnConvert.Text = "Convert";
      this.btnConvert.UseVisualStyleBackColor = true;
      this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 25);
      this.label1.TabIndex = 5;
      this.label1.Text = "Earth";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(229, 37);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 25);
      this.label2.TabIndex = 6;
      this.label2.Text = "Mercury";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(229, 124);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 25);
      this.label3.TabIndex = 7;
      this.label3.Text = "Venus";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(229, 208);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 25);
      this.label4.TabIndex = 8;
      this.label4.Text = "Mars";
      // 
      // Form1
      // 
      this.AcceptButton = this.btnConvert;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 295);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnConvert);
      this.Controls.Add(this.txtMarsWeight);
      this.Controls.Add(this.txtVenusWeight);
      this.Controls.Add(this.txtMercWeight);
      this.Controls.Add(this.txtEarthWeight);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtEarthWeight;
    private System.Windows.Forms.TextBox txtMercWeight;
    private System.Windows.Forms.TextBox txtVenusWeight;
    private System.Windows.Forms.TextBox txtMarsWeight;
    private System.Windows.Forms.Button btnConvert;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

