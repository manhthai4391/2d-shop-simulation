using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(playerTag))
        {
            collision.GetComponent<PlayerInventory>().coins++;
            gameObject.SetActive(false);
        }
    }
}
