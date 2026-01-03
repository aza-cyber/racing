using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    bool gameHasEnded=false;
public float restartDelay=10f;
    public static Manager instance;

void Awake()
{
    if (instance == null)
    {
        instance = this;
        // Optional: DontDestroyOnLoad(gameObject);
    }
    else
    {
        Destroy(gameObject);
    }
}

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
          gameHasEnded=true;
          Debug.Log("GAME IS OVER")  ;
        Invoke("Restart",restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
