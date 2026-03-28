#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Shotstack
{
    /// <summary>
    /// An audio enhancement that can be applied to the audio content of a rendition.<br/>
    /// The following providers are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;&lt;a href="#tocs_dolbyenhancement"&gt;DolbyEnhancement&lt;/a&gt;&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public readonly partial struct AudioEnhancement : global::System.IEquatable<AudioEnhancement>
    {
        /// <summary>
        /// Dolby.io audio enhancement provider. Credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/dolby), not in the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Shotstack.DolbyEnhancement? Dolby { get; init; }
#else
        public global::Shotstack.DolbyEnhancement? Dolby { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dolby))]
#endif
        public bool IsDolby => Dolby != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AudioEnhancement(global::Shotstack.DolbyEnhancement value) => new AudioEnhancement((global::Shotstack.DolbyEnhancement?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Shotstack.DolbyEnhancement?(AudioEnhancement @this) => @this.Dolby;

        /// <summary>
        /// 
        /// </summary>
        public AudioEnhancement(global::Shotstack.DolbyEnhancement? value)
        {
            Dolby = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dolby as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dolby?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDolby;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Shotstack.DolbyEnhancement?, TResult>? dolby = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDolby && dolby != null)
            {
                return dolby(Dolby!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Shotstack.DolbyEnhancement?>? dolby = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDolby)
            {
                dolby?.Invoke(Dolby!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dolby,
                typeof(global::Shotstack.DolbyEnhancement),
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
        public bool Equals(AudioEnhancement other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Shotstack.DolbyEnhancement?>.Default.Equals(Dolby, other.Dolby) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AudioEnhancement obj1, AudioEnhancement obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioEnhancement>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AudioEnhancement obj1, AudioEnhancement obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioEnhancement o && Equals(o);
        }
    }
}
