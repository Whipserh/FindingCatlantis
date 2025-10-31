using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
