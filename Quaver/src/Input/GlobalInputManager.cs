﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagedBass;
using Microsoft.Xna.Framework.Input;
using Quaver.GameState;
using Quaver.Main;

namespace Quaver.Input
{
    internal class GlobalInputManager : IInputManager
    {
        /// <summary>
        ///     The current state for the specifc input manager
        /// </summary>
        public State CurrentState { get; set; } // Global State, so this isn't necessary.

        /// <summary>
        ///     The current keyboard state.
        /// </summary>
        public KeyboardState KeyboardState { get; set; }

        /// <summary>
        ///     The current Mouse State
        /// </summary>
        public MouseState MouseState { get; set; }

        /// <summary>
        ///     Keeps track of the last scroll wheel value.
        /// </summary>
        private int LastScrollWheelValue { get; set; }

        /// <summary>
        ///     Check the input.
        /// </summary>
        public void CheckInput()
        {
            // Get the two states of the keyboard.
            KeyboardState = Keyboard.GetState();
            MouseState = Mouse.GetState();

            HandleVolumeChanges();
        }

        /// <summary>
        ///     Handles all global volume changes.
        ///     For this to be activated, the user must be holding down either ALT key while they are scrolling the mouse.
        /// </summary>
        private void HandleVolumeChanges()
        {
            //  Raise volume if the user scrolls up.
            if (MouseState.ScrollWheelValue > LastScrollWheelValue 
                && (KeyboardState.IsKeyDown(Keys.RightAlt) || KeyboardState.IsKeyDown(Keys.LeftAlt)) 
                && Config.Configuration.VolumeGlobal < 100)
            {
                Config.Configuration.VolumeGlobal += 5;

                // Set the last scroll wheel value
                LastScrollWheelValue = MouseState.ScrollWheelValue;

                // Change the audio volume based on the new config value.
                GameBase.SelectedBeatmap.Song.ChangeAudioVolume();
                Console.WriteLine($"[CONFIG MANAGER] VolumeGlobal Changed To: {Config.Configuration.VolumeGlobal}");
            }
            // Lower volume if the user scrolls down
            else if (MouseState.ScrollWheelValue < LastScrollWheelValue 
                && (KeyboardState.IsKeyDown(Keys.RightAlt) || KeyboardState.IsKeyDown(Keys.LeftAlt)) 
                && Config.Configuration.VolumeGlobal > 0)
            {
                Config.Configuration.VolumeGlobal -= 5;

                // Set the last scroll wheel value
                LastScrollWheelValue = MouseState.ScrollWheelValue;

                // Change the audio volume based on the new config value.
                GameBase.SelectedBeatmap.Song.ChangeAudioVolume();
                Console.WriteLine($"[CONFIG MANAGER] VolumeGlobal Changed To: {Config.Configuration.VolumeGlobal}");
            }
        }
    }
}