using System;
using System.Linq;
using System.Numerics;
using ImGuiNET;
using MoonSharp.Interpreter;
using Quaver.API.Enums;
using Quaver.Shared.Scripting;

namespace Quaver.Shared.Screens.Edit.Plugins
{
    public class EditorPlugin : LuaImGui, IEditorPlugin
    {
        /// <summary>
        /// </summary>
        private EditScreen Editor { get; }

        /// <summary>
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// </summary>
        public bool IsWindowHovered { get; set; }

        /// <summary>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     If the plugin is built into the editor
        /// </summary>
        public bool IsBuiltIn { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="editScreen"></param>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="description"></param>
        /// <param name="filePath"></param>
        /// <param name="isResource"></param>
        public EditorPlugin(EditScreen editScreen, string name, string author, string description, string filePath, bool isResource = false) : base(filePath, isResource)
        {
            Editor = editScreen;
            Name = name;
            Author = author;
            Description = description;
            IsBuiltIn = isResource;

            UserData.RegisterType<GameMode>();
            UserData.RegisterType<HitSounds>();
            UserData.RegisterType<TimeSignature>();
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public void Initialize()
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public override void SetFrameState()
        {
            WorkingScript.Globals["utils"] = typeof(EditorPluginUtils);
            WorkingScript.Globals["game_mode"] = typeof(GameMode);
            WorkingScript.Globals["hitsounds"] = typeof(HitSounds);
            WorkingScript.Globals["time_signature"] = typeof(TimeSignature);
            WorkingScript.Globals["actions"] = Editor.ActionManager.PluginActionManager;

            var state = (EditorPluginState) State;

            state.SongTime = (int) Math.Round(Editor.Track.Time, MidpointRounding.AwayFromZero);
            state.GameMode = Editor.WorkingMap.Mode;
            state.UnixTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            state.ScrollVelocities = Editor.WorkingMap.SliderVelocities;
            state.HitObjects = Editor.WorkingMap.HitObjects;
            state.TimingPoints = Editor.WorkingMap.TimingPoints;
            state.SelectedHitObjects = Editor.SelectedHitObjects.Value;
            state.CurrentTimingPoint = Editor.WorkingMap.GetTimingPointAt(state.SongTime);

            base.SetFrameState();

            state.PushImguiStyle();
            PushDefaultStyles();
        }

        /// <summary>
        ///     Called after rendering the plugin to pop the default style vars
        /// </summary>
        public override void AfterRender()
        {
            ImGui.PopStyleVar();
            IsWindowHovered = State.IsWindowHovered;

            base.AfterRender();
        }

        /// <summary>
        ///     To push any default styling for plugin windows
        /// </summary>
        private void PushDefaultStyles()
        {
            ImGui.PushStyleVar(ImGuiStyleVar.ItemSpacing, new Vector2(12, 4));
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override LuaPluginState GetStateObject() => new EditorPluginState(Options);
    }
}