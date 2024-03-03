using System;
using System.Threading;
using System.Windows.Input;
using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;

class Program
{
    public static IXbox360Controller ds4;
    [STAThread]
    static void doeditthing()
    {
        while (true)
        {
            if (Keyboard.IsKeyDown(Key.E))
            {
                ds4.SetButtonState(Xbox360Button.B, true);

                ds4.SetButtonState(Xbox360Button.B, false);
            }
        }
    }
    [STAThread]
    static void Main(string[] args)
    {
        Thread.Sleep(3000);

        // Create a new ViGEm client
        var client = new ViGEmClient();

        // Create a new PS4 controller
        ds4 = client.CreateXbox360Controller();

        // Connect the controller
        ds4.Connect();
        Thread thr = new Thread(doeditthing);
        thr.SetApartmentState(ApartmentState.STA);
        thr.Start();

        while (true)
        {
            ds4.SetButtonState(Xbox360Button.Up, true);
            Thread.Sleep(1);
            ds4.SetButtonState(Xbox360Button.Up, false);
            if (Keyboard.IsKeyDown(Key.L))
            {
                ds4.Disconnect();
                thr.Abort();
                break;
            }

        }
    }
}