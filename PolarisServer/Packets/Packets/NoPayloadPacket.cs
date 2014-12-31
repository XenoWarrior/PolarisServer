using System;

using PolarisServer.Models;

namespace PolarisServer.Packets
{
    public class NoPayloadPacket : Packet
    {
        byte type, subtype;

        public NoPayloadPacket(byte type, byte subtype)
        {
            this.type = type;
            this.subtype = subtype;
        }

        #region implemented abstract members of Packet

        public override byte[] Build()
        {
            return new byte[0];
        }

        public override PacketHeader GetHeader()
        {
            return new PacketHeader
            {
                type = type,
                subtype = subtype
            };
        }

        #endregion
    }
}

