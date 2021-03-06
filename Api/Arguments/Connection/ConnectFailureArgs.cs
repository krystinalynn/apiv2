namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the ConnectFailure event
    /// </summary>
    public class ConnectFailureArgs : EventArgs
    {
        private readonly IServer server;
        private readonly string error;
        private readonly EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the ConnectFailure event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="error">string</param>
        /// <param name="eatData">EatData</param>
        public ConnectFailureArgs(IServer server, string error, EatData eatData)
        {
            this.server = server;
            this.error = error;
            this.eatData = eatData;
        }

        /// <summary>
        ///     The IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     The error message
        /// </summary>
        public string Error { get { return this.error; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } }
    }
}