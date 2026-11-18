using Eclipse.Assets;
using MiraAPI.GameOptions;
using MiraAPI.Utilities;
using TownOfUs.Options;

namespace Eclipse.Options;

public sealed class UniversalModifierOptions : AbstractOptionGroup
{
    public override string GroupName => MiraLocaleManager.Get("Eclipse.Options.UniversalModifiers");
    public override Func<bool> GroupVisible => () => RoleOptions.IsClassicRoleAssignment;
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;
    public override uint GroupPriority => 1;
    
    public AmountChanceOption ClumsyAmount { get; } = new(
        MiraLocaleManager.Get("Eclipse.Options.UniversalModifiers.Clumsy.Amount"), 1f, 0f, 5f, 1f,
        color: EclipseColors.Clumsy, asset: EclipseModifierIcons.Clumsy,
        assetName: "Eclipse.Modifier.Universal.Clumsy", assetScale: 1.45f)
    {
        ChangedEvent = _clumsyNotif,
    };

    public AmountChanceOption ClumsyChance { get; } =
        new(MiraLocaleManager.Get("Eclipse.Options.UniversalModifiers.Clumsy.Chance"), 50f, 0, 100f, 10f, "#", "#", MiraNumberSuffixes.Percent,
            color: EclipseColors.Clumsy, asset: EclipseModifierIcons.Clumsy,
            assetName: "Eclipse.Modifier.Universal.Clumsy", assetScale: 1.45f)
        {
            ChangedEvent = _clumsyNotif,
            Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.ClumsyAmount.Value > 0
        };
    
    
    
    // notifs
    
    private static Action<float> _clumsyNotif = x =>
    {
        var optAmount = OptionGroupSingleton<UniversalModifierOptions>.Instance.ClumsyAmount;
        var opt = OptionGroupSingleton<UniversalModifierOptions>.Instance.ClumsyChance;
        if (!opt.ShowNotification)
        {
            return;
        }

        opt.AddSettingsChangeMessage(HudManager.Instance.Notifier,
            opt.StringName,
            MiraLocaleManager.Get("Eclipse.Modifier.Clumsy"),
            optAmount.Data.GetValueString(optAmount.Value),
            opt.Data.GetValueString(opt.Value));
    };
}