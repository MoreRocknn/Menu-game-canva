using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsInput : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetSceneByBuildIndex(1).isLoaded)
            {
                SceneManager.UnloadSceneAsync(sceneBuildIndex: 1);
            }
            else
            {
                SceneManager.LoadScene(sceneBuildIndex: 1, LoadSceneMode.Additive);
            }
        }
    }
}
