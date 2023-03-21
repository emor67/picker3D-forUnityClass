using System;
using System.Collections.Generic;

namespace Data.Valueobjects
{
    [Serializable]
    public struct LevelData
    {
        public List<PoolData> Pools;

        public LevelData(List<PoolData> pool)
        {
            Pools = pool;
        }
    }
}