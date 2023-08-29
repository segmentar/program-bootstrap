using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public String ClassificationPrototypeDescriptor(String name)
        {
            String stringResult = default;

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {name}",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal {name}" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{name}Data data" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"data = new {name}Data" + '(' + ')' + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "if (debug is true)",
                String.Empty + '\t' + '\t' + '\t' + '{',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "data.IsDebug = true" + ';',
                String.Empty + '\t' + '\t' + '\t' + '}',
                String.Empty + '\t' + '\t' + '\t' + "else",
                String.Empty + '\t' + '\t' + '\t' + '\t' + "\"false\".ToString()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "this.Data = data" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            return stringResult;
        }
    }
}
