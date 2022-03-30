using System;

namespace UnityEngine.Networking
{
    /// <summary>
    /// FilterLog is a utility class that controls the level of logging generated by UNET clients and servers.
    /// </summary>
    
    public class LogFilter
    {
        // this only exists for inspector UI?!
        public enum FilterLevel
        {
            Developer = 0,
            Debug = 1,
            Info = 2,
            Warn = 3,
            Error = 4,
            Fatal = 5,
            SetInScripting = -1
        };

        internal const int Developer = 0;
        internal const int SetInScripting = -1;

        /// <summary>
        /// Setting LogFilter.currentLogLevel to this will enable verbose debug logging.
        /// </summary>
        public const int Debug = 1;
        /// <summary>
        /// Setting LogFilter.currentLogLevel to this will log only info and above messages. This is the default level.
        /// </summary>
        public const int Info = 2;
        /// <summary>
        /// Setting LogFilter.currentLogLevel to this will log wanring and above messages.
        /// </summary>
        public const int Warn = 3;
        /// <summary>
        /// Setting LogFilter.currentLogLevel to this will error and above messages.
        /// </summary>
        public const int Error = 4;
        public const int Fatal = 5;

        [Obsolete("Use LogFilter.currentLogLevel instead")]
        static public FilterLevel current = FilterLevel.Info;

        static int s_CurrentLogLevel = Info;
        /// <summary>
        /// The current logging level that UNET is running with.
        /// </summary>
        static public int currentLogLevel { get { return s_CurrentLogLevel; } set { s_CurrentLogLevel = value; } }

        static internal bool logDev { get { return s_CurrentLogLevel <= Developer; } }
        /// <summary>
        /// Checks if debug logging is enabled.
        /// </summary>
        static public bool logDebug { get { return s_CurrentLogLevel <= Debug; } }
        /// <summary>
        /// Checks if info level logging is enabled.
        /// </summary>
        static public bool logInfo  { get { return s_CurrentLogLevel <= Info; } }
        /// <summary>
        /// Checks if wanring level logging is enabled.
        /// </summary>
        static public bool logWarn  { get { return s_CurrentLogLevel <= Warn; } }
        /// <summary>
        /// Checks if error logging is enabled.
        /// </summary>
        static public bool logError  { get { return s_CurrentLogLevel <= Error; } }
        static public bool logFatal { get { return s_CurrentLogLevel <= Fatal; } }
    }
}
