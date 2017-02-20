﻿using System.Xml.Serialization;

namespace SPICA.PICA.Commands
{
    public struct PICAStencilTest
    {
        [XmlAttribute] public bool Enabled;
        [XmlAttribute] public PICATestFunc Function;
        [XmlAttribute] public byte BufferMask;
        [XmlAttribute] public byte Reference;
        [XmlAttribute] public byte Mask;

        public PICAStencilTest(uint Param)
        {
            Enabled = (Param & 1) != 0;
            Function = (PICATestFunc)((Param >> 4) & 7);
            BufferMask = (byte)(Param >> 8);
            Reference = (byte)(Param >> 16);
            Mask = (byte)(Param >> 24);
        }

        public uint ToUInt32()
        {
            uint Param = 0;

            Param |= Enabled ? 1u : 0u;
            Param |= ((uint)Function & 7) << 4;
            Param |= (uint)BufferMask << 8;
            Param |= (uint)Reference << 16;
            Param |= (uint)Mask << 24;

            return Param;
        }
    }
}
