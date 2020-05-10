using System.Collections.Generic;
using Quaver.API.Maps;
using Quaver.API.Maps.Structures;

namespace Quaver.Shared.Screens.Edit.Actions.SV.ChangeOffsetBatch
{
    public class EditorActionChangeScrollVelocityOffsetBatch : IEditorAction
    {
        public EditorActionType Type { get; } = EditorActionType.ChangeScrollVelocityOffsetBatch;

        private EditorActionManager ActionManager { get; }

        private Qua WorkingMap { get; }

        private List<SliderVelocityInfo> ScrollVelocities { get; }

        private float Offset { get; }

        public EditorActionChangeScrollVelocityOffsetBatch(EditorActionManager manager, Qua workingMap, List<SliderVelocityInfo> svs,
            float offset)
        {
            ActionManager = manager;
            WorkingMap = workingMap;
            ScrollVelocities = svs;
            Offset = offset;
        }

        public void Perform()
        {
            foreach (var tp in ScrollVelocities)
                tp.StartTime += Offset;

            WorkingMap.Sort();
            ActionManager.TriggerEvent(Type, new EditorChangedScrollVelocityOffsetBatchEventArgs(ScrollVelocities, Offset));
        }

        public void Undo() => new EditorActionChangeScrollVelocityOffsetBatch(ActionManager, WorkingMap, ScrollVelocities, -Offset).Perform();
    }
}