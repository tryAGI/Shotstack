
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// How muted words sound. `silence` drops the volume to zero over each word; `bleep` does the same and plays a 1 kHz tone over it.<br/>
    /// Default Value: silence<br/>
    /// Example: bleep
    /// </summary>
    public enum MuteSound
    {
        /// <summary>
        ///
        /// </summary>
        Bleep,
        /// <summary>
        ///
        /// </summary>
        Silence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MuteSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MuteSound value)
        {
            return value switch
            {
                MuteSound.Bleep => "bleep",
                MuteSound.Silence => "silence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MuteSound? ToEnum(string value)
        {
            return value switch
            {
                "bleep" => MuteSound.Bleep,
                "silence" => MuteSound.Silence,
                _ => null,
            };
        }
    }
}