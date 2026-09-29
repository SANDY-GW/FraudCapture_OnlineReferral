namespace FC_OnlineReferral
{
    /// <summary>
    /// Shared static values used to pass simple state between page object actions
    /// and their corresponding step definitions.
    /// </summary>
    public static class AppConstants
    {
        private static readonly string CaseIdFilePath = System.IO.Path.Combine(
            System.IO.Path.GetTempPath(), "FraudCapture_LastNonInvCaseId.txt");

        public static string NotesandAttachmenttext { get; set; }

        public static string CaseId { get; set; }

        private static string _nonInvCaseId = string.Empty;

        /// <summary>
        /// Case ID captured for the most recently created Non-Investigative case.
        /// Persisted to a temp file so it can be retrieved by scenarios that run
        /// in a separate process/run from the one that created the case.
        /// </summary>
        public static string Non_Inv_CaseId
        {
            get
            {
                if (!string.IsNullOrEmpty(_nonInvCaseId))
                {
                    return _nonInvCaseId;
                }

                try
                {
                    if (System.IO.File.Exists(CaseIdFilePath))
                    {
                        _nonInvCaseId = System.IO.File.ReadAllText(CaseIdFilePath)?.Trim();
                    }
                }
                catch
                {
                    // Ignore file access issues and fall back to empty string.
                }

                return _nonInvCaseId ?? string.Empty;
            }
            set
            {
                _nonInvCaseId = value;
                try
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        System.IO.File.WriteAllText(CaseIdFilePath, value);
                    }
                }
                catch
                {
                    // Ignore file access issues; in-memory value still works within the same process.
                }
            }
        }

        public static string CaseStatus { get; set; }
    }
}
