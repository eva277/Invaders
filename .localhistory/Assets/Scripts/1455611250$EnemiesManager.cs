using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
    private const float HalfWidth = 0.6f;

    [SerializeField]
    private float speed = 3;
    private float limits;
    private float direction = 1;

    // Use this for initialization
    void Start () {
        limits = Camera.main.ViewportToWorldPoint(Vector3.right).x - HalfWidth;

    }

    // Update is called once per frame
    void Update () {
        Vector3 velocity = Vector3.right * speed * direction * Time.deltaTime;
        transform.Translate(velocity);

        float x = Mathf.Clamp(transform.position.x, -limits, limits);

        if (x != transform.position.x)
        {
            transform.position = new Vector3(x, transform.position.y, 0);
            direction *= -1;
        }
    }
}
