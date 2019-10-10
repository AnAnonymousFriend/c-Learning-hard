// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/LuCat.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace AspNetCoregRpcService {
  /// <summary>
  ///定义服务
  /// </summary>
  public static partial class LuCat
  {
    static readonly string __ServiceName = "LuCat.LuCat";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AspNetCoregRpcService.SuckingCatResult> __Marshaller_LuCat_SuckingCatResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AspNetCoregRpcService.SuckingCatResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AspNetCoregRpcService.BathTheCatReq> __Marshaller_LuCat_BathTheCatReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AspNetCoregRpcService.BathTheCatReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AspNetCoregRpcService.BathTheCatResp> __Marshaller_LuCat_BathTheCatResp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AspNetCoregRpcService.BathTheCatResp.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AspNetCoregRpcService.CountCatResult> __Marshaller_LuCat_CountCatResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AspNetCoregRpcService.CountCatResult.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AspNetCoregRpcService.SuckingCatResult> __Method_SuckingCat = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AspNetCoregRpcService.SuckingCatResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SuckingCat",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_LuCat_SuckingCatResult);

    static readonly grpc::Method<global::AspNetCoregRpcService.BathTheCatReq, global::AspNetCoregRpcService.BathTheCatResp> __Method_BathTheCat = new grpc::Method<global::AspNetCoregRpcService.BathTheCatReq, global::AspNetCoregRpcService.BathTheCatResp>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "BathTheCat",
        __Marshaller_LuCat_BathTheCatReq,
        __Marshaller_LuCat_BathTheCatResp);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AspNetCoregRpcService.CountCatResult> __Method_Count = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AspNetCoregRpcService.CountCatResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Count",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_LuCat_CountCatResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AspNetCoregRpcService.LuCatReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for LuCat</summary>
    public partial class LuCatClient : grpc::ClientBase<LuCatClient>
    {
      /// <summary>Creates a new client for LuCat</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LuCatClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LuCat that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LuCatClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LuCatClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LuCatClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///定义吸猫方法
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::AspNetCoregRpcService.SuckingCatResult SuckingCat(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SuckingCat(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///定义吸猫方法
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::AspNetCoregRpcService.SuckingCatResult SuckingCat(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SuckingCat, null, options, request);
      }
      /// <summary>
      ///定义吸猫方法
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::AspNetCoregRpcService.SuckingCatResult> SuckingCatAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SuckingCatAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///定义吸猫方法
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::AspNetCoregRpcService.SuckingCatResult> SuckingCatAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SuckingCat, null, options, request);
      }
      /// <summary>
      ///定义给猫洗澡双向流rpc
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::AspNetCoregRpcService.BathTheCatReq, global::AspNetCoregRpcService.BathTheCatResp> BathTheCat(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BathTheCat(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///定义给猫洗澡双向流rpc
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::AspNetCoregRpcService.BathTheCatReq, global::AspNetCoregRpcService.BathTheCatResp> BathTheCat(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_BathTheCat, null, options);
      }
      /// <summary>
      ///定义统计猫数量简单rpc
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::AspNetCoregRpcService.CountCatResult Count(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Count(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///定义统计猫数量简单rpc
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::AspNetCoregRpcService.CountCatResult Count(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Count, null, options, request);
      }
      /// <summary>
      ///定义统计猫数量简单rpc
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::AspNetCoregRpcService.CountCatResult> CountAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///定义统计猫数量简单rpc
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::AspNetCoregRpcService.CountCatResult> CountAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Count, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LuCatClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LuCatClient(configuration);
      }
    }

  }
}
#endregion
