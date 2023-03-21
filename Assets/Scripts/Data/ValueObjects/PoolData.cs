using System;

namespace Data.Valueobjects
{
    [Serializable]
    public struct PoolData
    {
        public byte RequiredObjectCount;

        public PoolData(byte requiredObjectCount)
        {
            RequiredObjectCount = requiredObjectCount;
        }
    }
}
