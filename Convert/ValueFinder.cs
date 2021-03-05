using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finder
{
    public class ValueFinder
    {
        public int Search<T, K>(T value, K searchValue)
        {
            var strValue = value.ToString(); 
            //var strValue = value.ToString().ToLower();

            if (strValue.Length == 0)
                throw new ArgumentException("value cannot be empty");

            if (searchValue.ToString().Length == 0)
                throw new ArgumentException("seach value cannot be empty");

            var strSearchValue = searchValue.ToString()[0]; 
            //var strSearchValue = searchValue.ToString().ToLower()[0];      

            var count = strValue.Where(c => c == strSearchValue).Count();

            return count;
        }
    }
}
