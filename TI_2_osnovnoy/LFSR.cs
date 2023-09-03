using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_2
{
  static class LFSR
  {
    public const int REGISTER_SIZE = 35;
    static byte[] register = new byte[REGISTER_SIZE];

    //заполняем регистр
    private static void FillRegister(string initStr)
    {
      for (int i = 0; i < initStr.Length; i++)
      {
        register[i] = byte.Parse(initStr[i].ToString());
      }
    }

    //получение текста из двоичной формы
    public static string TextFromBin(List<byte> bytes)
    {
      StringBuilder sb = new StringBuilder();
      foreach (byte b in bytes)
      {
        string tmp = Convert.ToString(b, 2);
        sb.Append("00000000"[..(8 - tmp.Length)] + tmp);
      }
      return sb.ToString();
    }

    //сдвиг регистра влево
    private static byte ShiftReg(byte[] reg)
    {
      byte olderBit = reg[0];
      byte oldSecondBit = reg[33];

      for (int i = 0; i < REGISTER_SIZE - 1; i++)
        reg[i] = reg[i + 1];

      //ставим новое значение на пустую ячейку
      reg[REGISTER_SIZE - 1] = (byte)(olderBit ^ oldSecondBit);

      return olderBit;
    }

    //Формируем ключ. Первый параметр - начальное состояние регистра сдвига, второе - длина текста
    public static List<byte> FormKey(string initStateStr, int length)
    {
      List<byte> key = new List<byte>();
      FillRegister(initStateStr);
      byte[] shiftRegister = register;
      int i = 0;

      while (length > 0)
      {
        key.Add(ShiftReg(shiftRegister));
        byte b = 0;
        int count = 7;

        while (length > 0 && count > 0)
        {
          key[i] = (byte)(key[i] << 1);
          b = ShiftReg(shiftRegister);
          key[i] |= b;
          count--;
          length--;
        }
        i++;
        length--;
      }
      return key;
    }

    //бинарная форма записи
    public static byte[] BinTextForm(string plaintext)
    {
      byte b = 0;
      int j = 0;
      int binTextSize = plaintext.Length / 8;
      byte[] binText = new byte[binTextSize];

      for (int i = 0; i < plaintext.Length; i++)
      {
        binText[j] = byte.Parse(plaintext[i].ToString());

        int count = 7;
        while (i < plaintext.Length - 1 && count > 0)
        {
          binText[j] = (byte)(binText[j] << 1);
          i++;
          b = byte.Parse(plaintext[i].ToString());
          binText[j] |= b;
          count--;
        }
        j++;
      }
      return binText;
    }

    //шифрование\дешифрование
    public static List<byte> Encrypt(byte[] plaintextBin, byte[] keyBin)
    {
      List<byte> resultBin = new List<byte>();

      for (int i = 0; i < plaintextBin.Length; i++)
        resultBin.Add((byte)(plaintextBin[i] ^ keyBin[i]));
      return resultBin;
    }
  }
}
