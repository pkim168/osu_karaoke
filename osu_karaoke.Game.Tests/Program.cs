using osu.Framework;
using osu.Framework.Platform;

namespace osu_karaoke.Game.Tests
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost("visual-tests"))
            using (var game = new osu_karaokeTestBrowser())
                host.Run(game);
        }
    }
}
