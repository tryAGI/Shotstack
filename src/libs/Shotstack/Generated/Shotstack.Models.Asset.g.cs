#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The type of asset to display for the duration of the Clip, i.e. a video clip or an image. Choose from one of the available asset types below.
    /// </summary>
    public readonly partial struct Asset : global::System.IEquatable<Asset>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Shotstack.AssetDiscriminatorType? Type { get; }

        /// <summary>
        /// The VideoAsset is used to create video sequences from video files. The src must be a publicly accessible URL to a video resource such as an mp4 file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.VideoAsset? Video { get; init; }
#else
        public global::Shotstack.VideoAsset? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// The ImageAsset is used to create video from images to compose an image. The src must be a publicly accessible URL to an image resource such as a jpg or png file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.ImageAsset? Image { get; init; }
#else
        public global::Shotstack.ImageAsset? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// The TextAsset is used to add text and titles to a video. The text can be styled with built in and custom<br/>
        /// [Fonts](#tocs_font). You can also add a background bounding box used to control wrapping and overflow. Emoticons are also supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.TextAsset? Text { get; init; }
#else
        public global::Shotstack.TextAsset? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// The RichTextAsset provides advanced text rendering with support for custom fonts, gradients, shadows, strokes,<br/>
        /// animations, and styling options. It offers more flexibility and visual effects than the basic TextAsset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.RichTextAsset? RichText { get; init; }
#else
        public global::Shotstack.RichTextAsset? RichText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RichText))]
#endif
        public bool IsRichText => RichText != null;

        /// <summary>
        /// The AudioAsset is used to add sound effects and audio at specific intervals on the timeline. The src must be a publicly accessible URL to an audio resource such  as an mp3 file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.AudioAsset? Audio { get; init; }
#else
        public global::Shotstack.AudioAsset? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// The LumaAsset is used to create luma matte masks, transitions and effects between other assets. A luma matte is a grey scale image or animated video where the black areas are transparent and the white areas solid. The luma matte animation should be provided as an mp4 video file. The src must be a publicly accessible URL to the file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.LumaAsset? Luma { get; init; }
#else
        public global::Shotstack.LumaAsset? Luma { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Luma))]
#endif
        public bool IsLuma => Luma != null;

        /// <summary>
        /// The CaptionAsset is used to add captions (subtitles) to a video. It uses a supplied SRT or VTT file which will<br/>
        /// be read and burnt to the video.<br/>
        /// Captions can be applied independently from a video or audio file for greater<br/>
        /// flexibility with styling and layout. For example you can scale, position or crop a video without modifying the<br/>
        /// captions.<br/>
        /// To sync captions with a video or audio file use a [Video](#tocs_videoasset") or [Audio](#tocs_audioasset") with<br/>
        /// matching start and end time.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.CaptionAsset? Caption { get; init; }
#else
        public global::Shotstack.CaptionAsset? Caption { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Caption))]
#endif
        public bool IsCaption => Caption != null;

        /// <summary>
        /// The RichCaptionAsset provides word-level caption animations with rich-text styling. It supports<br/>
        /// karaoke-style highlighting, word-by-word animations, and advanced typography. Use with SRT/VTT<br/>
        /// files or auto-transcription via aliases.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.RichCaptionAsset? RichCaption { get; init; }
#else
        public global::Shotstack.RichCaptionAsset? RichCaption { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RichCaption))]
#endif
        public bool IsRichCaption => RichCaption != null;

        /// <summary>
        /// **Notice: The HtmlAsset is deprecated, use the [TextAsset](#tocs_textasset) instead.**<br/>
        /// The HtmlAsset clip type lets you create text based layout and formatting using<br/>
        /// HTML and CSS. You can also set the height and width of a bounding box for the HTML<br/>
        /// content to sit within. Text and elements will wrap within the bounding box.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.HtmlAsset? Html { get; init; }
#else
        public global::Shotstack.HtmlAsset? Html { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Html))]
#endif
        public bool IsHtml => Html != null;

        /// <summary>
        /// **Notice: The TitleAsset is deprecated, use the [TextAsset](#tocs_textasset) instead.**<br/>
        /// The TitleAsset clip type lets you create video titles from a text string and apply styling and positioning.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.TitleAsset? Title { get; init; }
#else
        public global::Shotstack.TitleAsset? Title { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Title))]
#endif
        public bool IsTitle => Title != null;

        /// <summary>
        /// The ShapeAsset is used to add shapes to a video. The shape can be styled with a fill and a stroke.<br/>
        /// You can manipulate properties such as rotation to create dynamic effects like a diamond shape or stripes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.ShapeAsset? Shape { get; init; }
#else
        public global::Shotstack.ShapeAsset? Shape { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shape))]
