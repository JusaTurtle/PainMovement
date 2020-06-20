using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CalculateFaceAngleTest
    {
        [Test]
        public void InputDirectionIsZero_ShouldReturnZero()
        {
            Assert.That(CalculateFaceAngle(new Vector2()), Is.EqualTo(0).Within(0.01));
        }

        [Test]
        public void InputDirectionIs01_ShouldReturnZero()
        {
            Assert.That(CalculateFaceAngle(new Vector2(0, 1)), Is.EqualTo(0).Within(0.01));
        }

        [Test]
        public void InputDirectionIs10_ShouldReturn90()
        {
            Assert.That(CalculateFaceAngle(new Vector2(1, 0)), Is.EqualTo(90).Within(0.01));
        }

        private float CalculateFaceAngle(Vector2 inputDir)
        {
            return Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg;
        }
    }
}

