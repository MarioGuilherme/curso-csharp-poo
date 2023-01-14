namespace System {
    public static class StringExtensions {  // |-- Extendendo o objeto DateTime
        public static string Cut(this string thisObj, int count) {
            if (thisObj.Length <= count)
                return thisObj;

            return $"{thisObj[..count]}...";
        }
    }
}