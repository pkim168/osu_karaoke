using osu.Framework.Allocation;
using osu.Framework.Platform;

namespace osu_karaoke.Game.Tests.Visual
{
    public class TestSceneosu_karaokeGame : osu_karaokeTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        private osu_karaokeGame game;

        [BackgroundDependencyLoader]
        private void load(GameHost host)
        {
            game = new osu_karaokeGame();
            game.SetHost(host);

            Add(game);
        }
    }
}
