using System;
using Quaver.API.Maps.Processors.Scoring;
using Quaver.Shared.Database.Maps;
using Quaver.Shared.Helpers;
using Quaver.Shared.Screens.Results.UI.Header.Contents;
using Quaver.Shared.Screens.Results.UI.Header.Contents.Tabs;
using Wobble.Bindables;
using Wobble.Graphics;
using Wobble.Graphics.Sprites;
using Wobble.Window;

namespace Quaver.Shared.Screens.Results.UI.Header
{
    public class ResultsScreenHeader : Container
    {
        /// <summary>
        /// </summary>
        private Map Map { get; }

        /// <summary>
        /// </summary>
        private Bindable<ScoreProcessor> Processor { get; }

        /// <summary>
        /// </summary>
        private Bindable<ResultsScreenTabType> ActiveTab { get; }

        /// <summary>
        /// </summary>
        private ResultsScreenHeaderBackground Background { get; set; }

        /// <summary>
        /// </summary>
        private ResultsScreenHeaderContentContainer Container { get; set; }

        /// <summary>
        /// </summary>
        public static int HEIGHT { get; } = 270;

        /// <summary>
        /// </summary>
        /// <param name="map"></param>
        /// <param name="processor"></param>
        /// <param name="activeTab"></param>
        public ResultsScreenHeader(Map map, Bindable<ScoreProcessor> processor, Bindable<ResultsScreenTabType> activeTab)
        {
            Map = map;
            Processor = processor;
            ActiveTab = activeTab;

            Size = new ScalableVector2(WindowManager.Width, HEIGHT);

            CreateBackground();
            CreateContentContainer();
        }

        /// <summary>
        /// </summary>
        private void CreateBackground() => Background = new ResultsScreenHeaderBackground(new ScalableVector2(Width, 208))
            { Parent = this };

        /// <summary>
        /// </summary>
        private void CreateContentContainer() => Container = new ResultsScreenHeaderContentContainer(Map, Processor, ActiveTab, 190)
        {
            Parent = this,
            Alignment = Alignment.BotCenter,
        };
    }
}