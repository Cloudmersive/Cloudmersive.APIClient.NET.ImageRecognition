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
    ///  Class for testing EditApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EditApiTests
    {
        private EditApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EditApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EditApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EditApi
            //Assert.IsInstanceOfType(typeof(EditApi), instance, "instance is a EditApi");
        }

        
        /// <summary>
        /// Test EditAutoOrient
        /// </summary>
        [Test]
        public void EditAutoOrientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.EditAutoOrient(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditCompositeBasic
        /// </summary>
        [Test]
        public void EditCompositeBasicTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string location = null;
            //System.IO.Stream baseImage = null;
            //System.IO.Stream layeredImage = null;
            //var response = instance.EditCompositeBasic(location, baseImage, layeredImage);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditContrastAdaptive
        /// </summary>
        [Test]
        public void EditContrastAdaptiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //double? gamma = null;
            //System.IO.Stream imageFile = null;
            //var response = instance.EditContrastAdaptive(gamma, imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditDrawPolygon
        /// </summary>
        [Test]
        public void EditDrawPolygonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DrawPolygonRequest request = null;
            //var response = instance.EditDrawPolygon(request);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditDrawRectangle
        /// </summary>
        [Test]
        public void EditDrawRectangleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DrawRectangleRequest request = null;
            //var response = instance.EditDrawRectangle(request);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditDrawText
        /// </summary>
        [Test]
        public void EditDrawTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DrawTextRequest request = null;
            //var response = instance.EditDrawText(request);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditRotate
        /// </summary>
        [Test]
        public void EditRotateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //double? degrees = null;
            //System.IO.Stream imageFile = null;
            //var response = instance.EditRotate(degrees, imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
