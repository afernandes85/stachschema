// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fds/protobuf/stach/table/MetadataCollection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace FactSet.Protobuf.Stach.Table {

  /// <summary>Holder for reflection information generated from fds/protobuf/stach/table/MetadataCollection.proto</summary>
  public static partial class MetadataCollectionReflection {

    #region Descriptor
    /// <summary>File descriptor for fds/protobuf/stach/table/MetadataCollection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetadataCollectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFmZHMvcHJvdG9idWYvc3RhY2gvdGFibGUvTWV0YWRhdGFDb2xsZWN0aW9u",
            "LnByb3RvEhxmYWN0c2V0LnByb3RvYnVmLnN0YWNoLnRhYmxlGiVmZHMvcHJv",
            "dG9idWYvc3RhY2gvTWV0YWRhdGFJdGVtLnByb3RvGjBmZHMvcHJvdG9idWYv",
            "c3RhY2gvdGFibGUvTWV0YWRhdGFMb2NhdGlvbnMucHJvdG8i+AEKEk1ldGFk",
            "YXRhQ29sbGVjdGlvbhJKCgVpdGVtcxgBIAMoCzI7LmZhY3RzZXQucHJvdG9i",
            "dWYuc3RhY2gudGFibGUuTWV0YWRhdGFDb2xsZWN0aW9uLkl0ZW1zRW50cnkS",
            "QgoJbG9jYXRpb25zGAIgASgLMi8uZmFjdHNldC5wcm90b2J1Zi5zdGFjaC50",
            "YWJsZS5NZXRhZGF0YUxvY2F0aW9ucxpSCgpJdGVtc0VudHJ5EgsKA2tleRgB",
            "IAEoCRIzCgV2YWx1ZRgCIAEoCzIkLmZhY3RzZXQucHJvdG9idWYuc3RhY2gu",
            "TWV0YWRhdGFJdGVtOgI4AUJaCiBjb20uZmFjdHNldC5wcm90b2J1Zi5zdGFj",
            "aC50YWJsZUIXTWV0YWRhdGFDb2xsZWN0aW9uUHJvdG+qAhxGYWN0U2V0LlBy",
            "b3RvYnVmLlN0YWNoLlRhYmxlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::FactSet.Protobuf.Stach.MetadataItemReflection.Descriptor, global::FactSet.Protobuf.Stach.Table.MetadataLocationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::FactSet.Protobuf.Stach.Table.MetadataCollection), global::FactSet.Protobuf.Stach.Table.MetadataCollection.Parser, new[]{ "Items", "Locations" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MetadataCollection : pb::IMessage<MetadataCollection> {
    private static readonly pb::MessageParser<MetadataCollection> _parser = new pb::MessageParser<MetadataCollection>(() => new MetadataCollection());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MetadataCollection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::FactSet.Protobuf.Stach.Table.MetadataCollectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataCollection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataCollection(MetadataCollection other) : this() {
      items_ = other.items_.Clone();
      locations_ = other.locations_ != null ? other.locations_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataCollection Clone() {
      return new MetadataCollection(this);
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pbc::MapField<string, global::FactSet.Protobuf.Stach.MetadataItem>.Codec _map_items_codec
        = new pbc::MapField<string, global::FactSet.Protobuf.Stach.MetadataItem>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::FactSet.Protobuf.Stach.MetadataItem.Parser), 10);
    private readonly pbc::MapField<string, global::FactSet.Protobuf.Stach.MetadataItem> items_ = new pbc::MapField<string, global::FactSet.Protobuf.Stach.MetadataItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::FactSet.Protobuf.Stach.MetadataItem> Items {
      get { return items_; }
    }

    /// <summary>Field number for the "locations" field.</summary>
    public const int LocationsFieldNumber = 2;
    private global::FactSet.Protobuf.Stach.Table.MetadataLocations locations_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FactSet.Protobuf.Stach.Table.MetadataLocations Locations {
      get { return locations_; }
      set {
        locations_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MetadataCollection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MetadataCollection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Items.Equals(other.Items)) return false;
      if (!object.Equals(Locations, other.Locations)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Items.GetHashCode();
      if (locations_ != null) hash ^= Locations.GetHashCode();
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
      items_.WriteTo(output, _map_items_codec);
      if (locations_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Locations);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += items_.CalculateSize(_map_items_codec);
      if (locations_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Locations);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MetadataCollection other) {
      if (other == null) {
        return;
      }
      items_.Add(other.items_);
      if (other.locations_ != null) {
        if (locations_ == null) {
          Locations = new global::FactSet.Protobuf.Stach.Table.MetadataLocations();
        }
        Locations.MergeFrom(other.Locations);
      }
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
            items_.AddEntriesFrom(input, _map_items_codec);
            break;
          }
          case 18: {
            if (locations_ == null) {
              Locations = new global::FactSet.Protobuf.Stach.Table.MetadataLocations();
            }
            input.ReadMessage(Locations);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
