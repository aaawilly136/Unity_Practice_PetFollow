using UnityEngine;
using System.Collections;

public class Petfollow : MonoBehaviour
{
    [Header("速度"), Range(0, 1000)]
    public float speed = 1f;

    public Transform target;
    public Vector3 offset;

    public float backdistance = 2;
    public float topdistance = 2;


    private void Start()
    {
        target = GameObject.Find("follow").transform;
    }

    private void LateUpdate()
    {
        Move();
    }

    private void Move()
    {
        offset =- target.forward * backdistance + target.up * topdistance;
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime);
        transform.rotation = target.rotation;
    }
}
