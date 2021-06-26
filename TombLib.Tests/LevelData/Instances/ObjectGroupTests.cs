using System.Numerics;
using TombLib.LevelData;
using Xunit;

namespace TombLib.Tests.LevelData.Instances
{
    public class ObjectGroupTests
    {
        [Fact]
        public void Constructor_SetsRoomAndPositionFromInitialObject_AddsInitialObject()
        {
            // Arrange
            var level = new Level();
            var room = new Room(level, 12, 12, Vector3.Zero);

            var position = new Vector3(100f, 200f, 300f);
            var obj = new MoveableInstance
            {
                Position = position
            };

            room.AddObject(level, obj);

            // Act
            var objectGroup = new ObjectGroup(obj);

            // Assert
            Assert.Same(room, objectGroup.Room);
            Assert.Equal(position, objectGroup.Position);
            Assert.Single(objectGroup.Objects);
            Assert.Collection(
                objectGroup.Objects, 
                first => Assert.Same(obj, first)
                );
        }

        [Fact]
        public void SetPosition_SetsRelativeChildPositions()
        {
            // Arrange
            var position1 = new Vector3(100f, 200f, 300f);
            var position2 = new Vector3(105f, 205f, 305f);
            var position3 = new Vector3(95f, 195f, 295f);

            var obj1 = new MoveableInstance { Position = position1 };
            var obj2 = new MoveableInstance { Position = position2 };
            var obj3 = new MoveableInstance { Position = position3 };

            var objectGroup = new ObjectGroup(new[] { obj1, obj2, obj3 });

            // Act
            var targetPosition = new Vector3(50f, 60f, 70f);
            objectGroup.SetPosition(targetPosition);

            // Assert
            var expectedPosition2 = new Vector3(55f, 65f, 75f);
            var expectedPosition3 = new Vector3(45f, 55f, 65f);

            Assert.Equal(targetPosition, objectGroup.Position);
            Assert.Equal(targetPosition, obj1.Position);
            Assert.Equal(expectedPosition2, obj2.Position);
            Assert.Equal(expectedPosition3, obj3.Position);
        }
    }
}
