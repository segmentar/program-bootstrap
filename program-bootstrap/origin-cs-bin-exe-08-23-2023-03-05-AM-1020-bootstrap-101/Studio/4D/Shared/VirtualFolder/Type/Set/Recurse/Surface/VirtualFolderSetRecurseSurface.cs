using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public static VirtualFolder[] VirtualFolderRecurseSetSurface(VirtualFolder virtualFolder)
        {
            VirtualFolder[] arrayResult = default;

            var list = VirtualFolderRecurseSet(virtualFolder);

            VirtualFolder[] virtualFolderArray;

            virtualFolderArray = new VirtualFolder[list.Count];

            list.CopyTo(virtualFolderArray, 0);

            arrayResult = virtualFolderArray;

            return arrayResult;
        }
    }
}
