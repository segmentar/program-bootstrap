using Core;

using Core.Shared;

namespace Core
{
    using System;

    using System.IO;

    using System.Drawing;

    using System.Drawing.Imaging;

    internal partial class Program
    {
        internal void BuildTemplate(String workingDirectory)
        {
            var descriptor__READ_ME = String.Join('\n'.ToString(), new String[] {

                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + "Keep your .AppConfig file, and move it to the Studio/4D folder" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + "Make yourself a personalized 512/512 pixel .ico" + ' ' + '.',
                String.Empty
            });

            var descriptor__DOCUMENT = String.Join('\n'.ToString(), new String[] { 

                String.Empty,
                String.Empty + '\t' + "This is document" + ' ' + '.',
                String.Empty
            });

            VirtualFolder virtualFolder;

            virtualFolder = new VirtualFolderSimple(workingDirectory).Result;

            VirtualFilesystem virtualFilesystem;

            virtualFilesystem = new VirtualFilesystemSimple(virtualFolder).Result;

            String applicationString = default;

            if (Architecture.ApplicationType is ProgramCode.ApplicationType.BinaryPortableExecutable)
            {
                applicationString = "bin-exe";
            }
            else
                "false".ToString();

            if (Architecture.ApplicationType is ProgramCode.ApplicationType.LibraryDynamicLinkLibrary)
            {
                applicationString = "lib-dll";
            }
            else
                "false".ToString();

            var origin = virtualFilesystem.VirtualFolderRoot.AddFolder(VirtualFilesystem.ForgeOriginName(Architecture.ApplicationName, applicationString, Architecture.ApplicationVersion));

            var origin__READ_ME = origin.AddFile("ReadMe", "txt", descriptor__READ_ME);

            var split_CLASS = Architecture.ClassStringBuilder.ToString().Split('-');

            var split_MODULE = Architecture.ModuleStringBuilger.ToString().Split('-');

            var split_ICON = Architecture.IconStringBuilder.ToString().Split('-');

            foreach (var tuple in ProgramClassTupleSetSurface(split_CLASS))
            {
                Boolean isEntry;

                isEntry = Boolean.Parse(tuple.Item3);

                origin.AddClass(tuple.Item2, isEntry);

                continue;
            }

            foreach (var tuple in ProgramModuleTupleSetSurface(split_MODULE))
            {
                Int32 integerResult;

                Boolean booleanResult;

                booleanResult = Int32.TryParse(tuple.Item3, out integerResult);

                if (booleanResult is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                origin.AddModule(tuple.Item2, integerResult); 
               
                continue;
            }

            if (Architecture.IncludeStudioDirectory is true)
            {
                var studio = origin.AddFolder("Studio");

                var studio_1D = studio.AddFolder("1D");

                var studio_2D = studio.AddFolder("2D");

                var studio_3D = studio.AddFolder("3D");

                var studio_4D = studio.AddFolder("4D");

                var studio__1D__DOCUMENT = studio_1D.AddFile("Document", "txt", descriptor__DOCUMENT);
            }
            else
                "false".ToString();

            virtualFilesystem.Render(true);

            var ordinal = 1;

            foreach (var tuple in ProgramIconTupleSetSurface(split_ICON))
            {
                Color foregroundColor, backgroundColor;
                
                foregroundColor = Color.FromName(tuple.Item3);

                backgroundColor = Color.FromName(tuple.Item4);

                Single impact;

                impact = Single.Parse(tuple.Item5);

                Int32 scale;

                scale = Int32.Parse(tuple.Item6);

                var path_NAME = $"{tuple.Item2}-{ordinal}";

                var path_DIRECTORY_full_name = origin.FullName;

                var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, path_NAME);

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "ico");

                MakeIcon(path_FILE_filename_with_extension, foregroundColor, backgroundColor, impact, scale);

                ordinal = ordinal + 1;

                continue;
            }

            return;
        }
    }
}
