using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2D : MonoBehaviour
{

    public float speed;
    public bool jugadorA;

    // Update is called once per frame
    void Update()
    {
        float horizontal, vertical;

        if (jugadorA)
        {
            horizontal = Input.GetAxis("HorizontalA");
            vertical = Input.GetAxis("VerticalA");
        }
        else
        {
            horizontal = Input.GetAxis("HorizontalB");
            vertical = Input.GetAxis("VerticalB");
        }

        Vector3 direccion = new Vector3(horizontal, vertical);
        // Debug.Log(direccion);

        transform.position += direccion * speed * Time.deltaTime;
        // Debug.Log(Time.deltaTime); -> cuánto tiempo ocupa un fotograma.
        // ¿Por qué utilizamos el deltaTime? -> para democratizar las ventajas según los componentes.

    }
}
