using System.Collections.Generic;
using Quaver.API.Maps;
using Quaver.API.Maps.Structures;

namespace Quaver.Shared.Screens.Edit.Actions.Timing.ChangeOffsetBatch
{
    public class EditorActionChangeTimingPointOffsetBatch : IEditorAction
    {
        public EditorActionType Type { get; } = EditorActionType.ChangeTimingPointOffsetBatch;

        private EditorActionManager ActionManager { get; }

        private Qua WorkingMap { get; }

        private List<TimingPointInfo> TimingPoints { get; }

        private float Offset { get; }

        public EditorActionChangeTimingPointOffsetBatch(EditorActionManager manager, Qua workingMap, List<TimingPointInfo> tps,
            float offset)
        {
            ActionManager = manager;
            WorkingMap = workingMap;
            TimingPoints = tps;
            Offset = offset;
        }

        public void Perform()
        {
            foreach (var tp in TimingPoints)
                tp.StartTime += Offset;

            WorkingMap.Sort();
            ActionManager.TriggerEvent(Type, new EditorChangedTimingPointOffsetBatchEventArgs(TimingPoints, Offset));
        }

        public void Undo() => new EditorActionChangeTimingPointOffsetBatch(ActionManager, WorkingMap, TimingPoints, -Offset).Perform();
    }
}