using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILivesPanel : MonoBehaviour
{
    public Player Player;
    
    void Update()
    {
        for (int i = 0; i < Player.lives; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }

        for (int i = Player.lives; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
