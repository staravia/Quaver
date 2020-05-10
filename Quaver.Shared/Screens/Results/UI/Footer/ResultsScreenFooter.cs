using System.Collections.Generic;
using Quaver.Shared.Graphics.Menu.Border;
using Quaver.Shared.Graphics.Menu.Border.Components.Buttons;
using Quaver.Shared.Online;
using Wobble.Graphics;

namespace Quaver.Shared.Screens.Results.UI.Footer
{
    public class ResultsScreenFooter : MenuBorder
    {
        public ResultsScreenFooter(ResultsScreen screen) : base(MenuBorderType.Footer, new List<Drawable>
            {
                new ResultsFooterBackButton(screen),
                new IconTextButtonOptions(),
            }, new List<Drawable>())
        {
            if (OnlineManager.CurrentGame == null)
            {
                RightAlignedItems.Add(new ResultsFooterRetryButton(screen));
                RightAlignedItems.Add(new ResultsFooterWatchReplayButton(screen));
                RightAlignedItems.Add(new ResultsFooterExportReplayButton(screen));
            }

            if (screen.ScreenType == ResultsScreenType.Gameplay && screen.Gameplay.LoadedReplay == null)
                LeftAlignedItems.Add(new ResultsFooterFixOffsetButton(screen));

            AlignRightItems();
            AlignLeftItems();
        }
    }
}