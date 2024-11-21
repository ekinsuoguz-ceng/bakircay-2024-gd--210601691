using UnityEngine;

public class SimplePlatform : MonoBehaviour
{
    public Transform anchorPoint; // Platform üzerindeki sabit nokta

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruit")) // Sadece 'Fruit' tagine sahip nesnelerle çalýþýr
        {
            // Nesneyi platforma düzgünce yerleþtir
            other.transform.position = anchorPoint.position;
            other.GetComponent<Rigidbody>().isKinematic = true; // Hareketi durdur
        }
    }
}
