using UnityEngine;

public class Lookat : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x,
        this.transform.position.y,
        target.position.z);

        transform.LookAt(target, Vector3.up);

        this.transform.LookAt(targetPosition);
        this.transform.rotation *= Quaternion.Euler(0f, 180f, 0f);
    }
}
