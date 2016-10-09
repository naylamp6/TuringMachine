﻿using TuringMachine.Client.Sockets.Enums;

namespace TuringMachine.Client.Sockets.Messages.Responses
{
    public class LongMessageResponse : TuringMessage
    {
        /// <summary>
        /// Result
        /// </summary>
        public long Result { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public LongMessageResponse() : base(ETuringMessageType.LongResponse) { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="result">Result</param>
        public LongMessageResponse(long result) : this()
        {
            Result = result;
        }
    }
}