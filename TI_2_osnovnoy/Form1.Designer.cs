namespace TI_2_osnovnoy
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
      this.textBox_IshKey = new System.Windows.Forms.TextBox();
      this.GenerateKey = new System.Windows.Forms.Button();
      this.OpenFile = new System.Windows.Forms.Button();
      this.EncryptFile = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.richTextBox_IshTxt = new System.Windows.Forms.RichTextBox();
      this.richTextBox_EncrTxt = new System.Windows.Forms.RichTextBox();
      this.richTextBox_GenericKey = new System.Windows.Forms.RichTextBox();
      this.richTextBox_DecrFile = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // textBox_IshKey
      // 
      this.textBox_IshKey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.textBox_IshKey.Location = new System.Drawing.Point(31, 51);
      this.textBox_IshKey.Multiline = true;
      this.textBox_IshKey.Name = "textBox_IshKey";
      this.textBox_IshKey.Size = new System.Drawing.Size(265, 101);
      this.textBox_IshKey.TabIndex = 0;
      this.textBox_IshKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IshKey_KeyPress);
      // 
      // GenerateKey
      // 
      this.GenerateKey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.GenerateKey.Location = new System.Drawing.Point(31, 176);
      this.GenerateKey.Name = "GenerateKey";
      this.GenerateKey.Size = new System.Drawing.Size(265, 50);
      this.GenerateKey.TabIndex = 4;
      this.GenerateKey.Text = "Сгенерировать ключ";
      this.GenerateKey.UseVisualStyleBackColor = true;
      this.GenerateKey.Click += new System.EventHandler(this.GenerateKey_Click);
      // 
      // OpenFile
      // 
      this.OpenFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.OpenFile.Location = new System.Drawing.Point(31, 243);
      this.OpenFile.Name = "OpenFile";
      this.OpenFile.Size = new System.Drawing.Size(265, 50);
      this.OpenFile.TabIndex = 5;
      this.OpenFile.Text = "Открыть файл";
      this.OpenFile.UseVisualStyleBackColor = true;
      this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
      // 
      // EncryptFile
      // 
      this.EncryptFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.EncryptFile.Location = new System.Drawing.Point(31, 310);
      this.EncryptFile.Name = "EncryptFile";
      this.EncryptFile.Size = new System.Drawing.Size(265, 50);
      this.EncryptFile.TabIndex = 6;
      this.EncryptFile.Text = "Зашифровать/Расшифровать";
      this.EncryptFile.UseVisualStyleBackColor = true;
      this.EncryptFile.Click += new System.EventHandler(this.EncryptFile_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(104, 469);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 22);
      this.label1.TabIndex = 12;
      this.label1.Text = "x35 + x2 + 1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(34, 26);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(262, 22);
      this.label2.TabIndex = 13;
      this.label2.Text = "Исходное состояние регистра";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(319, 26);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(214, 22);
      this.label3.TabIndex = 14;
      this.label3.Text = "Сгенерированный ключ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label4.Location = new System.Drawing.Point(319, 191);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(146, 22);
      this.label4.TabIndex = 15;
      this.label4.Text = "Исходный текст";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.Location = new System.Drawing.Point(319, 354);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(199, 22);
      this.label5.TabIndex = 16;
      this.label5.Text = "Зашифрованный файл";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label6.Location = new System.Drawing.Point(319, 517);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(209, 22);
      this.label6.TabIndex = 17;
      this.label6.Text = "Расшифрованный файл";
      // 
      // richTextBox_IshTxt
      // 
      this.richTextBox_IshTxt.Location = new System.Drawing.Point(319, 216);
      this.richTextBox_IshTxt.Name = "richTextBox_IshTxt";
      this.richTextBox_IshTxt.Size = new System.Drawing.Size(771, 121);
      this.richTextBox_IshTxt.TabIndex = 18;
      this.richTextBox_IshTxt.Text = "";
      // 
      // richTextBox_EncrTxt
      // 
      this.richTextBox_EncrTxt.Location = new System.Drawing.Point(319, 379);
      this.richTextBox_EncrTxt.Name = "richTextBox_EncrTxt";
      this.richTextBox_EncrTxt.Size = new System.Drawing.Size(771, 112);
      this.richTextBox_EncrTxt.TabIndex = 19;
      this.richTextBox_EncrTxt.Text = "";
      // 
      // richTextBox_GenericKey
      // 
      this.richTextBox_GenericKey.Location = new System.Drawing.Point(319, 51);
      this.richTextBox_GenericKey.Name = "richTextBox_GenericKey";
      this.richTextBox_GenericKey.Size = new System.Drawing.Size(771, 120);
      this.richTextBox_GenericKey.TabIndex = 20;
      this.richTextBox_GenericKey.Text = "";
      // 
      // richTextBox_DecrFile
      // 
      this.richTextBox_DecrFile.Location = new System.Drawing.Point(319, 542);
      this.richTextBox_DecrFile.Name = "richTextBox_DecrFile";
      this.richTextBox_DecrFile.Size = new System.Drawing.Size(771, 131);
      this.richTextBox_DecrFile.TabIndex = 21;
      this.richTextBox_DecrFile.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1102, 696);
      this.Controls.Add(this.richTextBox_DecrFile);
      this.Controls.Add(this.richTextBox_GenericKey);
      this.Controls.Add(this.richTextBox_EncrTxt);
      this.Controls.Add(this.richTextBox_IshTxt);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.EncryptFile);
      this.Controls.Add(this.OpenFile);
      this.Controls.Add(this.GenerateKey);
      this.Controls.Add(this.textBox_IshKey);
      this.Name = "Form1";
      this.Text = "Потоковое шифрование";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private TextBox textBox_IshKey;
        private Button GenerateKey;
        private Button OpenFile;
        private Button EncryptFile;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox richTextBox_IshTxt;
        private RichTextBox richTextBox_EncrTxt;
        private RichTextBox richTextBox_GenericKey;
        private RichTextBox richTextBox_DecrFile;
    }
}