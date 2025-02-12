﻿namespace SevenZip
{
    using System;

    /// <summary>
    /// EventArgs for storing PercentDone property.
    /// </summary>
    public class PercentDoneEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the PercentDoneEventArgs class.
        /// </summary>
        /// <param name="percentDone">The percent of finished work.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"/>
        public PercentDoneEventArgs(float percentDone)
        {
            //if (percentDone > 100 || percentDone < 0)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(percentDone),
            //        "The percent of finished work must be between 0 and 100.");
            //}

            PercentDone = percentDone;
        }

        /// <summary>
        /// Gets the percent of finished work.
        /// </summary>
        public float PercentDone { get; }
    }
}
