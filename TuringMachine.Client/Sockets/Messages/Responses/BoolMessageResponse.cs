﻿using TuringMachine.Client.Sockets.Enums;

namespace TuringMachine.Client.Sockets.Messages.Responses
{
    public class BoolMessageResponse : TuringMessage
    {
        /// <summary>
        /// Result
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public BoolMessageResponse() : base(ETuringMessageType.BoolResponse) { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="result">Result</param>
        public BoolMessageResponse(bool result) : this()
        {
            Result = result;
        }
    }
}