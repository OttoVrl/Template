using System;

public class GameManager : SingletonDontDestroyMono<GameManager>
{
    public GameStates GameState;

    #region Events

    public event Action OnGameReadyToRun;
    public event Action OnGameStarted;
    public event Action OnGamePaused;
    public event Action OnGameWon;
    public event Action OnGameFinised;

    #endregion

    private void Start()
    {
        HandleGameReadyToRun();
    }


    #region State Methods

    public void HandleGameReadyToRun()
    {
        GameState = GameStates.InGameReadyToRun;
        OnGameReadyToRun?.Invoke();
    }
    
    public void HandleGameStarted()
    {
        GameState = GameStates.InGameStarted;
        OnGameStarted?.Invoke();
    }
    public void HandleGamePaused()
    {
        GameState = GameStates.InGamePaused;
        OnGamePaused?.Invoke();
    }
    public void HandleGameWon()
    {
        GameState = GameStates.InGameWon;
        OnGameWon?.Invoke();
    }  
    public void HandleGameFinished()
    {
        GameState = GameStates.InGameFinished;
        OnGameFinised?.Invoke();
    }

    #endregion
}