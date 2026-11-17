using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace Eclipse.Assets;

public static class EclipseAssets
{
    private const string ShortPath = "Eclipse.Resources";
    public static LoadableAsset<Sprite> Banner { get; } = new LoadableResourceAsset($"{ShortPath}.ExampleBanner.png");
}
