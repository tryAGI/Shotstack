#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Generate assets using the native Shotstack provider AI services.
    /// </summary>
    public readonly partial struct ShotstackGeneratedAssetOptions : global::System.IEquatable<ShotstackGeneratedAssetOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminatorType? Type { get; }

        /// <summary>
        /// Options for the Shotstack text-to-speech service. Set the text to be converted to speech and choose a voice to set the speaking style. The output will be generated as an MP3 audio file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.ShotstackTextToSpeechOptions? TextToSpeech { get; init; }
#else
        public global::Shotstack.ShotstackTextToSpeechOptions? TextToSpeech { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSpeech))]
#endif
        public bool IsTextToSpeech => TextToSpeech != null;

        /// <summary>
        /// Options for the Shotstack text-to-image service. Set a text prompt to generate an image from. The output will be  generated as a PNG file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.ShotstackTextToImageOptions? TextToImage { get; init; }
#else
        public global::Shotstack.ShotstackTextToImageOptions? TextToImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToImage))]
#endif
        public bool IsTextToImage => TextToImage != null;

        /// <summary>
        /// Options for the Shotstack text-generator service. Set a text prompt that will be used to generate a new body of text. The output will be generated as a text (txt) file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.ShotstackTextGeneratorOptions? TextGenerator { get; init; }
#else
        public global::Shotstack.ShotstackTextGeneratorOptions? TextGenerator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGenerator))]
#endif
        public bool IsTextGenerator => TextGenerator != null;

        /// <summary>
        /// Options for the Shotstack image-to-video service. Set the URL of an image to convert in to a video. The output will be generated as an MP4 file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.ShotstackImageToVideoOptions? ImageToVideo { get; init; }
#else
        public global::Shotstack.ShotstackImageToVideoOptions? ImageToVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToVideo))]
#endif
        public bool IsImageToVideo => ImageToVideo != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShotstackGeneratedAssetOptions(global::Shotstack.ShotstackTextToSpeechOptions value) => new ShotstackGeneratedAssetOptions((global::Shotstack.ShotstackTextToSpeechOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.ShotstackTextToSpeechOptions?(ShotstackGeneratedAssetOptions @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(global::Shotstack.ShotstackTextToSpeechOptions? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShotstackGeneratedAssetOptions(global::Shotstack.ShotstackTextToImageOptions value) => new ShotstackGeneratedAssetOptions((global::Shotstack.ShotstackTextToImageOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.ShotstackTextToImageOptions?(ShotstackGeneratedAssetOptions @this) => @this.TextToImage;

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(global::Shotstack.ShotstackTextToImageOptions? value)
        {
            TextToImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShotstackGeneratedAssetOptions(global::Shotstack.ShotstackTextGeneratorOptions value) => new ShotstackGeneratedAssetOptions((global::Shotstack.ShotstackTextGeneratorOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.ShotstackTextGeneratorOptions?(ShotstackGeneratedAssetOptions @this) => @this.TextGenerator;

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(global::Shotstack.ShotstackTextGeneratorOptions? value)
        {
            TextGenerator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShotstackGeneratedAssetOptions(global::Shotstack.ShotstackImageToVideoOptions value) => new ShotstackGeneratedAssetOptions((global::Shotstack.ShotstackImageToVideoOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.ShotstackImageToVideoOptions?(ShotstackGeneratedAssetOptions @this) => @this.ImageToVideo;

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(global::Shotstack.ShotstackImageToVideoOptions? value)
        {
            ImageToVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(
            global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminatorType? type,
            global::Shotstack.ShotstackTextToSpeechOptions? textToSpeech,
            global::Shotstack.ShotstackTextToImageOptions? textToImage,
            global::Shotstack.ShotstackTextGeneratorOptions? textGenerator,
            global::Shotstack.ShotstackImageToVideoOptions? imageToVideo
            )
        {
            Type = type;

            TextToSpeech = textToSpeech;
            TextToImage = textToImage;
            TextGenerator = textGenerator;
            ImageToVideo = imageToVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageToVideo as object ??
            TextGenerator as object ??
            TextToImage as object ??
            TextToSpeech as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToSpeech?.ToString() ??
            TextToImage?.ToString() ??
            TextGenerator?.ToString() ??
            ImageToVideo?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToSpeech && !IsTextToImage && !IsTextGenerator && !IsImageToVideo || !IsTextToSpeech && IsTextToImage && !IsTextGenerator && !IsImageToVideo || !IsTextToSpeech && !IsTextToImage && IsTextGenerator && !IsImageToVideo || !IsTextToSpeech && !IsTextToImage && !IsTextGenerator && IsImageToVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Shotstack.ShotstackTextToSpeechOptions?, TResult>? textToSpeech = null,
            global::System.Func<global::Shotstack.ShotstackTextToImageOptions?, TResult>? textToImage = null,
            global::System.Func<global::Shotstack.ShotstackTextGeneratorOptions?, TResult>? textGenerator = null,
            global::System.Func<global::Shotstack.ShotstackImageToVideoOptions?, TResult>? imageToVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToSpeech && textToSpeech != null)
            {
                return textToSpeech(TextToSpeech!);
            }
            else if (IsTextToImage && textToImage != null)
            {
                return textToImage(TextToImage!);
            }
            else if (IsTextGenerator && textGenerator != null)
            {
                return textGenerator(TextGenerator!);
            }
            else if (IsImageToVideo && imageToVideo != null)
            {
                return imageToVideo(ImageToVideo!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Shotstack.ShotstackTextToSpeechOptions?>? textToSpeech = null,
            global::System.Action<global::Shotstack.ShotstackTextToImageOptions?>? textToImage = null,
            global::System.Action<global::Shotstack.ShotstackTextGeneratorOptions?>? textGenerator = null,
            global::System.Action<global::Shotstack.ShotstackImageToVideoOptions?>? imageToVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
            else if (IsTextToImage)
            {
                textToImage?.Invoke(TextToImage!);
            }
            else if (IsTextGenerator)
            {
                textGenerator?.Invoke(TextGenerator!);
            }
            else if (IsImageToVideo)
            {
                imageToVideo?.Invoke(ImageToVideo!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToSpeech,
                typeof(global::Shotstack.ShotstackTextToSpeechOptions),
                TextToImage,
                typeof(global::Shotstack.ShotstackTextToImageOptions),
                TextGenerator,
                typeof(global::Shotstack.ShotstackTextGeneratorOptions),
                ImageToVideo,
                typeof(global::Shotstack.ShotstackImageToVideoOptions),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ShotstackGeneratedAssetOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.ShotstackTextToSpeechOptions?>.Default.Equals(TextToSpeech, other.TextToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.ShotstackTextToImageOptions?>.Default.Equals(TextToImage, other.TextToImage) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.ShotstackTextGeneratorOptions?>.Default.Equals(TextGenerator, other.TextGenerator) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.ShotstackImageToVideoOptions?>.Default.Equals(ImageToVideo, other.ImageToVideo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ShotstackGeneratedAssetOptions obj1, ShotstackGeneratedAssetOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShotstackGeneratedAssetOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShotstackGeneratedAssetOptions obj1, ShotstackGeneratedAssetOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShotstackGeneratedAssetOptions o && Equals(o);
        }
    }
}
