using UnityEngine;

namespace Commands
{
    public class OnLevelClearerCommand : MonoBehaviour
    {
        private Transform _levelHolder;

        internal OnLevelClearerCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }

        internal void Execute()
        {
            if (_levelHolder.childCount > 0)
            {
                Object.Destroy(_levelHolder.GetChild(0).gameObject);
            }
        }
    }
}