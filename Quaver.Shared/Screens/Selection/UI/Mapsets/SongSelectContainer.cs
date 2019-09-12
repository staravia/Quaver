using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Quaver.Shared.Graphics.Containers;
using Quaver.Shared.Helpers;
using Wobble.Bindables;
using Wobble.Graphics;
using Wobble.Graphics.Animations;
using Wobble.Graphics.Sprites;
using Wobble.Graphics.UI.Dialogs;
using Wobble.Input;

namespace Quaver.Shared.Screens.Selection.UI.Mapsets
{
    public abstract class SongSelectContainer<T> : PoolableScrollContainer<T>
    {
        public abstract SelectScrollContainerType Type { get; }

        /// <summary>
        ///     The index of the selected available item
        /// </summary>
        public BindableInt SelectedIndex { get; set; }

        /// <summary>
        ///     The height of the scroll container
        /// </summary>
        public static int HEIGHT { get; } = 880;

        /// <summary>
        /// </summary>
        private Sprite ScrollbarBackground { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="availableItems"></param>
        /// <param name="poolSize"></param>
        public SongSelectContainer(List<T> availableItems, int poolSize) : base(availableItems, poolSize, 0,
            new ScalableVector2(DrawableMapset.WIDTH, HEIGHT), new ScalableVector2(DrawableMapset.WIDTH,0))
        {
            PaddingBottom = 10;

            InputEnabled = true;
            EasingType = Easing.OutQuint;
            TimeToCompleteScroll = 1200;
            ScrollSpeed = 320;

            Alpha = 0;
            CreateScrollbar();

            SelectedIndex = new BindableInt(-1, 0, int.MaxValue);

            // ReSharper disable once VirtualMemberCallInConstructor
            SetSelectedIndex();

            PoolStartingIndex = GetPoolStartingIndex();
            SnapToSelected();
            CreatePool();
            PositionAndContainPoolObjects();
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            InputEnabled = GraphicsHelper.RectangleContains(ScreenRectangle, MouseManager.CurrentState.Position)
                           && DialogManager.Dialogs.Count == 0
                           && !KeyboardManager.CurrentState.IsKeyDown(Keys.LeftAlt)
                           && !KeyboardManager.CurrentState.IsKeyDown(Keys.RightAlt);

            if (DialogManager.Dialogs.Count == 0 && !KeyboardManager.CurrentState.IsKeyDown(Keys.LeftAlt) &&
                !KeyboardManager.CurrentState.IsKeyDown(Keys.RightAlt))
            {
                HandleInput(gameTime);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// </summary>
        public override void Destroy()
        {
            SelectedIndex?.Dispose();
            base.Destroy();
        }

        /// <summary>
        ///     Creates the scrollbar sprite and aligns it properly
        /// </summary>
        private void CreateScrollbar()
        {
            ScrollbarBackground = new Sprite()
            {
                Parent = this,
                Alignment = Alignment.MidRight,
                X = 30,
                Size = new ScalableVector2(4, Height - 50),
                Tint = ColorHelper.HexToColor("#474747")
            };

            MinScrollBarY = -805 - (int) Scrollbar.Height / 2;
            Scrollbar.Width = ScrollbarBackground.Width;
            Scrollbar.Parent = ScrollbarBackground;
            Scrollbar.Alignment = Alignment.BotCenter;
            Scrollbar.Tint = Color.White;
        }

        /// <summary>
        ///    Retrieves the starting index for the object pool
        /// </summary>
        /// <returns></returns>
        protected int GetPoolStartingIndex()
        {
            const int ITEMS_DISPLAYED_BEFORE_POOL_SHIFT = 5;

            var val = SelectedIndex.Value - ITEMS_DISPLAYED_BEFORE_POOL_SHIFT;

            if (SelectedIndex.Value <= 0)
                return 0;

            if (SelectedIndex.Value <= AvailableItems.Count - ITEMS_DISPLAYED_BEFORE_POOL_SHIFT)
                return val < 0 ? 0 : val;

            var proposed = AvailableItems.Count - PoolSize;
            return proposed < 0 ? 0 : proposed;
        }

        /// <summary>
        ///     Scrolls the container to the selected position
        /// </summary>
        protected void ScrollToSelected()
        {
            if (SelectedIndex.Value < 3)
                return;

            // Scroll the the place where the map is.
            var targetScroll = GetSelectedPosition();
            ScrollTo(targetScroll, 1800);
        }

        /// <summary>
        ///     Snaps the scroll container to the initial mapset.
        /// </summary>
        protected void SnapToSelected()
        {
            ContentContainer.Y = SelectedIndex.Value < 7 ? 0 : GetSelectedPosition();

            ContentContainer.Animations.Clear();
            PreviousContentContainerY = ContentContainer.Y;
            TargetY = PreviousContentContainerY;
            PreviousTargetY = PreviousContentContainerY;
        }

        /// <summary>
        ///     Destroys all of the objects in the pool and clears the list
        /// </summary>
        protected void DestroyAndClearPool()
        {
            Pool.ForEach(x => x.Destroy());
            Pool.Clear();
        }

        /// <summary>
        ///     Makes sure all of the objects in the pool are positioned properly
        ///     and contained in the container
        /// </summary>
        protected void PositionAndContainPoolObjects()
        {
            for (var i = 0; i < Pool.Count; i++)
            {
                Pool[i].Y = (PoolStartingIndex + i) * Pool[i].HEIGHT + PaddingTop;
                AddContainedDrawable(Pool[i]);
            }
        }

        /// <summary>
        ///     Gets the position of the selected item
        /// </summary>
        /// <returns></returns>
        protected abstract float GetSelectedPosition();

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        protected abstract override PoolableSprite<T> CreateObject(T item, int index);

        /// <summary>
        ///     Handles input for the scroll container
        /// </summary>
        /// <param name="gameTime"></param>
        protected abstract void HandleInput(GameTime gameTime);

        /// <summary>
        ///     Sets the appropriate index of the selected mapset
        /// </summary>
        protected abstract void SetSelectedIndex();
    }
}