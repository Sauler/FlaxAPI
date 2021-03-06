// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using System;
using System.Diagnostics;

namespace FlaxEngine
{
    /// <summary>
    /// Class containing methods to ease debugging while developing a game.
    /// </summary>
    public sealed class Debug
    {
        internal static Logger _logger;

        /// <summary>
        /// Get default debug logger.
        /// </summary>
        public static ILogger Logger
        {
            get { return _logger; }
        }

        static Debug()
        {
            _logger = new Logger(new DebugLogHandler());
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Flax console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        [Conditional("FLAX_ASSERTIONS")]
        [Obsolete("Please use verbose logging for all exceptions")]
        public static void Assert(bool condition)
        {
            if (!condition)
                Logger.Log(LogType.Assert, "Assertion failed");
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Flax console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="context">Object to which the message applies.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void Assert(bool condition, Object context)
        {
            if (!condition)
                Logger.Log(LogType.Assert, (object)"Assertion failed", context);
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Flax console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void Assert(bool condition, object message)
        {
            if (!condition)
                Logger.Log(LogType.Assert, message);
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Flax console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="message">String to be converted to string representation for display.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void Assert(bool condition, string message)
        {
            if (!condition)
                Logger.Log(LogType.Assert, message);
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Flax console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void Assert(bool condition, object message, Object context)
        {
            if (!condition)
                Logger.Log(LogType.Assert, message, context);
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Flax console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">String to be converted to string representation for display.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void Assert(bool condition, string message, Object context)
        {
            if (!condition)
                Logger.Log(LogType.Assert, (object)message, context);
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Flax console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void AssertFormat(bool condition, string format, params object[] args)
        {
            if (!condition)
                Logger.LogFormat(LogType.Assert, format, args);
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Flax console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void AssertFormat(bool condition, Object context, string format, params object[] args)
        {
            if (!condition)
                Logger.Log(LogType.Assert, context, string.Format(format, args));
        }

        /// <summary>
        /// Logs message to the Flax Console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        public static void Log(object message)
        {
            Logger.Log(LogType.Log, message);
        }

        /// <summary>
        /// Logs message to the Flax Console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void Log(object message, Object context)
        {
            Logger.Log(LogType.Log, message, context);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an assertion message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void LogAssertion(object message)
        {
            Logger.Log(LogType.Assert, message);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an assertion message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void LogAssertion(object message, Object context)
        {
            Logger.Log(LogType.Assert, message, context);
        }

        /// <summary>
        /// Logs a formatted assertion message to the Flax console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void LogAssertionFormat(string format, params object[] args)
        {
            Logger.LogFormat(LogType.Assert, format, args);
        }

        /// <summary>
        /// Logs a formatted assertion message to the Flax console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        [Conditional("FLAX_ASSERTIONS")]
        public static void LogAssertionFormat(Object context, string format, params object[] args)
        {
            Logger.Log(LogType.Assert, context, string.Format(format, args));
        }

        /// <summary>
        /// A variant of Debug.Log that logs an error message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        public static void LogError(object message)
        {
            Logger.Log(LogType.Error, message);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an error message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogError(object message, Object context)
        {
            Logger.Log(LogType.Error, message, context);
        }

        /// <summary>
        /// Logs a formatted error message to the Flax console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogErrorFormat(string format, params object[] args)
        {
            Logger.LogFormat(LogType.Error, format, args);
        }

        /// <summary>
        /// Logs a formatted error message to the Flax console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogErrorFormat(Object context, string format, params object[] args)
        {
            Logger.Log(LogType.Error, context, string.Format(format, args));
        }

        /// <summary>
        /// A variant of Debug.Log that logs an error message to the console.
        /// </summary>
        /// <param name="exception">Runtime Exception.</param>
        public static void LogException(Exception exception)
        {
            Logger.LogException(exception, null);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an error message to the console.
        /// </summary>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="exception">Runtime Exception.</param>
        public static void LogException(Exception exception, Object context)
        {
            Logger.LogException(exception, context);
        }

        /// <summary>
        /// Logs a formatted message to the Flax Console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogFormat(string format, params object[] args)
        {
            Logger.LogFormat(LogType.Log, format, args);
        }

        /// <summary>
        /// Logs a formatted message to the Flax Console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogFormat(Object context, string format, params object[] args)
        {
            Logger.Log(LogType.Log, context, string.Format(format, args));
        }

        /// <summary>
        /// A variant of Debug.Log that logs a warning message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        public static void LogWarning(object message)
        {
            Logger.Log(LogType.Warning, message);
        }

        /// <summary>
        /// A variant of Debug.Log that logs a warning message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogWarning(object message, Object context)
        {
            Logger.Log(LogType.Warning, message, context);
        }

        /// <summary>
        /// Logs a formatted warning message to the Flax Console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogWarningFormat(string format, params object[] args)
        {
            Logger.Log(LogType.Warning, format, args);
        }

        /// <summary>
        /// Logs a formatted warning message to the Flax Console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogWarningFormat(Object context, string format, params object[] args)
        {
            Logger.Log(LogType.Warning, context, string.Format(format, args));
        }
    }
}
