
namespace MODBS_CRC_Calculator
{
    public class CRCCalculator
    {
        // Simple method - shows algorithm concept
        public static ushort Calculate(byte[] data)
        {
            ushort crc = 0xFFFF;
            for (uint i = 0; i < data.Length; i++)
            {
                crc ^= data[i];

                for (byte bit = 0; bit < 8; bit++)
                {
                    if ((crc & 0x0001) > 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            return crc;
        }

        // Optimal method - uses hardcoded matching table
        public static ushort CalculateUsingTable(byte[] data)
        {
            ushort crc = 0xFFFF;
            for(int i = 0; i < data.Length;i++)
            {
                byte xor = (byte)(data[i] ^ crc);
                crc >>= 8;
                crc ^= LookupTables.CRCTable[xor];
            }
            return crc;
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
