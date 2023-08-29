using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public String ClassificationSequenceDescriptor(String name)
        {
            String stringResult = default;

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {name}Sequence",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal {name} Result {{ get; set; }} = default" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + $"internal {name}Sequence" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "Debug(debug)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{name} {name.ToLower()}" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{name.ToLower()} = new {name}(debug)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"this.Result = {name.ToLower()}" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + '~' + $"{name}Sequence" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            return stringResult;
        }
    }
}
