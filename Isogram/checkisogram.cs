using System;

namespace IsogramProblem
{
    public class checkisogram
    {
        public static int IsIsogram( string str)
        {
            //str = str.ToLower();
            int len = str.Length;
            string iso = "";
            foreach(char i in str)
            { 
                if (char.IsLetter(i))
                {
                    iso += i;
                }
            }
            char[] arr = iso.ToCharArray();
            Array.Sort(arr);
            
           // int flag=0;
            for(int i = 0; i < iso.Length-1; i++)
            {
                
                    if (arr[i] == arr[i + 1])
                    {
                        return 0;

                    }
                
            }
            return 1;
        }
    }
}
