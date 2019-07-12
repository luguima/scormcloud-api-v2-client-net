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
    /// SettingItem
    /// </summary>
    [DataContract]
    public partial class SettingItem :  IEquatable<SettingItem>, IValidatableObject
    {
        /// <summary>
        /// The source of this effective value, default, fallback, or the level the value was set at.
        /// </summary>
        /// <value>The source of this effective value, default, fallback, or the level the value was set at.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EffectiveValueSourceEnum
        {
            
            /// <summary>
            /// Enum Default for "default"
            /// </summary>
            [EnumMember(Value = "default")]
            Default,
            
            /// <summary>
            /// Enum Fallback for "fallback"
            /// </summary>
            [EnumMember(Value = "fallback")]
            Fallback,
            
            /// <summary>
            /// Enum Base for "base"
            /// </summary>
            [EnumMember(Value = "base")]
            Base,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum LearningStandard for "learningStandard"
            /// </summary>
            [EnumMember(Value = "learningStandard")]
            LearningStandard,
            
            /// <summary>
            /// Enum Application for "application"
            /// </summary>
            [EnumMember(Value = "application")]
            Application,
            
            /// <summary>
            /// Enum LearningStandardForApplication for "learningStandardForApplication"
            /// </summary>
            [EnumMember(Value = "learningStandardForApplication")]
            LearningStandardForApplication,
            
            /// <summary>
            /// Enum DispatchDestination for "dispatchDestination"
            /// </summary>
            [EnumMember(Value = "dispatchDestination")]
            DispatchDestination,
            
            /// <summary>
            /// Enum Course for "course"
            /// </summary>
            [EnumMember(Value = "course")]
            Course,
            
            /// <summary>
            /// Enum DispatchDestinationForCourse for "dispatchDestinationForCourse"
            /// </summary>
            [EnumMember(Value = "dispatchDestinationForCourse")]
            DispatchDestinationForCourse,
            
            /// <summary>
            /// Enum Registration for "registration"
            /// </summary>
            [EnumMember(Value = "registration")]
            Registration
        }

        /// <summary>
        /// The source of this effective value, default, fallback, or the level the value was set at.
        /// </summary>
        /// <value>The source of this effective value, default, fallback, or the level the value was set at.</value>
        [DataMember(Name="effectiveValueSource", EmitDefaultValue=false)]
        public EffectiveValueSourceEnum? EffectiveValueSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingItem" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="EffectiveValue">The value of this setting that would be used if read at this level, including defaults, fallback, and values set at less specific levels..</param>
        /// <param name="EffectiveValueSource">The source of this effective value, default, fallback, or the level the value was set at..</param>
        /// <param name="ExplicitValue">The value of this setting that is explicitly set at this level. If not present, the setting is not specified at this level..</param>
        /// <param name="Metadata">Metadata.</param>
        public SettingItem(string Id = default(string), string EffectiveValue = default(string), EffectiveValueSourceEnum? EffectiveValueSource = default(EffectiveValueSourceEnum?), string ExplicitValue = default(string), SettingMetadata Metadata = default(SettingMetadata))
        {
            this.Id = Id;
            this.EffectiveValue = EffectiveValue;
            this.EffectiveValueSource = EffectiveValueSource;
            this.ExplicitValue = ExplicitValue;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The value of this setting that would be used if read at this level, including defaults, fallback, and values set at less specific levels.
        /// </summary>
        /// <value>The value of this setting that would be used if read at this level, including defaults, fallback, and values set at less specific levels.</value>
        [DataMember(Name="effectiveValue", EmitDefaultValue=false)]
        public string EffectiveValue { get; set; }
        /// <summary>
        /// The value of this setting that is explicitly set at this level. If not present, the setting is not specified at this level.
        /// </summary>
        /// <value>The value of this setting that is explicitly set at this level. If not present, the setting is not specified at this level.</value>
        [DataMember(Name="explicitValue", EmitDefaultValue=false)]
        public string ExplicitValue { get; set; }
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public SettingMetadata Metadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EffectiveValue: ").Append(EffectiveValue).Append("\n");
            sb.Append("  EffectiveValueSource: ").Append(EffectiveValueSource).Append("\n");
            sb.Append("  ExplicitValue: ").Append(ExplicitValue).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as SettingItem);
        }

        /// <summary>
        /// Returns true if SettingItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SettingItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.EffectiveValue == other.EffectiveValue ||
                    this.EffectiveValue != null &&
                    this.EffectiveValue.Equals(other.EffectiveValue)
                ) && 
                (
                    this.EffectiveValueSource == other.EffectiveValueSource ||
                    this.EffectiveValueSource != null &&
                    this.EffectiveValueSource.Equals(other.EffectiveValueSource)
                ) && 
                (
                    this.ExplicitValue == other.ExplicitValue ||
                    this.ExplicitValue != null &&
                    this.ExplicitValue.Equals(other.ExplicitValue)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.EffectiveValue != null)
                    hash = hash * 59 + this.EffectiveValue.GetHashCode();
                if (this.EffectiveValueSource != null)
                    hash = hash * 59 + this.EffectiveValueSource.GetHashCode();
                if (this.ExplicitValue != null)
                    hash = hash * 59 + this.ExplicitValue.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
