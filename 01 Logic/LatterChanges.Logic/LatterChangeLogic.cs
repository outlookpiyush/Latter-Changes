using System;

namespace LatterChanges.Logic
{
    public class LatterChangeLogic
    {
        /// <summary>
        /// Changes Latter Based on Algo
        /// </summary>
        /// <param name="_inputString">_inputString as string </param>
        /// <returns>return outputString</returns>
        public string GetChangeLatter(string _inputString)
        {
            string inputString = _inputString.ToLower(); // Set All Input String Are In Lower Case
            string strOutput = string.Empty;
            foreach (var chars in inputString)
            {
                if ((int)chars > 96 && (int)chars < 122)
                    strOutput += (char)((int)chars + 1) == 'a' ? Convert.ToChar(((char)((int)chars + 1)).ToString().ToUpper()) : (char)((int)chars + 1) == 'e' ? Convert.ToChar(((char)((int)chars + 1)).ToString().ToUpper()) : (char)((int)chars + 1) == 'i' ? Convert.ToChar(((char)((int)chars + 1)).ToString().ToUpper()) : (char)((int)chars + 1) == 'o' ? Convert.ToChar(((char)((int)chars + 1)).ToString().ToUpper()) : (char)((int)chars + 1) == 'u' ? Convert.ToChar(((char)((int)chars + 1)).ToString().ToUpper()) : (char)((int)chars + 1);
                else
                    strOutput += chars;
            }
            return strOutput;
        }
    }
}
