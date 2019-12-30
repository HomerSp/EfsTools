﻿using System;
using System.IO;
using EfsTools.Resourses;

namespace EfsTools.Utils
{
    internal class HdlcEncoderException : Exception
    {
        public HdlcEncoderException(string message)
            : base(message)
        {
        }
    }

    internal static class HdlcEncoder
    {
        private const byte HdlcEscChar = 0x7D; /* Escape sequence 1st character value */
        private const byte HdlcEscMask = 0x20; /* Escape sequence complement value */
        private const byte HdlcControlChar = 0x7E;
        private const byte HdlcOverheadLength = 4;
        private const byte HdlcTrailerLength = 3;
        private const byte HdlcLeadingLength = 1;

        private static readonly Crc16 Crc16Encoder = new Crc16();

        public static byte[] Encode(byte[] data)
        {
            var crc = Crc16(data);

            var buffer = new MemoryStream(data.Length * 2 + HdlcOverheadLength);
            // This causes issues and all commands return BadCmd
            //buffer.WriteByte(HdlcControlChar); // start of frame

            for (var i = 0; i < data.Length; ++i)
                if (data[i] == HdlcControlChar || data[i] == HdlcEscChar)
                {
                    buffer.WriteByte(HdlcEscChar);
                    buffer.WriteByte((byte) ((data[i] == HdlcEscChar ? HdlcEscChar : HdlcControlChar) ^ HdlcEscMask));
                }
                else
                {
                    buffer.WriteByte(data[i]);
                }

            // add in each byte of the crc, but account for the crc containing HdlcControlChar or HdlcEscChar
            for (var i = 1; i >= 0; --i)
                if (crc[i] == HdlcControlChar || crc[i] == HdlcEscChar)
                {
                    buffer.WriteByte(HdlcEscChar);
                    buffer.WriteByte((byte) ((crc[i] == HdlcEscChar ? HdlcEscChar : HdlcControlChar) ^ HdlcEscMask));
                }
                else
                {
                    buffer.WriteByte(crc[i]);
                }

            buffer.WriteByte(HdlcControlChar); // Add ending control character

            var res = buffer.ToArray();
            return res;
        }

        public static byte[] Decode(byte[] data, int size)
        {
            var buffer = new MemoryStream(size);
            var crc = new byte[2];

            var i = 0;
            for (; i < size; ++i)
            {
                if (data[i] == HdlcControlChar && i == 0) continue;

                if (data[i] == HdlcControlChar) break; // stop from reading into another message

                if (data[i] == HdlcEscChar)
                {
                    buffer.WriteByte((byte) (data[i + 1] ^ HdlcEscMask));
                    i++;
                }
                else
                {
                    buffer.WriteByte(data[i]);
                }
            }

            var result = buffer.ToArray();
            if (result.Length > 1)
            {
                crc[0] = result[result.Length - 1];
                crc[1] = result[result.Length - 2];
                var buf = result;
                result = new byte[buf.Length - 2];
                Array.Copy(buf, 0, result, 0, result.Length);
            }

            var resultCrc = Crc16(result);

            if (resultCrc[0] != crc[0] && resultCrc[1] != crc[1])
            {
                var msg = string.Format(Strings.HdlcInvalidResponseCrcFormat, BitConverter.ToUInt16(crc, 0),
                    BitConverter.ToUInt16(resultCrc, 0));
                throw new HdlcEncoderException(msg);
            }

            return result;
        }

        private static byte[] Crc16(byte[] data)
        {
            return Crc16Encoder.ComputeChecksumBytes(data);
        }
    }
}