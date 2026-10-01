using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoTitleButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
