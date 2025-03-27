namespace CS_Server_Viewer.Models
{
    public static class StatusModel
    {
        public static readonly string Author = "Made by hculek";
        public static readonly string Licence = "Licence: MIT";
        public static readonly string GitUrl = "https://github.com/hculek";
        public static readonly string Version = "1.0";
        public static readonly string ProgramTitle = $"CS2 Server Viewer & Blacklisting. Version {Version}";

        public static readonly string JobInProgress = "Working...";
        public static readonly string JobDone = "Done.";

        public static readonly string ErrorMsg = "Error";
        public static readonly string ErrorTemplate = $"{StatusModel.ErrorMsg} {0}";
        public static readonly string ErrorServersEmpty = $"{ErrorMsg}: No servers loaded. Please click on Get Server List button.";
        public static readonly string ErrorNothingSelected = $"{ErrorMsg}: Please select servers for blacklist.";
        public static readonly string ErrorBlacklistEmpty = $"{ErrorMsg}: Blacklist is empty. Please click on Generate Blacklist button.";
    }
}
