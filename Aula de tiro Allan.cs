using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula1 : MonoBehaviour
{
    public float velocidade = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey( KeyCode.A))
        {
            transform.Translate(-1 * velocidade, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * velocidade, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, -1 * velocidade, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 1 * velocidade, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //this.gameObject.name --> personagem
        //other.gameObject.name --> inimigo

        if (other.gameObject.name == "Inimigo")
            Destroy(other.gameObject);
    }
}



