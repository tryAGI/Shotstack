#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class AssetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.Asset>
    {
        /// <inheritdoc />
        public override global::Shotstack.Asset Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AssetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AssetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.AssetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Shotstack.VideoAsset? video = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.VideoAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.VideoAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.VideoAsset)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.ImageAsset? image = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ImageAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ImageAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ImageAsset)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.TextAsset? text = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TextAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TextAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.TextAsset)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.RichTextAsset? richText = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.RichText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.RichTextAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.RichTextAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.RichTextAsset)}");
                richText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.AudioAsset? audio = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AudioAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AudioAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.AudioAsset)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.LumaAsset? luma = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Luma)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.LumaAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.LumaAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.LumaAsset)}");
                luma = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.CaptionAsset? caption = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Caption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.CaptionAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.CaptionAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.CaptionAsset)}");
                caption = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.RichCaptionAsset? richCaption = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.RichCaption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.RichCaptionAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.RichCaptionAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.RichCaptionAsset)}");
                richCaption = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.HtmlAsset? html = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Html)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.HtmlAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.HtmlAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.HtmlAsset)}");
                html = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.TitleAsset? title = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Title)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TitleAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TitleAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.TitleAsset)}");
                title = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.ShapeAsset? shape = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Shape)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShapeAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShapeAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ShapeAsset)}");
                shape = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgAsset? svg = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.Svg)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgAsset)}");
                svg = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.TextToImageAsset? textToImage = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.TextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TextToImageAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TextToImageAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.TextToImageAsset)}");
                textToImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.ImageToVideoAsset? imageToVideo = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.ImageToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ImageToVideoAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ImageToVideoAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ImageToVideoAsset)}");
                imageToVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.TextToSpeechAsset? textToSpeech = default;
            if (discriminator?.Type == global::Shotstack.AssetDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TextToSpeechAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TextToSpeechAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.TextToSpeechAsset)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Shotstack.Asset(
                discriminator?.Type,
                video,

                image,

                text,

                richText,

                audio,

                luma,

                caption,

                richCaption,

                html,

                title,

                shape,

                svg,

                textToImage,

                imageToVideo,

                textToSpeech
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.Asset value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.VideoAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.VideoAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.VideoAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ImageAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ImageAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ImageAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TextAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TextAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.TextAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsRichText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.RichTextAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.RichTextAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.RichTextAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RichText!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.AudioAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.AudioAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.AudioAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsLuma)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.LumaAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.LumaAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.LumaAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Luma!, typeInfo);
            }
            else if (value.IsCaption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.CaptionAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.CaptionAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.CaptionAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Caption!, typeInfo);
            }
            else if (value.IsRichCaption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.RichCaptionAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.RichCaptionAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.RichCaptionAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RichCaption!, typeInfo);
            }
            else if (value.IsHtml)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.HtmlAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.HtmlAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.HtmlAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Html!, typeInfo);
            }
            else if (value.IsTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TitleAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TitleAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.TitleAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Title!, typeInfo);
            }
            else if (value.IsShape)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShapeAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShapeAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ShapeAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shape!, typeInfo);
            }
            else if (value.IsSvg)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Svg!, typeInfo);
            }
            else if (value.IsTextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TextToImageAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TextToImageAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.TextToImageAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToImage!, typeInfo);
            }
            else if (value.IsImageToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ImageToVideoAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ImageToVideoAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ImageToVideoAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageToVideo!, typeInfo);
            }
            else if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.TextToSpeechAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.TextToSpeechAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.TextToSpeechAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech!, typeInfo);
            }
        }
    }
}