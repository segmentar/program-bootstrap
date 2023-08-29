using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFile
    {
        public static VirtualFile MakeVirtualFileDefault(String filename, Byte[] contentByteArray, Boolean debug)
        {
            VirtualFile virtualFileResult = default;

            var result = new VirtualFileSequence(filename, contentByteArray, debug).Result;

            VirtualFilePolicy.VirtaulFileArrayList.Add(result);

            virtualFileResult = result;

            return virtualFileResult;
        }
    }
}
