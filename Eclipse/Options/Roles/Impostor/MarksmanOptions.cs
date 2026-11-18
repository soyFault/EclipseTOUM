using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using Eclipse.Roles.Impostor.ImpostorPower;

namespace Eclipse.Options.Roles.Impostor;

public sealed class MarksmanOptions : AbstractOptionGroup<MarksmanRole>
{
    public override string GroupName => MiraLocaleManager.Get("Eclipse.Role.Marksman", "Marksman");

    [ModdedNumberOption("Eclipse.Option.Marksman.ReloadCd", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ReloadCooldown { get; set; } = 25f;

    [ModdedNumberOption("Eclipse.Option.Marksman.ShootCd", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ShootCooldown { get; set; } = 60f;

    public ModdedNumberOption ZoomRadius { get; set; } = new("Eclipse.Option.Marksman.ZoomRadius", 0.25f, 0.05f, 1f, 0.05f,
        MiraNumberSuffixes.Multiplier, "0.00");

    [ModdedToggleOption("Eclipse.Option.Marksman.ImpostorVision")]
    public bool ImpostorVision { get; set; } = true;

    [ModdedToggleOption("Eclipse.Option.Marksman.CanVent")]
    public bool CanVent { get; set; }
}