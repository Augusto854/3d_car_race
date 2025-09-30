using UnityEngine;

public class AICar : MonoBehaviour
{

    public transform[] waypoints;

    private int currentWaypointIndex = 0;

    public float speed = 10f;

    public float turnSpeed = 50f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Transform target = waypoints[currentWaypointIndex];

        Vector3 targetXZ = new Vector3(target.position.x, transform.position.y, target.position.z);

        Vector3 direction = (targetXZ - transform.position).normalized;

        Quaternion lookRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotationm rotationSpeed * Time.deltaTime);
    }
}
