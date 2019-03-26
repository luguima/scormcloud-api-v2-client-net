/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0 beta
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
    /// CredentialCreatedSchema
    /// </summary>
    [DataContract]
    public partial class CredentialCreatedSchema :  IEquatable<CredentialCreatedSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialCreatedSchema" /> class.
        /// </summary>
        /// <param name="id">id for this credential.</param>
        /// <param name="name">name for this credential.</param>
        /// <param name="credential">The newly created API credential.</param>
        /// <param name="pensCredential">The PENS key for this credential.</param>
        /// <param name="status">status.</param>
        public CredentialCreatedSchema(string id = default(string), string name = default(string), string credential = default(string), string pensCredential = default(string), string status = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Credential = credential;
            this.PensCredential = pensCredential;
            this.Status = status;
        }
        
        /// <summary>
        /// id for this credential
        /// </summary>
        /// <value>id for this credential</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// name for this credential
        /// </summary>
        /// <value>name for this credential</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The newly created API credential
        /// </summary>
        /// <value>The newly created API credential</value>
        [DataMember(Name="credential", EmitDefaultValue=false)]
        public string Credential { get; set; }

        /// <summary>
        /// The PENS key for this credential
        /// </summary>
        /// <value>The PENS key for this credential</value>
        [DataMember(Name="pensCredential", EmitDefaultValue=false)]
        public string PensCredential { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredentialCreatedSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Credential: ").Append(Credential).Append("\n");
            sb.Append("  PensCredential: ").Append(PensCredential).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as CredentialCreatedSchema);
        }

        /// <summary>
        /// Returns true if CredentialCreatedSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of CredentialCreatedSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialCreatedSchema input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Credential == input.Credential ||
                    (this.Credential != null &&
                    this.Credential.Equals(input.Credential))
                ) && 
                (
                    this.PensCredential == input.PensCredential ||
                    (this.PensCredential != null &&
                    this.PensCredential.Equals(input.PensCredential))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Credential != null)
                    hashCode = hashCode * 59 + this.Credential.GetHashCode();
                if (this.PensCredential != null)
                    hashCode = hashCode * 59 + this.PensCredential.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
