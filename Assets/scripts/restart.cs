using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    void OnMouseDown()
    {
        print("click");
        SceneManager.LoadScene("main");
    }
}
