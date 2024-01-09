using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    private float restartGameDelay = 1f;

    public GameObject levelCompletedUI;

    public void EndGame() {

        if (gameHasEnded == false) {
            gameHasEnded = true;

            Invoke("RestartGame", restartGameDelay);
        }
    }

    private void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        levelCompletedUI.SetActive(true);
    }
}
