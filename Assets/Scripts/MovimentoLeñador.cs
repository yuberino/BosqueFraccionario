using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLeñador : MonoBehaviour
{

    public Rigidbody2D rbd;

    private Animator anim;

    private SpriteRenderer spritePersonaje;
    public float fuerza;

    [SerializeField] private float _vel;

    bool siTocaElSuelo;

    void OnCollisionEnter(Collision other)
 {

     if(other.gameObject.CompareTag("Suelo"));
         siTocaElSuelo = true;
 }

    void Start()
    {
        siTocaElSuelo = true;

        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        spritePersonaje = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Saltar
    
        if (Input.GetKeyDown(KeyCode.Space) && siTocaElSuelo == true)
        {
            siTocaElSuelo = false;
            rbd.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }

        //Caminar

        float velocidadInput = Input.GetAxisRaw("Horizontal");
        rbd.velocity = new Vector2(velocidadInput * _vel, rbd.velocity.y);
        anim.SetFloat("Camina", Mathf.Abs(velocidadInput));

        if (velocidadInput < 0) {

            spritePersonaje.flipX = true;

        }

        else if (velocidadInput > 0) {

            spritePersonaje.flipX = false;

        }

    }
}
