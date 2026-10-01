using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel2 : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Level 2");
    }
}
