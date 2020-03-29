using System;
using Veldrid;
using Veldrid.Sdl2;
using Veldrid.StartupUtilities;

namespace Veldrid4Fun
{
    class Program
    {

        private static GraphicsDevice _graphicsDevice;
        static void Main(string[] args)
        {
            WindowCreateInfo windowCI = new WindowCreateInfo()
            {
                X = 100,
                Y = 100,
                WindowWidth = 960,
                WindowHeight = 540,
                WindowTitle = "Veldrid Tutorial"
            };
            Sdl2Window window = VeldridStartup.CreateWindow(ref windowCI);

            _graphicsDevice = VeldridStartup.CreateGraphicsDevice(window);

            while (window.Exists)
            {
                window.PumpEvents();
            }

        }
    }
}
