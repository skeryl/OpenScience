using System;
using NUnit.Framework;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Physics.Objects;

namespace Tests
{
    [TestFixture]
    public class PhysicalObjectsTests
    {
        [Test]
        public void SphereTests()
        {
            var sphere = new Sphere(new Meter(1));
            var volume = sphere.GetVolume<Meter>();
            Assert.AreEqual(4/3*Math.PI, volume.Value); // 4/3 * pi * r^2

            sphere.SetRadius(new Meter(5));
            Assert.AreEqual(4/3*Math.PI*Math.Pow(sphere.GetRadius<Meter>().Value,3), sphere.GetVolume<Meter>().Value);

            sphere.SetMass(new Kilogram(50));
            Assert.AreEqual(50000, sphere.GetMass<Gram>().Value);
        }
    }
}