#endif
        public bool IsShape => Shape != null;

        /// <summary>
        /// The SvgAsset is used to add scalable vector graphics (SVG) to a video using raw SVG markup.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "svg",<br/>
        ///   "src": "&lt;svg width=\"100\" height=\"100\"&gt;&lt;circle cx=\"50\" cy=\"50\" r=\"40\" fill=\"#FF0000\"/&gt;&lt;/svg&gt;"<br/>
        /// }<br/>
        /// ```<br/>
        /// **Supported elements:** `&lt;path&gt;`, `&lt;rect&gt;`, `&lt;circle&gt;`, `&lt;ellipse&gt;`,<br/>
        /// `&lt;line&gt;`, `&lt;polygon&gt;`, `&lt;polyline&gt;`<br/>
        /// **Automatically extracted from SVG markup:**<br/>
        /// - Path data (converted to a single combined path)<br/>
        /// - Fill color (from `fill` attribute or `style`)<br/>
        /// - Stroke color and width (from attributes or `style`)<br/>
        /// - Dimensions (from `width`/`height` or `viewBox`)<br/>
        /// - Opacity (from `opacity` attribute)<br/>
        /// See [W3C SVG 2 Specification](https://www.w3.org/TR/SVG2/) for path data syntax.<br/>
        /// Example: {"type":"svg","src":"\u003Csvg width=\u0022200\u0022 height=\u0022200\u0022\u003E\u003Crect x=\u002210\u0022 y=\u002210\u0022 width=\u0022180\u0022 height=\u0022180\u0022 rx=\u002220\u0022 fill=\u0022#3498db\u0022 stroke=\u0022#2C3E50\u0022 stroke-width=\u00223\u0022/\u003E\u003C/svg\u003E"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.SvgAsset? Svg { get; init; }
#else
        public global::Shotstack.SvgAsset? Svg { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Svg))]
#endif
        public bool IsSvg => Svg != null;

        /// <summary>
        /// The TextToImageAsset lets you create a dynamic image from a text prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.TextToImageAsset? TextToImage { get; init; }
#else
        public global::Shotstack.TextToImageAsset? TextToImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToImage))]
#endif
        public bool IsTextToImage => TextToImage != null;

        /// <summary>
        /// The ImageToVideoAsset lets you create a video from an image and a text prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.ImageToVideoAsset? ImageToVideo { get; init; }
#else
        public global::Shotstack.ImageToVideoAsset? ImageToVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToVideo))]
#endif
        public bool IsImageToVideo => ImageToVideo != null;

        /// <summary>
        /// The TextToSpeechAsset lets you generate a voice over from text using a text-to-speech service. The generated audio can be trimmed, faded and have its volume and speed adjusted using the same properties available on the AudioAsset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.TextToSpeechAsset? TextToSpeech { get; init; }
#else
        public global::Shotstack.TextToSpeechAsset? TextToSpeech { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSpeech))]
