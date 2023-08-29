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
        public static IList<VirtualFile> VirtualFolderFileSet(VirtualFolder virtualFolder)
        {
            ICollection<VirtualFile> collectionResult = default;

            collectionResult = new Collection<VirtualFile>();

            foreach (Object objectItem in virtualFolder.FilesystemEntryArrayList)
            {
                if ((objectItem is VirtualFile) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(objectItem as VirtualFile);

                continue;
            }

            return new List<VirtualFile>(collectionResult);
        }
    }
}
