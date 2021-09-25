using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using SlnOfQuadEquat;

namespace SlnOfQuadEquat.Tests
{
    public class SlnOfQuadEquatTests
    {
        [Fact]
        public void Sln_101_EmptyReturned()
        {
            //arrange
            List<double> numbers = new List<double>();
            numbers.Add(1);
            numbers.Add(0);
            numbers.Add(1);
            List<double> expected = new List<double>();
            //act
            SlnOfQuadEquat.SlnOfEquat slnOfEquat = new SlnOfQuadEquat.SlnOfEquat();
            var slns = slnOfEquat.Sln(numbers);
            //assert
            bool isEqual = Enumerable.SequenceEqual(expected, slns);
            Assert.True(isEqual);
        }

        [Fact]
        public void Sln_121_Minus1Returned()
        {
            //arrange
            List<double> numbers = new List<double>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(1);
            List<double> expected = new List<double>();
            expected.Add(-1);
            //act
            SlnOfQuadEquat.SlnOfEquat slnOfEquat = new SlnOfQuadEquat.SlnOfEquat();
            var slns = slnOfEquat.Sln(numbers);
            //assert
            bool isEqual = Enumerable.SequenceEqual(expected, slns);
            Assert.True(isEqual);
        }

        [Fact]
        public void Sln_NumbersWithMinusOrDot_TwoAnswersReturned()
        {
            //arrange
            List<double> numbers = new List<double>();
            numbers.Add(-1.5);
            numbers.Add(2.25);
            numbers.Add(0);
            List<double> expected = new List<double>();
            expected.Add(0);
            expected.Add(1.5);
            //act
            SlnOfQuadEquat.SlnOfEquat slnOfEquat = new SlnOfQuadEquat.SlnOfEquat();
            var slns = slnOfEquat.Sln(numbers);
            //assert
            bool isEqual = Enumerable.SequenceEqual(expected, slns);
            Assert.True(isEqual);
        }
    }
}
