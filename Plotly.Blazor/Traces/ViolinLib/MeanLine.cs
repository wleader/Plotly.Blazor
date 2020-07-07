/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ViolinLib
{
    /// <summary>
    ///     The MeanLine class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class MeanLine : IEquatable<MeanLine>
    {
        /// <summary>
        ///     Determines if a line corresponding to the sample&#39;s mean is shown inside
        ///     the violins. If <c>box.visible</c> is turned on, the mean line is drawn
        ///     inside the inner box. Otherwise, the mean line is drawn from one side of
        ///     the violin to other.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the mean line color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the mean line width.
        /// </summary>
        [JsonPropertyName(@"width")]
        public decimal? Width { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is MeanLine other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] MeanLine other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Visible == other.Visible ||
                    Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left MeanLine and the right MeanLine.
        /// </summary>
        /// <param name="left">Left MeanLine.</param>
        /// <param name="right">Right MeanLine.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (MeanLine left, MeanLine right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left MeanLine and the right MeanLine.
        /// </summary>
        /// <param name="left">Left MeanLine.</param>
        /// <param name="right">Right MeanLine.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (MeanLine left, MeanLine right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>MeanLine</returns>
        public MeanLine DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (MeanLine) formatter.Deserialize(ms);
        }
    }
}