// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fds/protobuf/stach/table/Reference.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace FactSet.Protobuf.Stach.Table {

  /// <summary>Holder for reflection information generated from fds/protobuf/stach/table/Reference.proto</summary>
  public static partial class ReferenceReflection {

    #region Descriptor
    /// <summary>File descriptor for fds/protobuf/stach/table/Reference.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReferenceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihmZHMvcHJvdG9idWYvc3RhY2gvdGFibGUvUmVmZXJlbmNlLnByb3RvEhxm",
            "YWN0c2V0LnByb3RvYnVmLnN0YWNoLnRhYmxlGixmZHMvcHJvdG9idWYvc3Rh",
            "Y2gvdGFibGUvUmVmZXJlbmNlVHlwZS5wcm90byKFAQoJUmVmZXJlbmNlEkMK",
            "DnJlZmVyZW5jZV90eXBlGAEgASgOMisuZmFjdHNldC5wcm90b2J1Zi5zdGFj",
            "aC50YWJsZS5SZWZlcmVuY2VUeXBlEhAKCHRhYmxlX2lkGAIgASgJEhEKCWNv",
            "bHVtbl9pZBgDIAEoCRIOCgZyb3dfaWQYBCABKAlCUQogY29tLmZhY3RzZXQu",
            "cHJvdG9idWYuc3RhY2gudGFibGVCDlJlZmVyZW5jZVByb3RvqgIcRmFjdFNl",
            "dC5Qcm90b2J1Zi5TdGFjaC5UYWJsZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::FactSet.Protobuf.Stach.Table.ReferenceTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::FactSet.Protobuf.Stach.Table.Reference), global::FactSet.Protobuf.Stach.Table.Reference.Parser, new[]{ "ReferenceType", "TableId", "ColumnId", "RowId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Reference : pb::IMessage<Reference> {
    private static readonly pb::MessageParser<Reference> _parser = new pb::MessageParser<Reference>(() => new Reference());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Reference> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::FactSet.Protobuf.Stach.Table.ReferenceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Reference() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Reference(Reference other) : this() {
      referenceType_ = other.referenceType_;
      tableId_ = other.tableId_;
      columnId_ = other.columnId_;
      rowId_ = other.rowId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Reference Clone() {
      return new Reference(this);
    }

    /// <summary>Field number for the "reference_type" field.</summary>
    public const int ReferenceTypeFieldNumber = 1;
    private global::FactSet.Protobuf.Stach.Table.ReferenceType referenceType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FactSet.Protobuf.Stach.Table.ReferenceType ReferenceType {
      get { return referenceType_; }
      set {
        referenceType_ = value;
      }
    }

    /// <summary>Field number for the "table_id" field.</summary>
    public const int TableIdFieldNumber = 2;
    private string tableId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TableId {
      get { return tableId_; }
      set {
        tableId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "column_id" field.</summary>
    public const int ColumnIdFieldNumber = 3;
    private string columnId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ColumnId {
      get { return columnId_; }
      set {
        columnId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "row_id" field.</summary>
    public const int RowIdFieldNumber = 4;
    private string rowId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RowId {
      get { return rowId_; }
      set {
        rowId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Reference);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Reference other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReferenceType != other.ReferenceType) return false;
      if (TableId != other.TableId) return false;
      if (ColumnId != other.ColumnId) return false;
      if (RowId != other.RowId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReferenceType != 0) hash ^= ReferenceType.GetHashCode();
      if (TableId.Length != 0) hash ^= TableId.GetHashCode();
      if (ColumnId.Length != 0) hash ^= ColumnId.GetHashCode();
      if (RowId.Length != 0) hash ^= RowId.GetHashCode();
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
      if (ReferenceType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ReferenceType);
      }
      if (TableId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TableId);
      }
      if (ColumnId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ColumnId);
      }
      if (RowId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RowId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReferenceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReferenceType);
      }
      if (TableId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TableId);
      }
      if (ColumnId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ColumnId);
      }
      if (RowId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RowId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Reference other) {
      if (other == null) {
        return;
      }
      if (other.ReferenceType != 0) {
        ReferenceType = other.ReferenceType;
      }
      if (other.TableId.Length != 0) {
        TableId = other.TableId;
      }
      if (other.ColumnId.Length != 0) {
        ColumnId = other.ColumnId;
      }
      if (other.RowId.Length != 0) {
        RowId = other.RowId;
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
          case 8: {
            referenceType_ = (global::FactSet.Protobuf.Stach.Table.ReferenceType) input.ReadEnum();
            break;
          }
          case 18: {
            TableId = input.ReadString();
            break;
          }
          case 26: {
            ColumnId = input.ReadString();
            break;
          }
          case 34: {
            RowId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
