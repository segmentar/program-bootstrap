using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolderSequence
    {
        public static void Debug(String fullName, Boolean debug)
        {
            if (VirtualFolderPolicy.VirtualFolderDebugPolicy is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(VirtualFolder) + ' ' + "::" + ' ' + nameof(VirtualFolderSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(fullName) + ':' + ' ' + fullName,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            });

            Console.Clear();

            Console.Out.WriteLine(descriptor);

            Console.In.ReadLine();

            return;
        }
    }
}
