using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**1) menu
 * 2) in game 
 * 3) game over
 * 4) pause
 * 
 **/

public enum GameState
{
    Menu,
    InGame,
    GameOver,
    Resume
}

public class GameManager : MonoBehaviour
{
    public GameState currentGameState = GameState.Menu;
    private static GameManager sharedInstance;

    private void Awake()
    {
        sharedInstance = this;
    }

    public static GameManager GetInstance()
    {
        return sharedInstance;
    }
    // Starts our Game
    public void StartGame()
    {
        PlayerController.GetInstance().StartGame();
        ChangeGameState(GameState.InGame);
    }

    private void Start()
    {
        //StartGame();
        currentGameState = GameState.Menu;
    }
    // When Player dies

    private void Update()
    {
        if (currentGameState != GameState.InGame && Input.GetButtonDown("s"))
        {
            ChangeGameState(GameState.InGame);
            StartGame();
        }
    }

    public void GameOver()
    {
        ChangeGameState(GameState.GameOver);
    }

    public void BackToMainMenu()
    {
        ChangeGameState(GameState.Menu);
    }

    void ChangeGameState(GameState newGameState)
    {
        if(newGameState == GameState.Menu)
        {

        }
        else if(newGameState == GameState.InGame)
        {

        }
        else if(newGameState == GameState.GameOver)
        {
            currentGameState = GameState.Menu;
        }
        currentGameState = newGameState;
    }
}
