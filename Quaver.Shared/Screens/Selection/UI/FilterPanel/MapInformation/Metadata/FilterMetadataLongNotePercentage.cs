using System;
using System.Globalization;
using Microsoft.Xna.Framework;
using Quaver.API.Helpers;
using Quaver.Shared.Database.Maps;
using Quaver.Shared.Helpers;
using Quaver.Shared.Modifiers;
using Wobble.Bindables;

namespace Quaver.Shared.Screens.Selection.UI.FilterPanel.MapInformation.Metadata
{
    public class FilterMetadataLongNotePercentage : TextKeyValue
    {
        public FilterMetadataLongNotePercentage() : base("LNs:", "10%", 20, ColorHelper.HexToColor($"#ffe76b"))
        {
            if (MapManager.Selected.Value != null)
                Value.Text = $"{GetPercentage()}";

            MapManager.Selected.ValueChanged += OnMapChanged;
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public override void Destroy()
        {
            // ReSharper disable once DelegateSubtraction
            MapManager.Selected.ValueChanged -= OnMapChanged;

            base.Destroy();
        }

        private void OnMapChanged(object sender, BindableValueChangedEventArgs<Map> e) => SetText();

        private string GetPercentage()
        {
            if (MapManager.Selected.Value == null)
                return "0%";

            return ((int) MapManager.Selected.Value.LNPercentage).ToString(CultureInfo.InvariantCulture) + "%";
        }

        private void SetText() => ScheduleUpdate(() => Value.Text = GetPercentage());
    }
}