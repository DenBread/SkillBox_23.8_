using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UIButton : MonoBehaviour
{
    public void ShowScene(int indexScene)
    {
        DOTween.Clear();
        SceneManager.LoadScene(indexScene);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
