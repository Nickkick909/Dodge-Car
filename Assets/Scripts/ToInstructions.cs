using UnityEngine;
using UnityEngine.SceneManagement;

public class ToInstructions : MonoBehaviour {
    public void OnClick()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
