using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.ProcessCaptureModes;

/// <summary>
/// Identifies how a process runner should handle child-process output.
/// </summary>
[EnumValue<string>]
public partial class ProcessCaptureMode
{
    /// <summary>
    /// Leaves output handling with the parent or invoking environment.
    /// </summary>
    public static readonly ProcessCaptureMode Inherit = new(nameof(Inherit));
}
