using UnityEngine;

public class RopeCutter : MonoBehaviour
{
    public GameObject cutEffectPrefab;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("RopePart"))
            {
                Destroy(hit.collider.gameObject);
                AudioManager.instance.PlaySound("cut");
                Instantiate(cutEffectPrefab, hit.point, Quaternion.identity);
            }
        }
    }
}
