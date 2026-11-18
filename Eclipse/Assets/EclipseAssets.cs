using MiraAPI.Utilities.Assets;
using Reactor.Utilities;
using UnityEngine;

namespace Eclipse.Assets;

public static class EclipseAssets
{
    private const string ShortPath = "Eclipse.Resources";
    public static readonly AssetBundle EcBundle = AssetBundleManager.Load("eclipse-assets");
    public static LoadableAsset<Sprite> Banner { get; } = new LoadableResourceAsset($"{ShortPath}.ExampleBanner.png");
}
