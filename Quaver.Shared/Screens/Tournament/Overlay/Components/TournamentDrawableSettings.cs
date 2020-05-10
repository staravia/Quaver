using System;
using IniFileParser.Model;
using Microsoft.Xna.Framework;
using Quaver.Shared.Assets;
using Quaver.Shared.Config;
using Wobble.Bindables;
using Wobble.Graphics;

namespace Quaver.Shared.Screens.Tournament.Overlay.Components
{
    public class TournamentDrawableSettings : IDisposable
    {
        /// <summary>
        ///     The name/prefix of the drawable
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     If the drawable is visible
        /// </summary>
        public Bindable<bool> Visible { get; } = new Bindable<bool>(true);

        /// <summary>
        ///     The font size of the text if this drawable is text
        /// </summary>
        public BindableInt FontSize { get; } = new BindableInt(22, 1, int.MaxValue);

        /// <summary>
        ///     The position of the drawable
        /// </summary>
        public Bindable<Vector2> Position { get; } = new Bindable<Vector2>(new Vector2(0, 0));

        /// <summary>
        ///     The alignment of the drawable
        /// </summary>
        public Bindable<Alignment> Alignment { get; } = new Bindable<Alignment>(Wobble.Graphics.Alignment.TopLeft);

        /// <summary>
        ///     The color/tint of the drawable
        /// </summary>
        public Bindable<Color> Tint { get; } = new Bindable<Color>(Color.White);

        /// <summary>
        ///     If the drawable will display as inverted. Not applicable for all
        /// </summary>
        public Bindable<bool> Inverted { get; } = new Bindable<bool>(false);

        /// <summary>
        ///     The font to be used for the text
        /// </summary>
        public Bindable<string> Font { get; } = new Bindable<string>(Fonts.LatoBlack);

        /// <summary>
        ///     If true, the value will dim when the individual player is losing
        /// </summary>
        public Bindable<bool> DimWhenLosing { get; } = new Bindable<bool>(false);

        /// <summary>
        ///     The font size when the user is losing if <see cref="DimWhenLosing"/> is true
        /// </summary>
        public BindableInt FontSizeWhenLosing { get; } = new BindableInt(20, 1, int.MaxValue);

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        public TournamentDrawableSettings(string name)
        {
            Name = name;
        }

        public virtual void Load(KeyDataCollection ini)
        {
            Visible.Value = ConfigHelper.ReadBool(Visible.Default, ini[$"{Name}Visible"]);
            Font.Value = ini[$"{Name}Font"];
            FontSize.Value = ConfigHelper.ReadInt32(FontSize.Default, ini[$"{Name}FontSize"]);
            Position.Value = ConfigHelper.ReadVector2(Position.Default, ini[$"{Name}Position"]);
            Alignment.Value = ConfigHelper.ReadEnum(Alignment.Default, ini[$"{Name}Alignment"]);
            Tint.Value = ConfigHelper.ReadColor(Tint.Default, ini[$"{Name}Color"]);
            Inverted.Value = ConfigHelper.ReadBool(Inverted.Default, ini[$"{Name}Inverted"]);
            DimWhenLosing.Value = ConfigHelper.ReadBool(DimWhenLosing.Default, ini[$"{Name}DimWhenLosing"]);
            FontSizeWhenLosing.Value = ConfigHelper.ReadInt32(FontSizeWhenLosing.Default, ini[$"{Name}FontSizeWhenLosing"]);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public virtual void Dispose()
        {
            Visible?.Dispose();
            FontSize?.Dispose();
            Position?.Dispose();
            Alignment?.Dispose();
            Tint.Dispose();
            Inverted.Dispose();
            Font.Dispose();
            DimWhenLosing.Dispose();
            FontSizeWhenLosing.Dispose();
        }
    }
}