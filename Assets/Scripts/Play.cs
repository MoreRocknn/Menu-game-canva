using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
}