using ProtoBuf;

namespace Lagrange.Core.Internal.Packets.Service.Oidb.Request;

// ReSharper disable InconsistentNaming

/// <summary>
/// Accept group request
/// </summary>
[ProtoContract]
[OidbSvcTrpcTcp(0x10c8, 1)]
internal class OidbSvcTrpcTcp0x10C8_1
{
    [ProtoMember(1)] public uint Accept { get; set; } // 2 for reject, 1 for accept, 3 for ignore

    [ProtoMember(2)] public OidbSvcTrpcTcp0x10C8_1Body? Body { get; set; }
}

[ProtoContract]
internal class OidbSvcTrpcTcp0x10C8_1Body
{
    [ProtoMember(1)] public ulong Sequence { get; set; } // 1
    
    [ProtoMember(2)] public uint Field2 { get; set; } // 2
    
    [ProtoMember(3)] public uint GroupUin { get; set; } // 3
    
    [ProtoMember(4)] public string? Field4 { get; set; } // ""
}