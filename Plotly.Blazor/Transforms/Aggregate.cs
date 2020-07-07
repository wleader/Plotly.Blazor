/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Transforms
{
    /// <summary>
    ///     The Aggregate class.
    ///     Implements the <see cref="ITransform" />.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Aggregate : ITransform, IEquatable<Aggregate>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TransformTypeEnum? Type { get; } = TransformTypeEnum.Aggregate;

        /// <summary>
        ///     Determines whether this aggregate transform is enabled or disabled.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

        /// <summary>
        ///     Sets the grouping target to which the aggregation is applied. Data points
        ///     with matching group values will be coalesced into one point, using the supplied
        ///     aggregation functions to reduce data in other data arrays. If a string,
        ///     <c>groups</c> is assumed to be a reference to a data array in the parent
        ///     trace object. To aggregate by nested variables, use <c>.</c> to access them.
        ///     For example, set <c>groups</c> to <c>marker.color</c> to aggregate about
        ///     the marker color array. If an array, <c>groups</c> is itself the data array
        ///     by which we aggregate.
        /// </summary>
        [JsonPropertyName(@"groups")]
        public string Groups { get; set;} 

        /// <summary>
        ///     Sets the grouping target to which the aggregation is applied. Data points
        ///     with matching group values will be coalesced into one point, using the supplied
        ///     aggregation functions to reduce data in other data arrays. If a string,
        ///     <c>groups</c> is assumed to be a reference to a data array in the parent
        ///     trace object. To aggregate by nested variables, use <c>.</c> to access them.
        ///     For example, set <c>groups</c> to <c>marker.color</c> to aggregate about
        ///     the marker color array. If an array, <c>groups</c> is itself the data array
        ///     by which we aggregate.
        /// </summary>
        [JsonPropertyName(@"groups")]
        [Array]
        public IList<string> GroupsArray { get; set;} 

        /// <summary>
        ///     Gets or sets the Aggregations.
        /// </summary>
        [JsonPropertyName(@"aggregations")]
        public IList<Plotly.Blazor.Transforms.AggregateLib.Aggregation> Aggregations { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  groups .
        /// </summary>
        [JsonPropertyName(@"groupssrc")]
        public string GroupsSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Aggregate other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Aggregate other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Enabled == other.Enabled ||
                    Enabled != null &&
                    Enabled.Equals(other.Enabled)
                ) && 
                (
                    Groups == other.Groups ||
                    Groups != null &&
                    Groups.Equals(other.Groups)
                ) && 
                (
                    Equals(GroupsArray, other.GroupsArray) ||
                    GroupsArray != null && other.GroupsArray != null &&
                    GroupsArray.SequenceEqual(other.GroupsArray)
                ) &&
                (
                    Equals(Aggregations, other.Aggregations) ||
                    Aggregations != null && other.Aggregations != null &&
                    Aggregations.SequenceEqual(other.Aggregations)
                ) &&
                (
                    GroupsSrc == other.GroupsSrc ||
                    GroupsSrc != null &&
                    GroupsSrc.Equals(other.GroupsSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Enabled != null) hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (Groups != null) hashCode = hashCode * 59 + Groups.GetHashCode();
                if (GroupsArray != null) hashCode = hashCode * 59 + GroupsArray.GetHashCode();
                if (Aggregations != null) hashCode = hashCode * 59 + Aggregations.GetHashCode();
                if (GroupsSrc != null) hashCode = hashCode * 59 + GroupsSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Aggregate and the right Aggregate.
        /// </summary>
        /// <param name="left">Left Aggregate.</param>
        /// <param name="right">Right Aggregate.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Aggregate left, Aggregate right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Aggregate and the right Aggregate.
        /// </summary>
        /// <param name="left">Left Aggregate.</param>
        /// <param name="right">Right Aggregate.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Aggregate left, Aggregate right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Aggregate</returns>
        public Aggregate DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Aggregate) formatter.Deserialize(ms);
        }
    }
}