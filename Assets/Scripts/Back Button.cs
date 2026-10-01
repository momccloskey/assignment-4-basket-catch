using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoTitleButton : MonoBehaviour
{
    void OnClick()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
