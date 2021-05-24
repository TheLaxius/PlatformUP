using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour{

    public Transform feet;
    public LayerMask groundLayers;

    public Transform teleport;
    public GameObject player;

    public bool isEnemy()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);
        if (groundCheck.gameObject != null)
        {
            return true;
        }
        return false;
    }


        void Start()
    {
    }
        private void OnCollisionEnter2D(Collision2D skeleton){
            if(isEnemy())
            {
            player.transform.position = teleport.transform.position;
            }
    }
}
