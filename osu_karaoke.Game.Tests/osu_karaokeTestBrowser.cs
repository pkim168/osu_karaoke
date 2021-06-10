using osu.Framework.Graphics;
using osu.Framework.Graphics.Cursor;
using osu.Framework.Platform;
using osu.Framework.Testing;

namespace osu_karaoke.Game.Tests
{
    public class osu_karaokeTestBrowser : osu_karaokeGameBase
    {
        protected override void LoadComplete()
        {
            base.LoadComplete();

            AddRange(new Drawable[]
            {
                new TestBrowser("osu_karaoke"),
                new CursorContainer()
            });
        }

        public override void SetHost(GameHost host)
        {
            base.SetHost(host);
            host.Window.CursorState |= CursorState.Hidden;
        }
    }
}
