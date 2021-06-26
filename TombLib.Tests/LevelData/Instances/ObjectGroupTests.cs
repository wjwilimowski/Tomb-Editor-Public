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
    }
}
