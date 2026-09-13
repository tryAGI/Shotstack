
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Shotstack
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.Destinations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Destinations), TypeInfoPropertyName = "Destinations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShotstackDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.MuxDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.S3Destination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.GoogleCloudStorageDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.GoogleDriveDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TiktokDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AkamaiNetStorageDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AzureBlobStorageDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.DestinationsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.MuxDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem), TypeInfoPropertyName = "MuxDestinationOptionsPlaybackPolicyItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.S3DestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.GoogleCloudStorageDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.GoogleDriveDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestinationPrivacyOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestinationPrivacyOptionsView), TypeInfoPropertyName = "VimeoDestinationPrivacyOptionsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestinationPrivacyOptionsEmbed), TypeInfoPropertyName = "VimeoDestinationPrivacyOptionsEmbed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestinationPrivacyOptionsComments), TypeInfoPropertyName = "VimeoDestinationPrivacyOptionsComments2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Transfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AssetResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AssetRenderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.AssetResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AssetResponseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AssetResponseAttributesStatus), TypeInfoPropertyName = "AssetResponseAttributesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TransferResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TransferResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TransferResponseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TransferResponseAttributesStatus), TypeInfoPropertyName = "TransferResponseAttributesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TiktokDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TiktokDestinationOptionsPrivacyLevel), TypeInfoPropertyName = "TiktokDestinationOptionsPrivacyLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AkamaiNetStorageDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AzureBlobStorageDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Destinations?), TypeInfoPropertyName = "NullableDestinations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem?), TypeInfoPropertyName = "NullableMuxDestinationOptionsPlaybackPolicyItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestinationPrivacyOptionsView?), TypeInfoPropertyName = "NullableVimeoDestinationPrivacyOptionsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestinationPrivacyOptionsEmbed?), TypeInfoPropertyName = "NullableVimeoDestinationPrivacyOptionsEmbed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VimeoDestinationPrivacyOptionsComments?), TypeInfoPropertyName = "NullableVimeoDestinationPrivacyOptionsComments2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AssetResponseAttributesStatus?), TypeInfoPropertyName = "NullableAssetResponseAttributesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TransferResponseAttributesStatus?), TypeInfoPropertyName = "NullableTransferResponseAttributesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TiktokDestinationOptionsPrivacyLevel?), TypeInfoPropertyName = "NullableTiktokDestinationOptionsPrivacyLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.Destinations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.AssetResponseData>))]
    internal sealed partial class ServeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ServeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ServeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Shotstack.JsonConverters.DestinationsJsonConverter());
            options.Converters.Add(new global::Shotstack.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Shotstack.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Shotstack.JsonConverters.OneOfJsonConverter<double?, object>());
            options.Converters.Add(new global::Shotstack.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem)

                    || typeToConvert == typeof(global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem?)

                    || typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsView)

                    || typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsView?)

                    || typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsEmbed)

                    || typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsEmbed?)

                    || typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsComments)

                    || typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsComments?)

                    || typeToConvert == typeof(global::Shotstack.AssetResponseAttributesStatus)

                    || typeToConvert == typeof(global::Shotstack.AssetResponseAttributesStatus?)

                    || typeToConvert == typeof(global::Shotstack.TransferResponseAttributesStatus)

                    || typeToConvert == typeof(global::Shotstack.TransferResponseAttributesStatus?)

                    || typeToConvert == typeof(global::Shotstack.TiktokDestinationOptionsPrivacyLevel)

                    || typeToConvert == typeof(global::Shotstack.TiktokDestinationOptionsPrivacyLevel?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem))
                {
                    return new global::Shotstack.JsonConverters.MuxDestinationOptionsPlaybackPolicyItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem?))
                {
                    return new global::Shotstack.JsonConverters.MuxDestinationOptionsPlaybackPolicyItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsView))
                {
                    return new global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsView?))
                {
                    return new global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsEmbed))
                {
                    return new global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsEmbedJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsEmbed?))
                {
                    return new global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsEmbedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsComments))
                {
                    return new global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsCommentsJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.VimeoDestinationPrivacyOptionsComments?))
                {
                    return new global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsCommentsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.AssetResponseAttributesStatus))
                {
                    return new global::Shotstack.JsonConverters.AssetResponseAttributesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.AssetResponseAttributesStatus?))
                {
                    return new global::Shotstack.JsonConverters.AssetResponseAttributesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.TransferResponseAttributesStatus))
                {
                    return new global::Shotstack.JsonConverters.TransferResponseAttributesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.TransferResponseAttributesStatus?))
                {
                    return new global::Shotstack.JsonConverters.TransferResponseAttributesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.TiktokDestinationOptionsPrivacyLevel))
                {
                    return new global::Shotstack.JsonConverters.TiktokDestinationOptionsPrivacyLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Shotstack.TiktokDestinationOptionsPrivacyLevel?))
                {
                    return new global::Shotstack.JsonConverters.TiktokDestinationOptionsPrivacyLevelNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ServeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}