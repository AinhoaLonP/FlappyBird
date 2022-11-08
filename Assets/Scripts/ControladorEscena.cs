using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public GameObject canvasPerder;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void Perder()
    {
        canvasPerder.SetActive(true);
        Time.timeScale = 0;
        audio.Stop();
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
