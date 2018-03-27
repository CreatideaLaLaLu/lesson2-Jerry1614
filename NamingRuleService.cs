using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaohsiung.Sport.Tourist.Service.BaseData
{
    public class NamingRuleService
    {
        /// <summary>
        /// 每一個function都要寫註解
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int TestFunction(int index)
        {
            // bad
            switch (index)
            {
                case 1: break;
                default: break;
            }

            // Good
            switch (index)
            {
                case 1:
                    // todo: do somthing
                    break;

                default:
                    // todo: do somthing
                    break;
            }

            // bad
            if (index == 0) DoTrue();
            else
                DoFalse();

            // Good
            if (index == 0)
            {
                DoTrue();
            }
            else
            {
                DoFalse();
            }

            // bad
            if (DoTrue() == true) { DoTrue(); }

            // Good
            if (DoTrue())
            {
                DoTrue();
            }

            // bad
            return (index * (index + 1) / 2);

            // Good
            return index * (index + 1) / 2;
        }

        /// <summary>
        /// 每一個function都要寫註解
        /// </summary>
        /// <returns></returns>
        private bool DoTrue()
        {
            return true;
        }

        /// <summary>
        /// 每一個function都要寫註解
        /// </summary>
        /// <returns></returns>
        private bool DoFalse()
        {
            return false;
        }


        // bad
        public void TestStringFunction(string value)
        {
            string NewString = "ABCDEFG"; //新字串

            if (value != null | value != "") value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");
        }

        // Good
        /// <summary>
        /// 每一個function都要寫註解
        /// </summary>
        /// <param name="value"></param>
        public void NewTestStringFunction(string value)
        {
            string newString = "ABCDEFG"; //新字串

            if (!string.IsNullOrEmpty(value))
            {
                newString = new StringBuilder(newString).Replace("A", ",").Replace("B", "_").Replace("C", " ").ToString();
            }
        }
    }
}
