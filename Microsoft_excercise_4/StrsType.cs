namespace Microsoft_excercise_4
{
    public class StrsType<TCus, TCVal>
    {
        protected readonly TCVal Value;

        public StrsType(TCVal value)
        {
            Value = value;
        }

        public static StrShift operator << (StrsType<TCus, TCVal> word, int shiftSize)
        {
            return word != null ? ShiftString(word.Value.ToString(), shiftSize, false) : string.Empty;
        }

        public static StrShift operator >> (StrsType<TCus, TCVal> word, int shiftSize)
        {
            return word != null ? ShiftString(word.Value.ToString(), shiftSize, true) : string.Empty;
        }

        public static StrShift operator == (StrsType<TCus, TCVal> word, int shiftSize)
        {
            return word != null ? ShiftString(word.Value.ToString(), shiftSize, false) : string.Empty;
        }

        public static StrShift operator != (StrsType<TCus, TCVal> word, int shiftSize)
        {
            return word != null ? ShiftString(word.Value.ToString(), shiftSize, true) : string.Empty;
        }

        private static string ShiftString(string word, int shiftCount, bool shiftFromEndToStart)
        {
            if (!string.IsNullOrEmpty(word))
            {
                string cutSubstring, result;

                if (shiftFromEndToStart)
                {
                    cutSubstring = word.Substring(0, shiftCount);
                    word = word.Substring(shiftCount, word.Length - shiftCount);
                    result = string.Concat(word, cutSubstring);
                }
                else
                {
                    cutSubstring = word.Substring(word.Length - shiftCount);
                    word = word.Substring(0, word.Length - shiftCount);
                    result = string.Concat(cutSubstring, word);
                }
                return result;
            }
            return string.Empty;
        }
    }
}