
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
            typeof(global::Shotstack.JsonConverters.EditDiskJsonConverter),

            typeof(global::Shotstack.JsonConverters.EditDiskNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.EditInstanceJsonConverter),

            typeof(global::Shotstack.JsonConverters.EditInstanceNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SoundtrackEffectJsonConverter),

            typeof(global::Shotstack.JsonConverters.SoundtrackEffectNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ClipFitJsonConverter),

            typeof(global::Shotstack.JsonConverters.ClipFitNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ClipPositionJsonConverter),

            typeof(global::Shotstack.JsonConverters.ClipPositionNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ClipEffectJsonConverter),

            typeof(global::Shotstack.JsonConverters.ClipEffectNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ClipFilterJsonConverter),

            typeof(global::Shotstack.JsonConverters.ClipFilterNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.AssetDiscriminatorTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.AssetDiscriminatorTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.VideoAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.VideoAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.VideoAssetVolumeEffectJsonConverter),

            typeof(global::Shotstack.JsonConverters.VideoAssetVolumeEffectNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ImageAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.ImageAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.AudioAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.AudioAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.AudioAssetEffectJsonConverter),

            typeof(global::Shotstack.JsonConverters.AudioAssetEffectNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ShapeAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.ShapeAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ShapeAssetShapeJsonConverter),

            typeof(global::Shotstack.JsonConverters.ShapeAssetShapeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.LumaAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.LumaAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.CaptionAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.CaptionAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionActiveFontTextDecorationJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionActiveFontTextDecorationNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionActiveStrokeJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionActiveStrokeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionActiveShadowJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionActiveShadowNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionAnimationStyleJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionAnimationStyleNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionAnimationDirectionJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionAnimationDirectionNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextToImageAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextToImageAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ImageToVideoAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.ImageToVideoAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.ImageToVideoAssetAspectRatioJsonConverter),

            typeof(global::Shotstack.JsonConverters.ImageToVideoAssetAspectRatioNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextToSpeechAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextToSpeechAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextToSpeechAssetEffectJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextToSpeechAssetEffectNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.HtmlAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.HtmlAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.HtmlAssetPositionJsonConverter),

            typeof(global::Shotstack.JsonConverters.HtmlAssetPositionNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TitleAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.TitleAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TitleAssetStyleJsonConverter),

            typeof(global::Shotstack.JsonConverters.TitleAssetStyleNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TitleAssetSizeJsonConverter),

            typeof(global::Shotstack.JsonConverters.TitleAssetSizeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TitleAssetPositionJsonConverter),

            typeof(global::Shotstack.JsonConverters.TitleAssetPositionNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgAssetTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgAssetTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgShapeDiscriminatorTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgShapeDiscriminatorTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgRectangleShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgRectangleShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgCircleShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgCircleShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgEllipseShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgEllipseShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgLineShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgLineShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgPolygonShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgPolygonShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgStarShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgStarShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgArrowShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgArrowShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgHeartShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgHeartShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgCrossShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgCrossShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgRingShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgRingShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgPathShapeTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgPathShapeTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgFillDiscriminatorTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgFillDiscriminatorTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgSolidFillTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgSolidFillTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgLinearGradientFillTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgLinearGradientFillTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgRadialGradientFillTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgRadialGradientFillTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgStrokeLineCapJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgStrokeLineCapNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgStrokeLineJoinJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgStrokeLineJoinNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TransitionInJsonConverter),

            typeof(global::Shotstack.JsonConverters.TransitionInNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TransitionOutJsonConverter),

            typeof(global::Shotstack.JsonConverters.TransitionOutNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextAlignmentHorizontalJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextAlignmentHorizontalNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextAlignmentVerticalJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextAlignmentVerticalNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextStyleTextTransformJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextStyleTextTransformNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextStyleTextDecorationJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextStyleTextDecorationNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextGradientTypeJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextGradientTypeNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAlignmentHorizontalJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAlignmentHorizontalNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAlignmentVerticalJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAlignmentVerticalNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAnimationPresetJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAnimationPresetNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAnimationStyleJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAnimationStyleNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAnimationDirectionJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichTextAnimationDirectionNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TweenInterpolationJsonConverter),

            typeof(global::Shotstack.JsonConverters.TweenInterpolationNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TweenEasingJsonConverter),

            typeof(global::Shotstack.JsonConverters.TweenEasingNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputFormatJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputFormatNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputResolutionJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputResolutionNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputAspectRatioJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputAspectRatioNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputScaleToJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputScaleToNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputQualityJsonConverter),

            typeof(global::Shotstack.JsonConverters.OutputQualityNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.MuxDestinationOptionsPlaybackPolicyItemJsonConverter),

            typeof(global::Shotstack.JsonConverters.MuxDestinationOptionsPlaybackPolicyItemNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsViewJsonConverter),

            typeof(global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsViewNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsEmbedJsonConverter),

            typeof(global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsEmbedNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsCommentsJsonConverter),

            typeof(global::Shotstack.JsonConverters.VimeoDestinationPrivacyOptionsCommentsNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenditionFormatJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenditionFormatNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenditionFitJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenditionFitNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenditionResolutionJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenditionResolutionNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TranscriptionFormatJsonConverter),

            typeof(global::Shotstack.JsonConverters.TranscriptionFormatNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.DolbyEnhancementOptionsPresetJsonConverter),

            typeof(global::Shotstack.JsonConverters.DolbyEnhancementOptionsPresetNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenderResponseDataStatusJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenderResponseDataStatusNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.AssetResponseAttributesStatusJsonConverter),

            typeof(global::Shotstack.JsonConverters.AssetResponseAttributesStatusNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TransferResponseAttributesStatusJsonConverter),

            typeof(global::Shotstack.JsonConverters.TransferResponseAttributesStatusNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.SourceResponseAttributesStatusJsonConverter),

            typeof(global::Shotstack.JsonConverters.SourceResponseAttributesStatusNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenditionResponseAttributesStatusJsonConverter),

            typeof(global::Shotstack.JsonConverters.RenditionResponseAttributesStatusNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextAnimationPresetJsonConverter),

            typeof(global::Shotstack.JsonConverters.TextAnimationPresetNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionStyleTextTransformJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionStyleTextTransformNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionStyleTextDecorationJsonConverter),

            typeof(global::Shotstack.JsonConverters.RichCaptionStyleTextDecorationNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.TiktokDestinationOptionsPrivacyLevelJsonConverter),

            typeof(global::Shotstack.JsonConverters.TiktokDestinationOptionsPrivacyLevelNullableJsonConverter),

            typeof(global::Shotstack.JsonConverters.AssetJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgShapeJsonConverter),

            typeof(global::Shotstack.JsonConverters.SvgFillJsonConverter),

            typeof(global::Shotstack.JsonConverters.DestinationsJsonConverter),

            typeof(global::Shotstack.JsonConverters.AudioEnhancementJsonConverter),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::Shotstack.RichTextPadding>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::Shotstack.RichTextPadding>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>),

            typeof(global::Shotstack.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Edit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Timeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Output))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.MergeField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.MergeField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.EditDisk), TypeInfoPropertyName = "EditDisk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.EditInstance), TypeInfoPropertyName = "EditInstance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Soundtrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.Font>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Font))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Track))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SoundtrackEffect), TypeInfoPropertyName = "SoundtrackEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.Clip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Clip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Asset), TypeInfoPropertyName = "Asset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OneOf<double?, string>), TypeInfoPropertyName = "OneOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ClipFit), TypeInfoPropertyName = "ClipFit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OneOf<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>), TypeInfoPropertyName = "OneOfSingleIListTween2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.Tween>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Tween))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ClipPosition), TypeInfoPropertyName = "ClipPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Offset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Transition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ClipEffect), TypeInfoPropertyName = "ClipEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ClipFilter), TypeInfoPropertyName = "ClipFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>), TypeInfoPropertyName = "OneOfDoubleIListTween2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Transformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VideoAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ImageAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AudioAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.LumaAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.CaptionAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.HtmlAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TitleAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShapeAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextToImageAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ImageToVideoAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextToSpeechAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AssetDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AssetDiscriminatorType), TypeInfoPropertyName = "AssetDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VideoAssetType), TypeInfoPropertyName = "VideoAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.VideoAssetVolumeEffect), TypeInfoPropertyName = "VideoAssetVolumeEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Crop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ChromaKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ImageAssetType), TypeInfoPropertyName = "ImageAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextAssetType), TypeInfoPropertyName = "TextAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextFont))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextStroke))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextAnimation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAssetType), TypeInfoPropertyName = "RichTextAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextFont))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextStroke))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextShadow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextBorder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OneOf<double?, global::Shotstack.RichTextPadding>), TypeInfoPropertyName = "OneOfDoubleRichTextPadding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextPadding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAnimation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AudioAssetType), TypeInfoPropertyName = "AudioAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AudioAssetEffect), TypeInfoPropertyName = "AudioAssetEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShapeAssetType), TypeInfoPropertyName = "ShapeAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShapeAssetShape), TypeInfoPropertyName = "ShapeAssetShape2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShapeAssetFill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShapeAssetStroke))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShapeAssetRectangle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShapeAssetCircle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ShapeAssetLine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.LumaAssetType), TypeInfoPropertyName = "LumaAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.CaptionAssetType), TypeInfoPropertyName = "CaptionAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.CaptionFont))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.CaptionBackground))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.CaptionMargin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionAssetType), TypeInfoPropertyName = "RichCaptionAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionFont))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionActive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionAnimation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionActiveFont))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionActiveFontTextDecoration), TypeInfoPropertyName = "RichCaptionActiveFontTextDecoration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OneOf<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>), TypeInfoPropertyName = "OneOfRichTextStrokeRichCaptionActiveStroke2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionActiveStroke), TypeInfoPropertyName = "RichCaptionActiveStroke2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OneOf<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>), TypeInfoPropertyName = "OneOfRichTextShadowRichCaptionActiveShadow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionActiveShadow), TypeInfoPropertyName = "RichCaptionActiveShadow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionAnimationStyle), TypeInfoPropertyName = "RichCaptionAnimationStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionAnimationDirection), TypeInfoPropertyName = "RichCaptionAnimationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextToImageAssetType), TypeInfoPropertyName = "TextToImageAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ImageToVideoAssetType), TypeInfoPropertyName = "ImageToVideoAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ImageToVideoAssetAspectRatio), TypeInfoPropertyName = "ImageToVideoAssetAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextToSpeechAssetType), TypeInfoPropertyName = "TextToSpeechAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextToSpeechAssetEffect), TypeInfoPropertyName = "TextToSpeechAssetEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.HtmlAssetType), TypeInfoPropertyName = "HtmlAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.HtmlAssetPosition), TypeInfoPropertyName = "HtmlAssetPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TitleAssetType), TypeInfoPropertyName = "TitleAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TitleAssetStyle), TypeInfoPropertyName = "TitleAssetStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TitleAssetSize), TypeInfoPropertyName = "TitleAssetSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TitleAssetPosition), TypeInfoPropertyName = "TitleAssetPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgAssetType), TypeInfoPropertyName = "SvgAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgShape), TypeInfoPropertyName = "SvgShape2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgRectangleShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgCircleShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgEllipseShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgLineShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgPolygonShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgStarShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgArrowShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgHeartShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgCrossShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgRingShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgPathShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgShapeDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgShapeDiscriminatorType), TypeInfoPropertyName = "SvgShapeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgRectangleShapeType), TypeInfoPropertyName = "SvgRectangleShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgCircleShapeType), TypeInfoPropertyName = "SvgCircleShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgEllipseShapeType), TypeInfoPropertyName = "SvgEllipseShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgLineShapeType), TypeInfoPropertyName = "SvgLineShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgPolygonShapeType), TypeInfoPropertyName = "SvgPolygonShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgStarShapeType), TypeInfoPropertyName = "SvgStarShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgArrowShapeType), TypeInfoPropertyName = "SvgArrowShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgHeartShapeType), TypeInfoPropertyName = "SvgHeartShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgCrossShapeType), TypeInfoPropertyName = "SvgCrossShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgRingShapeType), TypeInfoPropertyName = "SvgRingShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgPathShapeType), TypeInfoPropertyName = "SvgPathShapeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgFill), TypeInfoPropertyName = "SvgFill2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgSolidFill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgLinearGradientFill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgRadialGradientFill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgFillDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgFillDiscriminatorType), TypeInfoPropertyName = "SvgFillDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgSolidFillType), TypeInfoPropertyName = "SvgSolidFillType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgLinearGradientFillType), TypeInfoPropertyName = "SvgLinearGradientFillType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.SvgGradientStop>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgGradientStop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgRadialGradientFillType), TypeInfoPropertyName = "SvgRadialGradientFillType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgStroke))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgStrokeLineCap), TypeInfoPropertyName = "SvgStrokeLineCap2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgStrokeLineJoin), TypeInfoPropertyName = "SvgStrokeLineJoin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgShadow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SvgTransform))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TransitionIn), TypeInfoPropertyName = "TransitionIn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TransitionOut), TypeInfoPropertyName = "TransitionOut2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RotateTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SkewTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.FlipTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextAlignmentHorizontal), TypeInfoPropertyName = "TextAlignmentHorizontal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextAlignmentVertical), TypeInfoPropertyName = "TextAlignmentVertical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextStyleTextTransform), TypeInfoPropertyName = "RichTextStyleTextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextStyleTextDecoration), TypeInfoPropertyName = "RichTextStyleTextDecoration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextGradient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextGradientType), TypeInfoPropertyName = "RichTextGradientType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.RichTextGradientStop>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextGradientStop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAlignmentHorizontal), TypeInfoPropertyName = "RichTextAlignmentHorizontal2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAlignmentVertical), TypeInfoPropertyName = "RichTextAlignmentVertical2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAnimationPreset), TypeInfoPropertyName = "RichTextAnimationPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAnimationStyle), TypeInfoPropertyName = "RichTextAnimationStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichTextAnimationDirection), TypeInfoPropertyName = "RichTextAnimationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TweenInterpolation), TypeInfoPropertyName = "TweenInterpolation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TweenEasing), TypeInfoPropertyName = "TweenEasing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OutputResolution), TypeInfoPropertyName = "OutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OutputAspectRatio), TypeInfoPropertyName = "OutputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Size))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OutputScaleTo), TypeInfoPropertyName = "OutputScaleTo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OutputQuality), TypeInfoPropertyName = "OutputQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Range))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Poster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Thumbnail))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TemplateRender))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Outputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.Rendition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Rendition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Transcription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RenditionFormat), TypeInfoPropertyName = "RenditionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RenditionFit), TypeInfoPropertyName = "RenditionFit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RenditionResolution), TypeInfoPropertyName = "RenditionResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Speed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Enhancements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TranscriptionFormat), TypeInfoPropertyName = "TranscriptionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AudioEnhancement), TypeInfoPropertyName = "AudioEnhancement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.DolbyEnhancement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AudioEnhancementDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.DolbyEnhancementOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.DolbyEnhancementOptionsPreset), TypeInfoPropertyName = "DolbyEnhancementOptionsPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.Transfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.QueuedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.QueuedResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RenderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RenderResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RenderResponseDataStatus), TypeInfoPropertyName = "RenderResponseDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TemplateResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TemplateDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TemplateDataResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TemplateListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TemplateListResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.TemplateListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TemplateListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.ProbeResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.QueuedSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.QueuedSourceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SourceListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.SourceResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SourceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SourceResponseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.SourceResponseAttributesStatus), TypeInfoPropertyName = "SourceResponseAttributesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OutputsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.RenditionResponseAttributes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RenditionResponseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RenditionResponseAttributesStatus), TypeInfoPropertyName = "RenditionResponseAttributesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.UploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.UploadResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.UploadResponseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.IngestErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Shotstack.IngestErrorResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.IngestErrorResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TextAnimationPreset), TypeInfoPropertyName = "TextAnimationPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionStyleTextTransform), TypeInfoPropertyName = "RichCaptionStyleTextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.RichCaptionStyleTextDecoration), TypeInfoPropertyName = "RichCaptionStyleTextDecoration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TiktokDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.TiktokDestinationOptionsPrivacyLevel), TypeInfoPropertyName = "TiktokDestinationOptionsPrivacyLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AkamaiNetStorageDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.AzureBlobStorageDestinationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.MergeField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.Font>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.Clip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OneOf<float?, global::System.Collections.Generic.List<global::Shotstack.Tween>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.Tween>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Shotstack.OneOf<double?, global::System.Collections.Generic.List<global::Shotstack.Tween>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.SvgGradientStop>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.RichTextGradientStop>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.Destinations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.MuxDestinationOptionsPlaybackPolicyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.Rendition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.TemplateListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.AssetResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.SourceResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.RenditionResponseAttributes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Shotstack.IngestErrorResponseData>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}