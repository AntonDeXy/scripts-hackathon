using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DestroyObjByButton : MonoBehaviour
{
    GameObject player;

    void OnColliderEnter2D(Collider2D obj) // Here function gets your collider
    {
        if (player.obj.gameObject.tag == broken_house) /* program checks pressing space button here */
            Destroy(GameObject.tag(broken_house)); // program deletes object with broken_house tag here
        }
    }
}
