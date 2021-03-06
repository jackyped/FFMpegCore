﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMpegCore.FFMPEG.Arguments
{

    /// <summary>
    /// Represents parameter of concat argument
    /// Used for creating video from multiple images or videos
    /// </summary>
    public class ConcatArgument : Argument<IEnumerable<string>>, IEnumerable<string>
    {
        public ConcatArgument()
        {
            Value = new List<string>();
        }

        public ConcatArgument(IEnumerable<string> value) : base(value)
        {
        }

        public IEnumerator<string> GetEnumerator()
        {
            return Value.GetEnumerator();
        }

        /// <summary>
        /// String representation of the argument
        /// </summary>
        /// <returns>String representation of the argument</returns>
        public override string GetStringValue()
        {
            return ArgumentsStringifier.InputConcat(Value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
