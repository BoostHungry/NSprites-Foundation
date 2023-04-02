using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;

namespace NSprites
{
    public struct WorldPosition2D : IComponentData
    {
        public float2 value;
    }
}
