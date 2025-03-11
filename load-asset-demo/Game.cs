// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        const string assetFolder = "../../../../assets/";
        // 
        Texture2D texture =
            Graphics.LoadTexture(assetFolder + "graphics/raph 2d anim idle.png");

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Load asset demo");
            Window.SetSize(400, 400);

            string cwd = Directory.GetCurrentDirectory();
            Console.WriteLine($"DIRECTORY: {cwd}");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            Graphics.Draw(texture, 10, 10);
        }
    }

}
