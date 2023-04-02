
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN 
    {
//using uavcan.protocol.param.Value.cs
//using uavcan.protocol.param.NumericValue.cs
        public partial class uavcan_protocol_param_GetSet_res: IDroneCANSerialize 
        {
            public const int UAVCAN_PROTOCOL_PARAM_GETSET_RES_MAX_PACK_SIZE = 371;
            public const ulong UAVCAN_PROTOCOL_PARAM_GETSET_RES_DT_SIG = 0xA7B622F939D1A4D5;
            public const int UAVCAN_PROTOCOL_PARAM_GETSET_RES_DT_ID = 11;

            public uavcan_protocol_param_Value value = new uavcan_protocol_param_Value();
            public uavcan_protocol_param_Value default_value = new uavcan_protocol_param_Value();
            public uavcan_protocol_param_NumericValue max_value = new uavcan_protocol_param_NumericValue();
            public uavcan_protocol_param_NumericValue min_value = new uavcan_protocol_param_NumericValue();
            public uint8_t name_len; [MarshalAs(UnmanagedType.ByValArray,SizeConst=92)] public uint8_t[] name = Enumerable.Range(1, 92).Select(i => new uint8_t()).ToArray();

            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx)
            {
                encode_uavcan_protocol_param_GetSet_res(this, chunk_cb, ctx);
            }

            public void decode(CanardRxTransfer transfer)
            {
                decode_uavcan_protocol_param_GetSet_res(transfer, this);
            }

            public static uavcan_protocol_param_GetSet_res ByteArrayToDroneCANMsg(byte[] transfer, int startoffset)
            {
                var ans = new uavcan_protocol_param_GetSet_res();
                ans.decode(new DroneCAN.CanardRxTransfer(transfer.Skip(startoffset).ToArray()));
                return ans;
            }
        }
    }
}