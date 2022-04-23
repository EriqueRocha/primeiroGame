using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletando : MonoBehaviour
{
    private SpriteRenderer sr;
    private CapsuleCollider2D circle;

    public GameObject collected;

    public bool coletou;

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CapsuleCollider2D>();
        anim.SetBool("coletou", false);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
            
        {
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            coletou = true;
            anim.SetBool("coletou", true);

            Destroy(gameObject, 0.3f);
        }

    }
}