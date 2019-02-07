using UnityEngine.SceneManagement;
using UnityEngine;

public class startButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Begin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    
}
