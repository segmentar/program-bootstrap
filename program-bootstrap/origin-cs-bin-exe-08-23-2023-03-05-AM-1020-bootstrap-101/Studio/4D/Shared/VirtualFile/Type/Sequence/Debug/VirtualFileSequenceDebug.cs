using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFileSequence
    {
        public static void Debug(String filename, Byte[] contentByteArray, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(VirtualFile) + ' ' + "::" + ' ' + nameof(VirtualFileSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(filename) + ':' + ' ' + filename,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(contentByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{contentByteArray.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(contentByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), contentByteArray)
            });

            Console.Clear();

            Console.Out.WriteLine(descriptor);

            Console.In.ReadLine();

            return;
        }
    }
}
