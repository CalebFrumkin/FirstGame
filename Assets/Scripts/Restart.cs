using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
