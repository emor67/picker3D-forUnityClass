using UnityEngine;

namespace Commands
{
    public class OnLevelInitializerCommand : MonoBehaviour
    {
        private Transform _levelHolder;

        internal OnLevelInitializerCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }

        internal void Execute(int _levelID)
        {
            Object.Instantiate(Resources.Load<GameObject>(path: $"Prefabs/LevelPrefabs/level {_levelID}"), _levelHolder);
        }
    }
}
