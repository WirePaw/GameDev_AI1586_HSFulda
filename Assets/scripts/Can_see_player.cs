using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Can_see_player : MonoBehaviour
{
    public RaycastHit2D hit;
    public LayerMask layerMask;
    PlayerBehaviour player;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            hit = Physics2D.Raycast(transform.position, (collision.transform.position - transform.position).normalized, 20f, layerMask);
            
            if(hit.collider != null)
            {
                Debug.DrawLine(transform.position, hit.transform.position);
            }
            switch (hit.collider.tag) 
            {
                case "Player":
                    hit.collider.transform.gameObject.GetComponent<PlayerBehaviour>().loseLife();
                    break;
            }
        }
    }
}
