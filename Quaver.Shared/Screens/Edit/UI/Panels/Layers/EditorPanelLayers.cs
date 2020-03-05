using Quaver.API.Maps;
using Quaver.API.Maps.Structures;
using Quaver.Shared.Assets;
using Quaver.Shared.Graphics.Notifications;
using Quaver.Shared.Screens.Edit.Actions;
using Quaver.Shared.Screens.Edit.Actions.Layers.Create;
using Quaver.Shared.Screens.Edit.Actions.Layers.Remove;
using Quaver.Shared.Screens.Menu.UI.Jukebox;
using Wobble.Bindables;
using Wobble.Graphics;

namespace Quaver.Shared.Screens.Edit.UI.Panels.Layers
{
    public class EditorPanelLayers : EditorPanel
    {
        private Qua WorkingMap { get; }

        private Bindable<EditorLayerInfo> SelectedLayer { get; }

        private IconButton DeleteLayer { get; set; }

        private IconButton CreateLayer { get; set; }

        private EditorPanelLayersScrollContainer ScrollContainer { get; set; }

        private EditorLayerInfo DefaultLayer { get; }

        private EditorActionManager ActionManager { get; }

        private BindableList<HitObjectInfo> SelectedHitObjects { get; }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public EditorPanelLayers(EditorActionManager actionManager, Qua workingMap, Bindable<EditorLayerInfo> selectedLayer,
            EditorLayerInfo defaultLayer, BindableList<HitObjectInfo> selectedHitObjects) : base("Layers")
        {
            ActionManager = actionManager;
            WorkingMap = workingMap;
            SelectedLayer = selectedLayer;
            DefaultLayer = defaultLayer;
            SelectedHitObjects = selectedHitObjects;

            Depth = 1;

            CreateDeleteButton();
            CreateAddButton();
            CreateScrollContainer();
        }

        /// <summary>
        ///     Creates <see cref="DeleteLayer"/>
        /// </summary>
        private void CreateDeleteButton()
        {
            DeleteLayer = new IconButton(UserInterface.EditorDeleteLayer)
            {
                Parent = Header,
                Alignment = Alignment.MidRight,
                Size = new ScalableVector2(20, 20),
                X = -HeaderText.X
            };

            DeleteLayer.Clicked += (sender, args) =>
            {
                if (SelectedLayer.Value == DefaultLayer || SelectedLayer.Value == null)
                {
                    NotificationManager.Show(NotificationLevel.Warning, "You cannot delete the default layer!");
                    return;
                }

                ActionManager.Perform(new EditorActionRemoveLayer(ActionManager, WorkingMap, SelectedHitObjects, SelectedLayer.Value));
            };
        }

        /// <summary>
        ///     Creates <see cref="CreateLayer"/>
        /// </summary>
        private void CreateAddButton()
        {
            CreateLayer = new IconButton(UserInterface.EditorCreateLayer)
            {
                Parent = Header,
                Alignment = Alignment.MidRight,
                Size = DeleteLayer.Size,
                X = DeleteLayer.X - DeleteLayer.Width + DeleteLayer.X
            };

            CreateLayer.Clicked += (sender, args) =>
            {
                var layer = new EditorLayerInfo
                {
                    Name = $"Layer {WorkingMap.EditorLayers.Count + 1}",
                    ColorRgb = "255,255,255"
                };

                ActionManager.Perform(new EditorActionCreateLayer(WorkingMap, ActionManager, SelectedHitObjects, layer));
            };
        }

        /// <summary>
        ///     Creates <see cref="ScrollContainer"/>
        /// </summary>
        private void CreateScrollContainer()
        {
            ScrollContainer = new EditorPanelLayersScrollContainer(ActionManager, WorkingMap, SelectedLayer, DefaultLayer,
                new ScalableVector2(Content.Width - 7, Content.Height - 8))
            {
                Parent = Content,
                X = 4
            };
        }
    }
}