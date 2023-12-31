/*
 * Paperless Rest Server
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ApisavedViewsFilterRules : IEquatable<ApisavedViewsFilterRules>
    { 
        /// <summary>
        /// Gets or Sets RuleType
        /// </summary>
        [Required]

        [DataMember(Name="rule_type")]
        public int? RuleType { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [Required]

        [DataMember(Name="value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApisavedViewsFilterRules {\n");
            sb.Append("  RuleType: ").Append(RuleType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ApisavedViewsFilterRules)obj);
        }

        /// <summary>
        /// Returns true if ApisavedViewsFilterRules instances are equal
        /// </summary>
        /// <param name="other">Instance of ApisavedViewsFilterRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApisavedViewsFilterRules other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RuleType == other.RuleType ||
                    RuleType != null &&
                    RuleType.Equals(other.RuleType)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RuleType != null)
                    hashCode = hashCode * 59 + RuleType.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ApisavedViewsFilterRules left, ApisavedViewsFilterRules right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApisavedViewsFilterRules left, ApisavedViewsFilterRules right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
