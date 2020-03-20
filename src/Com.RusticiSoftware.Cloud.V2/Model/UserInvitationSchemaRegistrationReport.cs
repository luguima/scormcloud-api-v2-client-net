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
    /// An high level overview of information about the registration of the user to the invitation.
    /// </summary>
    [DataContract]
    public partial class UserInvitationSchemaRegistrationReport :  IEquatable<UserInvitationSchemaRegistrationReport>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [DataMember(Name="complete", EmitDefaultValue=false)]
        public RegistrationCompletion? Complete { get; set; }
        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public RegistrationSuccess? Success { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationSchemaRegistrationReport" /> class.
        /// </summary>
        /// <param name="complete">complete.</param>
        /// <param name="success">success.</param>
        /// <param name="totalSecondsTracked">totalSecondsTracked.</param>
        /// <param name="score">score.</param>
        public UserInvitationSchemaRegistrationReport(RegistrationCompletion? complete = default(RegistrationCompletion?), RegistrationSuccess? success = default(RegistrationSuccess?), double? totalSecondsTracked = default(double?), ScoreSchema score = default(ScoreSchema))
        {
            this.Complete = complete;
            this.Success = success;
            this.TotalSecondsTracked = totalSecondsTracked;
            this.Score = score;
        }
        


        /// <summary>
        /// Gets or Sets TotalSecondsTracked
        /// </summary>
        [DataMember(Name="totalSecondsTracked", EmitDefaultValue=false)]
        public double? TotalSecondsTracked { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public ScoreSchema Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInvitationSchemaRegistrationReport {\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  TotalSecondsTracked: ").Append(TotalSecondsTracked).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as UserInvitationSchemaRegistrationReport);
        }

        /// <summary>
        /// Returns true if UserInvitationSchemaRegistrationReport instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInvitationSchemaRegistrationReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInvitationSchemaRegistrationReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Complete == input.Complete ||
                    (this.Complete != null &&
                    this.Complete.Equals(input.Complete))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.TotalSecondsTracked == input.TotalSecondsTracked ||
                    (this.TotalSecondsTracked != null &&
                    this.TotalSecondsTracked.Equals(input.TotalSecondsTracked))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
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
                if (this.Complete != null)
                    hashCode = hashCode * 59 + this.Complete.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.TotalSecondsTracked != null)
                    hashCode = hashCode * 59 + this.TotalSecondsTracked.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
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
