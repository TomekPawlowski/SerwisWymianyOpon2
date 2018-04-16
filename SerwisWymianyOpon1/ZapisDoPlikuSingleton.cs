using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerwisWymianyOpon1
{
    public sealed class ZapisDoPlikuSingleton
    {
        
        private static ZapisDoPlikuSingleton m_oInstance = null;
        
        public static ZapisDoPlikuSingleton Instance
        {
            get
            {
                if(m_oInstance == null)
                {
                    m_oInstance = new ZapisDoPlikuSingleton();
                }
                return m_oInstance;
            }

        }

        public void ZapisDoPliku(string text)

        {
            
            File.WriteAllText(@"C:\temp\WriteLines.txt", text);
        }

    }
}
