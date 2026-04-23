using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.ProcessCaptureModes;

/// <summary>
/// Defines how process output should be captured.
/// </summary>
[EnumValue<string>]
public partial class ProcessCaptureMode
{
    public static readonly ProcessCaptureMode Inherit = new(nameof(Inherit));
}
