using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using TombLib.Utils;

namespace TombLib.LevelData
{
    public class ObjectGroup : PositionBasedObjectInstance, IRotateableY
    {
        public ObjectGroup(ItemInstance initialObject)
        {
            Room = initialObject.Room;
            Position = initialObject.Position;

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

        private float _rotationY;

        public float RotationY
        {
            get => _rotationY;
            set
            {
                var difference = value - _rotationY;

                _rotationY = value;

                foreach (var i in _objectInstances)
                    i.RotationY += difference;
            }
        }

        public void Rotate(int clicks)
        {
            var rotationToApply = 90.0f * clicks;

            RotationY += rotationToApply;

            // The formula used goes counterclockwise - using negative clicks to go clockwise
            var sin = SinClicks(-clicks);
            var cos = SinClicks(-clicks - 1);

            foreach (var i in _objectInstances)
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

        // Get sine of the angle clicks * 90deg
        private int SinClicks(int clicks)
        {
            const int nClicksInFullRotation = 4;

            var clicksModulo = clicks % nClicksInFullRotation;
            if (clicksModulo < 0)
                clicksModulo += nClicksInFullRotation;

            switch (clicksModulo)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 0;
                case 3:
                    return -1;
                default:
                    throw new ArgumentOutOfRangeException(nameof(clicks));
            }
        }
    }
}