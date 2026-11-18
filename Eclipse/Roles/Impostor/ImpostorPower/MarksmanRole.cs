using Il2CppInterop.Runtime.Attributes;
using MiraAPI.GameOptions;
using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
using Eclipse.Assets;
using Eclipse.Options.Roles.Impostor;
using TownOfUs.Assets;
using TownOfUs.Extensions;
using TownOfUs.Modules.Wiki;
using TownOfUs.Roles;
using TownOfUs.Utilities;
using UnityEngine;

namespace Eclipse.Roles.Impostor.ImpostorPower;

/// <summary>
/// 
/// </summary>
public sealed class MarksmanRole(IntPtr cppPtr)
    : ImpostorRole(cppPtr), ITownOfUsRole, IWikiDiscoverable, IDoomable
{
    public DoomableType DoomHintType => DoomableType.Hunter;
    public string IdPrefix => "Eclipse.Role";
    public string IdPart => "Marksman";
    
    public string GetAdvancedDescription()
    {
        return
            MiraLocaleManager.Get($"{IdPrefix}.{IdPart}.WikiDescription") +
            MiscUtils.AppendOptionsText(GetType());
    }
    
    [HideFromIl2Cpp]
    public List<CustomButtonWikiDescription> Abilities
    {
        get
        {
            return new List<CustomButtonWikiDescription>
            {
                new(MiraLocaleManager.Get($"{IdPrefix}.{IdPart}.Reload", "Reload"),
                    MiraLocaleManager.Get($"{IdPrefix}.{IdPart}.Reload.WikiDescription"),
                    EclipseNeutAssets.SentinelVentSprite),
                
                new(MiraLocaleManager.Get($"{IdPrefix}.{IdPart}.Shoot", "Shoot"),
                    MiraLocaleManager.Get($"{IdPrefix}.{IdPart}.Shoot.WikiDescription"),
                    EclipseNeutAssets.SentinelVentSprite),
                
            };
        }
    }
    
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Custom;
    public RoleAlignment RoleAlignment => RoleAlignment.ImpostorPower;

    /// <summary>
    /// 
    /// </summary>
    public CustomRoleConfiguration Configuration => new(this)
    {
        CanUseVent = OptionGroupSingleton<MarksmanOptions>.Instance.CanVent,
        IntroSound = TouAudio.GlitchSound,
        IconTmp = TmpSpriteUtils.CreateSpriteAsset(EclipseRoleIcons.Marksman.LoadAsset(), "Eclipse.Role.Neutral.Marksman", 1.45f),
        Icon = EclipseRoleIcons.Marksman,
        MaxRoleCount = 2,
    };
    
    public bool HasImpostorVision => OptionGroupSingleton<MarksmanOptions>.Instance.ImpostorVision;
    
    
}
