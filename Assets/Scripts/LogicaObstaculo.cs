using UnityEngine;

public class LogicaObstaculo : MonoBehaviour
{
    public float velocidad;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
    }
}
