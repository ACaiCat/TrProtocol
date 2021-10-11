﻿using System;
using System.Dynamic;
using System.Globalization;
using System.Reflection.Metadata;
using TrProtocol.Models;

namespace TrProtocol.Packets
{
    public class ChangeDoor : Packet
    {
        public override MessageID Type => MessageID.ChangeDoor;
        public bool ChangeType { get; set; }
        public ShortPosition Position { get; set; }
        public byte Direction { get; set; }
    }
}
