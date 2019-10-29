# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: fds/protobuf/stach/MetadataItem.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from google.protobuf import duration_pb2 as google_dot_protobuf_dot_duration__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2
from fds.protobuf.stach.table import Reference_pb2 as fds_dot_protobuf_dot_stach_dot_table_dot_Reference__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='fds/protobuf/stach/MetadataItem.proto',
  package='factset.protobuf.stach',
  syntax='proto3',
  serialized_options=_b('\n\032com.factset.protobuf.stachB\021MetadataItemProto\252\002\026FactSet.Protobuf.Stach'),
  serialized_pb=_b('\n%fds/protobuf/stach/MetadataItem.proto\x12\x16\x66\x61\x63tset.protobuf.stach\x1a\x1egoogle/protobuf/duration.proto\x1a\x1fgoogle/protobuf/timestamp.proto\x1a(fds/protobuf/stach/table/Reference.proto\"\x95\x03\n\x0cMetadataItem\x12\x0c\n\x04name\x18\x01 \x01(\t\x12\x16\n\x0c\x64ouble_value\x18\x64 \x01(\x01H\x00\x12\x15\n\x0b\x66loat_value\x18\x65 \x01(\x02H\x00\x12\x15\n\x0bint32_value\x18\x66 \x01(\x05H\x00\x12\x15\n\x0bint64_value\x18g \x01(\x03H\x00\x12\x14\n\nbool_value\x18j \x01(\x08H\x00\x12\x16\n\x0cstring_value\x18k \x01(\tH\x00\x12\x33\n\x0e\x64uration_value\x18l \x01(\x0b\x32\x19.google.protobuf.DurationH\x00\x12\x35\n\x0ftimestamp_value\x18m \x01(\x0b\x32\x1a.google.protobuf.TimestampH\x00\x12=\n\tref_value\x18\xc9\x01 \x01(\x0b\x32\'.factset.protobuf.stach.table.ReferenceH\x00\x42\x06\n\x04\x64\x61taJ\x04\x08h\x10iJ\x04\x08i\x10jJ\x06\x08\xc8\x01\x10\xc9\x01R\x0cuint32_valueR\x0cuint64_valueR\tany_valueBH\n\x1a\x63om.factset.protobuf.stachB\x11MetadataItemProto\xaa\x02\x16\x46\x61\x63tSet.Protobuf.Stachb\x06proto3')
  ,
  dependencies=[google_dot_protobuf_dot_duration__pb2.DESCRIPTOR,google_dot_protobuf_dot_timestamp__pb2.DESCRIPTOR,fds_dot_protobuf_dot_stach_dot_table_dot_Reference__pb2.DESCRIPTOR,])




_METADATAITEM = _descriptor.Descriptor(
  name='MetadataItem',
  full_name='factset.protobuf.stach.MetadataItem',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='name', full_name='factset.protobuf.stach.MetadataItem.name', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='double_value', full_name='factset.protobuf.stach.MetadataItem.double_value', index=1,
      number=100, type=1, cpp_type=5, label=1,
      has_default_value=False, default_value=float(0),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='float_value', full_name='factset.protobuf.stach.MetadataItem.float_value', index=2,
      number=101, type=2, cpp_type=6, label=1,
      has_default_value=False, default_value=float(0),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='int32_value', full_name='factset.protobuf.stach.MetadataItem.int32_value', index=3,
      number=102, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='int64_value', full_name='factset.protobuf.stach.MetadataItem.int64_value', index=4,
      number=103, type=3, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='bool_value', full_name='factset.protobuf.stach.MetadataItem.bool_value', index=5,
      number=106, type=8, cpp_type=7, label=1,
      has_default_value=False, default_value=False,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='string_value', full_name='factset.protobuf.stach.MetadataItem.string_value', index=6,
      number=107, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='duration_value', full_name='factset.protobuf.stach.MetadataItem.duration_value', index=7,
      number=108, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='timestamp_value', full_name='factset.protobuf.stach.MetadataItem.timestamp_value', index=8,
      number=109, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='ref_value', full_name='factset.protobuf.stach.MetadataItem.ref_value', index=9,
      number=201, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
    _descriptor.OneofDescriptor(
      name='data', full_name='factset.protobuf.stach.MetadataItem.data',
      index=0, containing_type=None, fields=[]),
  ],
  serialized_start=173,
  serialized_end=578,
)

_METADATAITEM.fields_by_name['duration_value'].message_type = google_dot_protobuf_dot_duration__pb2._DURATION
_METADATAITEM.fields_by_name['timestamp_value'].message_type = google_dot_protobuf_dot_timestamp__pb2._TIMESTAMP
_METADATAITEM.fields_by_name['ref_value'].message_type = fds_dot_protobuf_dot_stach_dot_table_dot_Reference__pb2._REFERENCE
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['double_value'])
_METADATAITEM.fields_by_name['double_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['float_value'])
_METADATAITEM.fields_by_name['float_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['int32_value'])
_METADATAITEM.fields_by_name['int32_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['int64_value'])
_METADATAITEM.fields_by_name['int64_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['bool_value'])
_METADATAITEM.fields_by_name['bool_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['string_value'])
_METADATAITEM.fields_by_name['string_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['duration_value'])
_METADATAITEM.fields_by_name['duration_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['timestamp_value'])
_METADATAITEM.fields_by_name['timestamp_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
_METADATAITEM.oneofs_by_name['data'].fields.append(
  _METADATAITEM.fields_by_name['ref_value'])
_METADATAITEM.fields_by_name['ref_value'].containing_oneof = _METADATAITEM.oneofs_by_name['data']
DESCRIPTOR.message_types_by_name['MetadataItem'] = _METADATAITEM
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

MetadataItem = _reflection.GeneratedProtocolMessageType('MetadataItem', (_message.Message,), dict(
  DESCRIPTOR = _METADATAITEM,
  __module__ = 'fds.protobuf.stach.MetadataItem_pb2'
  # @@protoc_insertion_point(class_scope:factset.protobuf.stach.MetadataItem)
  ))
_sym_db.RegisterMessage(MetadataItem)


DESCRIPTOR._options = None
# @@protoc_insertion_point(module_scope)
