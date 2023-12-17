using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can_exit_from : MonoBehaviour
{
    /*
     * --= Todo =--
     * - "life-system" with keys -> if keyCollected then "lose life" -> if allLifesLost then "open door"
     * - if playerMeetsDoor then nextLevelEvent: load next scene (prototype: destroy player)
     * 
     * attributes:
     * - isOpen
     * - numberOfKeys
     * ?
     */

    BoxCollider2D col;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        col.isTrigger = LevelManager.doorIsOpen;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
