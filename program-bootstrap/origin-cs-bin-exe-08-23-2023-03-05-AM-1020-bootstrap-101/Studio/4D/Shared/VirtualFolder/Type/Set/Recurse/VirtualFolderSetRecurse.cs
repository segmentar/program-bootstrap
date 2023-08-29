using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class VirtualFolder
    {
        public static IList<VirtualFolder> VirtualFolderRecurseSet(VirtualFolder virtualFolder)
        {
            ICollection<VirtualFolder> collectionResult = default;

            collectionResult = new Collection<VirtualFolder>();

            var array = VirtualFolderFolderSetSurface(virtualFolder);

            foreach (VirtualFolder virtualFolderItem in array)
            {
                collectionResult.Add(virtualFolderItem);

                var list = new List<VirtualFolder>(VirtualFolderRecurseSet(virtualFolderItem));

                foreach (var folder in list)
                {
                    collectionResult.Add(folder);

                    continue;
                }

                continue;
            }

            collectionResult.Add(virtualFolder);

            return new List<VirtualFolder>(collectionResult);
        }
    }
}
