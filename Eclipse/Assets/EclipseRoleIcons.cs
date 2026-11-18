using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace Eclipse.Assets;

public static class EclipseRoleIcons
{
    // THIS FILE SHOULD ONLY HOLD ROLE ICONS

    private const string ShortPath = "Eclipse.Resources";

    // Neutrals
    
    // Impostors
    public static LoadableAsset<Sprite> Marksman { get; } = new LoadableResourceAsset($"{ShortPath}.RoleIcons.Sentinel.png", 200);
}