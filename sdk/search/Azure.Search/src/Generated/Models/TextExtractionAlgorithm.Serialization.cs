// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Models
{
    internal static class TextExtractionAlgorithmExtensions
    {
        public static string ToSerialString(this TextExtractionAlgorithm value) => value switch
        {
            TextExtractionAlgorithm.Printed => "printed",
            TextExtractionAlgorithm.Handwritten => "handwritten",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TextExtractionAlgorithm value.")
        };

        public static TextExtractionAlgorithm ToTextExtractionAlgorithm(this string value)
        {
            if (string.Equals(value, "printed", StringComparison.InvariantCultureIgnoreCase)) return TextExtractionAlgorithm.Printed;
            if (string.Equals(value, "handwritten", StringComparison.InvariantCultureIgnoreCase)) return TextExtractionAlgorithm.Handwritten;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TextExtractionAlgorithm value.");
        }
    }
}