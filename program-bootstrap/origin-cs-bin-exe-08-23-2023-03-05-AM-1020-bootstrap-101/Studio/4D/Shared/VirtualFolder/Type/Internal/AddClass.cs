using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public VirtualFolder AddClass(String name, Boolean entry)
        {
            VirtualFolder virtualFolderResult = default; 

            var program = AddFolder(name);

            var program_DATA = program.AddFolder("Data");

            var program_LINK = program.AddFolder("Link");

            var program_LINK__POLICY = program_LINK.AddFolder("Policy");

            var program_META = program.AddFolder("Meta");

            var program_MODULE = program.AddFolder("Module");

            var program_OBJECT = program.AddFolder("Object");

            var program_OBJECT__PROGRAM_OBJECT = program_OBJECT.AddFolder($"{name}Object");

            var program_OBJECT__PROGRAM_DATA_OBJECT = program_OBJECT.AddFolder($"{name}DataObject");

            var program_PROTOTYPE = program.AddFolder("Prototype");

            if (entry is true)
            {
                var program_STATIC = program.AddFolder("Static");

                var program__PROGRAM__STATIC = program_STATIC.AddFile($"{name}Static", "cs", ClassificationStaticDescriptor(name));
            }
            else
                "false".ToString();

            var program_TYPE = program.AddFolder("Type");

            var program_TYPE__MAKE = program_TYPE.AddFolder("Make");

            var program_TYPE__MAKE__DEFAULT = program_TYPE__MAKE.AddFolder("Default");

            var program_TYPE__MAKE__DEFAULT__SURFACE = program_TYPE__MAKE__DEFAULT.AddFolder("Surface");

            var program_TYPE__SEQUENCE = program_TYPE.AddFolder("Sequence");

            var program_TYPE__SEQUENCE__DEBUG = program_TYPE__SEQUENCE.AddFolder("Debug");

            var program__PROGRAM__DATA = program_DATA.AddFile($"{name}Data", "cs", ClassificationDataDescriptor(name));

            var program__PROGRAM__LINK__POLICY = program_LINK__POLICY.AddFile($"{name}LinkPolicy", "cs", ClassificationLinkPolicyDescriptor(name));

            var program__PROGRAM__META = program_META.AddFile($"{name}Meta", "txt", ClassificationMetaDescriptor(name));

            var program__PROGRAM__OBJECT__PROGRAM_OBJECT = program_OBJECT__PROGRAM_OBJECT.AddFile($"{name}Object", "cs", ClassificationObjectDescriptor(name));

            var program__PROGRAM__OBJECT__PROGRAM_DATA_OBJECT = program_OBJECT__PROGRAM_DATA_OBJECT.AddFile($"{name}DataObject", "cs", ClassificationDataObjectDescriptor(name));

            var program__PROGRAM__PROTOTYPE = program_PROTOTYPE.AddFile($"{name}Prototype", "cs", ClassificationPrototypeDescriptor(name));

            var program__PROGRAM__TYPE__MAKE__DEFAULT = program_TYPE__MAKE__DEFAULT.AddFile($"{name}MakeDefault", "cs", ClassificationTypeDescriptor(name));

            var program__PROGRAM__TYPE__MAKE__DEFAULT__SURFACE = program_TYPE__MAKE__DEFAULT__SURFACE.AddFile($"{name}MakeDefaultSurface", "cs", ClassificationTypeSurfaceDescriptor(name));

            var program__PROGRAM__TYPE__SEQUENCE = program_TYPE__SEQUENCE.AddFile($"{name}Sequence", "cs", ClassificationSequenceDescriptor(name));

            var program__PROGRAM__TYPE__SEQUENCE__DEBUG = program_TYPE__SEQUENCE__DEBUG.AddFile($"{name}SequenceDebug", "cs", ClassificationSequenceDebugDescriptor(name));

            var program__PROGRAM__ENTRY = program.AddFile($"{name}", "cs", ClassificationEntryDescriptor(name));
            
            virtualFolderResult = program;

            return virtualFolderResult;
        }
    }
}
