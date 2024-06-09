
using System;
using System.Windows.Forms;

namespace MODBS_CRC_Calculator
{
    public class CRCCalculator
    {
        public static ushort Calculate(byte[] data)
        {
            ushort hiByte = 0xFF;
            ushort loByte = 0xFF;
            ushort index;
            for (int i = 0; i < data.Length; i++)
            {
                index = (ushort)(hiByte ^ data[i]);
                hiByte = (ushort)(loByte ^ LookupTables.aCRCHi[index]);
                loByte = LookupTables.aCRCLo[index];
            }
            return (ushort)(hiByte << 8 | loByte);
        }

        public static byte[] HexStrToByteArray(string hexInput)
        {
            List<byte> bytes = [];
            int passedChars = 0;

            if(hexInput.Length >= 2)
            {
                while (passedChars < hexInput.Length - 1)
                {
                    string byteHex = hexInput.Substring(passedChars, 2);
                    bytes.Add(Convert.ToByte(byteHex, 16));
                    passedChars += 2;
                }
            }

            if(hexInput.Length > passedChars)
            {
                string hexChar = hexInput[hexInput.Length-1].ToString();
                bytes.Add(Convert.ToByte(hexChar,16));
            }

            return bytes.ToArray();
        }
    }
}
