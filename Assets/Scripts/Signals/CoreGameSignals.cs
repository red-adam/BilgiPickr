using UnityEngine;
using UnityEngine.Events;
using Enums;

public class CoreGameSignals : MonoBehaviour
{
    //this is a messenger class
    #region Singleton
    
        public static CoreGameSignals Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Debug.LogWarning(Instance.GetInstanceID().ToString());
                Destroy(gameObject);
                return;
            }
            Instance = this;

    }

    #endregion

    public UnityAction<GameStates> onChangeGameState = delegate { }; // look up delegate function
    public UnityAction<int> onLevelInitialize = delegate { };
    public UnityAction onClearActiveLevel = delegate { };
    public UnityAction onLevelSuccessful = delegate { };
    public UnityAction onLevelFailed = delegate { };
    public UnityAction onNextLevel = delegate { };
    public UnityAction onRestartLevel = delegate { };
    public UnityAction onPlay = delegate { };
    public UnityAction onReset = delegate { };
}
