// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/SetLobbyVisibilityResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/SetLobbyVisibilityResponse.proto</summary>
  public static partial class SetLobbyVisibilityResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/SetLobbyVisibilityResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetLobbyVisibilityResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NldExvYmJ5Vmlz",
            "aWJpbGl0eVJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcu",
            "UmVzcG9uc2VzGiBQT0dPUHJvdG9zL0RhdGEvUmFpZC9Mb2JieS5wcm90byKS",
            "AgoaU2V0TG9iYnlWaXNpYmlsaXR5UmVzcG9uc2USUgoGcmVzdWx0GAEgASgO",
            "MkIuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5TZXRMb2JieVZp",
            "c2liaWxpdHlSZXNwb25zZS5SZXN1bHQSKgoFbG9iYnkYAiABKAsyGy5QT0dP",
            "UHJvdG9zLkRhdGEuUmFpZC5Mb2JieSJ0CgZSZXN1bHQSCQoFVU5TRVQQABIL",
            "CgdTVUNDRVNTEAESGwoXRVJST1JfTk9UX0xPQkJZX0NSRUFUT1IQAhIZChVF",
            "UlJPUl9MT0JCWV9OT1RfRk9VTkQQAxIaChZFUlJPUl9SQUlEX1VOQVZBSUxB",
            "QkxFEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Raid.LobbyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.SetLobbyVisibilityResponse), global::POGOProtos.Networking.Responses.SetLobbyVisibilityResponse.Parser, new[]{ "Result", "Lobby" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.SetLobbyVisibilityResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetLobbyVisibilityResponse : pb::IMessage<SetLobbyVisibilityResponse> {
    private static readonly pb::MessageParser<SetLobbyVisibilityResponse> _parser = new pb::MessageParser<SetLobbyVisibilityResponse>(() => new SetLobbyVisibilityResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetLobbyVisibilityResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.SetLobbyVisibilityResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyVisibilityResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyVisibilityResponse(SetLobbyVisibilityResponse other) : this() {
      result_ = other.result_;
      Lobby = other.lobby_ != null ? other.Lobby.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyVisibilityResponse Clone() {
      return new SetLobbyVisibilityResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.SetLobbyVisibilityResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.SetLobbyVisibilityResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "lobby" field.</summary>
    public const int LobbyFieldNumber = 2;
    private global::POGOProtos.Data.Raid.Lobby lobby_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Raid.Lobby Lobby {
      get { return lobby_; }
      set {
        lobby_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetLobbyVisibilityResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetLobbyVisibilityResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(Lobby, other.Lobby)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (lobby_ != null) hash ^= Lobby.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (lobby_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Lobby);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (lobby_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Lobby);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetLobbyVisibilityResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.lobby_ != null) {
        if (lobby_ == null) {
          lobby_ = new global::POGOProtos.Data.Raid.Lobby();
        }
        Lobby.MergeFrom(other.Lobby);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::POGOProtos.Networking.Responses.SetLobbyVisibilityResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (lobby_ == null) {
              lobby_ = new global::POGOProtos.Data.Raid.Lobby();
            }
            input.ReadMessage(lobby_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SetLobbyVisibilityResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_NOT_LOBBY_CREATOR")] ErrorNotLobbyCreator = 2,
        [pbr::OriginalName("ERROR_LOBBY_NOT_FOUND")] ErrorLobbyNotFound = 3,
        [pbr::OriginalName("ERROR_RAID_UNAVAILABLE")] ErrorRaidUnavailable = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
