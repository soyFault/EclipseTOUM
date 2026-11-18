using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace Eclipse.Assets;

public static class EclipseModifierIcons
{
    // Universal
  public static LoadableAsset<Sprite> Clumsy { get; } = new LoadableBundleAsset<Sprite>("Clumsy", EclipseAssets.EcBundle);
}