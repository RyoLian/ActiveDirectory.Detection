using System;
using System.DirectoryServices;

namespace ActiveDirectory.Detection.BLL
{
    public class ADCommad
    {
        bool IsExist(string url)
        {
            bool result;

            try
            {
                result=DirectoryEntry.Exists(url);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;

        }


    }
}
