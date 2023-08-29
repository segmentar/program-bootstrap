using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static Tuple<String, String, String>[] ProgramModuleTupleSetSurface(String[] split)
        {
            Tuple<String, String, String>[] arrayResult = default;

            var list = ProgramModuleTupleSet(split);

            Tuple<String, String, String>[] tupleArray;

            tupleArray = new Tuple<String, String, String>[list.Count];

            list.CopyTo(tupleArray, 0);

            arrayResult = tupleArray;

            return arrayResult;
        }
    }
}
