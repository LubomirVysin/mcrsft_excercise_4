using System;

namespace Microsoft_excercise_4
{
    public class StrShift : StrsType<StrShift, String>
    {
        private StrShift(string value) : base(value)
        {
        }

        public static implicit operator StrShift(string value)
        {
            return new StrShift(value);
        }

        public static implicit operator string(StrShift custom)
        {
            return custom.Value;
        }
    }
}
