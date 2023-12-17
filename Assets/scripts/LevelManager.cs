using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    /*
     * attributes
     * - keys
     * - time
     * - player lifes
     * - enemies?
     * - doorState?
     * 
     */

    public static bool doorIsOpen = false;
    public static int numberOfKeys = GameObject.FindGameObjectsWithTag("Key").Length;
    public static int numberOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;


    public static void decreaseNeededKeys()
    {
        numberOfKeys--;
        if(numberOfKeys <= 0)
        {
            doorIsOpen = true;
        }
    }
}
