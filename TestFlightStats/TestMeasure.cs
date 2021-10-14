using NUnit.Framework;
using System;
using System.Collections.Generic;
using FlightStats;
using System.Linq;

namespace TestFlightStats
{
    [TestFixture]
    public class TestMeasure
    {
        /// <summary>
        /// This test method is designed to test the string conversion of a measure based only on Farhenheit value
        /// </summary>
        [Test]
        public void ToString_ConstructorOneItem_Success()
        {
            //given
            Measure measure = new Measure(22);
            string expectedStringMessage = "22.00;-5.56;267.44;636.81";
            string actualStringMessage = "";

            //when
            actualStringMessage = measure.ToString();

            //then
            Assert.AreEqual(expectedStringMessage, actualStringMessage);
        }

        /// <summary>
        /// This test method is designed to test the string conversion of a measure based only on Farhenheit and Celsius values
        /// </summary>
        [Test]
        public void ToString_ConstructorTwoItems_Success()
        {
            //given
            Measure measure = new Measure(22, -5.56);
            string expectedStringMessage = "22.00;-5.56;267.44;636.81";
            string actualStringMessage = "";

            //when
            actualStringMessage = measure.ToString();

            //then
            Assert.AreEqual(expectedStringMessage, actualStringMessage);
        }

        /// <summary>
        /// This test method is designed to test the string conversion of a measure based only on Farhenheit, Celsius and Kelvin values
        /// </summary>
        [Test]
        public void ToString_ConstructorThreeItems_Success()
        {
            //given
            Measure measure = new Measure(22, -5.56, 267.44);
            string expectedStringMessage = "22.00;-5.56;267.44;636.81";
            string actualStringMessage = "";

            //when
            actualStringMessage = measure.ToString();

            //then
            Assert.AreEqual(expectedStringMessage, actualStringMessage);
        }

        /// <summary>
        /// This test method is designed to test the string conversion of a measure based on all values (Farhenheit, Celsius, Kelvin and Local Speed of Sound)
        /// </summary>
        [Test]
        public void ToString_ConstructorFourItems_Success()
        {
            //given
            Measure measure = new Measure(22, -5.56, 267.44, 636.81);
            string expectedStringMessage = "22.00;-5.56;267.44;636.81";
            string actualStringMessage = "";

            //when
            actualStringMessage = measure.ToString();

            //then
            Assert.AreEqual(expectedStringMessage, actualStringMessage);
        }
        /// <summary>
        /// This test method is designed to test the class with several values in different cases
        /// </summary>
        [Test]
        public void ToString_FinalTest_Success()
        {
            //given
            Measure measure01 = new Measure(32, 0.00, 273.00, 643.39);
            Measure measure02 = new Measure(0, -17.78, 255.22);
            Measure measure03 = new Measure(-45, -42.78);
            Measure measure04 = new Measure(-10, -23.33, 249.67, 615.28);
            Measure measure05 = new Measure(34, 1.11, 274.11, 644.70);
            List<Measure> listOfMeasures = new List<Measure>
            {
                new Measure(32,0.00,273.00,643.39),
                new Measure(0,-17.78,255.22),
                new Measure(-45,-42.78),
                new Measure(-10,-23.33,249.67,615.28),
                new Measure(34, 1.11, 274.11, 644.70)
            };

            List<string> expectedListOfMessages = new List<string>
            {
                "32.00;0.00;273.00;643.39",
                "0.00;-17.78;255.22;622.09",
                "-45.00;-42.78;230.22;590.84",
                "-10.00;-23.33;249.67;615.28",
                "34.00;1.11;274.11;644.70"
            };

            List<string> actualListOfMessagse = new List<string>();

            //when
            foreach (Measure measure in listOfMeasures)
            {
                actualListOfMessagse.Add(measure.ToString());
            }

            //then
            var messagesExpectedAndActual = expectedListOfMessages.Zip(actualListOfMessagse, (expectedMsg, actualMsg) => new { expectedListOfMessages = expectedMsg, actualListOfMessagse = actualMsg });
            foreach (var msg in messagesExpectedAndActual)
            {
                Assert.AreEqual(msg.expectedListOfMessages, msg.actualListOfMessagse);
            }
        }
        [Test]
        public void Measure_WrongFormat_ThrowWrongFormatMeasureException()
        {
            //given
            string givenDataLog = "32.00;0.00;;643.39";
            //when + then
            Assert.Throws<WrongFormatException>(delegate
            {
                new Measure(givenDataLog);
            }    
            );
        }
        [Test]
        public void ToString_ConstructorSingleString_Success()
        {
            //given
            string expectedMessage = "22.00;-5.56;266.44;636.81";
            Measure measure = new Measure(expectedMessage);
            string actualString = "";

            //when
            actualString = measure.ToString();

            //then
            Assert.AreEqual(expectedMessage, actualString);
        }
        [Test]
        public void ToString_ConstructorSingleStringEmpty_Success()
        {
            //given
            string expectedMessage = "22.00;-5.56;266.44;";
            Measure measure = new Measure(expectedMessage);
            string actualString = "";

            //when
            actualString = measure.ToString();

            //then
            Assert.AreEqual(expectedMessage, actualString);
        }
    }
}
