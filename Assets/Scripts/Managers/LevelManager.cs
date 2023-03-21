using Commands;
using Data.UnityObjects;
using Data.Valueobjects;
using UnityEngine;

namespace Manager
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private Transform levelHolder;
        [SerializeField] private byte totalLevelCount;

        private OnLevelInitializerCommand _onLevelInitializerCommand;
        private OnLevelClearerCommand _onLevelClearerCommand;

        private byte _levelID;
        private LevelData _data;

        private void Awake()
        {
            _data = GetLevelData();

            Init();
        }

        private void Init()
        {
            _onLevelInitializerCommand = new OnLevelInitializerCommand(levelHolder);
            _onLevelClearerCommand = new OnLevelClearerCommand(levelHolder);
        }

        private LevelData GetLevelData()
        {
            return Resources.Load<CD_Level>(path: "Data/CD_Level").Levels[_levelID];
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {

        }
        
        private void UnSubscribeEvents()
        {

        }

        private byte OnActiveLevelCount()
        {
            return (byte)(_levelID % totalLevelCount);
        }

        private void OnInitializeLevel()
        {
            _onLevelInitializerCommand.Execute(_levelID);
        }

        private void OnClearActiveLevel()
        {
            _onLevelClearerCommand.Execute();
        }

        private void OnDisable()
        {
            UnSubscribeEvents();
        }

        private void Start()
        {
            
        }
    }
}
