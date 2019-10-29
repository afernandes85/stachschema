// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fds/protobuf/stach/table/MetadataLocations.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace FactSet.Protobuf.Stach.Table {

  /// <summary>Holder for reflection information generated from fds/protobuf/stach/table/MetadataLocations.proto</summary>
  public static partial class MetadataLocationsReflection {

    #region Descriptor
    /// <summary>File descriptor for fds/protobuf/stach/table/MetadataLocations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetadataLocationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBmZHMvcHJvdG9idWYvc3RhY2gvdGFibGUvTWV0YWRhdGFMb2NhdGlvbnMu",
            "cHJvdG8SHGZhY3RzZXQucHJvdG9idWYuc3RhY2gudGFibGUaLWZkcy9wcm90",
            "b2J1Zi9zdGFjaC90YWJsZS9MaXN0T2ZNZXRhZGF0YS5wcm90byLzAgoRTWV0",
            "YWRhdGFMb2NhdGlvbnMSDQoFdGFibGUYASADKAkSTQoHY29sdW1ucxgCIAMo",
            "CzI8LmZhY3RzZXQucHJvdG9idWYuc3RhY2gudGFibGUuTWV0YWRhdGFMb2Nh",
            "dGlvbnMuQ29sdW1uc0VudHJ5EkcKBHJvd3MYAyADKAsyOS5mYWN0c2V0LnBy",
            "b3RvYnVmLnN0YWNoLnRhYmxlLk1ldGFkYXRhTG9jYXRpb25zLlJvd3NFbnRy",
            "eRpcCgxDb2x1bW5zRW50cnkSCwoDa2V5GAEgASgJEjsKBXZhbHVlGAIgASgL",
            "MiwuZmFjdHNldC5wcm90b2J1Zi5zdGFjaC50YWJsZS5MaXN0T2ZNZXRhZGF0",
            "YToCOAEaWQoJUm93c0VudHJ5EgsKA2tleRgBIAEoCRI7CgV2YWx1ZRgCIAEo",
            "CzIsLmZhY3RzZXQucHJvdG9idWYuc3RhY2gudGFibGUuTGlzdE9mTWV0YWRh",
            "dGE6AjgBQlkKIGNvbS5mYWN0c2V0LnByb3RvYnVmLnN0YWNoLnRhYmxlQhZN",
            "ZXRhZGF0YUxvY2F0aW9uc1Byb3RvqgIcRmFjdFNldC5Qcm90b2J1Zi5TdGFj",
            "aC5UYWJsZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::FactSet.Protobuf.Stach.Table.ListOfMetadataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::FactSet.Protobuf.Stach.Table.MetadataLocations), global::FactSet.Protobuf.Stach.Table.MetadataLocations.Parser, new[]{ "Table", "Columns", "Rows" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MetadataLocations : pb::IMessage<MetadataLocations> {
    private static readonly pb::MessageParser<MetadataLocations> _parser = new pb::MessageParser<MetadataLocations>(() => new MetadataLocations());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MetadataLocations> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::FactSet.Protobuf.Stach.Table.MetadataLocationsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataLocations() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataLocations(MetadataLocations other) : this() {
      table_ = other.table_.Clone();
      columns_ = other.columns_.Clone();
      rows_ = other.rows_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataLocations Clone() {
      return new MetadataLocations(this);
    }

    /// <summary>Field number for the "table" field.</summary>
    public const int TableFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_table_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> table_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Table {
      get { return table_; }
    }

    /// <summary>Field number for the "columns" field.</summary>
    public const int ColumnsFieldNumber = 2;
    private static readonly pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata>.Codec _map_columns_codec
        = new pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::FactSet.Protobuf.Stach.Table.ListOfMetadata.Parser), 18);
    private readonly pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata> columns_ = new pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata> Columns {
      get { return columns_; }
    }

    /// <summary>Field number for the "rows" field.</summary>
    public const int RowsFieldNumber = 3;
    private static readonly pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata>.Codec _map_rows_codec
        = new pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::FactSet.Protobuf.Stach.Table.ListOfMetadata.Parser), 26);
    private readonly pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata> rows_ = new pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::FactSet.Protobuf.Stach.Table.ListOfMetadata> Rows {
      get { return rows_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MetadataLocations);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MetadataLocations other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!table_.Equals(other.table_)) return false;
      if (!Columns.Equals(other.Columns)) return false;
      if (!Rows.Equals(other.Rows)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= table_.GetHashCode();
      hash ^= Columns.GetHashCode();
      hash ^= Rows.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      table_.WriteTo(output, _repeated_table_codec);
      columns_.WriteTo(output, _map_columns_codec);
      rows_.WriteTo(output, _map_rows_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += table_.CalculateSize(_repeated_table_codec);
      size += columns_.CalculateSize(_map_columns_codec);
      size += rows_.CalculateSize(_map_rows_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MetadataLocations other) {
      if (other == null) {
        return;
      }
      table_.Add(other.table_);
      columns_.Add(other.columns_);
      rows_.Add(other.rows_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            table_.AddEntriesFrom(input, _repeated_table_codec);
            break;
          }
          case 18: {
            columns_.AddEntriesFrom(input, _map_columns_codec);
            break;
          }
          case 26: {
            rows_.AddEntriesFrom(input, _map_rows_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
