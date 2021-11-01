/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0
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
using SwaggerDateConverter = Com.RusticiSoftware.Cloud.V2.Client.SwaggerDateConverter;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// RegistrationListSchema
    /// </summary>
    [DataContract]
    public partial class RegistrationListSchema :  IEquatable<RegistrationListSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationListSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegistrationListSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationListSchema" /> class.
        /// </summary>
        /// <param name="registrations">registrations (required).</param>
        /// <param name="more">Token for getting the next set of results, from the prior set of results..</param>
        public RegistrationListSchema(List<RegistrationSchema> registrations = default(List<RegistrationSchema>), string more = default(string))
        {
            // to ensure "registrations" is required (not null)
            if (registrations == null)
            {
                throw new InvalidDataException("registrations is a required property for RegistrationListSchema and cannot be null");
            }
            else
            {
                this.Registrations = registrations;
            }
            this.More = more;
        }
        
        /// <summary>
        /// Gets or Sets Registrations
        /// </summary>
        [DataMember(Name="registrations", EmitDefaultValue=false)]
        public List<RegistrationSchema> Registrations { get; set; }

        /// <summary>
        /// Token for getting the next set of results, from the prior set of results.
        /// </summary>
        /// <value>Token for getting the next set of results, from the prior set of results.</value>
        [DataMember(Name="more", EmitDefaultValue=false)]
        public string More { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegistrationListSchema {\n");
            sb.Append("  Registrations: ").Append(Registrations).Append("\n");
            sb.Append("  More: ").Append(More).Append("\n");
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
            return this.Equals(input as RegistrationListSchema);
        }

        /// <summary>
        /// Returns true if RegistrationListSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationListSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationListSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Registrations == input.Registrations ||
                    this.Registrations != null &&
                    this.Registrations.SequenceEqual(input.Registrations)
                ) && 
                (
                    this.More == input.More ||
                    (this.More != null &&
                    this.More.Equals(input.More))
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
                if (this.Registrations != null)
                    hashCode = hashCode * 59 + this.Registrations.GetHashCode();
                if (this.More != null)
                    hashCode = hashCode * 59 + this.More.GetHashCode();
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
