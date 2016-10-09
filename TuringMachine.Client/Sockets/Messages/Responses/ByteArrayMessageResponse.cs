﻿using TuringMachine.Client.Sockets.Enums;

namespace TuringMachine.Client.Sockets.Messages.Responses
{
    public class ByteArrayMessageResponse : TuringMessage
    {
        /// <summary>
        /// Result
        /// </summary>
        public byte[] Result { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ByteArrayMessageResponse() : base(ETuringMessageType.ByteArrayResponse) { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="result">Result</param>
        public ByteArrayMessageResponse(byte[] result) : this()
        {
            Result = result;
        }
    }
}