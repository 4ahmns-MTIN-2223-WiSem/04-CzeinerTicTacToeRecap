using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScripts : MonoBehaviour
{
    int spriteIndex = -1;
   

    public int turn() 
    {
        spriteIndex++;
        return spriteIndex % 2;
    }
}
