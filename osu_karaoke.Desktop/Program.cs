using osu.Framework.Platform;
using osu.Framework;
using osu_karaoke.Game;

namespace osu_karaoke.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"osu_karaoke"))
            using (osu.Framework.Game game = new osu_karaokeGame())
                host.Run(game);
        }
    }
}
