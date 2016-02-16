using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private const float HalfWidth = 0.55f;

    [SerializeField]
    private float speed = 3;
    [SerializeField]
    private Sprite[] sprites;
    private float limits;
    private SpriteRenderer sr;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private float shootTime = 1f;
    private float time;

    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
        limits = Camera.main.ViewportToWorldPoint(Vector3.right).x - HalfWidth;
        time = shootTime;

    }

    // Update is called once per frame
    void Update () {
        time += Time.deltaTime;

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

        if (x != transform.position.x)
        {
            transform.position = new Vector3(x, transform.position.y, 0);

        }
        if (Input.GetAxisRaw("Jump")==1 && time >= shootTime)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            time = 0;
        }
    }
}
