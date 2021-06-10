using osu.Framework.Testing;

namespace osu_karaoke.Game.Tests.Visual
{
    public class osu_karaokeTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new osu_karaokeTestSceneTestRunner();

        private class osu_karaokeTestSceneTestRunner : osu_karaokeGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
