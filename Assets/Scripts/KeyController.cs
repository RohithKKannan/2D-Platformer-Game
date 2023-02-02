using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    Animator keyAnimator;
    BoxCollider2D boxCollider2D;
    void Awake()
    {
        keyAnimator = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.PickUpKey();
            keyAnimator.SetTrigger("pickUp");
            boxCollider2D.isTrigger = true;
        }
    }
    public void DestroyKey()
    {
        Destroy(gameObject);
    }
}
