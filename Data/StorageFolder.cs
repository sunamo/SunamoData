namespace
#if SunamoFileIO
SunamoFileIO
#elif SunamoFileSystem
SunamoFileSystem
#elif SunamoPlatformUwpInterop
SunamoPlatformUwpInterop
#elif SunamoShared
SunamoShared
#elif SunamoLang
SunamoLang
#else
SunamoData
#endif
;

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace sunamo.Data
//{
//    public class StorageFolder
//    {
//        public string fullPath;

//        public StorageFolder(string fullPath)
//        {
//            this.fullPath = fullPath;
//        }

//        /// <summary>
//        /// Must return fullPath - its use in generic Combine method
//        /// </summary>
//        /// <returns></returns>
//        public override string ToString()
//        {
//            return base.ToString();
//        }
//    }
//}
