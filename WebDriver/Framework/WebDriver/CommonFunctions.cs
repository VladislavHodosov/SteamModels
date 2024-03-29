﻿using System;

namespace WebdriverFramework.Framework.WebDriver
{
    /// <summary>
    /// other methods
    /// </summary>
    public static class CommonFunctions
    {
        /// <summary>
        /// get time stamp
        /// </summary>
        /// <returns>date time</returns>
        public static string GetTimeStamp()
        {
            return $"{DateTime.Now:yyMMddHHmmss}";
        }
    }
}
