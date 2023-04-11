using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;

namespace NSprites
{
    [GhostComponent()]
    public struct WorldPosition2D : IComponentData
    {
        [GhostField] public float2 value;
    }
}
