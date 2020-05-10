using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Quaver.Shared.Assets;
using Quaver.Shared.Graphics.Menu.Border.Components;
using Quaver.Shared.Graphics.Notifications;
using Quaver.Shared.Screens.Selection.UI.Mapsets;
using Quaver.Shared.Screens.Selection.UI.Playlists.Dialogs.Create;
using Wobble.Graphics.Sprites.Text;
using Wobble.Graphics.UI.Dialogs;
using Wobble.Managers;

namespace Quaver.Shared.Screens.Selection.UI.Borders.Footer
{
    public class IconTextButtonCreatePlaylist : IconTextButton
    {
        public IconTextButtonCreatePlaylist() : base(FontAwesome.Get(FontAwesomeIcon.fa_plus_black_symbol),
            FontManager.GetWobbleFont(Fonts.LatoBlack),"Create Playlist", (sender, args) =>
            {
                DialogManager.Show(new CreatePlaylistDialog());
            })
        {
        }
    }
}