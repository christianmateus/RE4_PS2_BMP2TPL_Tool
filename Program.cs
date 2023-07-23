using TPLUtil;

namespace RE4_PS2_TPL_BMP_Tool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args[1] == "to-bmp")
            {
                ConverterBMP converterBMP = new ConverterBMP();
                converterBMP.TPLtoBMP(args[0]);
            }
            else
            {
                ConverterBMP converterBMP = new ConverterBMP();
                converterBMP.BMPtoTPL(args[0]);
            }
        }
    }
}
