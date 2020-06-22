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
        if (!gameHasEnded) 
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            //restart game
        }        
    }

    void Restart() 
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
