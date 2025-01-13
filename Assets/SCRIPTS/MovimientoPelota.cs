using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public GameManager manager;
    public float speed;
    float horizontal, vertical;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(horizontal, vertical).normalized;

        transform.position += direccion * speed * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == "Vertical")
        {
            horizontal *= -1;
        }
        if (collision.gameObject.tag == "Horizontal")
        {
            vertical *= -1;
        }
        if (collision.gameObject.tag == "PorteriaA")
        {
            manager.puntA++;
            Spawn();
        }
        if (collision.gameObject.tag == "PorteriaB")
        {
            manager.puntB++;
            Spawn();
        }
    }

    void Spawn()
    {
        transform.position = new Vector3(0, 0, 0);
        horizontal = Random.Range(-1f, 1f);

        if (horizontal < 0)
        {
            horizontal = -1;
        }
        else
        {
            horizontal = 1;
        }

        vertical = Random.Range(-1f, 1f);
    }
}
