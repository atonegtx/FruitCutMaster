using UnityEngine;

public class RopeGenerator : MonoBehaviour
{
    public GameObject ropePartPrefab;
    public int segmentCount = 10;
    public GameObject fruit;

    void Start()
    {
        GameObject previous = this.gameObject;

        for (int i = 0; i < segmentCount; i++)
        {
            GameObject segment = Instantiate(ropePartPrefab, previous.transform.position - Vector3.down * 0.2f, Quaternion.identity);
            segment.transform.SetParent(this.transform);

            var joint = segment.GetComponent<DistanceJoint2D>();
            joint.connectedBody = previous.GetComponent<Rigidbody2D>();

            previous = segment;
        }

        var lastJoint = fruit.AddComponent<DistanceJoint2D>();
        lastJoint.connectedBody = previous.GetComponent<Rigidbody2D>();
    }
}
