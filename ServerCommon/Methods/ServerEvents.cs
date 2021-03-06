﻿namespace ServerCommon.Methods
{
    public class OnServerLaunched
    {
        public const string Msg = "onlaunched";
        public int id { get; set; }
        public string msg = Msg;
        public int port { get; set; }
    }

    public class OnServerShutdown
    {
        public const string Msg = "onshutdown";
        public int id { get; set; }
        public string msg = Msg;
    }
}
