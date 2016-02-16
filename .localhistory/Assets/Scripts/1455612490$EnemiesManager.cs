using UnityEngine;
using System.Collections;

public class EnemiesManager : MonoBehaviour {
    private const float HalfWidth = 0.6f;

    [SerializeField]
    private float speed = 3;
    private float limits;
    private float direction = 1;
    [SerializeField]
    private Enemy[] enemies;

    // Use this for initialization
    void Start () {
        limits = Camera.main.ViewportToWorldPoint(Vector3.right).x - HalfWidth;

    }

    // Update is called once per frame
    void Update () {
        Vector3 velocity = Vector3.right * speed * direction * Time.deltaTime;

        foreach (Enemy enemy in enemies)
        {
            enemy.Move(velocity);
        }

        float deltaX = 0;
        foreach (Enemy enemy in enemies)
        {

            float x = Mathf.Clamp(enemy.transform.position.x, -limits, limits);

            if (x != enemy.transform.position.x)
            {
                deltaX = enemy.transform.position.x - x;
                direction *= -1;
                break;
            }
        }
        foreach (Enemy enemy in enemies)
        {
            enemy.Move(new Vector3(-deltaX,0,0));
        }
    }
}
