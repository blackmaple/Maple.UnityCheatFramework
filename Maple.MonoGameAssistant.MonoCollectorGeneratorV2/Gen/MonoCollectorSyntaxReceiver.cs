﻿using Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollectorDataV2;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{
    class MonoCollectorSyntaxReceiver : ISyntaxContextReceiver
    {
        public List<MonoCollectorOptionsData> CollectorOptionsDatas { get; } = new List<MonoCollectorOptionsData>();

        [Obsolete("remove...")]
        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax classDeclaration)
            {
                if (false == classDeclaration.AttributeLists.Any())
                {
                    return;
                }

                var classSymbol = context.SemanticModel.GetDeclaredSymbol(classDeclaration);
                var genOptions = classSymbol.GetAttributes().FirstOrDefault(p => p.AttributeClass.ToDisplayString() == typeof(MonoCollectorOptionsAttribute).FullName);
                if (genOptions is null)
                {
                    return;
                }

                var collectorOptionsData = genOptions.GetMonoCollectorOptionsData(classSymbol);
                CollectorOptionsDatas.Add(collectorOptionsData);
            }
        }


    }
}
