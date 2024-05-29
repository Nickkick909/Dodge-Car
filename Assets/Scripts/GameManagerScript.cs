using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

    public float restartDelay = 1f;
    bool gameIsOver = false;
    public void EndGame()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            //Debug.Log("Game over"); //for testing purposes
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
