
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
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transformation? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VideoAsset? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageAsset? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAsset? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAsset? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioAsset? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.LumaAsset? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionAsset? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAsset? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAsset? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Html5Asset? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAsset? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAsset? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SvgAsset? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToImageAsset? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAsset? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAsset? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetDiscriminator? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetDiscriminatorType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VideoAssetType? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VideoAssetVolumeEffect? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Crop? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ChromaKey? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageAssetType? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAssetType? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextFont? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextBackground? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignment? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextStroke? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAnimation? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAssetType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextFont? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyle? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStroke? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextShadow? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextBackground? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextBorder? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<double?, global::Shotstack.RichTextPadding>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextPadding? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignment? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimation? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioAssetType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioAssetEffect? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetShape? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetFill? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetStroke? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetRectangle? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetCircle? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShapeAssetLine? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.LumaAssetType? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionAssetType? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionFont? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionBackground? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.CaptionMargin? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAssetType? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionFont? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyle? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActive? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimation? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveFont? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveFontTextDecoration? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveStroke? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionActiveShadow? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimationStyle? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionAnimationDirection? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToImageAssetType? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAssetType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ImageToVideoAssetAspectRatio? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAssetType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextToSpeechAssetEffect? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAssetType? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HtmlAssetPosition? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Html5AssetType? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetStyle? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetSize? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TitleAssetPosition? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SvgAssetType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransitionIn? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransitionOut? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RotateTransformation? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SkewTransformation? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FlipTransformation? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignmentHorizontal? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAlignmentVertical? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextFontStyle? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyleTextTransform? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextStyleTextDecoration? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradient? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradientType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.RichTextGradientStop>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextGradientStop? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignmentHorizontal? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAlignmentVertical? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationPreset? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationStyle? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichTextAnimationDirection? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TweenInterpolation? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TweenEasing? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputFormat? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputResolution? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputAspectRatio? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Size? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputScaleTo? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputQuality? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Range? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Poster? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Thumbnail? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Destinations>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Destinations? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ShotstackDestination? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestination? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.S3Destination? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleCloudStorageDestination? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleDriveDestination? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestination? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestination? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AkamaiNetStorageDestination? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AzureBlobStorageDestination? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DestinationsDiscriminator? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestinationOptions? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.S3DestinationOptions? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleCloudStorageDestinationOptions? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GoogleDriveDestinationOptions? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationOptions? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptions? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsView? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsEmbed? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.VimeoDestinationPrivacyOptionsComments? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Template? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateRender? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Source? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Outputs? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.Rendition>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Rendition? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transcription? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionFormat? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionFit? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResolution? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Speed? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Enhancements? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TranscriptionFormat? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioEnhancement? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancement? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AudioEnhancementDiscriminator? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancementOptions? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.DolbyEnhancementOptionsPreset? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.Transfer? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedResponseData? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponse? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponseData? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenderResponseDataStatus? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateResponseData? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateDataResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateDataResponseData? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponse? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponseData? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.TemplateListResponseItem>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TemplateListResponseItem? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ProbeResponse? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseData? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetRenderResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.AssetResponseData>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseAttributes? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AssetResponseAttributesStatus? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponse? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseData? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseAttributes? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TransferResponseAttributesStatus? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedSourceResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.QueuedSourceResponseData? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceListResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.SourceResponseData>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseData? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponse? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseAttributes? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SourceResponseAttributesStatus? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OutputsResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.RenditionResponseAttributes>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResponseAttributes? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RenditionResponseAttributesStatus? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponseData? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.UploadResponseAttributes? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.IngestErrorResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.IngestErrorResponseData>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.IngestErrorResponseData? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TextAnimationPreset? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionFontStyle? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyleTextTransform? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RichCaptionStyleTextDecoration? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestinationOptions? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.TiktokDestinationOptionsPrivacyLevel? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AkamaiNetStorageDestinationOptions? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.AzureBlobStorageDestinationOptions? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationResponseStatus? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelPricing? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<double?, object>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelPricingTieredBy? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelPricingQuantity? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelPricingQuantityMeasure? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelPricingQuantityRound? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModel? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GenerationModelListResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Shotstack.GenerationModel>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.PostGenerateRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.OneOf<global::Shotstack.ImageAsset, global::Shotstack.VideoAsset, global::Shotstack.AudioAsset>? Type249 { get; set; }

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
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.List<global::Shotstack.Tween>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.RichTextGradientStop>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Destinations>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.Rendition>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.TemplateListResponseItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.AssetResponseData>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.SourceResponseData>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.RenditionResponseAttributes>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.IngestErrorResponseData>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Shotstack.GenerationModel>? ListType16 { get; set; }
    }
}