using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace Eclipse.Assets;

public static class EclipseImpAssets
{
    // THIS FILE SHOULD ONLY HOLD BUTTONS AND ROLE BANNERS, EVERYTHING ELSE BELONGS IN EclipseAssets.cs
    private const string ShortPath = "Eclipse.Resources.ImpButtons";
    // Marksman Assets
    public static LoadableAsset<Sprite> MarksmanShootSprite { get; } = new LoadableResourceAsset($"{ShortPath}.SentinelVentButton.png");
    public static LoadableAsset<Sprite> MarksmanReloadSprite { get; } = new LoadableResourceAsset($"{ShortPath}.SentinelExplodeButton.png");
}