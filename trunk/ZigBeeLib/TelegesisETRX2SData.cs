using System;

namespace ZigBeeLib{
    public class TelegesisETRX2SData{
        private const string _nodeId = "Undefined";
        private const string PREFIX = "\r\nSDATA:";
        private readonly ushort _ioData;
        private readonly string _readLines;

        public TelegesisETRX2SData(string readLines){
            IsUndefined = true;
            _readLines = readLines;
            if (!readLines.StartsWith(PREFIX))
                return;
            IsUndefined = false;
            //SDATA:000D6F0000179029
            int prefixLength = PREFIX.Length;
            const int NODE_ID_LENGTH = 16;
            string nodeId = readLines.Substring(prefixLength, NODE_ID_LENGTH);
            string ioDataText = readLines.Substring(prefixLength + NODE_ID_LENGTH + 1, 4);
            _ioData = Convert.ToUInt16(ioDataText, 16);
        }

        public string NodeId{
            get { return _nodeId; }
        }

        public ushort IOData{
            get { return _ioData; }
        }

        public bool IsUndefined { get; private set; }

        public bool IO0{
            get { return (IOData & 0x1) != 0; }
        }

        public bool IO1{
            get { return (IOData & 0x2) != 0; }
        }

        public bool IO2{
            get { return (IOData & 0x4) != 0; }
        }

        public bool IO3{
            get { return (IOData & 0x8) != 0; }
        }
    }
}