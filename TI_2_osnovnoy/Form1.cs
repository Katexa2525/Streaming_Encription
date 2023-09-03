using System.Text;
using TI_2;

namespace TI_2_osnovnoy
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      textBox_IshKey.MaxLength = 35;
    }
    private static string _filePath = String.Empty;

    private void GenerateKey_Click(object sender, EventArgs e)
    {
      if (textBox_IshKey.Text == String.Empty)
      {
        MessageBox.Show("Ошибка. Необходимо ввести начальное состояние для регистра!");
        return;
      }
      if (textBox_IshKey.Text== "00000000000000000000000000000000000")
      {
        MessageBox.Show("0 вводить нельзя!");
        return;
      }
      if (richTextBox_IshTxt.Text == String.Empty)
      {
        MessageBox.Show("Ошибка. Необходимо выбрать файл для шифрования!");
        return;
      }

      if (textBox_IshKey.Text.Length != LFSR.REGISTER_SIZE)
      {
        MessageBox.Show("Ошибка. Число разрядов регистра - 35!");
        return;
      }

      richTextBox_GenericKey.Text = LFSR.TextFromBin(LFSR.FormKey(
          textBox_IshKey.Text, richTextBox_IshTxt.Text.Length));
    }

    private void OpenFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();

      if (ofd.ShowDialog() == DialogResult.OK)
      {
        _filePath = ofd.FileName;
        byte[] bytes = File.ReadAllBytes(ofd.FileName);
        StringBuilder sb = new StringBuilder();
        foreach (byte b in bytes)
        {
          string tmp = Convert.ToString(b, 2);
          sb.Append("00000000"[..(8 - tmp.Length)] + tmp); //append добавляет подстроку тмп из 8 бит
        }
        richTextBox_IshTxt.Text = sb.ToString();
      }
    }

    private void EncryptFile_Click(object sender, EventArgs e)
    {
      if (richTextBox_GenericKey.Text == String.Empty)
      {
        MessageBox.Show("Ошибка. Необходимо сгенерировать ключ шифрования!");
        return;
      }
      //зашифровываем
      richTextBox_EncrTxt.Text = LFSR.TextFromBin(LFSR.Encrypt(
          LFSR.BinTextForm(richTextBox_IshTxt.Text), LFSR.BinTextForm(richTextBox_GenericKey.Text)));

      string fileName = System.IO.Path.GetDirectoryName(_filePath) + '\\' + "Encrypt_" +
          System.IO.Path.GetFileName(_filePath);
      File.WriteAllBytes(fileName, LFSR.BinTextForm(richTextBox_EncrTxt.Text));

      //расшифровываем
      richTextBox_DecrFile.Text = LFSR.TextFromBin(LFSR.Encrypt(
          LFSR.BinTextForm(richTextBox_EncrTxt.Text), LFSR.BinTextForm(richTextBox_GenericKey.Text)));

      string fileName1 = System.IO.Path.GetDirectoryName(_filePath) + '\\' + "Decrypt_" +
          System.IO.Path.GetFileName(_filePath);
      File.WriteAllBytes(fileName1, LFSR.BinTextForm(richTextBox_DecrFile.Text));
    }

    private void textBox_IshKey_KeyPress(object sender, KeyPressEventArgs e)
    {
      char number = e.KeyChar;
      if (!char.IsDigit(number) || (char.IsDigit(number) && (number != '0' && number != '1')))
      {
        e.Handled = true;
      }
    }
  }
}