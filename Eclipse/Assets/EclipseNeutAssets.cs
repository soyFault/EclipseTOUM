using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace Eclipse.Assets;

public static class EclipseNeutAssets
{
    // THIS FILE SHOULD ONLY HOLD BUTTONS AND ROLE BANNERS, EVERYTHING ELSE BELONGS IN EclipseAssets.cs
    private const string ShortPath = "Eclipse.Resources.NeutButtons";
    public static LoadableAsset<Sprite> SentinelVentSprite { get; } = new LoadableResourceAsset($"{ShortPath}.SentinelVentButton.png");
}