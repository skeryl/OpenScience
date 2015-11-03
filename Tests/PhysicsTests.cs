using System;
using NUnit.Framework;
using OpenScience.Math.Coordinates;
using OpenScience.Math.Units.DerivedUnits.Electricity;
using OpenScience.Math.Units.DerivedUnits.ForceMeasures;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Physics;
using OpenScience.Physics.FundamentalForces;
using OpenScience.Physics.Objects;

namespace Tests
{
    [TestFixture]
    public class PhysicsTests
    {
        [Test]
        public void TestGravitation()
        {
            var earth = new Sphere(new Meter(6378100), new Kilogram(5.98 * (Math.Pow(10, 24)))); // { Mass = , Coordinates = new PhysicalCoordinate<Meter>(new Meter(0), new Meter(0), new Meter(6378100)) };
            earth.SetCoordinates(PhysicalCoordinate<Meter>.Create(0, 0, 6378100));

            var shaneOnGround = new Sphere(new Centimeter(85), new Kilogram(79.37));

            var shaneAtWork = new Sphere(new Centimeter(85), new Kilogram(79.37));
            shaneAtWork.SetCoordinates(PhysicalCoordinate<Meter>.Create(0, 0, -60));

            var shaneOnPlane = new Sphere(new Centimeter(85), new Kilogram(79.37));
            shaneOnPlane.SetCoordinates(PhysicalCoordinate<Meter>.Create(0, 0, -11277.6));

            var halfwayToMoon = new Sphere(new Centimeter(85), new Kilogram(79.37));
            halfwayToMoon.SetCoordinates(PhysicalCoordinate<Meter>.Create(0, 0, -192201500));

            var forceOnGround = Gravitation.GravityBetween(shaneOnGround, earth);
            var forceAtWork = Gravitation.GravityBetween(shaneAtWork, earth);
            Assert.Less(forceAtWork.Value, forceOnGround.Value);

            var forceOnPlane = Gravitation.GravityBetween(shaneOnPlane, earth);
            Assert.Less(forceOnPlane.Value, forceAtWork.Value);

            var forceHalfwayToMoon = Gravitation.GravityBetween(halfwayToMoon, earth);
            Assert.Less(forceHalfwayToMoon.Value, forceOnPlane.Value);
        }

        [Test]
        public void TestElectromagnetism()
        {
            var particleOne = new Sphere().SetCharge(new Coulomb(1));
            var particleTwo = new Sphere().SetCharge(new Coulomb(1)).SetCoordinates(PhysicalCoordinate<Meter>.Create(0,0,1));
            Newton forceBetween = Electromagnetism.ForceBetween(particleOne, particleTwo);
            Assert.AreEqual(8987551787.3681755, forceBetween.Value);
        }

        [Test]
        public void TestPhysicalSystem()
        {
        }
    }
}
