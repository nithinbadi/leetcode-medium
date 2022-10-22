public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows==1){return s;}
        string[] letters = new string[numRows];
            string finalString;
            int count = 0;
            int j = 0, i = 0;
            letters[0] += s[0];
            while (true)
            {
                do
                {
                    i++;
                    if (i == s.Length) { break; }
                    if (count % 2 == 0)
                    {
                        j++;
                    }
                    else
                    {
                        j--;
                    }
                    letters[j] += s[i];

                } while (i % (numRows - 1) != 0);
                count++;
                if (i == s.Length) { break; }
            }

            finalString= string.Join("", letters);
        return finalString;
    }
}
