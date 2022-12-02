/* 
 * PracticePanther KISS Api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2
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

namespace PracticePanther.Api.Model
{
    /// <summary>
    /// CustomFieldRef
    /// </summary>
    [DataContract]
    public partial class CustomFieldRef :  IEquatable<CustomFieldRef>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            
            /// <summary>
            /// Enum TextBox for "TextBox"
            /// </summary>
            [EnumMember(Value = "TextBox")]
            TextBox = 1,
            
            /// <summary>
            /// Enum Date for "Date"
            /// </summary>
            [EnumMember(Value = "Date")]
            Date = 2,
            
            /// <summary>
            /// Enum DateTime for "DateTime"
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 3,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number = 4,
            
            /// <summary>
            /// Enum Currency for "Currency"
            /// </summary>
            [EnumMember(Value = "Currency")]
            Currency = 5,
            
            /// <summary>
            /// Enum TextEditor for "TextEditor"
            /// </summary>
            [EnumMember(Value = "TextEditor")]
            TextEditor = 6,
            
            /// <summary>
            /// Enum DropDownList for "DropDownList"
            /// </summary>
            [EnumMember(Value = "DropDownList")]
            DropDownList = 7,
            
            /// <summary>
            /// Enum Checkbox for "Checkbox"
            /// </summary>
            [EnumMember(Value = "Checkbox")]
            Checkbox = 8,
            
            /// <summary>
            /// Enum Contact for "Contact"
            /// </summary>
            [EnumMember(Value = "Contact")]
            Contact = 9
        }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="value_type", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomFieldRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldRef" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Label">Label.</param>
        /// <param name="ValueType">ValueType.</param>
        public CustomFieldRef(Guid? Id = default(Guid?), string Label = default(string), ValueTypeEnum? ValueType = default(ValueTypeEnum?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CustomFieldRef and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Label = Label;
            this.ValueType = ValueType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomFieldRef {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
            return this.Equals(input as CustomFieldRef);
        }

        /// <summary>
        /// Returns true if CustomFieldRef instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomFieldRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomFieldRef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
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
