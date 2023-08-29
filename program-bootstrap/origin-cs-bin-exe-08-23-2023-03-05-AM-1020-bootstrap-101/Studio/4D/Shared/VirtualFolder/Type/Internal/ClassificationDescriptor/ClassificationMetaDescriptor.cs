using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public String ClassificationMetaDescriptor(String name)
        {
            String stringResult = default;

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + "META",
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + "TYPE",
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + "LINK",
                String.Empty,
                String.Empty + "sequence" + ' ' + $"{name}" + ' ' + ':' + ' ' + "no unused namespace(s)",
                String.Empty,
                String.Empty + '\t' + ">" + "Data",
                String.Empty + '\t' + "<<" + $"{name}Data" + '.' + "cs",
                String.Empty,
                String.Empty + '\t' + ">" + "Prototype",
                String.Empty + '\t' + "<<" + $"{name}Prototype" + '.' + "cs",
                String.Empty,
                String.Empty + '\t' + "<" + $"{name}" + '.' + "cs",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + $"/static\\STATIC/{name}Static.cs\\",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + $"/object\\OBJECT/{name}Object.cs\\",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + $"/object\\OBJECT/{name}DataObject.cs\\",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + $"/sequence\\SEQUENCE/{name}Seqeunce.cs\\",
                String.Empty,
                String.Empty + "end" + ' ' + "sequence"
            });

            return stringResult;
        }
    }
}
