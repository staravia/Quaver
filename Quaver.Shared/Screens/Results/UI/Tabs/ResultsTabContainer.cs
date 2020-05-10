using Quaver.API.Maps.Processors.Scoring;
using Quaver.Server.Client.Structures;
using Quaver.Shared.Database.Maps;
using Quaver.Shared.Graphics.Menu.Border;
using Quaver.Shared.Screens.Results.UI.Header;
using Quaver.Shared.Screens.Results.UI.Header.Contents.Tabs;
using Wobble.Bindables;
using Wobble.Graphics;
using Wobble.Graphics.Sprites;
using Wobble.Window;

namespace Quaver.Shared.Screens.Results.UI.Tabs
{
    public class ResultsTabContainer : Sprite
    {
        /// <summary>
        /// </summary>
        protected Map Map { get; }

        /// <summary>
        /// </summary>
        protected Bindable<ScoreProcessor> Processor { get; }

        /// <summary>
        /// </summary>
        protected Bindable<ResultsScreenTabType> ActiveTab { get; }

        /// <summary>
        /// </summary>
        protected Bindable<bool> IsSubmittingScore { get; }

        /// <summary>
        /// </summary>
        protected Bindable<ScoreSubmissionResponse> ScoreSubmissionStats { get; }

        /// <summary>
        /// </summary>
        public static int PADDING_Y = 50;

        /// <summary>
        /// </summary>
        public static int PADDING_X = 10;

        /// <summary>
        /// </summary>
        /// <param name="map"></param>
        /// <param name="processor"></param>
        /// <param name="activeTab"></param>
        /// <param name="isSubmittingScore"></param>
        /// <param name="scoreSubmissionStats"></param>
        public ResultsTabContainer(Map map, Bindable<ScoreProcessor> processor, Bindable<ResultsScreenTabType> activeTab,
            Bindable<bool> isSubmittingScore, Bindable<ScoreSubmissionResponse> scoreSubmissionStats)
        {
            Map = map;
            Processor = processor;
            ActiveTab = activeTab;
            IsSubmittingScore = isSubmittingScore;
            ScoreSubmissionStats = scoreSubmissionStats;

            var height = WindowManager.Height - MenuBorder.HEIGHT * 2 - ResultsScreenHeader.HEIGHT - PADDING_Y;
            Size = new ScalableVector2(ResultsScreenView.CONTENT_WIDTH, height);
            Alpha = 0;
        }
    }
}