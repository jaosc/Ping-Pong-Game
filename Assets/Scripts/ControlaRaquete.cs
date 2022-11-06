using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaRaquete : MonoBehaviour
{   
    private Vector2 direcao;
    private Rigidbody2D rigidbodyRaquete;
    private float velocidade = 5;
    public string eixo;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyRaquete = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float eixoY = Input.GetAxis(eixo);
        direcao = new Vector2(0, eixoY);   
    }

    void FixedUpdate()
    {
        rigidbodyRaquete.MovePosition(rigidbodyRaquete.position + direcao.normalized * velocidade * Time.deltaTime);
    }
}
