using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using TombLib.Utils;

namespace TombLib.LevelData
{
    /// <summary>
    /// Represents a group of objects multi-selected by ctrl-clicking.
    /// </summary>
    public class ObjectGroup : PositionBasedObjectInstance, IRotateableY
    {
        public ObjectGroup(ItemInstance initialObject)
        {
            Room = initialObject.Room;
            Position = initialObject.Position;

            Objects.Add(initialObject);
        }

        public ObjectGroup(IReadOnlyList<ItemInstance> objects)
        {
            var initialObject = objects.First();

            Room = initialObject.Room;
            Position = initialObject.Position;

            foreach (var obj in objects)
            {
                Objects.Add(obj);
            }
        }

        public HashSet<ItemInstance> Objects { get; } = new HashSet<ItemInstance>();

        public void Add(ItemInstance objectInstance) => Objects.Add(objectInstance);
        public void Remove(ItemInstance objectInstance) => Objects.Remove(objectInstance);
        public bool Contains(ItemInstance obInstance) => Objects.Contains(obInstance);
        public bool Any() => Objects.Any();
        public List<ObjectInstance> ToObjectInstances() => Objects.OfType<ObjectInstance>().ToList();

        public override void SetPosition(Vector3 position)
        {
            var difference = position - Position;
            base.SetPosition(position);

            foreach (var i in Objects)
                i.SetPosition(i.Position + difference);
        }


        public override void Transform(RectTransformation transformation, VectorInt2 oldRoomSize)
        {
            base.Transform(transformation, oldRoomSize);
            foreach (var oi in Objects)
                oi.Transform(transformation, oldRoomSize);
        }

        private float _rotationY;

        public float RotationY
        {
            get => _rotationY;
            set
            {
                var difference = value - _rotationY;

                _rotationY = value;

                foreach (var i in Objects)
                    i.RotationY += difference;
            }
        }

        public void RotateAsGroup(float targetRotationDeg)
        {
            var rotationDifferenceRad = (targetRotationDeg - RotationY) * Math.PI / 180.0f;

            RotationY = targetRotationDeg;

            // The formula used goes counterclockwise - using negative angle to go clockwise
            var sin = (float)Math.Sin(-rotationDifferenceRad);
            var cos = (float)Math.Cos(-rotationDifferenceRad);

            foreach (var i in Objects)
            {
                var distance = i.Position - Position;

                var x = distance.X * cos - distance.Z * sin + Position.X;
                var z = distance.X * sin + distance.Z * cos + Position.Z;

                i.SetPosition(new Vector3(x, i.Position.Y, z));
            }
        }
    }
}