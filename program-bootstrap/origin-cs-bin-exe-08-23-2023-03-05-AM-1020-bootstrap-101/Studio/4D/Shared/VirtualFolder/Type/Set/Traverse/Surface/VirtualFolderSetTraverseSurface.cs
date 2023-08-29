using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public static Object[] VirtualFolderTraverseSetSurface(VirtualFolder[] virtualFolderArray)
        {
            Object[] arrayResult = default;

            var list = VirtualFolderTraverseSet(virtualFolderArray);

            Object[] objectArray;

            objectArray = new Object[list.Count];

            list.CopyTo(objectArray, 0);

            arrayResult = objectArray;

            return arrayResult;
        }
    }
}
