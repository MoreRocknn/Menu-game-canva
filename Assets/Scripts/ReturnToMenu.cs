using UnityEngine;

public class ReturnToMenu : MonoBehaviour
{
    public void OnReturnToMenuButtonClicked()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(0).isLoaded
            && UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(1).isLoaded)
        {
            UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneBuildIndex: 1);
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}