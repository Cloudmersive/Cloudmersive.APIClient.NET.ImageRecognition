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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NET.ImageRecognition.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.ImageRecognition.Model
{
    /// <summary>
    /// Location of one face in an image
    /// </summary>
    [DataContract]
    public partial class FaceWithLandmarks :  IEquatable<FaceWithLandmarks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceWithLandmarks" /> class.
        /// </summary>
        /// <param name="LeftEyebrow">LeftEyebrow.</param>
        /// <param name="RightEyebrow">RightEyebrow.</param>
        /// <param name="LeftEye">LeftEye.</param>
        /// <param name="RightEye">RightEye.</param>
        /// <param name="BottomAndSidesOfFace">BottomAndSidesOfFace.</param>
        /// <param name="NoseBridge">NoseBridge.</param>
        /// <param name="NoseBottom">NoseBottom.</param>
        /// <param name="LipsInnerOutline">LipsInnerOutline.</param>
        /// <param name="LipsOuterOutline">LipsOuterOutline.</param>
        /// <param name="LeftX">X coordinate of the left side of the face.</param>
        /// <param name="TopY">Y coordinate of the top side of the face.</param>
        /// <param name="RightX">X coordinate of the right side of the face.</param>
        /// <param name="BottomY">Y coordinate of the bottom side of the face.</param>
        public FaceWithLandmarks(List<FacePoint> LeftEyebrow = default(List<FacePoint>), List<FacePoint> RightEyebrow = default(List<FacePoint>), List<FacePoint> LeftEye = default(List<FacePoint>), List<FacePoint> RightEye = default(List<FacePoint>), List<FacePoint> BottomAndSidesOfFace = default(List<FacePoint>), List<FacePoint> NoseBridge = default(List<FacePoint>), List<FacePoint> NoseBottom = default(List<FacePoint>), List<FacePoint> LipsInnerOutline = default(List<FacePoint>), List<FacePoint> LipsOuterOutline = default(List<FacePoint>), int? LeftX = default(int?), int? TopY = default(int?), int? RightX = default(int?), int? BottomY = default(int?))
        {
            this.LeftEyebrow = LeftEyebrow;
            this.RightEyebrow = RightEyebrow;
            this.LeftEye = LeftEye;
            this.RightEye = RightEye;
            this.BottomAndSidesOfFace = BottomAndSidesOfFace;
            this.NoseBridge = NoseBridge;
            this.NoseBottom = NoseBottom;
            this.LipsInnerOutline = LipsInnerOutline;
            this.LipsOuterOutline = LipsOuterOutline;
            this.LeftX = LeftX;
            this.TopY = TopY;
            this.RightX = RightX;
            this.BottomY = BottomY;
        }
        
        /// <summary>
        /// Gets or Sets LeftEyebrow
        /// </summary>
        [DataMember(Name="LeftEyebrow", EmitDefaultValue=false)]
        public List<FacePoint> LeftEyebrow { get; set; }

        /// <summary>
        /// Gets or Sets RightEyebrow
        /// </summary>
        [DataMember(Name="RightEyebrow", EmitDefaultValue=false)]
        public List<FacePoint> RightEyebrow { get; set; }

        /// <summary>
        /// Gets or Sets LeftEye
        /// </summary>
        [DataMember(Name="LeftEye", EmitDefaultValue=false)]
        public List<FacePoint> LeftEye { get; set; }

        /// <summary>
        /// Gets or Sets RightEye
        /// </summary>
        [DataMember(Name="RightEye", EmitDefaultValue=false)]
        public List<FacePoint> RightEye { get; set; }

        /// <summary>
        /// Gets or Sets BottomAndSidesOfFace
        /// </summary>
        [DataMember(Name="BottomAndSidesOfFace", EmitDefaultValue=false)]
        public List<FacePoint> BottomAndSidesOfFace { get; set; }

        /// <summary>
        /// Gets or Sets NoseBridge
        /// </summary>
        [DataMember(Name="NoseBridge", EmitDefaultValue=false)]
        public List<FacePoint> NoseBridge { get; set; }

        /// <summary>
        /// Gets or Sets NoseBottom
        /// </summary>
        [DataMember(Name="NoseBottom", EmitDefaultValue=false)]
        public List<FacePoint> NoseBottom { get; set; }

        /// <summary>
        /// Gets or Sets LipsInnerOutline
        /// </summary>
        [DataMember(Name="LipsInnerOutline", EmitDefaultValue=false)]
        public List<FacePoint> LipsInnerOutline { get; set; }

        /// <summary>
        /// Gets or Sets LipsOuterOutline
        /// </summary>
        [DataMember(Name="LipsOuterOutline", EmitDefaultValue=false)]
        public List<FacePoint> LipsOuterOutline { get; set; }

        /// <summary>
        /// X coordinate of the left side of the face
        /// </summary>
        /// <value>X coordinate of the left side of the face</value>
        [DataMember(Name="LeftX", EmitDefaultValue=false)]
        public int? LeftX { get; set; }

        /// <summary>
        /// Y coordinate of the top side of the face
        /// </summary>
        /// <value>Y coordinate of the top side of the face</value>
        [DataMember(Name="TopY", EmitDefaultValue=false)]
        public int? TopY { get; set; }

        /// <summary>
        /// X coordinate of the right side of the face
        /// </summary>
        /// <value>X coordinate of the right side of the face</value>
        [DataMember(Name="RightX", EmitDefaultValue=false)]
        public int? RightX { get; set; }

        /// <summary>
        /// Y coordinate of the bottom side of the face
        /// </summary>
        /// <value>Y coordinate of the bottom side of the face</value>
        [DataMember(Name="BottomY", EmitDefaultValue=false)]
        public int? BottomY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaceWithLandmarks {\n");
            sb.Append("  LeftEyebrow: ").Append(LeftEyebrow).Append("\n");
            sb.Append("  RightEyebrow: ").Append(RightEyebrow).Append("\n");
            sb.Append("  LeftEye: ").Append(LeftEye).Append("\n");
            sb.Append("  RightEye: ").Append(RightEye).Append("\n");
            sb.Append("  BottomAndSidesOfFace: ").Append(BottomAndSidesOfFace).Append("\n");
            sb.Append("  NoseBridge: ").Append(NoseBridge).Append("\n");
            sb.Append("  NoseBottom: ").Append(NoseBottom).Append("\n");
            sb.Append("  LipsInnerOutline: ").Append(LipsInnerOutline).Append("\n");
            sb.Append("  LipsOuterOutline: ").Append(LipsOuterOutline).Append("\n");
            sb.Append("  LeftX: ").Append(LeftX).Append("\n");
            sb.Append("  TopY: ").Append(TopY).Append("\n");
            sb.Append("  RightX: ").Append(RightX).Append("\n");
            sb.Append("  BottomY: ").Append(BottomY).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceWithLandmarks);
        }

        /// <summary>
        /// Returns true if FaceWithLandmarks instances are equal
        /// </summary>
        /// <param name="input">Instance of FaceWithLandmarks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaceWithLandmarks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeftEyebrow == input.LeftEyebrow ||
                    this.LeftEyebrow != null &&
                    this.LeftEyebrow.SequenceEqual(input.LeftEyebrow)
                ) && 
                (
                    this.RightEyebrow == input.RightEyebrow ||
                    this.RightEyebrow != null &&
                    this.RightEyebrow.SequenceEqual(input.RightEyebrow)
                ) && 
                (
                    this.LeftEye == input.LeftEye ||
                    this.LeftEye != null &&
                    this.LeftEye.SequenceEqual(input.LeftEye)
                ) && 
                (
                    this.RightEye == input.RightEye ||
                    this.RightEye != null &&
                    this.RightEye.SequenceEqual(input.RightEye)
                ) && 
                (
                    this.BottomAndSidesOfFace == input.BottomAndSidesOfFace ||
                    this.BottomAndSidesOfFace != null &&
                    this.BottomAndSidesOfFace.SequenceEqual(input.BottomAndSidesOfFace)
                ) && 
                (
                    this.NoseBridge == input.NoseBridge ||
                    this.NoseBridge != null &&
                    this.NoseBridge.SequenceEqual(input.NoseBridge)
                ) && 
                (
                    this.NoseBottom == input.NoseBottom ||
                    this.NoseBottom != null &&
                    this.NoseBottom.SequenceEqual(input.NoseBottom)
                ) && 
                (
                    this.LipsInnerOutline == input.LipsInnerOutline ||
                    this.LipsInnerOutline != null &&
                    this.LipsInnerOutline.SequenceEqual(input.LipsInnerOutline)
                ) && 
                (
                    this.LipsOuterOutline == input.LipsOuterOutline ||
                    this.LipsOuterOutline != null &&
                    this.LipsOuterOutline.SequenceEqual(input.LipsOuterOutline)
                ) && 
                (
                    this.LeftX == input.LeftX ||
                    (this.LeftX != null &&
                    this.LeftX.Equals(input.LeftX))
                ) && 
                (
                    this.TopY == input.TopY ||
                    (this.TopY != null &&
                    this.TopY.Equals(input.TopY))
                ) && 
                (
                    this.RightX == input.RightX ||
                    (this.RightX != null &&
                    this.RightX.Equals(input.RightX))
                ) && 
                (
                    this.BottomY == input.BottomY ||
                    (this.BottomY != null &&
                    this.BottomY.Equals(input.BottomY))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LeftEyebrow != null)
                    hashCode = hashCode * 59 + this.LeftEyebrow.GetHashCode();
                if (this.RightEyebrow != null)
                    hashCode = hashCode * 59 + this.RightEyebrow.GetHashCode();
                if (this.LeftEye != null)
                    hashCode = hashCode * 59 + this.LeftEye.GetHashCode();
                if (this.RightEye != null)
                    hashCode = hashCode * 59 + this.RightEye.GetHashCode();
                if (this.BottomAndSidesOfFace != null)
                    hashCode = hashCode * 59 + this.BottomAndSidesOfFace.GetHashCode();
                if (this.NoseBridge != null)
                    hashCode = hashCode * 59 + this.NoseBridge.GetHashCode();
                if (this.NoseBottom != null)
                    hashCode = hashCode * 59 + this.NoseBottom.GetHashCode();
                if (this.LipsInnerOutline != null)
                    hashCode = hashCode * 59 + this.LipsInnerOutline.GetHashCode();
                if (this.LipsOuterOutline != null)
                    hashCode = hashCode * 59 + this.LipsOuterOutline.GetHashCode();
                if (this.LeftX != null)
                    hashCode = hashCode * 59 + this.LeftX.GetHashCode();
                if (this.TopY != null)
                    hashCode = hashCode * 59 + this.TopY.GetHashCode();
                if (this.RightX != null)
                    hashCode = hashCode * 59 + this.RightX.GetHashCode();
                if (this.BottomY != null)
                    hashCode = hashCode * 59 + this.BottomY.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
