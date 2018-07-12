﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Time)]
    [QcdmMinResponseLength(9)]
    internal class TimeCommandResponse : BaseCommandResponse
    {
        private TimeCommandResponse()
        {
        }

        public static TimeCommandResponse Parse(byte[] data)
        {
            var result = new TimeCommandResponse();
            result.CheckResponse(data);

            var time = BitConverter.ToInt64(data, 1);
            result.Time = time;
            return result;
        }

        public long Time { get; private set; }
    }
}