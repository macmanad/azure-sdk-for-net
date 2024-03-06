// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> Unknown version of Fhir_R4_DomainResource. </summary>
    internal partial class UnknownFhirR4DomainResource : FhirR4DomainResource
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFhirR4DomainResource"/>. </summary>
        /// <param name="resourceType"> The type of resource. </param>
        /// <param name="id"> Resource Id. </param>
        /// <param name="meta"> Metadata about the resource. </param>
        /// <param name="implicitRules"> A set of rules under which this content was created. </param>
        /// <param name="language"> Language of the resource content. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="text"> Text summary of the resource, for human interpretation. </param>
        /// <param name="contained"> Contained, inline Resources. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="modifierExtension"> Extensions that cannot be ignored. </param>
        internal UnknownFhirR4DomainResource(string resourceType, string id, FhirR4Meta meta, string implicitRules, string language, IDictionary<string, BinaryData> additionalProperties, FhirR4Narrative text, IList<FhirR4Resource> contained, IList<FhirR4Extension> extension, IList<FhirR4Extension> modifierExtension) : base(resourceType, id, meta, implicitRules, language, additionalProperties, text, contained, extension, modifierExtension)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownFhirR4DomainResource"/> for deserialization. </summary>
        internal UnknownFhirR4DomainResource()
        {
        }
    }
}
