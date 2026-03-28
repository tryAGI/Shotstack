#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class DestinationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.Destinations>
    {
        /// <inheritdoc />
        public override global::Shotstack.Destinations Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("exclude")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("options")) __score1++;
            if (__jsonProps.Contains("provider")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("options")) __score2++;
            if (__jsonProps.Contains("provider")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("options")) __score3++;
            if (__jsonProps.Contains("provider")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("options")) __score4++;
            if (__jsonProps.Contains("provider")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("options")) __score5++;
            if (__jsonProps.Contains("provider")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("options")) __score6++;
            if (__jsonProps.Contains("provider")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("options")) __score7++;
            if (__jsonProps.Contains("provider")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("options")) __score8++;
            if (__jsonProps.Contains("provider")) __score8++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }

            global::Shotstack.ShotstackDestination? shotstackDestination = default;
            global::Shotstack.MuxDestination? muxDestination = default;
            global::Shotstack.S3Destination? s3Destination = default;
            global::Shotstack.GoogleCloudStorageDestination? googleCloudStorageDestination = default;
            global::Shotstack.GoogleDriveDestination? googleDriveDestination = default;
            global::Shotstack.VimeoDestination? vimeoDestination = default;
            global::Shotstack.TiktokDestination? tiktokDestination = default;
            global::Shotstack.AkamaiNetStorageDestination? akamaiNetStorageDestination = default;
            global::Shotstack.AzureBlobStorageDestination? azureBlobStorageDestination = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ShotstackDestination).Name}");
                        shotstackDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.MuxDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.MuxDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.MuxDestination).Name}");
                        muxDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.S3Destination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.S3Destination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.S3Destination).Name}");
                        s3Destination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.GoogleCloudStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.GoogleCloudStorageDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.GoogleCloudStorageDestination).Name}");
                        googleCloudStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.GoogleDriveDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.GoogleDriveDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.GoogleDriveDestination).Name}");
                        googleDriveDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.VimeoDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.VimeoDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.VimeoDestination).Name}");
                        vimeoDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TiktokDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TiktokDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.TiktokDestination).Name}");
                        tiktokDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AkamaiNetStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AkamaiNetStorageDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.AkamaiNetStorageDestination).Name}");
                        akamaiNetStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AzureBlobStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AzureBlobStorageDestination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.AzureBlobStorageDestination).Name}");
                        azureBlobStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shotstackDestination == null && muxDestination == null && s3Destination == null && googleCloudStorageDestination == null && googleDriveDestination == null && vimeoDestination == null && tiktokDestination == null && akamaiNetStorageDestination == null && azureBlobStorageDestination == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ShotstackDestination).Name}");
                    shotstackDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.MuxDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.MuxDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.MuxDestination).Name}");
                    muxDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.S3Destination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.S3Destination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.S3Destination).Name}");
                    s3Destination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.GoogleCloudStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.GoogleCloudStorageDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.GoogleCloudStorageDestination).Name}");
                    googleCloudStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.GoogleDriveDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.GoogleDriveDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.GoogleDriveDestination).Name}");
                    googleDriveDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.VimeoDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.VimeoDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.VimeoDestination).Name}");
                    vimeoDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TiktokDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TiktokDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.TiktokDestination).Name}");
                    tiktokDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AkamaiNetStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AkamaiNetStorageDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.AkamaiNetStorageDestination).Name}");
                    akamaiNetStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AzureBlobStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AzureBlobStorageDestination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.AzureBlobStorageDestination).Name}");
                    azureBlobStorageDestination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Shotstack.Destinations(
                shotstackDestination,

                muxDestination,

                s3Destination,

                googleCloudStorageDestination,

                googleDriveDestination,

                vimeoDestination,

                tiktokDestination,

                akamaiNetStorageDestination,

                azureBlobStorageDestination
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.Destinations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShotstackDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ShotstackDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShotstackDestination, typeInfo);
            }
            else if (value.IsMuxDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.MuxDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.MuxDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.MuxDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MuxDestination, typeInfo);
            }
            else if (value.IsS3Destination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.S3Destination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.S3Destination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.S3Destination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3Destination, typeInfo);
            }
            else if (value.IsGoogleCloudStorageDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.GoogleCloudStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.GoogleCloudStorageDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.GoogleCloudStorageDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCloudStorageDestination, typeInfo);
            }
            else if (value.IsGoogleDriveDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.GoogleDriveDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.GoogleDriveDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.GoogleDriveDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleDriveDestination, typeInfo);
            }
            else if (value.IsVimeoDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.VimeoDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.VimeoDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.VimeoDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VimeoDestination, typeInfo);
            }
            else if (value.IsTiktokDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TiktokDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TiktokDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.TiktokDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TiktokDestination, typeInfo);
            }
            else if (value.IsAkamaiNetStorageDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AkamaiNetStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AkamaiNetStorageDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.AkamaiNetStorageDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AkamaiNetStorageDestination, typeInfo);
            }
            else if (value.IsAzureBlobStorageDestination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AzureBlobStorageDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AzureBlobStorageDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.AzureBlobStorageDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureBlobStorageDestination, typeInfo);
            }
        }
    }
}