//
//  Generated code. Do not modify.
//  source: chat.proto
//
// @dart = 2.12

// ignore_for_file: annotate_overrides, camel_case_types, comment_references
// ignore_for_file: constant_identifier_names, library_prefixes
// ignore_for_file: non_constant_identifier_names, prefer_final_fields
// ignore_for_file: unnecessary_import, unnecessary_this, unused_import

import 'dart:async' as $async;
import 'dart:core' as $core;

import 'package:grpc/service_api.dart' as $grpc;
import 'package:protobuf/protobuf.dart' as $pb;

import 'chat.pb.dart' as $1;
import 'google/protobuf/empty.pb.dart' as $0;

export 'chat.pb.dart';

@$pb.GrpcServiceName('Chat')
class ChatClient extends $grpc.Client {
  static final _$startReceivingMessages = $grpc.ClientMethod<$0.Empty, $1.ChatMessageResponse>(
      '/Chat/StartReceivingMessages',
      ($0.Empty value) => value.writeToBuffer(),
      ($core.List<$core.int> value) => $1.ChatMessageResponse.fromBuffer(value));
  static final _$joinChat = $grpc.ClientMethod<$0.Empty, $1.ChatHistory>(
      '/Chat/JoinChat',
      ($0.Empty value) => value.writeToBuffer(),
      ($core.List<$core.int> value) => $1.ChatHistory.fromBuffer(value));
  static final _$sendChatMessage = $grpc.ClientMethod<$1.ChatMessageRequest, $0.Empty>(
      '/Chat/SendChatMessage',
      ($1.ChatMessageRequest value) => value.writeToBuffer(),
      ($core.List<$core.int> value) => $0.Empty.fromBuffer(value));

  ChatClient($grpc.ClientChannel channel,
      {$grpc.CallOptions? options,
      $core.Iterable<$grpc.ClientInterceptor>? interceptors})
      : super(channel, options: options,
        interceptors: interceptors);

  $grpc.ResponseStream<$1.ChatMessageResponse> startReceivingMessages($0.Empty request, {$grpc.CallOptions? options}) {
    return $createStreamingCall(_$startReceivingMessages, $async.Stream.fromIterable([request]), options: options);
  }

  $grpc.ResponseFuture<$1.ChatHistory> joinChat($0.Empty request, {$grpc.CallOptions? options}) {
    return $createUnaryCall(_$joinChat, request, options: options);
  }

  $grpc.ResponseFuture<$0.Empty> sendChatMessage($1.ChatMessageRequest request, {$grpc.CallOptions? options}) {
    return $createUnaryCall(_$sendChatMessage, request, options: options);
  }
}

@$pb.GrpcServiceName('Chat')
abstract class ChatServiceBase extends $grpc.Service {
  $core.String get $name => 'Chat';

  ChatServiceBase() {
    $addMethod($grpc.ServiceMethod<$0.Empty, $1.ChatMessageResponse>(
        'StartReceivingMessages',
        startReceivingMessages_Pre,
        false,
        true,
        ($core.List<$core.int> value) => $0.Empty.fromBuffer(value),
        ($1.ChatMessageResponse value) => value.writeToBuffer()));
    $addMethod($grpc.ServiceMethod<$0.Empty, $1.ChatHistory>(
        'JoinChat',
        joinChat_Pre,
        false,
        false,
        ($core.List<$core.int> value) => $0.Empty.fromBuffer(value),
        ($1.ChatHistory value) => value.writeToBuffer()));
    $addMethod($grpc.ServiceMethod<$1.ChatMessageRequest, $0.Empty>(
        'SendChatMessage',
        sendChatMessage_Pre,
        false,
        false,
        ($core.List<$core.int> value) => $1.ChatMessageRequest.fromBuffer(value),
        ($0.Empty value) => value.writeToBuffer()));
  }

  $async.Stream<$1.ChatMessageResponse> startReceivingMessages_Pre($grpc.ServiceCall call, $async.Future<$0.Empty> request) async* {
    yield* startReceivingMessages(call, await request);
  }

  $async.Future<$1.ChatHistory> joinChat_Pre($grpc.ServiceCall call, $async.Future<$0.Empty> request) async {
    return joinChat(call, await request);
  }

  $async.Future<$0.Empty> sendChatMessage_Pre($grpc.ServiceCall call, $async.Future<$1.ChatMessageRequest> request) async {
    return sendChatMessage(call, await request);
  }

  $async.Stream<$1.ChatMessageResponse> startReceivingMessages($grpc.ServiceCall call, $0.Empty request);
  $async.Future<$1.ChatHistory> joinChat($grpc.ServiceCall call, $0.Empty request);
  $async.Future<$0.Empty> sendChatMessage($grpc.ServiceCall call, $1.ChatMessageRequest request);
}
