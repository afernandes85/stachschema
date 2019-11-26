// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fds/protobuf/stach/table/SeriesFormat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace FactSet.Protobuf.Stach.Table {

  /// <summary>Holder for reflection information generated from fds/protobuf/stach/table/SeriesFormat.proto</summary>
  public static partial class SeriesFormatReflection {

    #region Descriptor
    /// <summary>File descriptor for fds/protobuf/stach/table/SeriesFormat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SeriesFormatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitmZHMvcHJvdG9idWYvc3RhY2gvdGFibGUvU2VyaWVzRm9ybWF0LnByb3Rv",
            "EhxmYWN0c2V0LnByb3RvYnVmLnN0YWNoLnRhYmxlGjJmZHMvcHJvdG9idWYv",
            "c3RhY2gvdGFibGUvSG9yaXpvbnRhbEFsaWdubWVudC5wcm90bxowZmRzL3By",
            "b3RvYnVmL3N0YWNoL3RhYmxlL1ZlcnRpY2FsQWxpZ25tZW50LnByb3RvIrcB",
            "CgxTZXJpZXNGb3JtYXQSDgoGZm9ybWF0GAEgASgJEhMKC251bGxfZm9ybWF0",
            "GAIgASgJEkEKBmhhbGlnbhgDIAEoDjIxLmZhY3RzZXQucHJvdG9idWYuc3Rh",
            "Y2gudGFibGUuSG9yaXpvbnRhbEFsaWdubWVudBI/CgZ2YWxpZ24YBCABKA4y",
            "Ly5mYWN0c2V0LnByb3RvYnVmLnN0YWNoLnRhYmxlLlZlcnRpY2FsQWxpZ25t",
            "ZW50QlQKIGNvbS5mYWN0c2V0LnByb3RvYnVmLnN0YWNoLnRhYmxlQhFTZXJp",
            "ZXNGb3JtYXRQcm90b6oCHEZhY3RTZXQuUHJvdG9idWYuU3RhY2guVGFibGVi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::FactSet.Protobuf.Stach.Table.HorizontalAlignmentReflection.Descriptor, global::FactSet.Protobuf.Stach.Table.VerticalAlignmentReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::FactSet.Protobuf.Stach.Table.SeriesFormat), global::FactSet.Protobuf.Stach.Table.SeriesFormat.Parser, new[]{ "Format", "NullFormat", "Halign", "Valign" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SeriesFormat : pb::IMessage<SeriesFormat> {
    private static readonly pb::MessageParser<SeriesFormat> _parser = new pb::MessageParser<SeriesFormat>(() => new SeriesFormat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SeriesFormat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::FactSet.Protobuf.Stach.Table.SeriesFormatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SeriesFormat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SeriesFormat(SeriesFormat other) : this() {
      format_ = other.format_;
      nullFormat_ = other.nullFormat_;
      halign_ = other.halign_;
      valign_ = other.valign_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SeriesFormat Clone() {
      return new SeriesFormat(this);
    }

    /// <summary>Field number for the "format" field.</summary>
    public const int FormatFieldNumber = 1;
    private string format_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Format {
      get { return format_; }
      set {
        format_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "null_format" field.</summary>
    public const int NullFormatFieldNumber = 2;
    private string nullFormat_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NullFormat {
      get { return nullFormat_; }
      set {
        nullFormat_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "halign" field.</summary>
    public const int HalignFieldNumber = 3;
    private global::FactSet.Protobuf.Stach.Table.HorizontalAlignment halign_ = global::FactSet.Protobuf.Stach.Table.HorizontalAlignment.UnknownHalign;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FactSet.Protobuf.Stach.Table.HorizontalAlignment Halign {
      get { return halign_; }
      set {
        halign_ = value;
      }
    }

    /// <summary>Field number for the "valign" field.</summary>
    public const int ValignFieldNumber = 4;
    private global::FactSet.Protobuf.Stach.Table.VerticalAlignment valign_ = global::FactSet.Protobuf.Stach.Table.VerticalAlignment.UnknownValign;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FactSet.Protobuf.Stach.Table.VerticalAlignment Valign {
      get { return valign_; }
      set {
        valign_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SeriesFormat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SeriesFormat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Format != other.Format) return false;
      if (NullFormat != other.NullFormat) return false;
      if (Halign != other.Halign) return false;
      if (Valign != other.Valign) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Format.Length != 0) hash ^= Format.GetHashCode();
      if (NullFormat.Length != 0) hash ^= NullFormat.GetHashCode();
      if (Halign != global::FactSet.Protobuf.Stach.Table.HorizontalAlignment.UnknownHalign) hash ^= Halign.GetHashCode();
      if (Valign != global::FactSet.Protobuf.Stach.Table.VerticalAlignment.UnknownValign) hash ^= Valign.GetHashCode();
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
      if (Format.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Format);
      }
      if (NullFormat.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NullFormat);
      }
      if (Halign != global::FactSet.Protobuf.Stach.Table.HorizontalAlignment.UnknownHalign) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Halign);
      }
      if (Valign != global::FactSet.Protobuf.Stach.Table.VerticalAlignment.UnknownValign) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Valign);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Format.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Format);
      }
      if (NullFormat.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NullFormat);
      }
      if (Halign != global::FactSet.Protobuf.Stach.Table.HorizontalAlignment.UnknownHalign) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Halign);
      }
      if (Valign != global::FactSet.Protobuf.Stach.Table.VerticalAlignment.UnknownValign) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Valign);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SeriesFormat other) {
      if (other == null) {
        return;
      }
      if (other.Format.Length != 0) {
        Format = other.Format;
      }
      if (other.NullFormat.Length != 0) {
        NullFormat = other.NullFormat;
      }
      if (other.Halign != global::FactSet.Protobuf.Stach.Table.HorizontalAlignment.UnknownHalign) {
        Halign = other.Halign;
      }
      if (other.Valign != global::FactSet.Protobuf.Stach.Table.VerticalAlignment.UnknownValign) {
        Valign = other.Valign;
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
            Format = input.ReadString();
            break;
          }
          case 18: {
            NullFormat = input.ReadString();
            break;
          }
          case 24: {
            Halign = (global::FactSet.Protobuf.Stach.Table.HorizontalAlignment) input.ReadEnum();
            break;
          }
          case 32: {
            Valign = (global::FactSet.Protobuf.Stach.Table.VerticalAlignment) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
