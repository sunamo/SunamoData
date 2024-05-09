namespace
#if SunamoFileIO
SunamoFileIO
#elif SunamoFileSystem
SunamoFileSystem
#elif SunamoPlatformUwpInterop
SunamoPlatformUwpInterop
#elif SunamoShared
SunamoShared
#else
SunamoDataData
#endif
;

//public class StorageFile
//    {
//        public string folder;
//        public string file;
//        public string FullPath()
//        {
//            return Path.Combine(folder, file);
//        }

//        public StorageFile(string folder, string file)
//        {
//            this.folder = folder;
//            this.file = file;
//        }

//    public Task<Stream> OpenStreamForReadAsync()
//    {
//
//    }

//    public static Task<StorageFile> GetFileFromApplicationUriAsync(Uri localUri)
//    {
//
//    }

//    public Task<global::Windows.Storage.Streams.IRandomAccessStream> OpenAsync(global::Windows.Storage.FileAccessMode read)
//    {
//
//    }
//}
