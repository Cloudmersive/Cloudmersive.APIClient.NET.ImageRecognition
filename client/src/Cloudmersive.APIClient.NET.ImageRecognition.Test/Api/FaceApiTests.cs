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
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Cloudmersive.APIClient.NET.ImageRecognition.Test
{
    /// <summary>
    ///  Class for testing FaceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FaceApiTests
    {
        private FaceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FaceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FaceApi
            //Assert.IsInstanceOfType(typeof(FaceApi), instance, "instance is a FaceApi");
        }

        
        /// <summary>
        /// Test FaceCompare
        /// </summary>
        [Test]
        public void FaceCompareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputImage = null;
            //System.IO.Stream matchFace = null;
            //var response = instance.FaceCompare(inputImage, matchFace);
            //Assert.IsInstanceOf<FaceCompareResponse> (response, "response is FaceCompareResponse");
        }
        
        /// <summary>
        /// Test FaceCropFirst
        /// </summary>
        [Test]
        public void FaceCropFirstTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.FaceCropFirst(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FaceCropFirstRound
        /// </summary>
        [Test]
        public void FaceCropFirstRoundTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.FaceCropFirstRound(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FaceDetectAge
        /// </summary>
        [Test]
        public void FaceDetectAgeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.FaceDetectAge(imageFile);
            //Assert.IsInstanceOf<AgeDetectionResult> (response, "response is AgeDetectionResult");
        }
        
        /// <summary>
        /// Test FaceLocate
        /// </summary>
        [Test]
        public void FaceLocateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.FaceLocate(imageFile);
            //Assert.IsInstanceOf<FaceLocateResponse> (response, "response is FaceLocateResponse");
        }
        
        /// <summary>
        /// Test FaceLocateWithLandmarks
        /// </summary>
        [Test]
        public void FaceLocateWithLandmarksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.FaceLocateWithLandmarks(imageFile);
            //Assert.IsInstanceOf<FaceLocateWithLandmarksResponse> (response, "response is FaceLocateWithLandmarksResponse");
        }
        
    }

}
