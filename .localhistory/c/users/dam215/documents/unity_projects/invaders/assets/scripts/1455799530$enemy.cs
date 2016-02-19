using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    public void Move(Vector3 velocity)
    {
        transform.Translate(velocity);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBullet"))
        {
            gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }

    }
}
