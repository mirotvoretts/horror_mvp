using UnityEngine;

public class KeysCollector
{
    public static uint Balance { get; private set; }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Key>(out _))
        {
            Collect(collision.gameObject);
        }
    }

    private void Collect(GameObject key)
    {
        Balance++;
        key.SetActive(false);
    }

    public static void ResetBalance()
    {
        Balance = 0;
    }
}
