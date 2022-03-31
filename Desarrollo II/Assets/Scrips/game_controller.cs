using UnityEngine;
using UnityEngine.SceneManagement;

public class game_controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            closeAplication();
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void closeAplication()
    {

        Application.Quit();

    }

}
