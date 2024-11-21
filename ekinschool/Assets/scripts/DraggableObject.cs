using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    private Camera mainCamera;
    private Rigidbody rb;
    private bool isDragging = false;

    void Start()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        isDragging = true;
        rb.isKinematic = true; // Çekiþ sýrasýnda nesneyi sabitle
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            // Fare pozisyonuna göre nesneyi hareket ettir
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = mainCamera.WorldToScreenPoint(transform.position).z; // Derinlik bilgisi
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector3(worldPosition.x, worldPosition.y, worldPosition.z);
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
        rb.isKinematic = false; // Sürükleme bittiðinde fizik tekrar aktifleþir
    }
}
