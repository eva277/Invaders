using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private const float HalfWidth = 0.55f;

    [SerializeField]
    private float speed = 3;
    private float limits;

	// Use this for initialization
	void Start () {
        limits = Camera.main.ViewportToWorldPoint(Vector3.right).x - HalfWidth;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 velocity = Vector3.right * speed * Input.GetAxisRaw("Horizontal")*Time.deltaTime;
        transform.Translate(velocity);

        float x = Mathf.Clamp(transform.position.x, -limits, limits);
        transform.position = new Vector3(x, transform.position.y, 0);


    }
}
