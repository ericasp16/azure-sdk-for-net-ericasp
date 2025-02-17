// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Notebook root-level metadata. </summary>
    public partial class NotebookMetadata
    {
        /// <summary> Initializes a new instance of <see cref="NotebookMetadata"/>. </summary>
        public NotebookMetadata()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="NotebookMetadata"/>. </summary>
        /// <param name="kernelspec"> Kernel information. </param>
        /// <param name="languageInfo"> Language info. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal NotebookMetadata(NotebookKernelSpec kernelspec, NotebookLanguageInfo languageInfo, IDictionary<string, object> additionalProperties)
        {
            Kernelspec = kernelspec;
            LanguageInfo = languageInfo;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Kernel information. </summary>
        public NotebookKernelSpec Kernelspec { get; set; }
        /// <summary> Language info. </summary>
        public NotebookLanguageInfo LanguageInfo { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
