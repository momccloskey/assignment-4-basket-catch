using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapetoTitle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title Screen");
        }

    }
}
