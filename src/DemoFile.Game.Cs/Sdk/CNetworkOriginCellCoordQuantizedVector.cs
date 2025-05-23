﻿namespace DemoFile.Game.Cs;

public sealed partial class CNetworkOriginCellCoordQuantizedVector : IEquatable<CNetworkOriginCellCoordQuantizedVector>
{
    private const int CELL_WIDTH = 1 << 9;

    public Vector Vector => new(
        (CellX - 32) * CELL_WIDTH + X,
        (CellY - 32) * CELL_WIDTH + Y,
        (CellZ - 32) * CELL_WIDTH + Z);

    public bool Equals(CNetworkOriginCellCoordQuantizedVector? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Vector.Equals(other.Vector);
    }

    public override string ToString() => Vector.ToString();

    private static FieldDecode.CustomDeserializer<CNetworkOriginCellCoordQuantizedVector, UInt16> CreateDecoder_cellx(
        FieldEncodingInfo fieldEncodingInfo)
    {
        var decoder = FieldDecode.CreateDecoder_UInt16(fieldEncodingInfo);
        return (CNetworkOriginCellCoordQuantizedVector _, ref BitBuffer buffer) => decoder(ref buffer);
    }

    private static FieldDecode.CustomDeserializer<CNetworkOriginCellCoordQuantizedVector, UInt16> CreateDecoder_celly(
        FieldEncodingInfo fieldEncodingInfo)
    {
        var decoder = FieldDecode.CreateDecoder_UInt16(fieldEncodingInfo);
        return (CNetworkOriginCellCoordQuantizedVector _, ref BitBuffer buffer) => decoder(ref buffer);
    }

    private static FieldDecode.CustomDeserializer<CNetworkOriginCellCoordQuantizedVector, UInt16> CreateDecoder_cellz(
        FieldEncodingInfo fieldEncodingInfo)
    {
        var decoder = FieldDecode.CreateDecoder_UInt16(fieldEncodingInfo);
        return (CNetworkOriginCellCoordQuantizedVector _, ref BitBuffer buffer) => decoder(ref buffer);
    }

    private static FieldDecode.CustomDeserializer<CNetworkOriginCellCoordQuantizedVector, float> CreateDecoder_posx(
        FieldEncodingInfo fieldEncodingInfo)
    {
        var decoder = FieldDecode.CreateDecoder_float(fieldEncodingInfo);
        return (CNetworkOriginCellCoordQuantizedVector _, ref BitBuffer buffer) => decoder(ref buffer);
    }

    private static FieldDecode.CustomDeserializer<CNetworkOriginCellCoordQuantizedVector, float> CreateDecoder_posy(
        FieldEncodingInfo fieldEncodingInfo)
    {
        var decoder = FieldDecode.CreateDecoder_float(fieldEncodingInfo);
        return (CNetworkOriginCellCoordQuantizedVector _, ref BitBuffer buffer) => decoder(ref buffer);
    }

    private static FieldDecode.CustomDeserializer<CNetworkOriginCellCoordQuantizedVector, float> CreateDecoder_posz(
        FieldEncodingInfo fieldEncodingInfo)
    {
        var decoder = FieldDecode.CreateDecoder_float(fieldEncodingInfo);
        return (CNetworkOriginCellCoordQuantizedVector _, ref BitBuffer buffer) => decoder(ref buffer);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((CNetworkOriginCellCoordQuantizedVector) obj);
    }

    public override int GetHashCode() => Vector.GetHashCode();

    public static bool operator ==(CNetworkOriginCellCoordQuantizedVector? left, CNetworkOriginCellCoordQuantizedVector? right) => Equals(left, right);

    public static bool operator !=(CNetworkOriginCellCoordQuantizedVector? left, CNetworkOriginCellCoordQuantizedVector? right) => !Equals(left, right);
}
