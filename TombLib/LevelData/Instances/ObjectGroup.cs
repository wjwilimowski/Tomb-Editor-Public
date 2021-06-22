using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using TombLib.Utils;

namespace TombLib.LevelData
{
    public class ObjectGroup : ItemInstance
    {
        public ObjectGroup(ItemInstance initialObject)
        {
            Room = initialObject.Room;
            Position = initialObject.Position;
            ItemType = initialObject.ItemType;


            _objectInstances.Add(initialObject);
        }

        private readonly HashSet<ItemInstance> _objectInstances = new HashSet<ItemInstance>();

        public void Add(ItemInstance objectInstance) => _objectInstances.Add(objectInstance);
        public void Remove(ItemInstance objectInstance) => _objectInstances.Remove(objectInstance);
        public bool Contains(ItemInstance obInstance) => _objectInstances.Contains(obInstance);
        public bool Any() => _objectInstances.Any();

        public override void SetPosition(Vector3 position)
        {
            var difference = position - Position;
            base.SetPosition(position);

            foreach (var i in _objectInstances)
                i.SetPosition(i.Position + difference);
        }

        public List<ObjectInstance> ToObjectInstances() => _objectInstances.OfType<ObjectInstance>().ToList();

        public override void Transform(RectTransformation transformation, VectorInt2 oldRoomSize)
        {
            base.Transform(transformation, oldRoomSize);
            foreach (var oi in _objectInstances)
                oi.Transform(transformation, oldRoomSize);
        }

        public override ItemType ItemType { get; }

        public void SetRotationY(float targetRotation)
        {
            var difference = targetRotation - RotationY;

            RotationY = targetRotation;

            foreach (var i in _objectInstances)
                i.RotationY += difference;
        }
    }
}