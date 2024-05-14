//
//  Generated code. Do not modify.
//  source: chat.proto
//
// @dart = 2.12

// ignore_for_file: annotate_overrides, camel_case_types, comment_references
// ignore_for_file: constant_identifier_names, library_prefixes
// ignore_for_file: non_constant_identifier_names, prefer_final_fields
// ignore_for_file: unnecessary_import, unnecessary_this, unused_import

import 'dart:convert' as $convert;
import 'dart:core' as $core;
import 'dart:typed_data' as $typed_data;

@$core.Deprecated('Use chatMessageRequestDescriptor instead')
const ChatMessageRequest$json = {
  '1': 'ChatMessageRequest',
  '2': [
    {'1': 'content', '3': 1, '4': 1, '5': 9, '10': 'content'},
  ],
};

/// Descriptor for `ChatMessageRequest`. Decode as a `google.protobuf.DescriptorProto`.
final $typed_data.Uint8List chatMessageRequestDescriptor = $convert.base64Decode(
    'ChJDaGF0TWVzc2FnZVJlcXVlc3QSGAoHY29udGVudBgBIAEoCVIHY29udGVudA==');

@$core.Deprecated('Use chatMessageResponseDescriptor instead')
const ChatMessageResponse$json = {
  '1': 'ChatMessageResponse',
  '2': [
    {'1': 'user', '3': 1, '4': 1, '5': 9, '10': 'user'},
    {'1': 'content', '3': 2, '4': 1, '5': 9, '10': 'content'},
    {'1': 'timestamp', '3': 3, '4': 1, '5': 11, '6': '.google.protobuf.Timestamp', '10': 'timestamp'},
    {'1': 'isOwner', '3': 4, '4': 1, '5': 8, '10': 'isOwner'},
  ],
};

/// Descriptor for `ChatMessageResponse`. Decode as a `google.protobuf.DescriptorProto`.
final $typed_data.Uint8List chatMessageResponseDescriptor = $convert.base64Decode(
    'ChNDaGF0TWVzc2FnZVJlc3BvbnNlEhIKBHVzZXIYASABKAlSBHVzZXISGAoHY29udGVudBgCIA'
    'EoCVIHY29udGVudBI4Cgl0aW1lc3RhbXAYAyABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0'
    'YW1wUgl0aW1lc3RhbXASGAoHaXNPd25lchgEIAEoCFIHaXNPd25lcg==');

@$core.Deprecated('Use chatHistoryDescriptor instead')
const ChatHistory$json = {
  '1': 'ChatHistory',
  '2': [
    {'1': 'messages', '3': 1, '4': 3, '5': 11, '6': '.ChatMessageResponse', '10': 'messages'},
  ],
};

/// Descriptor for `ChatHistory`. Decode as a `google.protobuf.DescriptorProto`.
final $typed_data.Uint8List chatHistoryDescriptor = $convert.base64Decode(
    'CgtDaGF0SGlzdG9yeRIwCghtZXNzYWdlcxgBIAMoCzIULkNoYXRNZXNzYWdlUmVzcG9uc2VSCG'
    '1lc3NhZ2Vz');

