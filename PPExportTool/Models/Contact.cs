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
    /// Represents a contact. Each account can have multiple contacts. One of them must be the primary contact
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="AccountRef"> .</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="PhoneMobile">This will be used to send text message reminders and notifications to this contact.</param>
        /// <param name="PhoneHome">PhoneHome.</param>
        /// <param name="PhoneFax">PhoneFax.</param>
        /// <param name="PhoneWork">PhoneWork.</param>
        /// <param name="Email">Must be a valid email address.</param>
        /// <param name="Notes">Can be either plain text or HTML..</param>
        /// <param name="CustomFieldValues">This is a list of custom field values related to this contact.</param>
        public Contact(Guid? Id = default(Guid?), AccountReference AccountRef = default(AccountReference), string FirstName = default(string), string LastName = default(string), string PhoneMobile = default(string), string PhoneHome = default(string), string PhoneFax = default(string), string PhoneWork = default(string), string Email = default(string), string Notes = default(string), List<CustomFieldValue> CustomFieldValues = default(List<CustomFieldValue>))
        {
            this.Id = Id;
            this.AccountRef = AccountRef;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneMobile = PhoneMobile;
            this.PhoneHome = PhoneHome;
            this.PhoneFax = PhoneFax;
            this.PhoneWork = PhoneWork;
            this.Email = Email;
            this.Notes = Notes;
            this.CustomFieldValues = CustomFieldValues;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name="account_ref", EmitDefaultValue=false)]
        public AccountReference AccountRef { get; set; }

        /// <summary>
        /// This will be set to true if this contact is a primary contact for the account This will be set to true if this contact is a primary contact for the account
        /// </summary>
        /// <value>This will be set to true if this contact is a primary contact for the account This will be set to true if this contact is a primary contact for the account</value>
        [DataMember(Name="is_primary_contact", EmitDefaultValue=false)]
        public bool? IsPrimaryContact { get; private set; }

        /// <summary>
        /// This is the display name for the contact. It is read-only and set automatically based on the user settings in the UI This is the display name for the contact. It is read-only and set automatically based on the user settings in the UI
        /// </summary>
        /// <value>This is the display name for the contact. It is read-only and set automatically based on the user settings in the UI This is the display name for the contact. It is read-only and set automatically based on the user settings in the UI</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// This will be used to send text message reminders and notifications to this contact
        /// </summary>
        /// <value>This will be used to send text message reminders and notifications to this contact</value>
        [DataMember(Name="phone_mobile", EmitDefaultValue=false)]
        public string PhoneMobile { get; set; }

        /// <summary>
        /// Gets or Sets PhoneHome
        /// </summary>
        [DataMember(Name="phone_home", EmitDefaultValue=false)]
        public string PhoneHome { get; set; }

        /// <summary>
        /// Gets or Sets PhoneFax
        /// </summary>
        [DataMember(Name="phone_fax", EmitDefaultValue=false)]
        public string PhoneFax { get; set; }

        /// <summary>
        /// Gets or Sets PhoneWork
        /// </summary>
        [DataMember(Name="phone_work", EmitDefaultValue=false)]
        public string PhoneWork { get; set; }

        /// <summary>
        /// Must be a valid email address
        /// </summary>
        /// <value>Must be a valid email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Can be either plain text or HTML.
        /// </summary>
        /// <value>Can be either plain text or HTML.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// This is a list of custom field values related to this contact
        /// </summary>
        /// <value>This is a list of custom field values related to this contact</value>
        [DataMember(Name="custom_field_values", EmitDefaultValue=false)]
        public List<CustomFieldValue> CustomFieldValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountRef: ").Append(AccountRef).Append("\n");
            sb.Append("  IsPrimaryContact: ").Append(IsPrimaryContact).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneMobile: ").Append(PhoneMobile).Append("\n");
            sb.Append("  PhoneHome: ").Append(PhoneHome).Append("\n");
            sb.Append("  PhoneFax: ").Append(PhoneFax).Append("\n");
            sb.Append("  PhoneWork: ").Append(PhoneWork).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  CustomFieldValues: ").Append(CustomFieldValues).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
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
                    this.AccountRef == input.AccountRef ||
                    (this.AccountRef != null &&
                    this.AccountRef.Equals(input.AccountRef))
                ) && 
                (
                    this.IsPrimaryContact == input.IsPrimaryContact ||
                    (this.IsPrimaryContact != null &&
                    this.IsPrimaryContact.Equals(input.IsPrimaryContact))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.PhoneMobile == input.PhoneMobile ||
                    (this.PhoneMobile != null &&
                    this.PhoneMobile.Equals(input.PhoneMobile))
                ) && 
                (
                    this.PhoneHome == input.PhoneHome ||
                    (this.PhoneHome != null &&
                    this.PhoneHome.Equals(input.PhoneHome))
                ) && 
                (
                    this.PhoneFax == input.PhoneFax ||
                    (this.PhoneFax != null &&
                    this.PhoneFax.Equals(input.PhoneFax))
                ) && 
                (
                    this.PhoneWork == input.PhoneWork ||
                    (this.PhoneWork != null &&
                    this.PhoneWork.Equals(input.PhoneWork))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.CustomFieldValues == input.CustomFieldValues ||
                    this.CustomFieldValues != null &&
                    this.CustomFieldValues.SequenceEqual(input.CustomFieldValues)
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
                if (this.AccountRef != null)
                    hashCode = hashCode * 59 + this.AccountRef.GetHashCode();
                if (this.IsPrimaryContact != null)
                    hashCode = hashCode * 59 + this.IsPrimaryContact.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.PhoneMobile != null)
                    hashCode = hashCode * 59 + this.PhoneMobile.GetHashCode();
                if (this.PhoneHome != null)
                    hashCode = hashCode * 59 + this.PhoneHome.GetHashCode();
                if (this.PhoneFax != null)
                    hashCode = hashCode * 59 + this.PhoneFax.GetHashCode();
                if (this.PhoneWork != null)
                    hashCode = hashCode * 59 + this.PhoneWork.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.CustomFieldValues != null)
                    hashCode = hashCode * 59 + this.CustomFieldValues.GetHashCode();
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
