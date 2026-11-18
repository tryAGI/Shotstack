#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Shotstack
{
    /// <summary>
    /// A filter that adjusts the look of a Clip. Choose from one of the available filter types below. Tween values outside a field's range are limited to that range.
    /// </summary>
    public readonly partial struct Filter : global::System.IEquatable<Filter>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.FilterDiscriminatorType? Type { get; }

        /// <summary>
        /// Lightens or darkens the clip.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.BrightnessFilter? Brightness { get; init; }
#else
        public global::Shotstack.BrightnessFilter? Brightness { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Brightness))]
#endif
        public bool IsBrightness => Brightness != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrightness(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.BrightnessFilter? value)
        {
            value = Brightness;
            return IsBrightness;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BrightnessFilter PickBrightness() => Brightness is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Brightness' but the value was {ToString()}.");

        /// <summary>
        /// Increases or decreases the difference between the light and dark areas of the clip.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.ContrastFilter? Contrast { get; init; }
#else
        public global::Shotstack.ContrastFilter? Contrast { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Contrast))]
#endif
        public bool IsContrast => Contrast != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContrast(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.ContrastFilter? value)
        {
            value = Contrast;
            return IsContrast;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.ContrastFilter PickContrast() => Contrast is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Contrast' but the value was {ToString()}.");

        /// <summary>
        /// Increases or decreases the intensity of the colors in the clip.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.SaturationFilter? Saturation { get; init; }
#else
        public global::Shotstack.SaturationFilter? Saturation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Saturation))]
#endif
        public bool IsSaturation => Saturation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSaturation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.SaturationFilter? value)
        {
            value = Saturation;
            return IsSaturation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SaturationFilter PickSaturation() => Saturation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Saturation' but the value was {ToString()}.");

        /// <summary>
        /// Rotates the hues of the clip around the color wheel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.HueFilter? Hue { get; init; }
#else
        public global::Shotstack.HueFilter? Hue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hue))]
#endif
        public bool IsHue => Hue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.HueFilter? value)
        {
            value = Hue;
            return IsHue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.HueFilter PickHue() => Hue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hue' but the value was {ToString()}.");

        /// <summary>
        /// Applies several grading adjustments at once: exposure, temperature, tint, highlights, shadows and vibrance. Every property is optional and an omitted property leaves the clip unchanged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.GradeFilter? Grade { get; init; }
#else
        public global::Shotstack.GradeFilter? Grade { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Grade))]
#endif
        public bool IsGrade => Grade != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGrade(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.GradeFilter? value)
        {
            value = Grade;
            return IsGrade;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.GradeFilter PickGrade() => Grade is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grade' but the value was {ToString()}.");

        /// <summary>
        /// Blurs the clip. Set `value` to blur both axes equally, or set `x` and `y` to blur each axis separately.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.BlurFilter? Blur { get; init; }
#else
        public global::Shotstack.BlurFilter? Blur { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Blur))]
#endif
        public bool IsBlur => Blur != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlur(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.BlurFilter? value)
        {
            value = Blur;
            return IsBlur;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.BlurFilter PickBlur() => Blur is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Blur' but the value was {ToString()}.");

        /// <summary>
        /// Sharpens the clip.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.SharpenFilter? Sharpen { get; init; }
#else
        public global::Shotstack.SharpenFilter? Sharpen { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharpen))]
#endif
        public bool IsSharpen => Sharpen != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharpen(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.SharpenFilter? value)
        {
            value = Sharpen;
            return IsSharpen;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.SharpenFilter PickSharpen() => Sharpen is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharpen' but the value was {ToString()}.");

        /// <summary>
        /// Turns the clip into blocky pixels.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.PixelateFilter? Pixelate { get; init; }
#else
        public global::Shotstack.PixelateFilter? Pixelate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pixelate))]
#endif
        public bool IsPixelate => Pixelate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPixelate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.PixelateFilter? value)
        {
            value = Pixelate;
            return IsPixelate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.PixelateFilter PickPixelate() => Pixelate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pixelate' but the value was {ToString()}.");

        /// <summary>
        /// Offsets the red and blue channels in opposite directions to create a color fringing effect. Channels pushed past one edge of the frame reappear at the opposite edge, so small values such as 0.02 work best and 1 or -1 shows no split.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.RgbSplitFilter? RgbSplit { get; init; }
#else
        public global::Shotstack.RgbSplitFilter? RgbSplit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RgbSplit))]
