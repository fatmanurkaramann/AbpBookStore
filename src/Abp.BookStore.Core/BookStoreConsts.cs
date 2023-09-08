using Abp.BookStore.Debugging;

namespace Abp.BookStore
{
    public class BookStoreConsts
    {
        public const string LocalizationSourceName = "BookStore";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "82a0452b015b4f48ab39f7ea557982ab";
    }
}
