using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public String ClassificationTypeSurfaceDescriptor(String name)
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
                String.Empty + '\t' + '\t' + $"internal static {name} Make{name}DefaultSurface" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{name} {name.ToLower()}Result = default" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{name.ToLower()}Result = Make{name}Default({name}Policy.{name}DebugPolicy)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"return {name.ToLower()}Result" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            return stringResult;
        }
    }
}