#endif
        public bool IsRgbSplit => RgbSplit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRgbSplit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.RgbSplitFilter? value)
        {
            value = RgbSplit;
            return IsRgbSplit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.RgbSplitFilter PickRgbSplit() => RgbSplit is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RgbSplit' but the value was {ToString()}.");

        /// <summary>
        /// Inverts the clip, turning light areas dark and dark areas light. It has no properties other than `type` and cannot be animated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.NegativeFilter? Negative { get; init; }
#else
        public global::Shotstack.NegativeFilter? Negative { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Negative))]
#endif
        public bool IsNegative => Negative != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNegative(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Shotstack.NegativeFilter? value)
        {
            value = Negative;
            return IsNegative;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Shotstack.NegativeFilter PickNegative() => Negative is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Negative' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.BrightnessFilter value) => new Filter((global::Shotstack.BrightnessFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.BrightnessFilter?(Filter @this) => @this.Brightness;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.BrightnessFilter? value)
        {
            Brightness = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromBrightness(global::Shotstack.BrightnessFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.ContrastFilter value) => new Filter((global::Shotstack.ContrastFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.ContrastFilter?(Filter @this) => @this.Contrast;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.ContrastFilter? value)
        {
            Contrast = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromContrast(global::Shotstack.ContrastFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.SaturationFilter value) => new Filter((global::Shotstack.SaturationFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.SaturationFilter?(Filter @this) => @this.Saturation;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.SaturationFilter? value)
        {
            Saturation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromSaturation(global::Shotstack.SaturationFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.HueFilter value) => new Filter((global::Shotstack.HueFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.HueFilter?(Filter @this) => @this.Hue;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.HueFilter? value)
        {
            Hue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromHue(global::Shotstack.HueFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.GradeFilter value) => new Filter((global::Shotstack.GradeFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.GradeFilter?(Filter @this) => @this.Grade;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.GradeFilter? value)
        {
            Grade = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromGrade(global::Shotstack.GradeFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.BlurFilter value) => new Filter((global::Shotstack.BlurFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.BlurFilter?(Filter @this) => @this.Blur;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.BlurFilter? value)
        {
            Blur = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromBlur(global::Shotstack.BlurFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.SharpenFilter value) => new Filter((global::Shotstack.SharpenFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.SharpenFilter?(Filter @this) => @this.Sharpen;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.SharpenFilter? value)
        {
            Sharpen = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromSharpen(global::Shotstack.SharpenFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.PixelateFilter value) => new Filter((global::Shotstack.PixelateFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.PixelateFilter?(Filter @this) => @this.Pixelate;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.PixelateFilter? value)
        {
            Pixelate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromPixelate(global::Shotstack.PixelateFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.RgbSplitFilter value) => new Filter((global::Shotstack.RgbSplitFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.RgbSplitFilter?(Filter @this) => @this.RgbSplit;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.RgbSplitFilter? value)
        {
            RgbSplit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromRgbSplit(global::Shotstack.RgbSplitFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::Shotstack.NegativeFilter value) => new Filter((global::Shotstack.NegativeFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Shotstack.NegativeFilter?(Filter @this) => @this.Negative;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::Shotstack.NegativeFilter? value)
        {
            Negative = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromNegative(global::Shotstack.NegativeFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public Filter(
            global::Shotstack.FilterDiscriminatorType? type,
            global::Shotstack.BrightnessFilter? brightness,
            global::Shotstack.ContrastFilter? contrast,
            global::Shotstack.SaturationFilter? saturation,
            global::Shotstack.HueFilter? hue,
            global::Shotstack.GradeFilter? grade,
            global::Shotstack.BlurFilter? blur,
            global::Shotstack.SharpenFilter? sharpen,
            global::Shotstack.PixelateFilter? pixelate,
            global::Shotstack.RgbSplitFilter? rgbSplit,
            global::Shotstack.NegativeFilter? negative
            )
        {
            Type = type;

            Brightness = brightness;
            Contrast = contrast;
            Saturation = saturation;
            Hue = hue;
            Grade = grade;
            Blur = blur;
            Sharpen = sharpen;
            Pixelate = pixelate;
            RgbSplit = rgbSplit;
            Negative = negative;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Negative as object ??
            RgbSplit as object ??
            Pixelate as object ??
            Sharpen as object ??
            Blur as object ??
            Grade as object ??
            Hue as object ??
            Saturation as object ??
            Contrast as object ??
            Brightness as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Brightness?.ToString() ??
            Contrast?.ToString() ??
            Saturation?.ToString() ??
            Hue?.ToString() ??
            Grade?.ToString() ??
            Blur?.ToString() ??
            Sharpen?.ToString() ??
            Pixelate?.ToString() ??
            RgbSplit?.ToString() ??
            Negative?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBrightness && !IsContrast && !IsSaturation && !IsHue && !IsGrade && !IsBlur && !IsSharpen && !IsPixelate && !IsRgbSplit && !IsNegative || !IsBrightness && IsContrast && !IsSaturation && !IsHue && !IsGrade && !IsBlur && !IsSharpen && !IsPixelate && !IsRgbSplit && !IsNegative || !IsBrightness && !IsContrast && IsSaturation && !IsHue && !IsGrade && !IsBlur && !IsSharpen && !IsPixelate && !IsRgbSplit && !IsNegative || !IsBrightness && !IsContrast && !IsSaturation && IsHue && !IsGrade && !IsBlur && !IsSharpen && !IsPixelate && !IsRgbSplit && !IsNegative || !IsBrightness && !IsContrast && !IsSaturation && !IsHue && IsGrade && !IsBlur && !IsSharpen && !IsPixelate && !IsRgbSplit && !IsNegative || !IsBrightness && !IsContrast && !IsSaturation && !IsHue && !IsGrade && IsBlur && !IsSharpen && !IsPixelate && !IsRgbSplit && !IsNegative || !IsBrightness && !IsContrast && !IsSaturation && !IsHue && !IsGrade && !IsBlur && IsSharpen && !IsPixelate && !IsRgbSplit && !IsNegative || !IsBrightness && !IsContrast && !IsSaturation && !IsHue && !IsGrade && !IsBlur && !IsSharpen && IsPixelate && !IsRgbSplit && !IsNegative || !IsBrightness && !IsContrast && !IsSaturation && !IsHue && !IsGrade && !IsBlur && !IsSharpen && !IsPixelate && IsRgbSplit && !IsNegative || !IsBrightness && !IsContrast && !IsSaturation && !IsHue && !IsGrade && !IsBlur && !IsSharpen && !IsPixelate && !IsRgbSplit && IsNegative;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Shotstack.BrightnessFilter, TResult>? brightness = null,
            global::System.Func<global::Shotstack.ContrastFilter, TResult>? contrast = null,
            global::System.Func<global::Shotstack.SaturationFilter, TResult>? saturation = null,
            global::System.Func<global::Shotstack.HueFilter, TResult>? hue = null,
            global::System.Func<global::Shotstack.GradeFilter, TResult>? grade = null,
            global::System.Func<global::Shotstack.BlurFilter, TResult>? blur = null,
            global::System.Func<global::Shotstack.SharpenFilter, TResult>? sharpen = null,
            global::System.Func<global::Shotstack.PixelateFilter, TResult>? pixelate = null,
            global::System.Func<global::Shotstack.RgbSplitFilter, TResult>? rgbSplit = null,
            global::System.Func<global::Shotstack.NegativeFilter, TResult>? negative = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Brightness is { } __value0 && brightness != null)
            {
                return brightness(__value0);
            }
            else if (Contrast is { } __value1 && contrast != null)
            {
                return contrast(__value1);
            }
            else if (Saturation is { } __value2 && saturation != null)
            {
                return saturation(__value2);
            }
            else if (Hue is { } __value3 && hue != null)
            {
                return hue(__value3);
            }
            else if (Grade is { } __value4 && grade != null)
            {
                return grade(__value4);
            }
            else if (Blur is { } __value5 && blur != null)
            {
                return blur(__value5);
            }
            else if (Sharpen is { } __value6 && sharpen != null)
            {
                return sharpen(__value6);
            }
            else if (Pixelate is { } __value7 && pixelate != null)
            {
                return pixelate(__value7);
            }
            else if (RgbSplit is { } __value8 && rgbSplit != null)
            {
                return rgbSplit(__value8);
            }
            else if (Negative is { } __value9 && negative != null)
            {
                return negative(__value9);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Shotstack.BrightnessFilter>? brightness = null,

            global::System.Action<global::Shotstack.ContrastFilter>? contrast = null,

            global::System.Action<global::Shotstack.SaturationFilter>? saturation = null,

            global::System.Action<global::Shotstack.HueFilter>? hue = null,

            global::System.Action<global::Shotstack.GradeFilter>? grade = null,

            global::System.Action<global::Shotstack.BlurFilter>? blur = null,

            global::System.Action<global::Shotstack.SharpenFilter>? sharpen = null,

            global::System.Action<global::Shotstack.PixelateFilter>? pixelate = null,

            global::System.Action<global::Shotstack.RgbSplitFilter>? rgbSplit = null,

            global::System.Action<global::Shotstack.NegativeFilter>? negative = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Brightness is { } __value0)
            {
                brightness?.Invoke(__value0);
            }
            else if (Contrast is { } __value1)
            {
                contrast?.Invoke(__value1);
            }
            else if (Saturation is { } __value2)
            {
                saturation?.Invoke(__value2);
            }
            else if (Hue is { } __value3)
            {
                hue?.Invoke(__value3);
            }
            else if (Grade is { } __value4)
            {
                grade?.Invoke(__value4);
            }
            else if (Blur is { } __value5)
            {
                blur?.Invoke(__value5);
            }
            else if (Sharpen is { } __value6)
            {
                sharpen?.Invoke(__value6);
            }
            else if (Pixelate is { } __value7)
            {
                pixelate?.Invoke(__value7);
            }
            else if (RgbSplit is { } __value8)
            {
                rgbSplit?.Invoke(__value8);
            }
            else if (Negative is { } __value9)
            {
                negative?.Invoke(__value9);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Shotstack.BrightnessFilter>? brightness = null,
            global::System.Action<global::Shotstack.ContrastFilter>? contrast = null,
            global::System.Action<global::Shotstack.SaturationFilter>? saturation = null,
            global::System.Action<global::Shotstack.HueFilter>? hue = null,
            global::System.Action<global::Shotstack.GradeFilter>? grade = null,
            global::System.Action<global::Shotstack.BlurFilter>? blur = null,
            global::System.Action<global::Shotstack.SharpenFilter>? sharpen = null,
            global::System.Action<global::Shotstack.PixelateFilter>? pixelate = null,
            global::System.Action<global::Shotstack.RgbSplitFilter>? rgbSplit = null,
            global::System.Action<global::Shotstack.NegativeFilter>? negative = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Brightness is { } __value0)
            {
                brightness?.Invoke(__value0);
            }
            else if (Contrast is { } __value1)
            {
                contrast?.Invoke(__value1);
            }
            else if (Saturation is { } __value2)
            {
                saturation?.Invoke(__value2);
            }
            else if (Hue is { } __value3)
            {
                hue?.Invoke(__value3);
            }
            else if (Grade is { } __value4)
            {
                grade?.Invoke(__value4);
            }
            else if (Blur is { } __value5)
            {
                blur?.Invoke(__value5);
            }
            else if (Sharpen is { } __value6)
            {
                sharpen?.Invoke(__value6);
            }
            else if (Pixelate is { } __value7)
            {
                pixelate?.Invoke(__value7);
            }
            else if (RgbSplit is { } __value8)
            {
                rgbSplit?.Invoke(__value8);
            }
            else if (Negative is { } __value9)
            {
                negative?.Invoke(__value9);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Brightness,
                typeof(global::Shotstack.BrightnessFilter),
                Contrast,
                typeof(global::Shotstack.ContrastFilter),
                Saturation,
                typeof(global::Shotstack.SaturationFilter),
                Hue,
                typeof(global::Shotstack.HueFilter),
                Grade,
                typeof(global::Shotstack.GradeFilter),
                Blur,
                typeof(global::Shotstack.BlurFilter),
                Sharpen,
                typeof(global::Shotstack.SharpenFilter),
                Pixelate,
                typeof(global::Shotstack.PixelateFilter),
                RgbSplit,
                typeof(global::Shotstack.RgbSplitFilter),
                Negative,
                typeof(global::Shotstack.NegativeFilter),
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
        public bool Equals(Filter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.BrightnessFilter?>.Default.Equals(Brightness, other.Brightness) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.ContrastFilter?>.Default.Equals(Contrast, other.Contrast) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.SaturationFilter?>.Default.Equals(Saturation, other.Saturation) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.HueFilter?>.Default.Equals(Hue, other.Hue) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.GradeFilter?>.Default.Equals(Grade, other.Grade) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.BlurFilter?>.Default.Equals(Blur, other.Blur) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.SharpenFilter?>.Default.Equals(Sharpen, other.Sharpen) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.PixelateFilter?>.Default.Equals(Pixelate, other.Pixelate) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.RgbSplitFilter?>.Default.Equals(RgbSplit, other.RgbSplit) &&
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.NegativeFilter?>.Default.Equals(Negative, other.Negative)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Filter obj1, Filter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Filter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Filter obj1, Filter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Filter o && Equals(o);
        }
    }
}
