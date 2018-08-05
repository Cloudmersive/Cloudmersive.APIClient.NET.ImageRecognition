/* 
 * imageapi
 *
 * Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;

namespace Cloudmersive.APIClient.NET.ImageRecognition.Test
{
    /// <summary>
    ///  Class for testing ArtisticApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ArtisticApiTests
    {
        private ArtisticApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ArtisticApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ArtisticApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ArtisticApi
            //Assert.IsInstanceOfType(typeof(ArtisticApi), instance, "instance is a ArtisticApi");
        }

        
        /// <summary>
        /// Test ArtisticPainting
        /// </summary>
        [Test]
        public void ArtisticPaintingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string style = null;
            //System.IO.Stream imageFile = null;
            //var response = instance.ArtisticPainting(style, imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
