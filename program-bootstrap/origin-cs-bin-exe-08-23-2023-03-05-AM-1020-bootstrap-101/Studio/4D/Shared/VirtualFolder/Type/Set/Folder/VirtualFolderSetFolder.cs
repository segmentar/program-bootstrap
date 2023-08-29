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
        public static IList<VirtualFolder> VirtualFolderFolderSet(VirtualFolder virtualFolder)
        {
            ICollection<VirtualFolder> collectionResult = default;

            collectionResult = new Collection<VirtualFolder>();

            foreach (Object objectItem in virtualFolder.FilesystemEntryArrayList)
            {
                if ((objectItem is VirtualFolder) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(objectItem as VirtualFolder);

                continue;
            }

            return new List<VirtualFolder>(collectionResult);
        }
    }
}
