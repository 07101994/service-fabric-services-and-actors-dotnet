// ------------------------------------------------------------
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT License (MIT).See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System.Runtime.Serialization;
using Microsoft.ServiceFabric.Services.Remoting.V2;

/// <summary>
/// This is a marker class indicating the remoting request / response is wrapped or not.
/// </summary>
[DataContract(Name = "msgBodywrapped", Namespace = Constants.ServiceCommunicationNamespace)]
public abstract class WrappedMessage
{
    /// <summary>
    /// Gets or sets  the wrapped object.
    /// </summary>
    [DataMember(Name = "value", IsRequired = true, Order = 1)]
    public object Value
    {
        get;
        set;
    }
}
