using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordProcessor
{
    public class PasswordProcesses
    {
        public string getCombinationsCount(bool isCapital, bool isSmall, bool isNumber, long specialCharCount, long charCount)
        {
            long capValue, smallValue, numberValue, charCombinations,totalCombinations;

            if (isCapital)
                capValue = 26L;
            else
                capValue = 0L;

            if (isSmall)
                smallValue = 26L;
            else
                smallValue = 0L;

            if (isNumber)
                numberValue = 10L;
            else
                numberValue = 0L;

            charCombinations = (capValue + smallValue + numberValue) + specialCharCount;

            try
            {
                totalCombinations = Convert.ToInt64(Math.Pow((double)charCombinations, (double)charCount)); //all characters are repeatable
                return String.Format("{0:n0}", totalCombinations); //thousands separator
                
            }

            catch (Exception oex)  //greater than Long.MAX_VALUE
            {
                return "Infinite";
            }  
        }

        public String createPassword(String charSet, int charCount)
        {
            char[] pass = new char[charCount];
            Random rnd = new Random();
            String finalPassword="";
            for (int x = 0; x < pass.Length; x++)
            {
                pass[x] = charSet[rnd.Next(charSet.Length)];
            }

            for (int y = 0; y < pass.Length; y++)
            {
               finalPassword = finalPassword + pass[y]; //concatenates the characters
            }

            return finalPassword;
        }
    }
}
