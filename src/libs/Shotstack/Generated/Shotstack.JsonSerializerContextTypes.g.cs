
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Edit? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Timeline? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Output? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.MergeField>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MergeField? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.EditDisk? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.EditInstance? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Soundtrack? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Font>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Font? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Track>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Track? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SoundtrackEffect? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Clip>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Clip? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Asset? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<double?, string>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ClipFit? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Tween>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Tween? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ClipPosition? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Offset? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transition? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ClipEffect? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ClipFilter? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Filter>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Filter? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transformation? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VideoAsset? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageAsset? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAsset? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAsset? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioAsset? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.LumaAsset? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionAsset? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAsset? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAsset? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Html5Asset? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAsset? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAsset? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SvgAsset? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToImageAsset? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAsset? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAsset? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetDiscriminator? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetDiscriminatorType? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VideoAssetType? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VideoAssetVolumeEffect? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Mute? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Crop? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ChromaKey? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageAssetType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAssetType? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextFont? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextBackground? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignment? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextStroke? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAnimation? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAssetType? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextFont? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyle? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStroke? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextShadow? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextBackground? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextBorder? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<double?, global::Shotstack.RichTextPadding>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextPadding? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignment? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimation? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioAssetType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioAssetEffect? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Duck? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetType? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetShape? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetFill? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetStroke? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetRectangle? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetCircle? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetLine? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.LumaAssetType? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionAssetType? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionFont? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionBackground? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionMargin? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAssetType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionFont? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyle? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActive? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimation? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveFont? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveFontTextDecoration? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveStroke? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveShadow? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimationStyle? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimationDirection? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToImageAssetType? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAssetType? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAssetAspectRatio? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAssetType? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAssetEffect? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAssetType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAssetPosition? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Html5AssetType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetStyle? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetSize? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetPosition? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SvgAssetType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransitionIn? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransitionOut? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<string, global::System.Collections.Generic.IList<string>>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RotateTransformation? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SkewTransformation? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FlipTransformation? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignmentHorizontal? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignmentVertical? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextFontStyle? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyleTextTransform? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyleTextDecoration? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradient? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradientType? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.RichTextGradientStop>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradientStop? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignmentHorizontal? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignmentVertical? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationPreset? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationStyle? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationDirection? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TweenInterpolation? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TweenEasing? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BrightnessFilter? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ContrastFilter? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SaturationFilter? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HueFilter? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GradeFilter? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BlurFilter? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SharpenFilter? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.PixelateFilter? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RgbSplitFilter? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.NegativeFilter? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FilterDiscriminator? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FilterDiscriminatorType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BrightnessFilterType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ContrastFilterType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SaturationFilterType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HueFilterType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GradeFilterType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BlurFilterType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SharpenFilterType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.PixelateFilterType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RgbSplitFilterType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.NegativeFilterType? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputFormat? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputResolution? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputAspectRatio? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Size? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputScaleTo? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputQuality? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Range? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Poster? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Thumbnail? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Destinations>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Destinations? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShotstackDestination? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestination? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.S3Destination? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleCloudStorageDestination? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleDriveDestination? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestination? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestination? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AkamaiNetStorageDestination? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AzureBlobStorageDestination? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DestinationsDiscriminator? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestinationOptions? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.S3DestinationOptions? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleCloudStorageDestinationOptions? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleDriveDestinationOptions? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationOptions? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptions? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsView? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsEmbed? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsComments? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Template? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateRender? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Source? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Outputs? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Rendition>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Rendition? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transcription? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionFormat? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionFit? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResolution? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Speed? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Enhancements? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TranscriptionFormat? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioEnhancement? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancement? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioEnhancementDiscriminator? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancementOptions? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancementOptionsPreset? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transfer? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationAsset? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationAssetType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModel? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelUnavailableReason? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationRequest? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationQuote? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelListResponse? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.GenerationModel>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationResponseStatus? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationErrorResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponseError? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponseErrorName? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedResponse? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedResponseData? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponseData? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponseDataStatus? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateResponseData? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateDataResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateDataResponseData? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponseData? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.TemplateListResponseItem>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponseItem? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ProbeResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseData? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetRenderResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.AssetResponseData>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseAttributes? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseAttributesStatus? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponse? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseData? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseAttributes? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseAttributesStatus? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedSourceResponse? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedSourceResponseData? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceListResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.SourceResponseData>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseData? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseAttributes? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseAttributesStatus? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputsResponse? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.RenditionResponseAttributes>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResponseAttributes? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResponseAttributesStatus? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponse? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponseData? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponseAttributes? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.IngestErrorResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.IngestErrorResponseData>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.IngestErrorResponseData? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAnimationPreset? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionFontStyle? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyleTextTransform? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyleTextDecoration? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestinationOptions? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestinationOptionsPrivacyLevel? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AkamaiNetStorageDestinationOptions? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AzureBlobStorageDestinationOptions? Type278 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.MergeField>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Font>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Track>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Clip>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<float?, global::System.Collections.Generic.List<global::Shotstack.Tween>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Tween>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Filter>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.List<global::Shotstack.Tween>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<string, global::System.Collections.Generic.List<string>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.RichTextGradientStop>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Destinations>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Rendition>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.GenerationModel>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.TemplateListResponseItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.AssetResponseData>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.SourceResponseData>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.RenditionResponseAttributes>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.IngestErrorResponseData>? ListType19 { get; set; }
    }
}