using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public void OnSettingsButtonClicked()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1, LoadSceneMode.Additive);
    }

    public void OnCloseSettingsButtonClicked()
    {
        SceneManager.UnloadSceneAsync(sceneBuildIndex: 1);
    }
}