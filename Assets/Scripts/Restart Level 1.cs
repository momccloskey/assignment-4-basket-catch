using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel1 : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Level 1");
    }
}
