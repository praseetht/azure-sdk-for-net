// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Extracted information from a single page. </summary>
    internal partial class PageResult_internal
    {
        /// <summary> Initializes a new instance of PageResult_internal. </summary>
        internal PageResult_internal()
        {
        }

        /// <summary> Initializes a new instance of PageResult_internal. </summary>
        /// <param name="page"> Page number. </param>
        /// <param name="clusterId"> Cluster identifier. </param>
        /// <param name="keyValuePairs"> List of key-value pairs extracted from the page. </param>
        /// <param name="tables"> List of data tables extracted from the page. </param>
        internal PageResult_internal(int page, int? clusterId, IList<KeyValuePair_internal> keyValuePairs, IList<DataTable_internal> tables)
        {
            Page = page;
            ClusterId = clusterId;
            KeyValuePairs = keyValuePairs;
            Tables = tables;
        }

        /// <summary> Page number. </summary>
        public int Page { get; internal set; }
        /// <summary> Cluster identifier. </summary>
        public int? ClusterId { get; internal set; }
        /// <summary> List of key-value pairs extracted from the page. </summary>
        public IList<KeyValuePair_internal> KeyValuePairs { get; internal set; }
        /// <summary> List of data tables extracted from the page. </summary>
        public IList<DataTable_internal> Tables { get; internal set; }
    }
}