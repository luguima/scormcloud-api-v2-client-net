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

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// ApplicationListSchema
    /// </summary>
    [DataContract]
    public partial class ApplicationListSchema :  IEquatable<ApplicationListSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationListSchema" /> class.
        /// </summary>
        /// <param name="Applications">Applications.</param>
        public ApplicationListSchema(List<ApplicationSchema> Applications = default(List<ApplicationSchema>))
        {
            this.Applications = Applications;
        }
        
        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public List<ApplicationSchema> Applications { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationListSchema {\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
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
            return this.Equals(obj as ApplicationListSchema);
        }

        /// <summary>
        /// Returns true if ApplicationListSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationListSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationListSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Applications == other.Applications ||
                    this.Applications != null &&
                    this.Applications.SequenceEqual(other.Applications)
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
                if (this.Applications != null)
                    hash = hash * 59 + this.Applications.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
