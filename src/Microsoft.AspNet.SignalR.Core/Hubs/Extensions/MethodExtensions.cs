﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using Newtonsoft.Json.Linq;

namespace Microsoft.AspNet.SignalR.Hubs
{
    public static class MethodExtensions
    {
        public static bool Matches(this MethodDescriptor methodDescriptor, params IJsonValue[] parameters)
        {
            if ((methodDescriptor.Parameters.Count > 0 && parameters == null)
                || methodDescriptor.Parameters.Count != parameters.Length)
            {
                return false;
            }

            return true;
        }
    }
}
