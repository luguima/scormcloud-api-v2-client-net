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
    /// CreatePrivateInvitationSchema
    /// </summary>
    [DataContract]
    public partial class CreatePrivateInvitationSchema :  IEquatable<CreatePrivateInvitationSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateInvitationSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePrivateInvitationSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateInvitationSchema" /> class.
        /// </summary>
        /// <param name="courseId">The id of the course for which to create an invitation. (required).</param>
        /// <param name="creatingUserEmail">The email of the user who is creating the invitation. (required).</param>
        /// <param name="invitationEmail">invitationEmail (required).</param>
        /// <param name="postBack">Specifies a URL for which to post activity and status data in real time as the course is completed.</param>
        /// <param name="expirationDate">The ISO 8601 TimeStamp (defaults to UTC) after which this invitation will expire and can no longer be launched. An empty value will represent no expiration date. .</param>
        /// <param name="tags">Optional tags to be applied to this invitation..</param>
        public CreatePrivateInvitationSchema(string courseId = default(string), string creatingUserEmail = default(string), InvitationEmailSchema invitationEmail = default(InvitationEmailSchema), PostBackSchema postBack = default(PostBackSchema), DateTime? expirationDate = default(DateTime?), List<string> tags = default(List<string>))
        {
            // to ensure "courseId" is required (not null)
            if (courseId == null)
            {
                throw new InvalidDataException("courseId is a required property for CreatePrivateInvitationSchema and cannot be null");
            }
            else
            {
                this.CourseId = courseId;
            }
            // to ensure "creatingUserEmail" is required (not null)
            if (creatingUserEmail == null)
            {
                throw new InvalidDataException("creatingUserEmail is a required property for CreatePrivateInvitationSchema and cannot be null");
            }
            else
            {
                this.CreatingUserEmail = creatingUserEmail;
            }
            // to ensure "invitationEmail" is required (not null)
            if (invitationEmail == null)
            {
                throw new InvalidDataException("invitationEmail is a required property for CreatePrivateInvitationSchema and cannot be null");
            }
            else
            {
                this.InvitationEmail = invitationEmail;
            }
            this.PostBack = postBack;
            this.ExpirationDate = expirationDate;
            this.Tags = tags;
        }
        
        /// <summary>
        /// The id of the course for which to create an invitation.
        /// </summary>
        /// <value>The id of the course for which to create an invitation.</value>
        [DataMember(Name="courseId", EmitDefaultValue=false)]
        public string CourseId { get; set; }

        /// <summary>
        /// The email of the user who is creating the invitation.
        /// </summary>
        /// <value>The email of the user who is creating the invitation.</value>
        [DataMember(Name="creatingUserEmail", EmitDefaultValue=false)]
        public string CreatingUserEmail { get; set; }

        /// <summary>
        /// Gets or Sets InvitationEmail
        /// </summary>
        [DataMember(Name="invitationEmail", EmitDefaultValue=false)]
        public InvitationEmailSchema InvitationEmail { get; set; }

        /// <summary>
        /// Specifies a URL for which to post activity and status data in real time as the course is completed
        /// </summary>
        /// <value>Specifies a URL for which to post activity and status data in real time as the course is completed</value>
        [DataMember(Name="postBack", EmitDefaultValue=false)]
        public PostBackSchema PostBack { get; set; }

        /// <summary>
        /// The ISO 8601 TimeStamp (defaults to UTC) after which this invitation will expire and can no longer be launched. An empty value will represent no expiration date. 
        /// </summary>
        /// <value>The ISO 8601 TimeStamp (defaults to UTC) after which this invitation will expire and can no longer be launched. An empty value will represent no expiration date. </value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Optional tags to be applied to this invitation.
        /// </summary>
        /// <value>Optional tags to be applied to this invitation.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateInvitationSchema {\n");
            sb.Append("  CourseId: ").Append(CourseId).Append("\n");
            sb.Append("  CreatingUserEmail: ").Append(CreatingUserEmail).Append("\n");
            sb.Append("  InvitationEmail: ").Append(InvitationEmail).Append("\n");
            sb.Append("  PostBack: ").Append(PostBack).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as CreatePrivateInvitationSchema);
        }

        /// <summary>
        /// Returns true if CreatePrivateInvitationSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePrivateInvitationSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePrivateInvitationSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CourseId == input.CourseId ||
                    (this.CourseId != null &&
                    this.CourseId.Equals(input.CourseId))
                ) && 
                (
                    this.CreatingUserEmail == input.CreatingUserEmail ||
                    (this.CreatingUserEmail != null &&
                    this.CreatingUserEmail.Equals(input.CreatingUserEmail))
                ) && 
                (
                    this.InvitationEmail == input.InvitationEmail ||
                    (this.InvitationEmail != null &&
                    this.InvitationEmail.Equals(input.InvitationEmail))
                ) && 
                (
                    this.PostBack == input.PostBack ||
                    (this.PostBack != null &&
                    this.PostBack.Equals(input.PostBack))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.CourseId != null)
                    hashCode = hashCode * 59 + this.CourseId.GetHashCode();
                if (this.CreatingUserEmail != null)
                    hashCode = hashCode * 59 + this.CreatingUserEmail.GetHashCode();
                if (this.InvitationEmail != null)
                    hashCode = hashCode * 59 + this.InvitationEmail.GetHashCode();
                if (this.PostBack != null)
                    hashCode = hashCode * 59 + this.PostBack.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
