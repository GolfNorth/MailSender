﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WpfTestMailSender
{
    public static class SMTPServer
    {
        public static string Host { get; } = "127.0.0.1";
        public static string From { get; } = "webmaster@golfnorth.ru";
        public static string To { get; } = "webmaster@golfnorth.ru";
        public static int Port { get; } = 25;

    }
}
