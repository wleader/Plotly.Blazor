/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.IndicatorLib
{
    /// <summary>
    ///     Determines how the value is displayed on the graph. <c>number</c> displays
    ///     the value numerically in text. <c>delta</c> displays the difference to a
    ///     reference value in text. Finally, <c>gauge</c> displays the value graphically
    ///     on an axis.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeFlag
    {
        [EnumMember(Value=@"number")]
        Number = 1,
        [EnumMember(Value=@"delta")]
        Delta = 2,
        [EnumMember(Value=@"gauge")]
        Gauge = 4
    }
}