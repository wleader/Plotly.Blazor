/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.TreeMapLib
{
    /// <summary>
    ///     The PathBar class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class PathBar : IEquatable<PathBar>
    {
        /// <summary>
        ///     Determines if the path bar is drawn i.e. outside the trace <c>domain</c>
        ///     and with one pixel gap.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Determines on which side of the the treemap the <c>pathbar</c> should be
        ///     presented.
        /// </summary>
        [JsonPropertyName(@"side")]
        public Plotly.Blazor.Traces.TreeMapLib.PathBarLib.SideEnum? Side { get; set;} 

        /// <summary>
        ///     Determines which shape is used for edges between <c>barpath</c> labels.
        /// </summary>
        [JsonPropertyName(@"edgeshape")]
        public Plotly.Blazor.Traces.TreeMapLib.PathBarLib.EdgeShapeEnum? EdgeShape { get; set;} 

        /// <summary>
        ///     Sets the thickness of <c>pathbar</c> (in px). If not specified the <c>pathbar.textfont.size</c>
        ///     is used with 3 pixles extra padding on each side.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public decimal? Thickness { get; set;} 

        /// <summary>
        ///     Sets the font used inside <c>pathbar</c>.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public Plotly.Blazor.Traces.TreeMapLib.PathBarLib.TextFont TextFont { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is PathBar other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] PathBar other)
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
                    Side == other.Side ||
                    Side != null &&
                    Side.Equals(other.Side)
                ) && 
                (
                    EdgeShape == other.EdgeShape ||
                    EdgeShape != null &&
                    EdgeShape.Equals(other.EdgeShape)
                ) && 
                (
                    Thickness == other.Thickness ||
                    Thickness != null &&
                    Thickness.Equals(other.Thickness)
                ) && 
                (
                    TextFont == other.TextFont ||
                    TextFont != null &&
                    TextFont.Equals(other.TextFont)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (Side != null) hashCode = hashCode * 59 + Side.GetHashCode();
                if (EdgeShape != null) hashCode = hashCode * 59 + EdgeShape.GetHashCode();
                if (Thickness != null) hashCode = hashCode * 59 + Thickness.GetHashCode();
                if (TextFont != null) hashCode = hashCode * 59 + TextFont.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left PathBar and the right PathBar.
        /// </summary>
        /// <param name="left">Left PathBar.</param>
        /// <param name="right">Right PathBar.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (PathBar left, PathBar right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left PathBar and the right PathBar.
        /// </summary>
        /// <param name="left">Left PathBar.</param>
        /// <param name="right">Right PathBar.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (PathBar left, PathBar right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>PathBar</returns>
        public PathBar DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (PathBar) formatter.Deserialize(ms);
        }
    }
}