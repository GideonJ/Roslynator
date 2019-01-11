﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

using System;
using Microsoft.CodeAnalysis;

namespace Roslynator.CodeAnalysis.CSharp
{
    public static partial class DiagnosticDescriptors
    {
        /// <summary>ROS0001</summary>
        public static readonly DiagnosticDescriptor UsePropertySyntaxNodeSpanStart = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.UsePropertySyntaxNodeSpanStart, 
            title:              "Use property SyntaxNode.SpanStart.", 
            messageFormat:      "Use property SyntaxNode.SpanStart.", 
            category:           DiagnosticCategories.Performance, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.UsePropertySyntaxNodeSpanStart}", 
            customTags:         Array.Empty<string>());

        /// <summary>ROS0002</summary>
        public static readonly DiagnosticDescriptor UsePropertySyntaxNodeRawKind = new DiagnosticDescriptor(
            id:                 DiagnosticIdentifiers.UsePropertySyntaxNodeRawKind, 
            title:              "Use property SyntaxNode.RawKind.", 
            messageFormat:      "Use property SyntaxNode.RawKind.", 
            category:           DiagnosticCategories.Performance, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        $"{HelpLinkUriRoot}{DiagnosticIdentifiers.UsePropertySyntaxNodeRawKind}", 
            customTags:         Array.Empty<string>());

    }
}