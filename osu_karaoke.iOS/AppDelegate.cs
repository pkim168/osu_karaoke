// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using Foundation;
using osu.Framework.iOS;
using osu_karaoke.Game;

namespace osu_karaoke.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : GameAppDelegate
    {
        protected override osu.Framework.Game CreateGame() => new osu_karaokeGame();
    }
}
