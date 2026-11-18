using Eclipse.Assets;
using Eclipse.Options;
using MiraAPI.GameOptions;
using MiraAPI.Utilities.Assets;
using TownOfUs.Modifiers;
using TownOfUs.Modifiers.Game;
using TownOfUs.Modules.Wiki;
using TownOfUs.Utilities;
using UnityEngine;

namespace Eclipse.Modifiers.Game.Universal;

public sealed class ClumsyModifier : UniversalGameModifier, IWikiDiscoverable
{
    public override ModifierUiConfiguration Configuration => new(
        EclipseColors.Clumsy,
        TmpSpriteUtils.CreateSpriteAsset(EclipseModifierIcons.Clumsy,
            "Eclipse.Modifier.Universal.Clumsy", 1.45f));
    
    public override string IdPart => "Clumsy";
    public override string ModifierName => MiraLocaleManager.Get($"TownOfUsMira.Modifier.{IdPart}");
    public override LoadableAsset<Sprite>? ModifierIcon => EclipseModifierIcons.Clumsy;
    
    public override ModifierFaction FactionType => ModifierFaction.UniversalPassive;
    public override Color FreeplayFileColor => new Color32(180, 180, 180, 255);
    
    public override string GetDescription()
    {
        return MiraLocaleManager.Get($"Eclipse.Modifier.{IdPart}.TabDescription");
    }

    public string GetAdvancedDescription()
    {
        return MiraLocaleManager.Get($"Eclipse.Modifier.{IdPart}.WikiDescription") + MiscUtils.AppendOptionsText(GetType());
    }
    
    public List<CustomButtonWikiDescription> Abilities { get; } = [];
    
    public override int GetAssignmentChance()
    {
        return OptionGroupSingleton<UniversalModifierOptions>.Instance.ClumsyChance;
    }

    public override int GetAmountPerGame()
    {
        return OptionGroupSingleton<UniversalModifierOptions>.Instance.ClumsyAmount;
    }
    
}