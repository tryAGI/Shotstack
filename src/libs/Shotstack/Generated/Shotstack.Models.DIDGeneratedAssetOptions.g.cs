#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Generate assets using the third party D-ID provider AI services.<br/>
    /// The following AI generation services are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;&lt;a href="#tocs_didtexttoavataroptions"&gt;DidTextToAvatarOptions&lt;/a&gt;&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public readonly partial struct DIDGeneratedAssetOptions : global::System.IEquatable<DIDGeneratedAssetOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Shotstack.DIDGeneratedAssetOptionsDiscriminatorType? Type { get; }

        /// <summary>
        /// Options for the D-ID text-to-avatar service. Set the text to be converted to an avatar and configure the avatar and background. The output will be generated as an MP4 video file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.DIDTextToAvatarOptions? TextToAvatar { get; init; }
#else
        public global::Shotstack.DIDTextToAvatarOptions? TextToAvatar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToAvatar))]
#endif
        public bool IsTextToAvatar => TextToAvatar != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DIDGeneratedAssetOptions(global::Shotstack.DIDTextToAvatarOptions value) => new DIDGeneratedAssetOptions((global::Shotstack.DIDTextToAvatarOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.DIDTextToAvatarOptions?(DIDGeneratedAssetOptions @this) => @this.TextToAvatar;

        /// <summary>
        /// 
        /// </summary>
        public DIDGeneratedAssetOptions(global::Shotstack.DIDTextToAvatarOptions? value)
        {
            TextToAvatar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DIDGeneratedAssetOptions(
            global::Shotstack.DIDGeneratedAssetOptionsDiscriminatorType? type,
            global::Shotstack.DIDTextToAvatarOptions? textToAvatar
            )
        {
            Type = type;

            TextToAvatar = textToAvatar;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToAvatar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToAvatar?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToAvatar;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Shotstack.DIDTextToAvatarOptions?, TResult>? textToAvatar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToAvatar && textToAvatar != null)
            {
                return textToAvatar(TextToAvatar!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Shotstack.DIDTextToAvatarOptions?>? textToAvatar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToAvatar)
            {
                textToAvatar?.Invoke(TextToAvatar!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToAvatar,
                typeof(global::Shotstack.DIDTextToAvatarOptions),
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
        public bool Equals(DIDGeneratedAssetOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.DIDTextToAvatarOptions?>.Default.Equals(TextToAvatar, other.TextToAvatar) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DIDGeneratedAssetOptions obj1, DIDGeneratedAssetOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DIDGeneratedAssetOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DIDGeneratedAssetOptions obj1, DIDGeneratedAssetOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DIDGeneratedAssetOptions o && Equals(o);
        }
    }
}
