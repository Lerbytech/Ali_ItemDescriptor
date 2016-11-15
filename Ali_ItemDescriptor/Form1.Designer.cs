namespace Ali_ItemDescriptor
{
  partial class Form1
  {
    /// <summary>
    /// Требуется переменная конструктора.
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
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.TB_ItemStats = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.TB_Description = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.BTN_GenStats = new System.Windows.Forms.Button();
      this.BTN_GenDescrition = new System.Windows.Forms.Button();
      this.BTN_DefaultStats = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TB_ItemStats
      // 
      this.TB_ItemStats.Location = new System.Drawing.Point(12, 60);
      this.TB_ItemStats.Multiline = true;
      this.TB_ItemStats.Name = "TB_ItemStats";
      this.TB_ItemStats.Size = new System.Drawing.Size(241, 988);
      this.TB_ItemStats.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Свойства";
      // 
      // TB_Description
      // 
      this.TB_Description.Location = new System.Drawing.Point(303, 288);
      this.TB_Description.Multiline = true;
      this.TB_Description.Name = "TB_Description";
      this.TB_Description.Size = new System.Drawing.Size(1032, 760);
      this.TB_Description.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(303, 269);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(151, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Сгенерированное описание:";
      // 
      // BTN_GenStats
      // 
      this.BTN_GenStats.Location = new System.Drawing.Point(303, 187);
      this.BTN_GenStats.Name = "BTN_GenStats";
      this.BTN_GenStats.Size = new System.Drawing.Size(194, 23);
      this.BTN_GenStats.TabIndex = 4;
      this.BTN_GenStats.Text = "Придумать характеристики";
      this.BTN_GenStats.UseVisualStyleBackColor = true;
      this.BTN_GenStats.Click += new System.EventHandler(this.BTN_GenStats_Click);
      // 
      // BTN_GenDescrition
      // 
      this.BTN_GenDescrition.Location = new System.Drawing.Point(542, 187);
      this.BTN_GenDescrition.Name = "BTN_GenDescrition";
      this.BTN_GenDescrition.Size = new System.Drawing.Size(194, 23);
      this.BTN_GenDescrition.TabIndex = 5;
      this.BTN_GenDescrition.Text = "Придумать описание";
      this.BTN_GenDescrition.UseVisualStyleBackColor = true;
      this.BTN_GenDescrition.Click += new System.EventHandler(this.BTN_GenDescription_Click);
      // 
      // BTN_DefaultStats
      // 
      this.BTN_DefaultStats.Location = new System.Drawing.Point(303, 158);
      this.BTN_DefaultStats.Name = "BTN_DefaultStats";
      this.BTN_DefaultStats.Size = new System.Drawing.Size(194, 23);
      this.BTN_DefaultStats.TabIndex = 6;
      this.BTN_DefaultStats.Text = "Default stats";
      this.BTN_DefaultStats.UseVisualStyleBackColor = true;
      this.BTN_DefaultStats.Click += new System.EventHandler(this.BTN_DefaultStats_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1356, 1060);
      this.Controls.Add(this.BTN_DefaultStats);
      this.Controls.Add(this.BTN_GenDescrition);
      this.Controls.Add(this.BTN_GenStats);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TB_Description);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TB_ItemStats);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TB_ItemStats;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TB_Description;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BTN_GenStats;
    private System.Windows.Forms.Button BTN_GenDescrition;
    private System.Windows.Forms.Button BTN_DefaultStats;
  }
}

