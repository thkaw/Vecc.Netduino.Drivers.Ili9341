using SecretLabs.NETMF.Hardware.NetduinoPlus;
using System.Threading;

namespace Vecc.Netduino.Drivers.Ili9341.Sandbox
{
    public class Program
    {
        public static void Main()
        {
            var tft = new Driver(isLandscape: false,
                                 lcdChipSelectPin: Pins.GPIO_PIN_D10,
                                 dataCommandPin: Pins.GPIO_PIN_A2,
                                 resetPin: Pins.GPIO_PIN_A1);
            var font = new StandardFixedWidthFont();
            tft.ClearScreen();
            tft.DrawString(10, 10, "NETDUINO PLUS 2", 0xF800, font);
            tft.DrawString(10, 50, "ILI9341 TFT TESTING PASS!", 0xF800, font);
            tft.DrawString(10, 90, "  WWW.NTEX.TW", 0xF800, font); 
            tft.DrawLine(20, 170, 210, 170, 0x0F00);
            tft.DrawRectangle(20, 180, 200, 50, 0x0f00);
            tft.FillScreen(22, 218, 180, 230, 0xfff0); 
            tft.BacklightOn = true;

            int i = 0;
            while (true) {
                Thread.Sleep(1000);
                tft.DrawString(10, 90, "  WWW.NTEX.TW  ", 0xF800, font);
            Thread.Sleep(1000);
            tft.DrawString(10, 90, ">>WWW.NTEX.TW<<", 0xF800, font);
            tft.DrawString(10, 120, i.ToString(), 0x0FF0, font);
            i++;
            }
        }
    }
}
