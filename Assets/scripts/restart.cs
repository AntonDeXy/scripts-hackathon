using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void Click()
    {
        print("restart clicked");
        SceneManager.LoadScene("main");
    }
}
