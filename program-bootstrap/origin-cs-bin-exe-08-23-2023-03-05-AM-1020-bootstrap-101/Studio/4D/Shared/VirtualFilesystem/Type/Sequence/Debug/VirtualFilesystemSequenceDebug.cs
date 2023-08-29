using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Text;

    public partial class VirtualFilesystemSequence
    {
        public static void Debug(Encoding encoding, VirtualFolder virtualFolder, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(VirtualFileSimple) + ' ' + "::" + ' ' + nameof(VirtualFilesystemSequence) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(encoding) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(virtualFolder) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(debug) + ':' + ' ' + debug,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(encoding) + ':',
                    String.Empty + encoding,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(virtualFolder) + ':',
                    String.Empty + virtualFolder
                });

            Console.Clear();

            Console.Out.WriteLine(descriptor);

            Console.In.ReadLine();

            return;
        }
    }
}
