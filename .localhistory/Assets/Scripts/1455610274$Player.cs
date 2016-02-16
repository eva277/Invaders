using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private const float HalfWidth = 0.55f;

    [SerializeField]
    private float speed = 3;
    [SerializeField]
    private Sprite[] sprites;
    private float limits;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
        rb=GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        limits = Camera.main.ViewportToWorldPoint(Vector3.right).x - HalfWidth;
	}
	
	// Update is called once per frame
	void Update () {
        float direction = Input.GetAxisRaw("Horizontal");

        if (direction==1)
        {
            sr.sprite = sprites[6];
        }
        else if (direction == -1)
        {
            sr.sprite = sprites[0];
        }
        else 
        {
            sr.sprite = sprites[3];
        }

        Vector3 velocity = Vector3.right * speed * direction*Time.deltaTime;
        transform.Translate(velocity);

        float x = Mathf.Clamp(transform.position.x, -limits, limits);
        transform.position = new Vector3(x, transform.position.y, 0);


    }
}
