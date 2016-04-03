using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class EnumTest :  IEquatable<EnumTest>
    { 
    
        /// <summary>
        /// Gets or Sets EnumString
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnumStringEnum {
            
            [EnumMember(Value = "UPPER")]
            Upper,
            
            [EnumMember(Value = "lower")]
            Lower
        }

    
        /// <summary>
        /// Gets or Sets EnumString
        /// </summary>
        [DataMember(Name="enum_string", EmitDefaultValue=false)]
        public EnumStringEnum? EnumString { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTest" /> class.
        /// Initializes a new instance of the <see cref="EnumTest" />class.
        /// </summary>
        /// <param name="EnumString">EnumString.</param>
        /// <param name="EnumInteger">EnumInteger.</param>
        /// <param name="EnumNumber">EnumNumber.</param>

        public EnumTest(EnumStringEnum? EnumString = null, int? EnumInteger = null, double? EnumNumber = null)
        {
            this.EnumString = EnumString;
            this.EnumInteger = EnumInteger;
            this.EnumNumber = EnumNumber;
            
        }
        
    
        /// <summary>
        /// Gets or Sets EnumInteger
        /// </summary>
        [DataMember(Name="enum_integer", EmitDefaultValue=false)]
        public int? EnumInteger { get; set; }
    
        /// <summary>
        /// Gets or Sets EnumNumber
        /// </summary>
        [DataMember(Name="enum_number", EmitDefaultValue=false)]
        public double? EnumNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumTest {\n");
            sb.Append("  EnumString: ").Append(EnumString).Append("\n");
            sb.Append("  EnumInteger: ").Append(EnumInteger).Append("\n");
            sb.Append("  EnumNumber: ").Append(EnumNumber).Append("\n");
            
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
            return this.Equals(obj as EnumTest);
        }

        /// <summary>
        /// Returns true if EnumTest instances are equal
        /// </summary>
        /// <param name="other">Instance of EnumTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumTest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnumString == other.EnumString ||
                    this.EnumString != null &&
                    this.EnumString.Equals(other.EnumString)
                ) && 
                (
                    this.EnumInteger == other.EnumInteger ||
                    this.EnumInteger != null &&
                    this.EnumInteger.Equals(other.EnumInteger)
                ) && 
                (
                    this.EnumNumber == other.EnumNumber ||
                    this.EnumNumber != null &&
                    this.EnumNumber.Equals(other.EnumNumber)
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
                
                if (this.EnumString != null)
                    hash = hash * 59 + this.EnumString.GetHashCode();
                
                if (this.EnumInteger != null)
                    hash = hash * 59 + this.EnumInteger.GetHashCode();
                
                if (this.EnumNumber != null)
                    hash = hash * 59 + this.EnumNumber.GetHashCode();
                
                return hash;
            }
        }
    }

}
