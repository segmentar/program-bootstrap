using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static Tuple<String, String, String, String, String, String>[] ProgramIconTupleSetSurface(String[] split)
        {
            Tuple<String, String, String, String, String, String>[] arrayResult = default;

            var list = ProgramIconTupleSet(split);

            Tuple<String, String, String, String, String, String>[] tupleArray;

            tupleArray = new Tuple<String, String, String, String, String, String>[list.Count];

            list.CopyTo(tupleArray, 0);

            arrayResult = tupleArray;

            return arrayResult;
        }
    }
}
