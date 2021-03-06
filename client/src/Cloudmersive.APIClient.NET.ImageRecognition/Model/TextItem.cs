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
    /// Individual instance of text occuring in an image; one piece of text
    /// </summary>
    [DataContract]
    public partial class TextItem :  IEquatable<TextItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextItem" /> class.
        /// </summary>
        /// <param name="leftX">Left X coordinate of the text location; 0 represents the left edge of the input image.</param>
        /// <param name="topY">Top Y coordinate of the text location; 0 represents the top edge of the input image.</param>
        /// <param name="width">Width in pixels of the text item.</param>
        /// <param name="height">Height in pixels of the text item.</param>
        public TextItem(int? leftX = default(int?), int? topY = default(int?), int? width = default(int?), int? height = default(int?))
        {
            this.LeftX = leftX;
            this.TopY = topY;
            this.Width = width;
            this.Height = height;
        }
        
        /// <summary>
        /// Left X coordinate of the text location; 0 represents the left edge of the input image
        /// </summary>
        /// <value>Left X coordinate of the text location; 0 represents the left edge of the input image</value>
        [DataMember(Name="LeftX", EmitDefaultValue=false)]
        public int? LeftX { get; set; }

        /// <summary>
        /// Top Y coordinate of the text location; 0 represents the top edge of the input image
        /// </summary>
        /// <value>Top Y coordinate of the text location; 0 represents the top edge of the input image</value>
        [DataMember(Name="TopY", EmitDefaultValue=false)]
        public int? TopY { get; set; }

        /// <summary>
        /// Width in pixels of the text item
        /// </summary>
        /// <value>Width in pixels of the text item</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Height in pixels of the text item
        /// </summary>
        /// <value>Height in pixels of the text item</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextItem {\n");
            sb.Append("  LeftX: ").Append(LeftX).Append("\n");
            sb.Append("  TopY: ").Append(TopY).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TextItem);
        }

        /// <summary>
        /// Returns true if TextItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TextItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextItem input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
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
                if (this.LeftX != null)
                    hashCode = hashCode * 59 + this.LeftX.GetHashCode();
                if (this.TopY != null)
                    hashCode = hashCode * 59 + this.TopY.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
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
