using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfBound : MonoBehaviour
{

    public AudioClip collisionSound; // 再生する音源を設定
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "floor")
        {
            // 指定した音源を再生
            AudioSource.PlayClipAtPoint(collisionSound, collision.GetContact(0).point);
        }
    }
}

