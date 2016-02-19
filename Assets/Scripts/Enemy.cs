using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    [SerializeField]
    private GameObject Explosion;
    private GameManager gameManager;

    // Use this for initialization
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
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
            Instantiate(Explosion,transform.position,Quaternion.identity);
            gameManager.AddScore(1);
        }

    }
}
