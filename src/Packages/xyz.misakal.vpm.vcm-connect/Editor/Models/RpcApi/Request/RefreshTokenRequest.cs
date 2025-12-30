using System.Text.Json.Serialization;

namespace VRChatContentPublisherConnect.Editor.Models.RpcApi.Request;

internal record RefreshTokenRequest(
    [property: JsonPropertyName("ClientName")]
    string ClientName);