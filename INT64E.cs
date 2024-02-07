

   static public class INT64E
    {
        public static int mirror ( this int x)
        {
            char[] chars=x.ToString().ToCharArray();
            Array.Reverse(chars);

            return int.Parse(new string(chars));
        }
    }
