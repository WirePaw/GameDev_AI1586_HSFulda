using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Vector2 spawnpoint;
    public int life;
    void Start()
    {
        spawnpoint = transform.position;
    }
    public void loseLife()
    {
        life--;
        if(life <= 0 )
        {
            // kill player
            Destroy(this.gameObject);
        }
        else
        {
            transform.position = spawnpoint;
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 40), "Life: "+ life);
        GUI.Label(new Rect(10, 35, 300, 20), "doorIsOpen: " + LevelManager.doorIsOpen);
        GUI.Label(new Rect(10, 60, 300, 20), "numberOfKeys: " + LevelManager.numberOfKeys);
        GUI.Label(new Rect(10, 85, 300, 20), "numberOfEnemies: " + LevelManager.numberOfEnemies);
    }
}
