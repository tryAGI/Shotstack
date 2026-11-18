
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
        public global::Shotstack.ShapeAssetType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetShape? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetFill? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetStroke? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetRectangle? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetCircle? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetLine? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.LumaAssetType? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionAssetType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionFont? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionBackground? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionMargin? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAssetType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionFont? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyle? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActive? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimation? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveFont? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveFontTextDecoration? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveStroke? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveShadow? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimationStyle? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimationDirection? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToImageAssetType? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAssetType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAssetAspectRatio? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAssetType? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAssetEffect? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAssetType? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAssetPosition? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Html5AssetType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetStyle? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetSize? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetPosition? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SvgAssetType? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransitionIn? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransitionOut? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RotateTransformation? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SkewTransformation? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FlipTransformation? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignmentHorizontal? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignmentVertical? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextFontStyle? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyleTextTransform? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyleTextDecoration? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradient? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradientType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.RichTextGradientStop>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradientStop? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignmentHorizontal? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignmentVertical? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationPreset? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationStyle? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationDirection? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TweenInterpolation? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TweenEasing? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BrightnessFilter? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ContrastFilter? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SaturationFilter? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HueFilter? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GradeFilter? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BlurFilter? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SharpenFilter? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.PixelateFilter? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RgbSplitFilter? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.NegativeFilter? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FilterDiscriminator? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FilterDiscriminatorType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BrightnessFilterType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ContrastFilterType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SaturationFilterType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HueFilterType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GradeFilterType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BlurFilterType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SharpenFilterType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.PixelateFilterType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RgbSplitFilterType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.NegativeFilterType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputFormat? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputResolution? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputAspectRatio? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Size? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputScaleTo? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputQuality? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Range? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Poster? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Thumbnail? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Destinations>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Destinations? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShotstackDestination? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestination? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.S3Destination? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleCloudStorageDestination? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleDriveDestination? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestination? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestination? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AkamaiNetStorageDestination? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AzureBlobStorageDestination? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DestinationsDiscriminator? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestinationOptions? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.S3DestinationOptions? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleCloudStorageDestinationOptions? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleDriveDestinationOptions? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationOptions? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptions? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsView? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsEmbed? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsComments? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Template? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateRender? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Source? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Outputs? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Rendition>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Rendition? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transcription? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionFormat? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionFit? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResolution? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Speed? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Enhancements? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TranscriptionFormat? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioEnhancement? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancement? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioEnhancementDiscriminator? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancementOptions? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancementOptionsPreset? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transfer? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationAsset? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationAssetType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModel? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelUnavailableReason? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationQuote? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelListResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.GenerationModel>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationResponseStatus? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationErrorResponse? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponseError? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelErrorResponseErrorName? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedResponseData? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponseData? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponseDataStatus? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateResponse? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateResponseData? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateDataResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateDataResponseData? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponseData? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.TemplateListResponseItem>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponseItem? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ProbeResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponse? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseData? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetRenderResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.AssetResponseData>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseAttributes? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseAttributesStatus? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseData? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseAttributes? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseAttributesStatus? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedSourceResponse? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedSourceResponseData? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceListResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.SourceResponseData>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseData? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseAttributes? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseAttributesStatus? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputsResponse? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.RenditionResponseAttributes>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResponseAttributes? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResponseAttributesStatus? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponse? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponseData? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponseAttributes? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.IngestErrorResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.IngestErrorResponseData>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.IngestErrorResponseData? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAnimationPreset? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionFontStyle? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyleTextTransform? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyleTextDecoration? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestinationOptions? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestinationOptionsPrivacyLevel? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AkamaiNetStorageDestinationOptions? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AzureBlobStorageDestinationOptions? Type274 { get; set; }

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
        public global::System.Collections.Generic.List<global::Shotstack.RichTextGradientStop>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Destinations>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Rendition>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.GenerationModel>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.TemplateListResponseItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.AssetResponseData>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.SourceResponseData>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.RenditionResponseAttributes>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.IngestErrorResponseData>? ListType17 { get; set; }
    }
}