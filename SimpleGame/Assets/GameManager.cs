using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private bool gameHasEnded = false;
    public float resetTimer = 2f;

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Reset", resetTimer);
        }
    }

    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
