using FontStashSharp;
using Microsoft.Xna.Framework;
using Quaver.Shared.Database.Maps;
using Quaver.Shared.Helpers;
using Quaver.Shared.Screens.Selection.UI.Mapsets.Maps.Components;
using Quaver.Shared.Screens.Selection.UI.Mapsets.Maps.Components.Difficulty;
using Wobble;
using Wobble.Graphics;
using Wobble.Screens;
using Alignment = Wobble.Graphics.Alignment;

namespace Quaver.Shared.Screens.Tests.DifficultyBars
{
    public class TestScreenDifficultyBarView : ScreenView
    {
        public TestScreenDifficultyBarView(Screen screen) : base(screen)
        {
            var map = new Map()
            {
                Artist = "Swan",
                Title = "Left Right",
                DifficultyName = "Hard",
                Difficulty10X = 27,
                Difficulty15X = 23
            };

            new DifficultyBarDisplay(map)
            {
                Parent = Container,
                Alignment = Alignment.MidCenter,
                Y = -200
            };

            new CachedDifficultyBarDisplay(new DifficultyBarDisplay(map, false, true))
            {
                Parent = Container,
               Alignment = Alignment.MidCenter,
            };
        }

        public override void Update(GameTime gameTime) => Container?.Update(gameTime);

        public override void Draw(GameTime gameTime)
        {
            GameBase.Game.GraphicsDevice.Clear(ColorHelper.HexToColor("#000000"));
            Container?.Draw(gameTime);
        }

        public override void Destroy() => Container?.Destroy();
    }
}