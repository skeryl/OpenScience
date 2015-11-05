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
            var earth = new Sphere(new Meter(6378100), new Kilogram(5.98 * (Math.Pow(10, 24))));
            earth.SetCoordinates(PhysicalCoordinate<Meter>.Create(0, 0, 6378100));

            var shaneOnGround = new Sphere(new Centimeter(85), new Kilogram(79.37));

            var shaneAtWork = new Sphere(new Centimeter(85), new Kilogram(79.37));
            shaneAtWork.SetCoordinates(PhysicalCoordinate<Meter>.Create(0, 0, -20));

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
            var physicalSystem = new PhysicalSystem(new Sphere(new Meter(1)).SetMass(new Kilogram(5)),
                                                    new Sphere(new Meter(1)).SetMass(new Kilogram(7)));
            Assert.AreEqual(12, physicalSystem.GetTotalMass<Kilogram>().Value);
        }

        [Test]
        public void TestPhysicalCoordinates()
        {
            var coords1 = PhysicalCoordinate<Meter>.Create(25, 0, 0);
            var coords2 = PhysicalCoordinate<Meter>.Create(50, 0, 0);
            Assert.AreEqual(coords1.DistanceFrom(coords2), new Meter(25));

            var coords3 = PhysicalCoordinate<Meter>.Create(0, 0, 0);
            var coords4 = PhysicalCoordinate<Meter>.Create(30, 40, 0);
            Assert.AreEqual(coords3.DistanceFrom(coords4), new Meter(50));
            Assert.AreEqual(coords3.DistanceFrom(coords4), coords4.DistanceFrom(coords3));

            var coords5 = PhysicalCoordinate<Meter>.Create(-10, 1, -5);
            var coords6 = PhysicalCoordinate<Meter>.Create(100, 10, 20);
            Assert.AreEqual(113.16359838747, Math.Round(coords5.DistanceFrom(coords6).Value, 11));
        }
    }
}
