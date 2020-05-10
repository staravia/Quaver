using Microsoft.Xna.Framework;
using Quaver.Shared.Helpers;
using Wobble.Graphics.Animations;
using Wobble.Graphics.Sprites.Text;

namespace Quaver.Shared.Screens.Selection.UI.Playlists
{
    public class PlaylistDifficultyDisplay : PlaylistKeyValueDisplay
    {
        public SpriteTextPlus Dash { get; }

        public SpriteTextPlus MaxDifficulty { get; private set; }

        public PlaylistDifficultyDisplay(string key = null) : base(key ?? "Difficulty:", "0", Color.White, false)
        {
            Dash = new SpriteTextPlus(Key.Font, "-", Key.FontSize)
            {
                Parent = this,
                UsePreviousSpriteBatchOptions = true,
                Tint = Key.Tint
            };

            MaxDifficulty = new SpriteTextPlus(Value.Font, "0", Value.FontSize)
            {
                Parent = this,
                UsePreviousSpriteBatchOptions = true
            };
        }

        /// <summary>
        ///     Changes the min/max difficulty values
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void ChangeValue(double min, double max)
        {
            const int spacing = 4;

            Value.Text = StringHelper.RatingToString(min);
            Value.Tint = ColorHelper.DifficultyToColor((float) min);

            Dash.X = Value.X + Value.Width + spacing;

            MaxDifficulty.Text = StringHelper.RatingToString(max);
            MaxDifficulty.Tint = ColorHelper.DifficultyToColor((float) max);

            MaxDifficulty.X = Dash.X + Dash.Width + spacing;

            base.UpdateSize();
        }

        public void Fade(float alpha, int time)
        {
            foreach (var child in Children)
            {
                if (child is SpriteTextPlus s)
                {
                    s.ClearAnimations();
                    s.FadeTo(alpha, Easing.Linear, time);
                }
            }
        }
    }
}