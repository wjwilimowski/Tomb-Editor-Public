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

            ObjectInstances.Add(initialObject);
        }

        public HashSet<ItemInstance> ObjectInstances = new HashSet<ItemInstance>();

        public void Add(ItemInstance objectInstance) => ObjectInstances.Add(objectInstance);
        public void Remove(ItemInstance objectInstance) => ObjectInstances.Remove(objectInstance);
        public bool Contains(ItemInstance obInstance) => ObjectInstances.Contains(obInstance);
        public bool Any() => ObjectInstances.Any();

        public override void SetPosition(Vector3 position)
        {
            var difference = position - Position;
            base.SetPosition(position);

            foreach (var i in ObjectInstances)
                i.SetPosition(i.Position + difference);
        }

        public List<ObjectInstance> ToObjectInstances() => ObjectInstances.OfType<ObjectInstance>().ToList();

        public override void Transform(RectTransformation transformation, VectorInt2 oldRoomSize)
        {
            base.Transform(transformation, oldRoomSize);
            foreach (var oi in ObjectInstances)
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

                foreach (var i in ObjectInstances)
                    i.RotationY += difference;
            }
        }

        public void RotateToDeg(float targetDeg)
        {
            var rotationToApply = targetDeg - RotationY;

            RotationY += rotationToApply;

            var rotationToApplyRad = rotationToApply * Math.PI / 180.0f;
            // The formula used goes counterclockwise - using negative clicks to go clockwise
            var sin = (float)Math.Sin(-rotationToApplyRad);
            var cos = (float)Math.Cos(-rotationToApplyRad);

            foreach (var i in ObjectInstances)
            {
                var distance = i.Position - Position;
                if (distance.X != 0.0f || distance.Z != 0.0f)
                {
                    i.SetPosition(new Vector3(
                        distance.X * cos - distance.Z * sin + Position.X,
                        i.Position.Y,
                        distance.X * sin + distance.Z * cos + Position.Z
                    ));
                }
            }
        }
    }
}