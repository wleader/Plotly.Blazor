/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.IsoSurfaceLib
{
    /// <summary>
    ///     The Lighting class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Lighting : IEquatable<Lighting>
    {
        /// <summary>
        ///     Epsilon for vertex normals calculation avoids math issues arising from degenerate
        ///     geometry.
        /// </summary>
        [JsonPropertyName(@"vertexnormalsepsilon")]
        public decimal? VertexNormalsEpsilon { get; set;} 

        /// <summary>
        ///     Epsilon for face normals calculation avoids math issues arising from degenerate
        ///     geometry.
        /// </summary>
        [JsonPropertyName(@"facenormalsepsilon")]
        public decimal? FaceNormalsEpsilon { get; set;} 

        /// <summary>
        ///     Ambient light increases overall color visibility but can wash out the image.
        /// </summary>
        [JsonPropertyName(@"ambient")]
        public decimal? Ambient { get; set;} 

        /// <summary>
        ///     Represents the extent that incident rays are reflected in a range of angles.
        /// </summary>
        [JsonPropertyName(@"diffuse")]
        public decimal? Diffuse { get; set;} 

        /// <summary>
        ///     Represents the level that incident rays are reflected in a single direction,
        ///     causing shine.
        /// </summary>
        [JsonPropertyName(@"specular")]
        public decimal? Specular { get; set;} 

        /// <summary>
        ///     Alters specular reflection; the rougher the surface, the wider and less
        ///     contrasty the shine.
        /// </summary>
        [JsonPropertyName(@"roughness")]
        public decimal? Roughness { get; set;} 

        /// <summary>
        ///     Represents the reflectance as a dependency of the viewing angle; e.g. paper
        ///     is reflective when viewing it from the edge of the paper (almost 90 degrees),
        ///     causing shine.
        /// </summary>
        [JsonPropertyName(@"fresnel")]
        public decimal? Fresnel { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Lighting other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Lighting other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    VertexNormalsEpsilon == other.VertexNormalsEpsilon ||
                    VertexNormalsEpsilon != null &&
                    VertexNormalsEpsilon.Equals(other.VertexNormalsEpsilon)
                ) && 
                (
                    FaceNormalsEpsilon == other.FaceNormalsEpsilon ||
                    FaceNormalsEpsilon != null &&
                    FaceNormalsEpsilon.Equals(other.FaceNormalsEpsilon)
                ) && 
                (
                    Ambient == other.Ambient ||
                    Ambient != null &&
                    Ambient.Equals(other.Ambient)
                ) && 
                (
                    Diffuse == other.Diffuse ||
                    Diffuse != null &&
                    Diffuse.Equals(other.Diffuse)
                ) && 
                (
                    Specular == other.Specular ||
                    Specular != null &&
                    Specular.Equals(other.Specular)
                ) && 
                (
                    Roughness == other.Roughness ||
                    Roughness != null &&
                    Roughness.Equals(other.Roughness)
                ) && 
                (
                    Fresnel == other.Fresnel ||
                    Fresnel != null &&
                    Fresnel.Equals(other.Fresnel)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (VertexNormalsEpsilon != null) hashCode = hashCode * 59 + VertexNormalsEpsilon.GetHashCode();
                if (FaceNormalsEpsilon != null) hashCode = hashCode * 59 + FaceNormalsEpsilon.GetHashCode();
                if (Ambient != null) hashCode = hashCode * 59 + Ambient.GetHashCode();
                if (Diffuse != null) hashCode = hashCode * 59 + Diffuse.GetHashCode();
                if (Specular != null) hashCode = hashCode * 59 + Specular.GetHashCode();
                if (Roughness != null) hashCode = hashCode * 59 + Roughness.GetHashCode();
                if (Fresnel != null) hashCode = hashCode * 59 + Fresnel.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Lighting and the right Lighting.
        /// </summary>
        /// <param name="left">Left Lighting.</param>
        /// <param name="right">Right Lighting.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Lighting left, Lighting right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Lighting and the right Lighting.
        /// </summary>
        /// <param name="left">Left Lighting.</param>
        /// <param name="right">Right Lighting.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Lighting left, Lighting right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Lighting</returns>
        public Lighting DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Lighting) formatter.Deserialize(ms);
        }
    }
}