#endif
        public bool IsTextToSpeech => TextToSpeech != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.VideoAsset value) => new Asset((global::Shotstack.VideoAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.VideoAsset?(Asset @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.VideoAsset? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.ImageAsset value) => new Asset((global::Shotstack.ImageAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.ImageAsset?(Asset @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.ImageAsset? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.TextAsset value) => new Asset((global::Shotstack.TextAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.TextAsset?(Asset @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.TextAsset? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.RichTextAsset value) => new Asset((global::Shotstack.RichTextAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.RichTextAsset?(Asset @this) => @this.RichText;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.RichTextAsset? value)
        {
            RichText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.AudioAsset value) => new Asset((global::Shotstack.AudioAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.AudioAsset?(Asset @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.AudioAsset? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.LumaAsset value) => new Asset((global::Shotstack.LumaAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.LumaAsset?(Asset @this) => @this.Luma;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.LumaAsset? value)
        {
            Luma = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.CaptionAsset value) => new Asset((global::Shotstack.CaptionAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.CaptionAsset?(Asset @this) => @this.Caption;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.CaptionAsset? value)
        {
            Caption = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.RichCaptionAsset value) => new Asset((global::Shotstack.RichCaptionAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.RichCaptionAsset?(Asset @this) => @this.RichCaption;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.RichCaptionAsset? value)
        {
            RichCaption = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.HtmlAsset value) => new Asset((global::Shotstack.HtmlAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.HtmlAsset?(Asset @this) => @this.Html;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.HtmlAsset? value)
        {
            Html = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.TitleAsset value) => new Asset((global::Shotstack.TitleAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.TitleAsset?(Asset @this) => @this.Title;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.TitleAsset? value)
        {
            Title = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.ShapeAsset value) => new Asset((global::Shotstack.ShapeAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.ShapeAsset?(Asset @this) => @this.Shape;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.ShapeAsset? value)
        {
            Shape = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.SvgAsset value) => new Asset((global::Shotstack.SvgAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.SvgAsset?(Asset @this) => @this.Svg;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.SvgAsset? value)
        {
            Svg = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.TextToImageAsset value) => new Asset((global::Shotstack.TextToImageAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.TextToImageAsset?(Asset @this) => @this.TextToImage;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.TextToImageAsset? value)
        {
            TextToImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.ImageToVideoAsset value) => new Asset((global::Shotstack.ImageToVideoAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.ImageToVideoAsset?(Asset @this) => @this.ImageToVideo;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.ImageToVideoAsset? value)
        {
            ImageToVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::Shotstack.TextToSpeechAsset value) => new Asset((global::Shotstack.TextToSpeechAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.TextToSpeechAsset?(Asset @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::Shotstack.TextToSpeechAsset? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Asset(
            global::Shotstack.AssetDiscriminatorType? type,
            global::Shotstack.VideoAsset? video,
            global::Shotstack.ImageAsset? image,
            global::Shotstack.TextAsset? text,
            global::Shotstack.RichTextAsset? richText,
            global::Shotstack.AudioAsset? audio,
            global::Shotstack.LumaAsset? luma,
            global::Shotstack.CaptionAsset? caption,
            global::Shotstack.RichCaptionAsset? richCaption,
            global::Shotstack.HtmlAsset? html,
            global::Shotstack.TitleAsset? title,
            global::Shotstack.ShapeAsset? shape,
            global::Shotstack.SvgAsset? svg,
            global::Shotstack.TextToImageAsset? textToImage,
            global::Shotstack.ImageToVideoAsset? imageToVideo,
            global::Shotstack.TextToSpeechAsset? textToSpeech
            )
        {
            Type = type;

            Video = video;
            Image = image;
            Text = text;
            RichText = richText;
            Audio = audio;
            Luma = luma;
            Caption = caption;
            RichCaption = richCaption;
            Html = html;
            Title = title;
            Shape = shape;
            Svg = svg;
            TextToImage = textToImage;
            ImageToVideo = imageToVideo;
            TextToSpeech = textToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToSpeech as object ??
            ImageToVideo as object ??
            TextToImage as object ??
            Svg as object ??
            Shape as object ??
            Title as object ??
            Html as object ??
            RichCaption as object ??
            Caption as object ??
            Luma as object ??
            Audio as object ??
            RichText as object ??
            Text as object ??
            Image as object ??
            Video as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Video?.ToString() ??
            Image?.ToString() ??
            Text?.ToString() ??
            RichText?.ToString() ??
            Audio?.ToString() ??
            Luma?.ToString() ??
            Caption?.ToString() ??
            RichCaption?.ToString() ??
            Html?.ToString() ??
            Title?.ToString() ??
            Shape?.ToString() ??
            Svg?.ToString() ??
            TextToImage?.ToString() ??
            ImageToVideo?.ToString() ??
            TextToSpeech?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && IsTextToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Shotstack.VideoAsset?, TResult>? video = null,
            global::System.Func<global::Shotstack.ImageAsset?, TResult>? image = null,
            global::System.Func<global::Shotstack.TextAsset?, TResult>? text = null,
            global::System.Func<global::Shotstack.RichTextAsset?, TResult>? richText = null,
            global::System.Func<global::Shotstack.AudioAsset?, TResult>? audio = null,
            global::System.Func<global::Shotstack.LumaAsset?, TResult>? luma = null,
            global::System.Func<global::Shotstack.CaptionAsset?, TResult>? caption = null,
            global::System.Func<global::Shotstack.RichCaptionAsset?, TResult>? richCaption = null,
            global::System.Func<global::Shotstack.HtmlAsset?, TResult>? html = null,
            global::System.Func<global::Shotstack.TitleAsset?, TResult>? title = null,
            global::System.Func<global::Shotstack.ShapeAsset?, TResult>? shape = null,
            global::System.Func<global::Shotstack.SvgAsset?, TResult>? svg = null,
            global::System.Func<global::Shotstack.TextToImageAsset?, TResult>? textToImage = null,
            global::System.Func<global::Shotstack.ImageToVideoAsset?, TResult>? imageToVideo = null,
            global::System.Func<global::Shotstack.TextToSpeechAsset?, TResult>? textToSpeech = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsRichText && richText != null)
            {
                return richText(RichText!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsLuma && luma != null)
            {
                return luma(Luma!);
            }
            else if (IsCaption && caption != null)
            {
                return caption(Caption!);
            }
            else if (IsRichCaption && richCaption != null)
            {
                return richCaption(RichCaption!);
            }
            else if (IsHtml && html != null)
            {
                return html(Html!);
            }
            else if (IsTitle && title != null)
            {
                return title(Title!);
            }
            else if (IsShape && shape != null)
            {
                return shape(Shape!);
            }
            else if (IsSvg && svg != null)
            {
                return svg(Svg!);
            }
            else if (IsTextToImage && textToImage != null)
            {
                return textToImage(TextToImage!);
            }
            else if (IsImageToVideo && imageToVideo != null)
            {
                return imageToVideo(ImageToVideo!);
            }
            else if (IsTextToSpeech && textToSpeech != null)
            {
                return textToSpeech(TextToSpeech!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Shotstack.VideoAsset?>? video = null,
            global::System.Action<global::Shotstack.ImageAsset?>? image = null,
            global::System.Action<global::Shotstack.TextAsset?>? text = null,
            global::System.Action<global::Shotstack.RichTextAsset?>? richText = null,
            global::System.Action<global::Shotstack.AudioAsset?>? audio = null,
            global::System.Action<global::Shotstack.LumaAsset?>? luma = null,
            global::System.Action<global::Shotstack.CaptionAsset?>? caption = null,
            global::System.Action<global::Shotstack.RichCaptionAsset?>? richCaption = null,
            global::System.Action<global::Shotstack.HtmlAsset?>? html = null,
            global::System.Action<global::Shotstack.TitleAsset?>? title = null,
            global::System.Action<global::Shotstack.ShapeAsset?>? shape = null,
            global::System.Action<global::Shotstack.SvgAsset?>? svg = null,
            global::System.Action<global::Shotstack.TextToImageAsset?>? textToImage = null,
            global::System.Action<global::Shotstack.ImageToVideoAsset?>? imageToVideo = null,
            global::System.Action<global::Shotstack.TextToSpeechAsset?>? textToSpeech = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsRichText)
            {
                richText?.Invoke(RichText!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsLuma)
            {
                luma?.Invoke(Luma!);
            }
            else if (IsCaption)
            {
                caption?.Invoke(Caption!);
            }
            else if (IsRichCaption)
            {
                richCaption?.Invoke(RichCaption!);
            }
            else if (IsHtml)
            {
                html?.Invoke(Html!);
            }
            else if (IsTitle)
            {
                title?.Invoke(Title!);
            }
            else if (IsShape)
            {
                shape?.Invoke(Shape!);
            }
            else if (IsSvg)
            {
                svg?.Invoke(Svg!);
            }
            else if (IsTextToImage)
            {
                textToImage?.Invoke(TextToImage!);
            }
            else if (IsImageToVideo)
            {
                imageToVideo?.Invoke(ImageToVideo!);
            }
            else if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Video,
                typeof(global::Shotstack.VideoAsset),
                Image,
                typeof(global::Shotstack.ImageAsset),
                Text,
                typeof(global::Shotstack.TextAsset),
                RichText,
                typeof(global::Shotstack.RichTextAsset),
                Audio,
                typeof(global::Shotstack.AudioAsset),
                Luma,
                typeof(global::Shotstack.LumaAsset),
                Caption,
                typeof(global::Shotstack.CaptionAsset),
                RichCaption,
                typeof(global::Shotstack.RichCaptionAsset),
                Html,
                typeof(global::Shotstack.HtmlAsset),
                Title,
                typeof(global::Shotstack.TitleAsset),
                Shape,
                typeof(global::Shotstack.ShapeAsset),
                Svg,
                typeof(global::Shotstack.SvgAsset),
                TextToImage,
                typeof(global::Shotstack.TextToImageAsset),
                ImageToVideo,
                typeof(global::Shotstack.ImageToVideoAsset),
                TextToSpeech,
                typeof(global::Shotstack.TextToSpeechAsset),
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
        public bool Equals(Asset other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.VideoAsset?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.ImageAsset?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.TextAsset?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.RichTextAsset?>.Default.Equals(RichText, other.RichText) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.AudioAsset?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.LumaAsset?>.Default.Equals(Luma, other.Luma) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.CaptionAsset?>.Default.Equals(Caption, other.Caption) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.RichCaptionAsset?>.Default.Equals(RichCaption, other.RichCaption) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.HtmlAsset?>.Default.Equals(Html, other.Html) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.TitleAsset?>.Default.Equals(Title, other.Title) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.ShapeAsset?>.Default.Equals(Shape, other.Shape) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.SvgAsset?>.Default.Equals(Svg, other.Svg) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.TextToImageAsset?>.Default.Equals(TextToImage, other.TextToImage) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.ImageToVideoAsset?>.Default.Equals(ImageToVideo, other.ImageToVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.TextToSpeechAsset?>.Default.Equals(TextToSpeech, other.TextToSpeech) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Asset obj1, Asset obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Asset>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Asset obj1, Asset obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Asset o && Equals(o);
        }
    }
}
