
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
        public global::Shotstack.Crop? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ChromaKey? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageAssetType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAssetType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextFont? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextBackground? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignment? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextStroke? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAnimation? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAssetType? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextFont? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyle? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStroke? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextShadow? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextBackground? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextBorder? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<double?, global::Shotstack.RichTextPadding>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextPadding? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignment? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimation? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioAssetType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioAssetEffect? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Duck? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetShape? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetFill? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetStroke? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetRectangle? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetCircle? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetLine? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.LumaAssetType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionAssetType? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionFont? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionBackground? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionMargin? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAssetType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionFont? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyle? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActive? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimation? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveFont? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveFontTextDecoration? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveStroke? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveShadow? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimationStyle? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimationDirection? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToImageAssetType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAssetType? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAssetAspectRatio? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAssetType? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAssetEffect? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAssetType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAssetPosition? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Html5AssetType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetStyle? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetSize? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetPosition? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SvgAssetType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransitionIn? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransitionOut? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<string, global::System.Collections.Generic.IList<string>>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RotateTransformation? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SkewTransformation? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FlipTransformation? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignmentHorizontal? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignmentVertical? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextFontStyle? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyleTextTransform? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyleTextDecoration? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradient? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradientType? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.RichTextGradientStop>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradientStop? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignmentHorizontal? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignmentVertical? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationPreset? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationStyle? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationDirection? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TweenInterpolation? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TweenEasing? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BrightnessFilter? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ContrastFilter? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SaturationFilter? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HueFilter? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GradeFilter? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BlurFilter? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SharpenFilter? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.PixelateFilter? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RgbSplitFilter? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.NegativeFilter? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FilterDiscriminator? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FilterDiscriminatorType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BrightnessFilterType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ContrastFilterType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SaturationFilterType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HueFilterType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GradeFilterType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BlurFilterType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SharpenFilterType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.PixelateFilterType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RgbSplitFilterType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.NegativeFilterType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputFormat? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputResolution? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputAspectRatio? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Size? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputScaleTo? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputQuality? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Range? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Poster? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Thumbnail? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Destinations>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Destinations? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShotstackDestination? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestination? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.S3Destination? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleCloudStorageDestination? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleDriveDestination? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestination? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestination? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AkamaiNetStorageDestination? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AzureBlobStorageDestination? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DestinationsDiscriminator? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestinationOptions? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.S3DestinationOptions? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleCloudStorageDestinationOptions? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleDriveDestinationOptions? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationOptions? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptions? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsView? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsEmbed? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsComments? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Template? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateRender? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Source? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Outputs? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Rendition>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Rendition? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transcription? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionFormat? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionFit? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResolution? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Speed? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Enhancements? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TranscriptionFormat? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioEnhancement? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancement? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioEnhancementDiscriminator? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancementOptions? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancementOptionsPreset? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transfer? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationAsset? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationAssetType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModel? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelUnavailableReason? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationQuote? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelListResponse? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.GenerationModel>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationResponseStatus? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationErrorResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponseError? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponseErrorName? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedResponseData? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponse? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponseData? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponseDataStatus? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateResponse? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateResponseData? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateDataResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateDataResponseData? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponseData? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.TemplateListResponseItem>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponseItem? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ProbeResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseData? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetRenderResponse? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.AssetResponseData>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseAttributes? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseAttributesStatus? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseData? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseAttributes? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseAttributesStatus? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedSourceResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedSourceResponseData? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceListResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.SourceResponseData>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseData? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponse? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseAttributes? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseAttributesStatus? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputsResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.RenditionResponseAttributes>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResponseAttributes? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResponseAttributesStatus? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponseData? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponseAttributes? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.IngestErrorResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.IngestErrorResponseData>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.IngestErrorResponseData? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAnimationPreset? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionFontStyle? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyleTextTransform? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyleTextDecoration? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestinationOptions? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestinationOptionsPrivacyLevel? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AkamaiNetStorageDestinationOptions? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AzureBlobStorageDestinationOptions? Type277 { get; set; }

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