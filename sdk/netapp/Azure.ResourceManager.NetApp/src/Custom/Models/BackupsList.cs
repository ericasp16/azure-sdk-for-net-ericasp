﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> List of Backups. </summary>
    internal partial class BackupsList
    {
        /// <summary> Initializes a new instance of BackupsList. </summary>
        /// <param name="value"> A list of Backups. </param>
        internal BackupsList(IReadOnlyList<NetAppBackupData> value)
        {
            Value = value;
        }
    }
}
