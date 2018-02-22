﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCollision : MonoBehaviour {

    public PlayerMovement player;
    public PlayerMovementVersionTwo playerV2;
    public bool playerOne = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Climbable")
        {
            if (playerOne)
            {
                if (gameObject.tag == "Chest")
                    player.setChestCollision(true);

                if (gameObject.tag == "RGrab")
                    player.setRightGrab(true);

                if (gameObject.tag == "LGrab")

                    player.setLeftGrab(true);

            }
            else
            {
                if (gameObject.tag == "Chest")
                    playerV2.setChestCollision(true);

                if (gameObject.tag == "RGrab")
                   playerV2.setRightGrab(true);

                if (gameObject.tag == "LGrab")
                    playerV2.setLeftGrab(true);
            }
            

   
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Climbable")
        {
            if (playerOne)
            {
                if (gameObject.tag == "Chest")
                    player.setChestCollision(false);

                if (gameObject.tag == "RGrab")
                    player.setRightGrab(false);

                if (gameObject.tag == "LGrab")

                    player.setLeftGrab(false);
            }
            else
            {
                if (gameObject.tag == "Chest")
                    playerV2.setChestCollision(false);

                if (gameObject.tag == "RGrab")
                    playerV2.setRightGrab(false);

                if (gameObject.tag == "LGrab")
                    playerV2.setLeftGrab(false);
            }
        }
    }
}
