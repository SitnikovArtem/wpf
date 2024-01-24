﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.ComponentModel;
using System.Xaml;
using System.Xaml.Schema;

namespace System.Windows.Markup
{
    public class PropertyDefinition : MemberDefinition
    {
        private IList<Attribute> _attributes;

        public override string Name { get; set; }

        [TypeConverter(typeof(XamlTypeTypeConverter))]
        public XamlType Type { get; set; }

        [DefaultValue(null)]
        public string Modifier { get; set; }

        public IList<Attribute> Attributes => _attributes ??= new List<Attribute>();
    }
}
