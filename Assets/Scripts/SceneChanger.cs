using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("GameScene");
    }


}
