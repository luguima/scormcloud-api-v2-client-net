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
    /// CompletionAmountSchema
    /// </summary>
    [DataContract]
    public partial class CompletionAmountSchema :  IEquatable<CompletionAmountSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionAmountSchema" /> class.
        /// </summary>
        /// <param name="scaled">Scaled completion amount between 0 and 100.</param>
        public CompletionAmountSchema(double? scaled = default(double?))
        {
            this.Scaled = scaled;
        }
        
        /// <summary>
        /// Scaled completion amount between 0 and 100
        /// </summary>
        /// <value>Scaled completion amount between 0 and 100</value>
        [DataMember(Name="scaled", EmitDefaultValue=false)]
        public double? Scaled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletionAmountSchema {\n");
            sb.Append("  Scaled: ").Append(Scaled).Append("\n");
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
            return this.Equals(input as CompletionAmountSchema);
        }

        /// <summary>
        /// Returns true if CompletionAmountSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of CompletionAmountSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletionAmountSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Scaled == input.Scaled ||
                    (this.Scaled != null &&
                    this.Scaled.Equals(input.Scaled))
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
                if (this.Scaled != null)
                    hashCode = hashCode * 59 + this.Scaled.GetHashCode();
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
