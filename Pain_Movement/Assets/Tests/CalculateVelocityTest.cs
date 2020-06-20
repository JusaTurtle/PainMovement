using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CalculateVelocityTest
    {
        [Test]
        public void WhenDirectionIsZero_ShouldReturnZero()
        {
            Assert.That(CalculateHorizontalVelocity(new Vector2(), 2), Is.EqualTo(new Vector2()));
        }


        [Test]
        public void WhenDirectionIs01_ShouldReturn01()
        {
            IsVelocityCalculated(new Vector2(0, 0), 1, new Vector2(0, 0));
        }

        [Test]
        public void WhenDirectionIs01AndSpeedIs2_ShouldReturn02()
        {
            IsVelocityCalculated(new Vector2(0, 1), 2, new Vector2(0, 2));
        }

        [Test]
        public void WhenDirectionIs11AndSpeedIs1_ShouldReturnVelocityWithMagtitudeIs1()
        {
            IsVelocityCalculated(new Vector2(1, 1), 1, new Vector2(1 / Mathf.Sqrt(2), 1 / Mathf.Sqrt(2)));
        }

        private void IsVelocityCalculated(Vector2 direction, int speed, Vector2 expected)
        {
            Assert.That(CalculateHorizontalVelocity(direction, speed), Is.EqualTo(expected).Within(0.001));
        }

        private Vector2 CalculateHorizontalVelocity(Vector2 direction, float speed)
        {
            return direction.normalized * speed;
        }
    }
}
