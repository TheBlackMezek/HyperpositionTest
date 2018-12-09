using System;
using Unity.Entities;

[Serializable]
public struct HyperposMarker : IComponentData
{
}

public class HyperposMarkerComponent : ComponentDataWrapper<HyperposMarker> { }
