using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFileSequence
    {
        public VirtualFile Result { get; set; } = default;

        public VirtualFileSequence(String filename, Byte[] contentByteArray, Boolean debug)
        {
            Debug(filename, contentByteArray, debug);

            VirtualFile virtualFile;

            virtualFile = new VirtualFile(filename, contentByteArray, debug);

            this.Result = virtualFile;

            return;
        }

        ~VirtualFileSequence()
        {
            return;
        }
    }
}
