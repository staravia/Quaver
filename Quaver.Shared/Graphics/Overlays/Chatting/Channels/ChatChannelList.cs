using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Quaver.Server.Client.Structures;
using Quaver.Shared.Assets;
using Quaver.Shared.Graphics.Form.Checkboxes;
using Quaver.Shared.Graphics.Overlays.Chatting.Channels.Join;
using Quaver.Shared.Graphics.Overlays.Chatting.Channels.Scrolling;
using Quaver.Shared.Helpers;
using TagLib.Id3v2;
using Wobble.Bindables;
using Wobble.Graphics;
using Wobble.Graphics.Sprites;
using Wobble.Graphics.Sprites.Text;
using Wobble.Graphics.UI.Buttons;
using Wobble.Input;
using Wobble.Managers;

namespace Quaver.Shared.Graphics.Overlays.Chatting.Channels
{
    public class ChatChannelList : Sprite, IResizable
    {
        /// <summary>
        /// </summary>
        private Bindable<ChatChannel> ActiveChannel { get; }

        /// <summary>
        /// </summary>
        public ImageButton HeaderBackground { get; private set; }

        /// <summary>
        /// </summary>
        private SpriteTextPlus HeaderText { get; set; }

        /// <summary>
        /// </summary>
        private JoinChatButton JoinChatButton { get; set; }

        /// <summary>
        /// </summary>
        public ChatChannelScrollContainer ChannelContainer { get; private set; }

        /// <summary>
        /// </summary>
        /// <param name="activeChannel"></param>
        /// <param name="size"></param>
        public ChatChannelList(Bindable<ChatChannel> activeChannel, ScalableVector2 size)
        {
            ActiveChannel = activeChannel;

            Tint = ColorHelper.HexToColor("#242424");
            Size = size;

            CreateHeaderBackground();
            CreateHeaderText();
            CreateJoinChatButton();
            CreateChannelContainer();
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            HeaderBackground.Depth = JoinChatButton.IsHovered() ? 1 : 0;
            base.Update(gameTime);
        }

        /// <summary>
        /// </summary>
        private void CreateHeaderBackground()
        {
            HeaderBackground = new ImageButton(UserInterface.HubHeaderBackground)
            {
                Parent = this,
                Size = new ScalableVector2(Width, 56),
            };
        }

        /// <summary>
        /// </summary>
        private void CreateHeaderText()
        {
            HeaderText = new SpriteTextPlus(FontManager.GetWobbleFont(Fonts.LatoBlack), "Chat Channels".ToUpper(), 21)
            {
                Parent = HeaderBackground,
                Alignment = Alignment.MidLeft,
                X = 16
            };
        }

        /// <summary>
        /// </summary>
        private void CreateJoinChatButton()
        {
            JoinChatButton = new JoinChatButton()
            {
                Parent = HeaderBackground,
                Alignment = Alignment.MidRight,
                X = -HeaderText.X,
                Size = new ScalableVector2(20, 20)
            };
        }

        /// <summary>
        /// </summary>
        private void CreateChannelContainer()
        {
            ChannelContainer = new ChatChannelScrollContainer(ActiveChannel, HeaderBackground.Height,
                new ScalableVector2(Width, Height - HeaderBackground.Height))
            {
                Parent = this,
                Y = HeaderBackground.Height
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="size"></param>
        public void ChangeSize(ScalableVector2 size)
        {
            Height = size.X.Value;

            foreach (var child in Children)
            {
                if (child is IResizable c)
                    c.ChangeSize(size);
            }
        }
    }
}