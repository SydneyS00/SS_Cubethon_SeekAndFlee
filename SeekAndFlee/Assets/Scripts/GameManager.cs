using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }



    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("RestartGame", restartDelay);
            //Restarting the game
        }
        

    }

    void RestartGame()
    {
        //Reloads the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
