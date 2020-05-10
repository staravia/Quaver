/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 * Copyright (c) Swan & The Quaver Team <support@quavergame.com>.
*/

using System.Collections.Generic;
using System.IO;
using Wobble;
using Wobble.Graphics.BitmapFonts;
using Wobble.Graphics.Sprites.Text;
using Wobble.Managers;

namespace Quaver.Shared.Assets
{
    public static class Fonts
    {
        public static string Exo2Bold { get; } = "exo2-bold";
        public static string Exo2BoldItalic { get; } = "exo2-bolditalic";
        public static string Exo2Italic { get; } = "exo2-italic";
        public static string Exo2Light { get; } = "exo2-light";
        public static string Exo2Medium { get; } = "exo2-medium";
        public static string Exo2MediumItalic { get; } = "exo2-mediumitalic";
        public static string Exo2Regular { get; } = "exo2-regular";
        public static string Exo2SemiBold { get; } = "exo2-semibold";
        public static string Exo2SemiBoldItalic { get; } = "exo2-semibolditalic";
        public static string Exo2Thin { get; } = "exo2-thin";
        public static string Exo2ThinItalic { get; } = "exo2-thinitalic";
        public static string SourceSansProRegular { get; } = "sspro-regular";
        public static string SourceSansProBold { get; } = "sspro-bold";
        public static string SourceSansProSemiBold { get; } = "sspro-semibold";

        #region NEW_FONTS
        public static string LatoRegular { get; } = "Lato-Regular";
        public static string LatoSemiBold { get; } = "Lato-Semibold";
        public static string LatoBold { get; } = "Lato-Bold";
        public static string LatoLight { get; } = "Lato-Light";
        public static string LatoHeavy { get; } = "Lato-Heavy";
        public static string LatoBlack { get; } = "Lato-Black";

        #endregion

        /// <summary>
        ///     Loads all bitmap fonts.
        /// </summary>
        public static void LoadGdiFonts()
        {
            BitmapFontFactory.AddFont(Exo2Bold, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-bold.ttf"));
            BitmapFontFactory.AddFont(Exo2BoldItalic, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-bolditalic.ttf"));
            BitmapFontFactory.AddFont(Exo2Italic, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-italic.ttf"));
            BitmapFontFactory.AddFont(Exo2Light, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-light.ttf"));
            BitmapFontFactory.AddFont(Exo2Medium, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-medium.ttf"));
            BitmapFontFactory.AddFont(Exo2MediumItalic, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-mediumitalic.ttf"));
            BitmapFontFactory.AddFont(Exo2Regular, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-regular.ttf"));
            BitmapFontFactory.AddFont(Exo2SemiBold, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-semibold.ttf"));
            BitmapFontFactory.AddFont(Exo2SemiBoldItalic, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-semibolditalic.ttf"));
            BitmapFontFactory.AddFont(Exo2Thin, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-thin.ttf"));
            BitmapFontFactory.AddFont(Exo2ThinItalic, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/Exo2/exo2-thinitalic.ttf"));
            BitmapFontFactory.AddFont(SourceSansProRegular, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/SourceSansPro/sspro-regular.ttf"));
            BitmapFontFactory.AddFont(SourceSansProBold, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/SourceSansPro/sspro-bold.ttf"));
            BitmapFontFactory.AddFont(SourceSansProSemiBold, GameBase.Game.Resources.Get("Quaver.Resources/Fonts/SourceSansPro/sspro-semibold.ttf"));
        }

        /// <summary>
        /// </summary>
        public static void LoadWobbleFonts()
        {
            const string folder = "Quaver.Resources/Fonts";

            // Load fallback fonts or fonts that are used across multiple WobbleFonts
            const string emojiString = "Emoji";
            var emojiFont = GameBase.Game.Resources.Get($@"{folder}/NotoColorEmoji/NotoColorEmoji.ttf");

            const string cjkString = "CJK";
            var notoCjkFont = GameBase.Game.Resources.Get($@"{folder}/NotoCJK/noto-sans-cjk-black.ttf");

            // Lato-Regular
            FontManager.CacheWobbleFont(LatoRegular, new WobbleFontStore(20,
                GameBase.Game.Resources.Get($"{folder}/Lato/{LatoRegular}.ttf"), new Dictionary<string, byte[]>
                {
                    {emojiString, emojiFont},
                    {cjkString, notoCjkFont}
                }));

            // Lato-Semibold
            FontManager.CacheWobbleFont(LatoSemiBold, new WobbleFontStore(20,
                GameBase.Game.Resources.Get($"{folder}/Lato/{LatoSemiBold}.ttf"), new Dictionary<string, byte[]>
                {
                    {emojiString, emojiFont},
                    {cjkString, notoCjkFont}
                }));

            // Lato-Bold
            FontManager.CacheWobbleFont(LatoBold, new WobbleFontStore(20,
                GameBase.Game.Resources.Get($"{folder}/Lato/{LatoBold}.ttf"), new Dictionary<string, byte[]>
                {
                    {emojiString, emojiFont},
                    {cjkString, notoCjkFont}
                }));

            // Lato-Light
            FontManager.CacheWobbleFont(LatoLight, new WobbleFontStore(20,
                GameBase.Game.Resources.Get($"{folder}/Lato/{LatoLight}.ttf"), new Dictionary<string, byte[]>
                {
                    {emojiString, emojiFont},
                    {cjkString, notoCjkFont}
                }));

            // Lato-Heavy
            FontManager.CacheWobbleFont(LatoHeavy, new WobbleFontStore(20,
                GameBase.Game.Resources.Get($"{folder}/Lato/{LatoHeavy}.ttf"), new Dictionary<string, byte[]>
                {
                    {emojiString, emojiFont},
                    {cjkString, notoCjkFont}
                }));

            var latoBlack = GameBase.Game.Resources.Get($"{folder}/Lato/{LatoBlack}.ttf");

            // Lato-Black
            FontManager.CacheWobbleFont(LatoBlack, new WobbleFontStore(20, latoBlack, new Dictionary<string, byte[]>
                {
                    {emojiString, emojiFont},
                    {cjkString, notoCjkFont}
                }));

            var dir = $"{WobbleGame.WorkingDirectory}/Fonts";
            Directory.CreateDirectory(dir);

            // Copy over
            File.WriteAllBytes($"{dir}/lato-black.ttf", latoBlack);
        }
    }
}