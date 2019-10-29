// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fds/protobuf/stach/table/SeriesDefinition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace FactSet.Protobuf.Stach.Table {

  /// <summary>Holder for reflection information generated from fds/protobuf/stach/table/SeriesDefinition.proto</summary>
  public static partial class SeriesDefinitionReflection {

    #region Descriptor
    /// <summary>File descriptor for fds/protobuf/stach/table/SeriesDefinition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SeriesDefinitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9mZHMvcHJvdG9idWYvc3RhY2gvdGFibGUvU2VyaWVzRGVmaW5pdGlvbi5w",
            "cm90bxIcZmFjdHNldC5wcm90b2J1Zi5zdGFjaC50YWJsZRonZmRzL3Byb3Rv",
            "YnVmL3N0YWNoL3RhYmxlL0RhdGFUeXBlLnByb3RvGitmZHMvcHJvdG9idWYv",
            "c3RhY2gvdGFibGUvU2VyaWVzRm9ybWF0LnByb3RvIrECChBTZXJpZXNEZWZp",
            "bml0aW9uEgoKAmlkGAEgASgJEgwKBG5hbWUYAiABKAkSEwoLZGVzY3JpcHRp",
            "b24YAyABKAkSNAoEdHlwZRgEIAEoDjImLmZhY3RzZXQucHJvdG9idWYuc3Rh",
            "Y2gudGFibGUuRGF0YVR5cGUSFAoMaXNfZGltZW5zaW9uGAUgASgIEhEKCWlz",
            "X2hpZGRlbhgGIAEoCBIXCg9uZXh0X3NpYmxpbmdfaWQYByABKAkSEQoJcGFy",
            "ZW50X2lkGAggASgJEhEKCWhlYWRlcl9pZBgJIAEoCRIUCgxoZWFkZXJfaW5k",
            "ZXgYCiABKAUSOgoGZm9ybWF0GAsgASgLMiouZmFjdHNldC5wcm90b2J1Zi5z",
            "dGFjaC50YWJsZS5TZXJpZXNGb3JtYXRCWAogY29tLmZhY3RzZXQucHJvdG9i",
            "dWYuc3RhY2gudGFibGVCFVNlcmllc0RlZmluaXRpb25Qcm90b6oCHEZhY3RT",
            "ZXQuUHJvdG9idWYuU3RhY2guVGFibGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::FactSet.Protobuf.Stach.Table.DataTypeReflection.Descriptor, global::FactSet.Protobuf.Stach.Table.SeriesFormatReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::FactSet.Protobuf.Stach.Table.SeriesDefinition), global::FactSet.Protobuf.Stach.Table.SeriesDefinition.Parser, new[]{ "Id", "Name", "Description", "Type", "IsDimension", "IsHidden", "NextSiblingId", "ParentId", "HeaderId", "HeaderIndex", "Format" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SeriesDefinition : pb::IMessage<SeriesDefinition> {
    private static readonly pb::MessageParser<SeriesDefinition> _parser = new pb::MessageParser<SeriesDefinition>(() => new SeriesDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SeriesDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::FactSet.Protobuf.Stach.Table.SeriesDefinitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SeriesDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SeriesDefinition(SeriesDefinition other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      description_ = other.description_;
      type_ = other.type_;
      isDimension_ = other.isDimension_;
      isHidden_ = other.isHidden_;
      nextSiblingId_ = other.nextSiblingId_;
      parentId_ = other.parentId_;
      headerId_ = other.headerId_;
      headerIndex_ = other.headerIndex_;
      format_ = other.format_ != null ? other.format_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SeriesDefinition Clone() {
      return new SeriesDefinition(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::FactSet.Protobuf.Stach.Table.DataType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FactSet.Protobuf.Stach.Table.DataType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "is_dimension" field.</summary>
    public const int IsDimensionFieldNumber = 5;
    private bool isDimension_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsDimension {
      get { return isDimension_; }
      set {
        isDimension_ = value;
      }
    }

    /// <summary>Field number for the "is_hidden" field.</summary>
    public const int IsHiddenFieldNumber = 6;
    private bool isHidden_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsHidden {
      get { return isHidden_; }
      set {
        isHidden_ = value;
      }
    }

    /// <summary>Field number for the "next_sibling_id" field.</summary>
    public const int NextSiblingIdFieldNumber = 7;
    private string nextSiblingId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextSiblingId {
      get { return nextSiblingId_; }
      set {
        nextSiblingId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent_id" field.</summary>
    public const int ParentIdFieldNumber = 8;
    private string parentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ParentId {
      get { return parentId_; }
      set {
        parentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "header_id" field.</summary>
    public const int HeaderIdFieldNumber = 9;
    private string headerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HeaderId {
      get { return headerId_; }
      set {
        headerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "header_index" field.</summary>
    public const int HeaderIndexFieldNumber = 10;
    private int headerIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int HeaderIndex {
      get { return headerIndex_; }
      set {
        headerIndex_ = value;
      }
    }

    /// <summary>Field number for the "format" field.</summary>
    public const int FormatFieldNumber = 11;
    private global::FactSet.Protobuf.Stach.Table.SeriesFormat format_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FactSet.Protobuf.Stach.Table.SeriesFormat Format {
      get { return format_; }
      set {
        format_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SeriesDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SeriesDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (Type != other.Type) return false;
      if (IsDimension != other.IsDimension) return false;
      if (IsHidden != other.IsHidden) return false;
      if (NextSiblingId != other.NextSiblingId) return false;
      if (ParentId != other.ParentId) return false;
      if (HeaderId != other.HeaderId) return false;
      if (HeaderIndex != other.HeaderIndex) return false;
      if (!object.Equals(Format, other.Format)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (IsDimension != false) hash ^= IsDimension.GetHashCode();
      if (IsHidden != false) hash ^= IsHidden.GetHashCode();
      if (NextSiblingId.Length != 0) hash ^= NextSiblingId.GetHashCode();
      if (ParentId.Length != 0) hash ^= ParentId.GetHashCode();
      if (HeaderId.Length != 0) hash ^= HeaderId.GetHashCode();
      if (HeaderIndex != 0) hash ^= HeaderIndex.GetHashCode();
      if (format_ != null) hash ^= Format.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (Type != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (IsDimension != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDimension);
      }
      if (IsHidden != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsHidden);
      }
      if (NextSiblingId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(NextSiblingId);
      }
      if (ParentId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ParentId);
      }
      if (HeaderId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(HeaderId);
      }
      if (HeaderIndex != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(HeaderIndex);
      }
      if (format_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Format);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (IsDimension != false) {
        size += 1 + 1;
      }
      if (IsHidden != false) {
        size += 1 + 1;
      }
      if (NextSiblingId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextSiblingId);
      }
      if (ParentId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParentId);
      }
      if (HeaderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HeaderId);
      }
      if (HeaderIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HeaderIndex);
      }
      if (format_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Format);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SeriesDefinition other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.IsDimension != false) {
        IsDimension = other.IsDimension;
      }
      if (other.IsHidden != false) {
        IsHidden = other.IsHidden;
      }
      if (other.NextSiblingId.Length != 0) {
        NextSiblingId = other.NextSiblingId;
      }
      if (other.ParentId.Length != 0) {
        ParentId = other.ParentId;
      }
      if (other.HeaderId.Length != 0) {
        HeaderId = other.HeaderId;
      }
      if (other.HeaderIndex != 0) {
        HeaderIndex = other.HeaderIndex;
      }
      if (other.format_ != null) {
        if (format_ == null) {
          format_ = new global::FactSet.Protobuf.Stach.Table.SeriesFormat();
        }
        Format.MergeFrom(other.Format);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 32: {
            type_ = (global::FactSet.Protobuf.Stach.Table.DataType) input.ReadEnum();
            break;
          }
          case 40: {
            IsDimension = input.ReadBool();
            break;
          }
          case 48: {
            IsHidden = input.ReadBool();
            break;
          }
          case 58: {
            NextSiblingId = input.ReadString();
            break;
          }
          case 66: {
            ParentId = input.ReadString();
            break;
          }
          case 74: {
            HeaderId = input.ReadString();
            break;
          }
          case 80: {
            HeaderIndex = input.ReadInt32();
            break;
          }
          case 90: {
            if (format_ == null) {
              format_ = new global::FactSet.Protobuf.Stach.Table.SeriesFormat();
            }
            input.ReadMessage(format_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
