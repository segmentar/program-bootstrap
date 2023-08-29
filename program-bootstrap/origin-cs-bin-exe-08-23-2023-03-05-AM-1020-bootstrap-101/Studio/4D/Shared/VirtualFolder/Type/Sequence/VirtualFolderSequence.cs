using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Collections;

    public partial class VirtualFolderSequence
    {
        public VirtualFolder Result { get; set; } = default;

        public VirtualFolderSequence(String fullName, IEnumerable enumerable, Boolean debug)
        {
            Debug(fullName, debug);

            var list = new ArrayList(enumerable as ICollection);

            VirtualFolder virtualFolder;

            virtualFolder = new VirtualFolder(fullName, list, debug);

            this.Result = virtualFolder;

            return;
        }

        ~VirtualFolderSequence()
        {
            return;
        }
    }
}
