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

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// ApplicationToken
    /// </summary>
    [DataContract]
    public partial class ApplicationToken :  IEquatable<ApplicationToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationToken" /> class.
        /// </summary>
        /// <param name="AccessToken">AccessToken.</param>
        /// <param name="ExpiresIn">ExpiresIn.</param>
        /// <param name="TokenType">TokenType.</param>
        public ApplicationToken(string AccessToken = default(string), int? ExpiresIn = default(int?), string TokenType = default(string))
        {
            this.AccessToken = AccessToken;
            this.ExpiresIn = ExpiresIn;
            this.TokenType = TokenType;
        }
        
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }
        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationToken {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ApplicationToken);
        }

        /// <summary>
        /// Returns true if ApplicationToken instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationToken other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.ExpiresIn == other.ExpiresIn ||
                    this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(other.ExpiresIn)
                ) && 
                (
                    this.TokenType == other.TokenType ||
                    this.TokenType != null &&
                    this.TokenType.Equals(other.TokenType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.ExpiresIn != null)
                    hash = hash * 59 + this.ExpiresIn.GetHashCode();
                if (this.TokenType != null)
                    hash = hash * 59 + this.TokenType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
